using HW1.Enums;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace HW1.Models.ViewModel
{
    /// <summary>
    /// 收入、支出
    /// </summary>
    public class InOutViewModel
    {
        /// <summary>
        /// 收入、支出類別
        /// </summary>
        [DisplayName( "類別" )]
        public InOut Category { get; set; }
        /// <summary>
        /// 金額
        /// </summary>
        [DisplayName( "金額" )]
        public int Money { get; set; }
        /// <summary>
        /// 日期
        /// </summary>
        [DisplayName( "日期" )]
        [DisplayFormat( DataFormatString = "yyyy-MM-dd" )]
        public DateTime Date { get; set; }
        /// <summary>
        /// 備註
        /// </summary>
        [DisplayName( "備註" )]
        public string Description { get; set; }
    }
}