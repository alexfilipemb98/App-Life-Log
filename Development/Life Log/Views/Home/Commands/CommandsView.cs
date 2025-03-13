using Data.Entities;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Tile;
using Life_Log.Helpers;
using Life_Log.Properties;
using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DevExpress.LookAndFeel.DXSkinColors;

namespace Life_Log.Views.Home.Commands
{
    /// <summary>
    /// Commands List View
    /// </summary>
    public partial class CommandsView : XtraUserControl
    {
        #region MAIN

        //PRIVATE
        private Data.Entities.CommandsEntity _crtCommand;
        private bool _createNew = false;

        /// <summary>
        /// Constructor to initialize the view
        /// </summary>
        public CommandsView() => InitializeComponent();

        #endregion

        #region CLICK

        /// <summary>
        /// Refreshes the list of commands
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bbiRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadData();
        }

        /// <summary>
        /// New button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bbiNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowDetailView();
        }

        /// <summary>
        /// Back button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bbiBack_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShowListView();
        }

        /// <summary>
        /// Tile view item click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tileView_ItemRightClick(object sender, TileViewItemClickEventArgs e)
        {
            try
            {

                CommandsEntity extProgram = GridHelper.GetObjectByRowHandle<CommandsEntity>(tileView, tileView.FocusedRowHandle);
                BarItemLink bbiEnable = popupMenu.ItemLinks.FirstOrDefault(w => w.Item.Name == "bbiEnable");
                bbiEnable.ImageOptions.SvgImage = extProgram.IsEnabled ? Resources.actions_deletecircled : Resources.actions_checkcircled;
                bbiEnable.Caption = extProgram.IsEnabled ? "Disable" : "Enable";

                popupMenu.ShowPopup(Control.MousePosition);
            }
            catch (Exception ex)
            {
                ErrorHelper.Handler(ex);
            }
        }

        /// <summary>
        /// Tile view item double click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tileView_ItemDoubleClick(object sender, TileViewItemClickEventArgs e)
        {
            try
            {
                if (!(tileView.GetFocusedRow() is Data.Entities.CommandsEntity model))
                    return;

                ExecuteFile(model);
            }
            catch (Exception ex)
            {
                ErrorHelper.Handler(ex);
            }
        }

        /// <summary>
        /// Save button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bbiSave_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                if (commandsDetailView.Save())
                {
                    if (_createNew)
                    {
                        commandsBindingSource.Add(_crtCommand);
                        _createNew = false;
                    }
                    else
                        tileView.UpdateCurrentRow();

                    ShowListView();
                }
            }
            catch (Exception ex)
            {
                ErrorHelper.Handler(ex);
            }
        }

        /// <summary>
        /// Edit button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bbiEdit_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                CommandsEntity extProgram = GridHelper.GetObjectByRowHandle<CommandsEntity>(tileView, tileView.FocusedRowHandle);
                if (extProgram != null)
                {
                    ShowDetailView(extProgram);
                }
            }
            catch (Exception ex)
            {
                ErrorHelper.Handler(ex);
            }
        }

        /// <summary>
        /// Run as admin
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bbiRunAdmin_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                if (!(tileView.GetFocusedRow() is Data.Entities.CommandsEntity model))
                    return;

                ExecuteFile(model, true);
            }
            catch (Exception ex)
            {
                ErrorHelper.Handler(ex);
            }
        }

        /// <summary>
        /// Enable command
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bbiEnable_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                CommandsEntity commnad = GridHelper.GetObjectByRowHandle<CommandsEntity>(tileView, tileView.FocusedRowHandle);
                if (commnad != null)
                {
                    bool isEnabled = AppHelper.DataEngine.Commands.ToggleState(commnad);
                    tileView.UpdateCurrentRow();
                }
            }
            catch (Exception ex)
            {
                ErrorHelper.Handler(ex);
            }
        }

        /// <summary>
        /// Create a file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bbiCreateFile_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                if (!(tileView.GetFocusedRow() is CommandsEntity model))
                    return;

                bool created = SaveCommandToFile(model);
                AppHelper.StatusMessage(created ? "File created!" : "Failed to create!", created);
            }
            catch (Exception ex)
            {
                ErrorHelper.Handler(ex);
            }
        }

        /// <summary>
        /// Delete command
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bbiDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                if (!(tileView.GetFocusedRow() is CommandsEntity model))
                    return;

                DialogResult result = DialogHelper.ShowDeleteDialog("Delete Command", $"Do you really want to delete {model.Name}?");

                if (result == DialogResult.Yes)
                {
                    bool deleted = AppHelper.DataEngine.Commands.Delete(model.Id, out string message);
                    
                    if (deleted)
                        commandsBindingSource.Remove(model);

                    AppHelper.StatusMessage(message, ForeColors.Critical);
                }
            }
            catch (Exception ex)
            {
                ErrorHelper.Handler(ex);
            }
        }

        #endregion

        #region SELECTED INDEX CHANGED

        /// <summary>
        /// Selected index changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listboxPrograms_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (listboxPrograms.SelectedItem is ExternalProgramsEntity programsEntity)
                {
                    if (programsEntity.Id == Guid.Empty)
                        commandsBindingSource.DataSource = AppHelper.DataEngine.Commands.GetAll();
                    else
                        commandsBindingSource.DataSource = AppHelper.DataEngine.Commands.GetByProgram(programsEntity.Id);

                }
            }
            catch (Exception ex)
            {
                ErrorHelper.Handler(ex);
            }
        }

        #endregion

        #region OTHERS EVENTS

        /// <summary>
        /// Custom item template event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tileView_CustomItemTemplate(object sender, TileViewCustomItemTemplateEventArgs e)
        {
            try
            {
                CommandsEntity model = GridHelper.GetObjectByRowHandle<CommandsEntity>(tileView, e.RowHandle);

                if (model == null)
                    return;

                e.HtmlTemplate.Template =
                    e.HtmlTemplate.Template.Replace("@@classEnabled@@",
                    model.IsEnabled ? "cardBorderEnabled"
                                  : "cardBorderDisabled");

                ExternalProgramsEntity externalProgram = model.ExternalProgram;

                if (externalProgram != null && externalProgram.Image != null)
                {
                    ImagesEntity iconData = externalProgram.Image;

                    if (iconData.IsSvg)
                        model.Icon = iconData.SvgImage;
                    else
                        model.Icon = iconData.BitImage;
                }
            }
            catch (Exception ex)
            {
                ErrorHelper.Handler(ex);
            }
        }

        /// <summary>
        /// Listbox custom item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBoxControl1_CustomItemTemplate(object sender, CustomItemTemplateEventArgs e)
        {
            if (e.Item is ExternalProgramsEntity programsEntity && programsEntity.Image != null)
            {
                if (programsEntity.Image.IsSvg)
                    programsEntity.Icon = programsEntity.Image.SvgImage;
                else
                    programsEntity.Icon = programsEntity.Image.BitImage;
            }
        }

        #endregion

        #region FUNCTIONS

        /// <summary>
        /// Loads the data
        /// </summary>
        public void LoadData()
        {
            externalProgramsEntityBindingSource.DataSource = AppHelper.DataEngine.ExternalPrograms.GetAll();
            externalProgramsEntityBindingSource.Insert(0, new ExternalProgramsEntity
            {
                Id = Guid.Empty,
                IdImage = Guid.Empty,
                Icon = Resources.clear_filters,
            });

            listboxPrograms.SelectedIndex = 0;
        }

        /// <summary>
        /// Shows the detail view
        /// </summary>
        private void ShowDetailView(CommandsEntity command = null)
        {
            try
            {
                if (command == null)
                {
                    command = new CommandsEntity();
                    command.Id = Guid.NewGuid();
                    command.EditingMode = false;

                    _createNew = true;
                }

                _crtCommand = command;

                bbiNew.Visibility = BarItemVisibility.Never;
                bbiSave.Visibility = BarItemVisibility.Always;
                bbiBack.Visibility = BarItemVisibility.Always;
                bbiEdit.Visibility = BarItemVisibility.Never;
                bbiRefresh.Visibility = BarItemVisibility.Never;
                bbiSearch.Visibility = BarItemVisibility.Never;

                navigationFrame.SelectedPage = npEditor;
                commandsDetailView.LoadData(command);
            }
            catch (Exception ex)
            {
                ErrorHelper.Handler(ex);
            }
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
                commandsDetailView.ResetForm();
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
        private void ExecuteFile(CommandsEntity command, bool runInAdmin = false)
        {
            if (!command.IsEnabled)
            {
                AppHelper.StatusMessage("Command is disabled!", ForeColors.Critical);
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

                    ExternalProgramsEntity program = command.ExternalProgram;

                    program.FileExtension = program.FileExtension.Replace(".", string.Empty);
                    batchFilePath += $".{program.FileExtension}";
                    fileName = program.PathToProgram;
                    arguments = $"{program.Arguments} {batchFilePath}";

                    Encoding utf8WithBom = new UTF8Encoding(encoderShouldEmitUTF8Identifier: true);
                    File.WriteAllText(batchFilePath, command.Command, utf8WithBom);

                    ProcessStartInfo startInfo = new ProcessStartInfo
                    {
                        FileName = fileName,
                        Arguments = arguments,
                        UseShellExecute = true,
                        CreateNoWindow = false,
                    };

                    if (runInAdmin)
                        startInfo.Verb = "runas";

                    Process process = new Process
                    {
                        StartInfo = startInfo
                    };

                    process.Start();
                    process.WaitForExit();

                    AppHelper.StatusMessage($"Command '{command.Name}' executed!", ForeColors.Information);

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
                AppHelper.MainFormInstance.Invoke((MethodInvoker)(() =>
                    AppHelper.MainFormInstance.BringToFront()));
            });
        }

        /// <summary>
        /// Create a file for the command
        /// </summary>
        /// <param name="command"></param>
        /// <returns></returns>
        public static bool SaveCommandToFile(CommandsEntity command)
        {
            string typeStr = command.ExternalProgram.FileExtension;

            SaveFileDialog saveFile = new SaveFileDialog
            {
                Filter = $"{typeStr} Files (*.{typeStr})|*.{typeStr}",
                DefaultExt = typeStr,
                Title = $"Save {typeStr} File",
                FileName = command.Name
            };

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                Encoding utf8WithBom = new UTF8Encoding(encoderShouldEmitUTF8Identifier: true);
                File.WriteAllText(saveFile.FileName, command.Command, utf8WithBom);
                return true;
            }

            return false;
        }

        #endregion
    }
}
