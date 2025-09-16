using Core.Models.Data;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using Life_Log.Helpers;
using Life_Log.Views.Home.Main.CommandsRunner;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DevExpress.LookAndFeel.DXSkinColors;

namespace Life_Log.Views.Home.Main.Contacts
{
    public partial class ContactsView : XtraUserControl
    {
        public ContactsView() => InitializeComponent();
        private void bbiNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ContactsDataModel model = new ContactsDataModel
            {
                IdUser = AppHelper.CurrentUser.Id
            };

            ShowDetails(model);
        }



        /// <summary>
        /// Static function to load data
        /// </summary>
        public void LoadData(bool showMessage = true)
        {
            AppHelper.ShowLoading();
            Task.Run(() =>
            {
                Invoke((MethodInvoker)(() =>
                {
                    List<ContactsDataModel> list = AppHelper.Engine.Users.GetContacts(AppHelper.CurrentUser.Id, out string message);

                    contactsDataModelBindingSource.DataSource = list;

                    if (showMessage)
                        AppHelper.SetStatusLabel(message, ForeColors.Information);

                }));
            }).ContinueWith(t =>
            {
                AppHelper.HideLoading();
            });
        }

        /// <summary>
        /// Go back
        /// </summary>
        private void GoBack()
        {
            contactsDetailView.ResetForm();
            navigationFrame.SelectedPage = npMain;
            bbiSave.Visibility = BarItemVisibility.Never;
            bbiNew.Visibility = BarItemVisibility.Always;
            bbiReload.Visibility = BarItemVisibility.Always;
            bbiBack.Visibility = BarItemVisibility.Never;

            LoadData();
        }

        /// <summary>
        /// Show details
        /// </summary>
        /// <param name="model"></param>
        private void ShowDetails(ContactsDataModel model)
        {
            contactsDetailView.LoadData(model);
            navigationFrame.SelectedPage = npEdit;
            bbiSave.Visibility = BarItemVisibility.Always;
            bbiNew.Visibility = BarItemVisibility.Never;
            bbiReload.Visibility = BarItemVisibility.Never;
            bbiBack.Visibility = BarItemVisibility.Always;
        }

        private void bbiSave_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (contactsDetailView.SaveData())
                GoBack();
        }

        private void tileView_ItemRightClick(object sender, DevExpress.XtraGrid.Views.Tile.TileViewItemClickEventArgs e)
        {
            popupMenu.ShowPopup(Control.MousePosition);
        }

        private void bbiEdit_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!(tileView.GetFocusedRow() is ContactsDataModel model))
                return;

            ShowDetails(model);
        }

        private void bbiBack_ItemClick(object sender, ItemClickEventArgs e) => GoBack();

        private void tileView_CustomItemTemplate(object sender, DevExpress.XtraGrid.Views.Tile.TileViewCustomItemTemplateEventArgs e)
        {
            ContactsDataModel model = GridHelper.GetObjectByRowHandle<ContactsDataModel>(tileView, e.RowHandle);

            if (model == null) return;

            if (model.IdImage > 0)
            {
                ImageDataModel iconData = AppHelper.Engine.Images.Get(model.IdImage, out _);

                if (iconData.IsSvg)
                    model.Icon = iconData.SvgImage;
                else
                    model.Icon = iconData.BitImage;
            }
        }

        /// <summary>
        /// Reload data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bbiReload_ItemClick(object sender, ItemClickEventArgs e) =>
            LoadData();
    }
}
