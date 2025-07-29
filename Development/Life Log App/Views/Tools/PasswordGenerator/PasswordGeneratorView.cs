using DevExpress.XtraEditors;
using Life_Log_App.Helpers;
using System;
using Utils;

namespace Life_Log_App.Views.Tools.PasswordGenerator
{
    /// <summary>
    /// Password generate
    /// </summary>
    public partial class PasswordGeneratorView : XtraUserControl
    {
        #region MAIN

        /// <summary>
        /// Constructor
        /// </summary>
        public PasswordGeneratorView() => InitializeComponent();

        #endregion

        #region ITEM CLICK

        /// <summary>
        /// Button to generate passwords
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bbiGenPass_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) =>
            GeneratePasswords();

        #endregion

        #region TOGGLED

        /// <summary>
        /// Shared event to generate passwords
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void event_Toggled(object sender, EventArgs e) => 
            GeneratePasswords();

        #endregion

        #region FUNCTIONS

        /// <summary>
        /// Generate passwords
        /// </summary>
        /// <returns></returns>
        private void GeneratePasswords()
        {
            try
            {
                if (!tsUseUCLetters.IsOn && !tsUseLCLetters.IsOn && !tsUseNumbers.IsOn && !tsUseSpecialChars.IsOn)
                {
                    passwordsList.Clear();
                }
                else
                {
                    passwordsList.Clear();
                    for (int i = 0; i < passwordsCount.Value; i++)
                    {
                        passwordsList.AppendLine(SecurityUtil.GeneratePassword(passwordLegth.Value, tsUseUCLetters.IsOn, tsUseLCLetters.IsOn, tsUseNumbers.IsOn, tsUseSpecialChars.IsOn));
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorHelper.Handler(ex);
            }
        }

        #endregion

    }
}
