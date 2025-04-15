using Core.Extensions;
using DevExpress.XtraDataLayout;
using DevExpress.XtraEditors.DXErrorProvider;
using DevExpress.XtraLayout;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Windows.Forms;

namespace LifeLogApp.Helpers
{
    /// <summary>
    /// Validation helper
    /// </summary>
    public static class ValidationHelper
    {
        /// <summary>
        /// Validate model and set error to dxerrorprovider
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="model"></param>
        /// <param name="dXErrorProvider"></param>
        /// <param name="layoutControl"></param>
        /// <returns></returns>
        public static bool ValidateModelAndSetError<T>(T model, DXErrorProvider dXErrorProvider, LayoutControl layoutControl)
        {
            dXErrorProvider.ClearErrors();

            bool isValid = model.IsValid(out List<ValidationResult> validationResults);
            if (!isValid)
            {
                foreach (ValidationResult validation in validationResults)
                {
                    if (!validation.MemberNames.Any())
                        continue;

                    string tag = validation.MemberNames?.First();
                    Control control = FindControlByTag(layoutControl, tag);

                    if (control != null)
                        dXErrorProvider.SetError(control, validation.ErrorMessage);
                }
            }

            return isValid;
        }

        /// <summary>
        /// Validate model and set error
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="model"></param>
        /// <param name="dXErrorProvider"></param>
        /// <param name="dataLayoutControl"></param>
        /// <returns></returns>
        public static bool ValidateModelAndSetError<T>(T model, DXErrorProvider dXErrorProvider, DataLayoutControl dataLayoutControl)
        {
            dXErrorProvider.ClearErrors();
            dataLayoutControl.Validate();

            bool isValid = model.IsValid(out List<ValidationResult> validationResults);
            if (!isValid)
            {
                foreach (ValidationResult validation in validationResults)
                {
                    if (!validation.MemberNames.Any())
                        continue;

                    string propertyName = validation.MemberNames.First();

                    Control boundControl = dataLayoutControl.Controls
                            .OfType<Control>()
                            .FirstOrDefault(c => c.DataBindings.Cast<Binding>()
                            .Any(b => b.BindingMemberInfo.BindingMember == propertyName));

                    if (boundControl != null)
                        dXErrorProvider.SetError(boundControl, validation.ErrorMessage);
                }
            }

            return isValid;
        }

        #region FUNCTIONS

        /// <summary>
        /// Find control by tag 
        /// </summary>
        /// <param name="parent"></param>
        /// <param name="tag"></param>
        /// <returns></returns>
        private static Control FindControlByTag(Control parent, object tag)
        {
            foreach (Control control in parent.Controls)
            {
                if (control.Tag != null && control.Tag.Equals(tag))
                    return control;

                Control foundControl = FindControlByTag(control, tag);
                if (foundControl != null)
                    return foundControl;

            }

            return null;
        }

        #endregion
    }

}
