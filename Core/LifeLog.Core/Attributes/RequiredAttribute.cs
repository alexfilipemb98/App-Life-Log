namespace LifeLog.Core.Attributes
{
    /// <summary>
    /// Requiered atribute with a auto message
    /// </summary>
    public class Required : System.ComponentModel.DataAnnotations.RequiredAttribute
    {
        #region MAIN

        /// <summary>
        /// Constructor
        /// </summary>
        public Required()
        {
            ErrorMessage = "The field '{0}' is required!";
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
