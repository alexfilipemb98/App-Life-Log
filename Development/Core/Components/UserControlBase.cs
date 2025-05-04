using DevExpress.XtraEditors;
using DevExpress.XtraRichEdit;
using Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Components
{
    public partial class UserControlBase : XtraUserControl , IUserControl
    {
        /// <summary>
        /// Base UserControl
        /// </summary>
        public UserControlBase() => InitializeComponent();

        #region FUNCOES

        /// <summary>
        /// Loads the data
        /// </summary>
        public virtual void LoadData()
        {

        }

        /// <summary>
        /// Saves the data
        /// </summary>
        public virtual bool SaveData()
        {
            return true;
        }

        #endregion
    }
}
