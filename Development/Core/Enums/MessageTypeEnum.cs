using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
