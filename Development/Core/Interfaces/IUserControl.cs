using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    /// <summary>
    /// Interface for UserControl
    /// </summary>
    public interface IUserControl
    {
        /// <summary>
        /// Load data
        /// </summary>
        void LoadData();

        /// <summary>
        /// Save data
        /// </summary>
        /// <returns></returns>
        bool SaveData();    

    }
}
