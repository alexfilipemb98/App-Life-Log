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
    public partial class CommandsListView : XtraUserControl
    {
        #region MAIN

        //PRIVATE
        private Data.Entities.CommandsEntity _crtCommand;
        private bool _createNew = false;

        /// <summary>
        /// Constructor to initialize the view
        /// </summary>
        public CommandsListView() => InitializeComponent();

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
                Data.Entities.CommandsEntity model = GridHelper.GetObjectByRowHandle<Data.Entities.CommandsEntity>(tileView, e.RowHandle);

                if (model == null)
                    return;

                e.HtmlTemplate.Template =
                    e.HtmlTemplate.Template.Replace("@@classEnabled@@",
                    model.IsEnabled ? "cardBorderEnabled"
                                  : "cardBorderDisabled");

                Data.Entities.ExternalProgramsEntity externalProgram = model.ExternalProgram;

                if ((externalProgram != null) && (externalProgram.Image != null))
                {
                    Data.Entities.ImagesEntity iconData = externalProgram.Image;

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

        #endregion

        #region FUNCTIONS

        /// <summary>
        /// Loads the data
        /// </summary>
        public void LoadData()
        {
            commandsBindingSource.DataSource = AppHelper.DataEngine.Commands.GetAll();
            externalProgramsEntityBindingSource.DataSource = AppHelper.DataEngine.ExternalPrograms.GetAll();
        }

        /// <summary>
        /// Shows the detail view
        /// </summary>
        private void ShowDetailView(Data.Entities.CommandsEntity model = null)
        {
            try
            {
                if (model == null)
                {
                    model = new Data.Entities.CommandsEntity();
                    model.Id = Guid.NewGuid();
                    model.EditingMode = false;

                    _createNew = true;
                }

                _crtCommand = model;

                bbiNew.Visibility = BarItemVisibility.Never;
                bbiSave.Visibility = BarItemVisibility.Always;
                bbiBack.Visibility = BarItemVisibility.Always;
                bbiEdit.Visibility = BarItemVisibility.Never;

                navigationFrame.SelectedPage = npEditor;
                commandsDetailView.LoadData(model);
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
        /// <param name="file"></param>
        /// <returns></returns>
        private void ExecuteFile(Data.Entities.CommandsEntity file, bool runInAdmin = false)
        {
            if (!file.IsEnabled)
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

                    ExternalProgramsEntity program = file.ExternalProgram;

                    program.FileExtension = program.FileExtension.Replace(".", string.Empty);
                    batchFilePath += $".{program.FileExtension}";
                    fileName = program.PathToProgram;
                    arguments = $"{program.Arguments} {batchFilePath}";

                    Encoding utf8WithBom = new UTF8Encoding(encoderShouldEmitUTF8Identifier: true);
                    File.WriteAllText(batchFilePath, file.Command, utf8WithBom);

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

                    AppHelper.StatusMessage($"Command '{file.Name}' executed!", ForeColors.Information);

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

        #endregion
    }
}
