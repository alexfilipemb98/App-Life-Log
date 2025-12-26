using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Attributes
{
    public class RangeAttribute : System.ComponentModel.DataAnnotations.RangeAttribute
    {
        #region MAIN

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="minimum"></param>
        /// <param name="maximum"></param>
        public RangeAttribute(int minimum, int maximum) : base(minimum, maximum)
        {
            ErrorMessage = "The field '{0}' is out of range!";
        }

        #endregion

        #region OVERRIDES

        /// <summary>
        /// Format message
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public override string FormatErrorMessage(string name) =>
            string.Format(ErrorMessage ?? string.Empty, name);

        #endregion
    }
}
