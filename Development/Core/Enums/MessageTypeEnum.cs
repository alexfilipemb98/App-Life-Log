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
        [Description("(q) Question")]
        Question,
        [Description("(d) Delete")]
        Delete,
        [Description("(c) Confirm")]
        Confirm
    }
}
