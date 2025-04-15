using System;
using System.ComponentModel;
using System.Linq;

namespace Core.Enums
{
    /// <summary>
    /// Message Type Enum
    /// </summary>
    public enum MessageTypeEnum
    {
        [Description("(Q) Question")]
        Question,
        [Description("(D) Delete")]
        Delete,
        [Description("(C) Confirm")]
        Confirm,
        [Description("(M) Message")]
        Notification,
        [Description("(T) Toast")]
        Toast
    }
}
