using System.ComponentModel;

namespace HW1.Enums
{
    /// <summary>
    /// 收入、支出
    /// </summary>
    public enum InOut
    {
        /// <summary>
        /// 收入
        /// </summary>
        [Description( "收入" )]
        In = 1,
        /// <summary>
        /// 支出
        /// </summary>
        [Description( "支出" )]
        Out
    }
}