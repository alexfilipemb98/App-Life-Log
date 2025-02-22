using DevExpress.XtraBars.Ribbon;
using Life_Log.Helpers;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Life_Log.Forms.Dialogs
{
    /// <summary>
    /// Three simple rule form
    /// </summary>
    public partial class ThreeSimpleRuleForm : RibbonForm
    {
        #region MAIN

        /// <summary>
        /// Constructor
        /// </summary>
        public ThreeSimpleRuleForm() => InitializeComponent();

        #endregion

        #region EDIT VALUE CHANGED

        /// <summary>
        /// Edit value changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextEdit_EditValueChanged(object sender, EventArgs e)
        {
            if (teAValue.EditValue != null && teBValue.EditValue != null && teA2Value.EditValue != null)
                teResult.Text = (((decimal)teBValue.EditValue * (decimal)teA2Value.EditValue) / (decimal)teAValue.EditValue).ToString();
        }

        #endregion

        #region FUNCTIONS
        
        /// <summary>
        /// Show form
        /// </summary>
        /// <returns></returns>
        public static DialogResult Dialog()
        {
            using (ThreeSimpleRuleForm form = new ThreeSimpleRuleForm())
            {
                return form.ShowDialog(AppHelper.MainFormInstance);
            }
        }

        #endregion
    }
}