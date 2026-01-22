namespace LifeLog.Core.Attributes;

/// <summary>
/// String length with an auto message
/// </summary>
public class StringLengthAttribute : System.ComponentModel.DataAnnotations.StringLengthAttribute
{
    #region MAIN

    //PRIVATE
    private int? CurrentLength { get; set; }

    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="maximumLength"></param>
    public StringLengthAttribute(int maximumLength) : base(maximumLength)
    {
    }

    #endregion

    #region OVERRIDES

    /// <summary>
    /// Is Valid
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    public override bool IsValid(object? value)
    {
        string? valStr = value as string;
        int length = valStr?.Length ?? 0;

        CurrentLength = length;

        if (string.IsNullOrEmpty(valStr))
        {
            return true;
        }

        if (length < MinimumLength || length > MaximumLength)
        {
            return false;
        }

        return true;
    }

    /// <summary>
    /// Format error message
    /// </summary>
    /// <param name="name"></param>
    /// <returns></returns>
    public override string FormatErrorMessage(string name)
    {
        if (CurrentLength.HasValue)
        {
            if (CurrentLength.Value < MinimumLength)
            {
                return $"The '{name}' length is '{CurrentLength.Value}', must be at least '{MinimumLength}' characters!";
            }
            else if (CurrentLength.Value > MaximumLength)
            {
                return $"The '{name}' length is '{CurrentLength.Value}', must be less or equal to '{MaximumLength}' characters!";
            }
        }

        return $"The '{name}' length must be between '{MinimumLength}' and '{MaximumLength}' characters!";
    }

    #endregion
}