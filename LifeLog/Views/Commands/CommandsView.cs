using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Tile;
using LifeLog.Core.Utils;
using LifeLog.Data.Entities;
using LifeLog.Helpers;
using LifeLog.Properties;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace LifeLog.Views.Commands
{
    /// <summary>
    /// Commands Runner View
    /// </summary>
    public partial class CommandsView : XtraUserControl
    {
        #region MAIN

        //PRIVATE
        private Command? _crtCommands;
        private List<Command> _listCommands;

        /// <summary>
        /// Constructor
        /// </summary>
        public CommandsView() => InitializeComponent();

        #endregion

        #region EVENTS

        #region CLICK

        /// <summary>
        /// Refresh Button Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void bbiRefresh_ItemClick(object sender, ItemClickEventArgs e) =>
            await LoadData();

        /// <summary>
        /// New command click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bbiNew_ItemClick(object sender, ItemClickEventArgs e) =>
            ShowDetailView();

        /// <summary>
        /// Back
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bbiBack_ItemClick(object sender, ItemClickEventArgs e) =>
            ShowListView();

        /// <summary>
        /// Edit
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bbiEdit_ItemClick(object sender, ItemClickEventArgs e)
        {
            Command? command = ControlsHelper.GetObjectByRowHandle<Command>(tileView, tileView.FocusedRowHandle);
            if (command != null)
                ShowDetailView(command);
        }

        /// <summary>
        /// Save commands
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void bbiSave_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                this.ValidateChildren();

                if (!ValidateModel())
                    return;

                (bool saved, _) = await Program.DataEngine!.Commands.Save(_crtCommands);

                if (saved)
                {
                    MessageBox.Show("Saved");
                }
                else
                {
                    MessageBox.Show("Failed Saved");
                }

                if (saved)
                {
                    List<Command> lista = bsCommandsList.List.Cast<Command>().ToList();

                    if (!lista.Any(w => w.Id == _crtCommands.Id))
                    {
                        bsCommandsList.Add(_crtCommands);
                        tileView.RefreshData();
                    }
                    else
                        tileView.UpdateCurrentRow();

                    _crtCommands = null;

                    ShowListView();
                }
            }
            catch (Exception ex)
            {
                ErrorHelper.Handler(ex);
            }
        }

        /// <summary>
        /// Enables or disables the command
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void bbiEnable_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                Command? command = ControlsHelper.GetObjectByRowHandle<Command>(tileView, tileView.FocusedRowHandle);
                if (command == null)
                    return;

                if (command.ExternalProgram is null)
                {
                    MessageBox.Show("Can't enable command, doesn't have program!");
                    return;
                }

                (bool state, _) = await Program.DataEngine!.Commands.ToggleEnabledState((Guid)command.Id!);

                command.IsEnabled = state;

                if (state)
                {
                    MessageBox.Show("Enabled");
                }
                else
                {
                    MessageBox.Show("Disabled");
                }

                int rowHandle = tileView.LocateByValue(nameof(command.Id), command.Id);

                tileView.RefreshRow(rowHandle);
            }
            catch (Exception ex)
            {
                ErrorHelper.Handler(ex);
            }
        }

        /// <summary>
        /// Save commands to a file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bbiCreateFile_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                Command command = ControlsHelper.GetObjectByRowHandle<Command>(tileView, tileView.FocusedRowHandle);
                if (command == null)
                    return;

                using (SaveFileDialog dialog = new SaveFileDialog())
                {
                    string ext = command.ExternalProgram.FileExtension.Replace(".", ""); // "bat"
                    dialog.Filter = $"Files {ext.ToUpper()} (*.{ext})|*.{ext}|All Files (*.*)|*.*";
                    dialog.DefaultExt = ext;
                    dialog.Title = $"Save | {command.Name}";
                    dialog.AddExtension = true;

                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        Encoding encoding = new UTF8Encoding(encoderShouldEmitUTF8Identifier: false);

                        File.WriteAllText(dialog.FileName, command.Text, encoding);

                        MessageBox.Show("Command exported to file!");
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorHelper.Handler(ex);
            }
        }

        /// <summary>
        /// Delete command!
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void bbiDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                Command? command = ControlsHelper.GetObjectByRowHandle<Command>(tileView, tileView.FocusedRowHandle);
                if (command == null)
                    return;


                DialogResult result = MessageBox.Show($"Do you really want to delete {command.Name}?", "Delete?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    (bool delete, _) = await Program.DataEngine!.Commands.Delete((Guid)command.Id!);
                    if (delete)
                    {
                        bsCommandsList.Remove(command);
                        MessageBox.Show("Command deleted");
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorHelper.Handler(ex);
            }
        }

        /// <summary>
        /// Run command as admin
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bbiRunAdmin_ItemClick(object sender, ItemClickEventArgs e) =>
            RunCommandClickHelper(true);

        /// <summary>
        /// Export commands to a json file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void bbiExport_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Title = "Save commands as JSON";
                    saveFileDialog.Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*";
                    saveFileDialog.DefaultExt = "json";
                    saveFileDialog.FileName = "commands.json";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        (List<Command?>? commands, _) = await Program.DataEngine!.Commands.GetUserCommands(Program.LoggedUser.Id);
                        JsonUtil.ExportToFile(commands, saveFileDialog.FileName, indented: true);

                        MessageBox.Show($"({commands.Count}) Commands exported successfuly!");
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorHelper.Handler(ex);
            }
        }

        /// <summary>
        /// Import commnads
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void bbiImport_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                using (var openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.Title = "Open commands JSON";
                    openFileDialog.Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*";
                    openFileDialog.DefaultExt = "json";

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        List<Command> commandsJson = JsonUtil.ImportFromFile<List<Command>>(openFileDialog.FileName);

                        commandsJson.ForEach(w => w.IdUser = Program.LoggedUser.Id);

                        (bool saved, _) = await Program.DataEngine.Commands.SaveList(commandsJson);

                        if (saved)
                        {
                            foreach (var command in commandsJson)
                                bsCommandsList.Add(command);
                        }

                        MessageBox.Show($"({commandsJson.Count}) Commands {(saved ? "imported successfuly" : "not imported")}!");
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorHelper.Handler(ex);
            }
        }

        #endregion

        #region TILE VIEW

        /// <summary>
        /// Tile View
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tileView_Click(object sender, EventArgs e)
        {
            if (((MouseEventArgs)e).Button != MouseButtons.Right)
                return;

            bbiEdit.Visibility = BarItemVisibility.Never;
            bbiDelete.Visibility = BarItemVisibility.Never;
            bbiEnable.Visibility = BarItemVisibility.Never;
            bbiCreateFile.Visibility = BarItemVisibility.Never;
            bbiRunAdmin.Visibility = BarItemVisibility.Never;

            popupMenu.ShowPopup(Control.MousePosition);
        }

        /// <summary>
        /// Right click commands event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tileView_ItemRightClick(object sender, TileViewItemClickEventArgs e)
        {
            if (!(tileView.GetFocusedRow() is Command model))
                return;

            bbiEdit.Visibility = BarItemVisibility.Always;
            bbiDelete.Visibility = BarItemVisibility.Always;
            bbiEnable.Visibility = BarItemVisibility.Always;
            bbiCreateFile.Visibility = BarItemVisibility.Always;

            bbiEnable.ImageOptions.SvgImage = model.IsEnabled ? Resources.actions_deletecircled : Resources.actions_checkcircled;
            bbiEnable.Caption = model.IsEnabled ? "Disable" : "Enable";

            bbiRunAdmin.Visibility = model.IsEnabled ? BarItemVisibility.Always : BarItemVisibility.Never;

            popupMenu.ShowPopup(Control.MousePosition);
        }

        /// <summary>
        /// Item double click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tileView_ItemDoubleClick(object sender, TileViewItemClickEventArgs e) =>
            RunCommandClickHelper(false);

        /// <summary>
        /// Custom item template event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tileView_CustomItemTemplate(object sender, TileViewCustomItemTemplateEventArgs e)
        {
            try
            {
                Command model = ControlsHelper.GetObjectByRowHandle<Command>(tileView, e.RowHandle);

                if (model == null)
                    return;

                e.HtmlTemplate.Template =
                    e.HtmlTemplate.Template.Replace("@@classEnabled@@",
                    model.IsEnabled ? "cardBorderEnabled"
                                  : "cardBorderDisabled");

                if (model.ExternalProgram != null)
                {
                    var iconData = model.ExternalProgram.ImageData;
                    if (iconData == null)
                    {
                        e.HtmlTemplate.Template = e.HtmlTemplate.Template.Replace("@@icon@@", string.Empty);
                        return;
                    }
                    else
                    {
                        model.Icon = model.ExternalProgram.Icon;
                    }

                }
            }
            catch (Exception ex)
            {
                ErrorHelper.Handler(ex);
            }
        }

        #endregion

        #region SELECTED VALUE CHANGED

        /// <summary>
        /// Selected value changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listboxPrograms_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (_listCommands is null)
                    return;

                LoadCommandsHelper();

            }
            catch (Exception ex)
            {
                ErrorHelper.Handler(ex);
            }
        }

        #endregion

        #region CHECKED CHANGED

        /// <summary>
        /// Show or Hides the disabled commands
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bstiShowDisabledCommands_CheckedChanged(object sender, ItemClickEventArgs e) =>
            LoadCommandsHelper();

        #endregion

        #endregion

        #region FUNCTIONS

        #region PUBLIC

        /// <summary>
        /// Load data
        /// </summary>
        /// <returns></returns>
        public async Task LoadData()
        {
            try
            {
                (List<ExternalProgram> externalPrograms, _) = await Program.DataEngine.ExternalPrograms.GetAll();

                externalPrograms.Insert(0, new ExternalProgram
                {
                    Id = Guid.Empty,
                    Icon = Resources.clearfilter,
                });

                cbeProgram.Properties.DataSource = externalPrograms.Where(w => w.Id != Guid.Empty);

                bsExternalPrograms.DataSource = externalPrograms;

                (List<Command> commands, _) = await Program.DataEngine.Commands.GetUserCommands(Program.LoggedUser.Id);
                _listCommands = commands;

                LoadCommandsHelper();

            }
            catch (Exception ex)
            {
                ErrorHelper.Handler(ex);
            }
        }

        #endregion

        #region PRIVATE

        /// <summary>
        /// Runs the commands 
        /// </summary>
        /// <param name="admin"></param>
        private void RunCommandClickHelper(bool admin)
        {
            try
            {
                if (!(tileView.GetFocusedRow() is Command model))
                    return;

                ExecuteFile(model, admin);
            }
            catch (Exception ex)
            {
                ErrorHelper.Handler(ex);
            }
        }

        /// <summary>
        /// Execute File
        /// </summary>
        /// <param name="command"></param>
        /// <returns></returns>
        private void ExecuteFile(Command command, bool runInAdmin = false)
        {
            if (!command.IsEnabled)
            {
                MessageBox.Show("Command is disabled!");
                return;
            }

            Task.Run(() =>
            {
                string batchFilePath = string.Empty;
                string fileName = string.Empty;
                string arguments = string.Empty;

                try
                {
                    if (!Directory.Exists("Temp"))
                        Directory.CreateDirectory("Temp");

                    batchFilePath = Path.Combine("Temp", $"temp_{Guid.NewGuid()}");

                    if (command.ExternalProgram == null)
                        throw new ArgumentNullException("External program is not defined for this command.");

                    command.ExternalProgram.FileExtension = command.ExternalProgram.FileExtension.Replace(".", string.Empty);
                    batchFilePath += $".{command.ExternalProgram.FileExtension}";
                    fileName = command.ExternalProgram.PathToProgram;
                    arguments = $"{command.ExternalProgram.Arguments} {batchFilePath}";

                    Encoding encoding = new UTF8Encoding(encoderShouldEmitUTF8Identifier: false);

                    File.WriteAllText(batchFilePath, command.Text, encoding);

                    ProcessStartInfo startInfo = new ProcessStartInfo
                    {
                        FileName = fileName,
                        Arguments = arguments,
                        UseShellExecute = true,
                        CreateNoWindow = false,
                    };

                    if (runInAdmin || command.NeedsAdmin)
                        startInfo.Verb = "runas";

                    Process process = new Process
                    {
                        StartInfo = startInfo
                    };

                    process.Start();
                    process.WaitForExit();

                    MessageBox.Show($"Command '{command.Name}' executed!");

                }
                catch (Exception ex)
                {
                    ErrorHelper.Handler(ex);
                }
                finally
                {
                    if (File.Exists(batchFilePath))
                        File.Delete(batchFilePath);
                }

            }).ContinueWith(t =>
            {
                this.Parent.Invoke((MethodInvoker)(() =>
                    this.Parent.BringToFront()));
            });
        }

        /// <summary>
        /// Show the list view
        /// </summary>
        private void ShowListView()
        {
            try
            {
                bbiNew.Visibility = BarItemVisibility.Always;
                bbiEdit.Visibility = BarItemVisibility.Always;
                bbiBack.Visibility = BarItemVisibility.Never;
                bbiSave.Visibility = BarItemVisibility.Never;
                bbiRefresh.Visibility = BarItemVisibility.Always;
                bbiSearch.Visibility = BarItemVisibility.Always;

                navigationFrame.SelectedPage = npMain;

                cbeProgram.EditValue = null;
                recMain.ResetText();
                teName.ResetText();
                teDescription.ResetText();
                tsEnabled.Reset();
                tsNeedsAdmin.Reset();

                _crtCommands = null;
            }
            catch (Exception ex)
            {
                ErrorHelper.Handler(ex);
            }
        }

        /// <summary>
        /// Show detail view 
        /// </summary>
        /// <param name="command"></param>
        private void ShowDetailView(Command command = null)
        {
            try
            {
                if (command == null)
                {
                    command = new Command();
                    command.IdUser = Program.LoggedUser.Id;
                }

                bbiNew.Visibility = BarItemVisibility.Never;
                bbiSave.Visibility = BarItemVisibility.Always;
                bbiBack.Visibility = BarItemVisibility.Always;
                bbiEdit.Visibility = BarItemVisibility.Never;
                bbiRefresh.Visibility = BarItemVisibility.Never;
                bbiSearch.Visibility = BarItemVisibility.Never;

                navigationFrame.SelectedPage = npEditor;

                _crtCommands = command;

                cbeProgram.EditValue = command.ExternalProgram?.Id;
                recMain.Text = command.Text;
                teName.Text = command.Name;
                teDescription.Text = command.Description;
                tsEnabled.IsOn = command.IsEnabled;
                tsNeedsAdmin.IsOn = command.NeedsAdmin;
            }
            catch (Exception ex)
            {
                ErrorHelper.Handler(ex);
            }
        }

        /// <summary>
        /// Help to load the commands
        /// </summary>
        private void LoadCommandsHelper()
        {
            List<Command> list = bstiShowDisabledCommands.Checked ? _listCommands : _listCommands.Where(w => w.IsEnabled).ToList();

            if (!(listboxPrograms.SelectedItem is ExternalProgram ep) || ep.Id == Guid.Empty)
                bsCommandsList.DataSource = list;
            else
                bsCommandsList.DataSource = list.Where(w => w.ExternalProgram?.Id == ep.Id).ToList();
        }

        /// <summary>
        /// Validate model
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        private bool ValidateModel()
        {
            dxErrorProvider.ClearErrors();

            _crtCommands.IsEnabled = tsEnabled.IsOn;
            _crtCommands.NeedsAdmin = tsNeedsAdmin.IsOn;
            _crtCommands.Text = recMain.Text;
            _crtCommands.Name = teName.Text;
            _crtCommands.Description = teDescription.Text;

            if (cbeProgram.GetSelectedDataRow() is ExternalProgram program)
                _crtCommands.ExternalProgram = program;
            else if (!_crtCommands.IsEnabled)
                dxErrorProvider.SetError(cbeProgram, _crtCommands.GetValidationMessage(nameof(Command.ExternalProgram)));

            if (string.IsNullOrWhiteSpace(_crtCommands.Name))
                dxErrorProvider.SetError(teName, _crtCommands.GetValidationMessage(nameof(Command.Name)));

            if (string.IsNullOrWhiteSpace(_crtCommands.Text))
                dxErrorProvider.SetError(recMain, _crtCommands.GetValidationMessage(nameof(Command.Text)));

            if (string.IsNullOrWhiteSpace(_crtCommands.Description))
                dxErrorProvider.SetError(teDescription, _crtCommands.GetValidationMessage(nameof(Command.Description)));

            return !dxErrorProvider.HasErrors;
        }

        #endregion

        #endregion

        private void tileView_ItemDrag(object sender, DevExpress.XtraGrid.Views.Tile.ItemDragEventArgs e)
        {

        }

        private void tileView_ItemDrop(object sender, ItemDropEventArgs e)
        {
            Task.Run(async () =>
            {
                //await Task.Delay(1500);

                for (int i = 0; i < tileView.RowCount; i++)
                {
                    int rowHandle = tileView.GetRowHandle(i);

                    if (tileView.GetRow(rowHandle) is Command command)
                    {
                        //command.Position = i;
                        //CommandsData.SavePosition(command);
                    }
                }
            });

            Command cmd = tileView.GetObjectByRowHandle<Command>(e.RowHandle);

            MessageBox.Show($"Command '{cmd.Name}' moved!");
        }
    }
}
