using HW1.Enums;
using HW1.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HW1.Models.Service
{
    /// <summary>
    /// 收入、支出
    /// </summary>
    public class InOutService
    {
        /// <summary>
        /// 建立N筆假資料
        /// </summary>
        /// <param name="count">數量</param>
        public IEnumerable<InOutViewModel> CreateFakeData( int count )
        {
            var random = new Random( Guid.NewGuid().GetHashCode() );
            var model = new List<InOutViewModel>();
            for ( var i = 0; i < count; i++ )
            {
                model.Add( new InOutViewModel { Category = i < count / 2 ? InOut.In : InOut.Out,
                                                Money = random.Next( 1, 9999 ),
                                                Date = DateTime.Now.AddDays( i ),
                                              } );
            }

            return model;
        }
    }
}