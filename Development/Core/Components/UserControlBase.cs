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
    public partial class UserControlBase<Model> : XtraUserControl , IUserControl<Model>
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
        public virtual bool SaveData(out Model data)
        {
            data = default(Model);
            return true;
        }

        /// <summary>
        /// Resets the data
        /// </summary>
        public virtual void ResetData()
        {
        }

        /// <summary>
        /// Sets the data
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="data"></param>
        /// <exception cref="NotImplementedException"></exception>
        public virtual void SetData(Model data)
        {
          
        }

        #endregion
    }
}
