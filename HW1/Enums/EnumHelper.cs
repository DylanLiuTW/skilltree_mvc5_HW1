using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Web.Mvc;

namespace HW1.Enums
{
    public static class EnumHelper
    {
        /// <summary>
        /// 取得列舉描述
        /// </summary>
        /// <param name="obj">列舉物件</param>
        /// <returns></returns>
        public static string GetDescription( this Enum obj )
        {
            string objName = obj.ToString();
            var t = obj.GetType();
            System.Reflection.FieldInfo fi = t.GetField( objName );
            var arrDesc = ( DescriptionAttribute[] ) fi.GetCustomAttributes( typeof( DescriptionAttribute ), false );

            return arrDesc[ 0 ].Description;
        }
        /// <summary>
        /// 取得列舉描述
        /// </summary>
        /// <typeparam name="T">列舉類型</typeparam>
        /// <param name="obj">列舉數字</param>
        /// <returns></returns>
        public static string GetDescription<T>( this object obj )
        {
            int value;
            if ( obj == null )
            {
                return string.Empty;
            }
            else
            {
                if ( !int.TryParse( obj.ToString(), out value ) )
                {
                    value = 0;
                }
            }

            var e = Enum.Parse( typeof( T ), Convert.ToString( value ) );

            return ( ( Enum ) e ).GetDescription();
        }

        /// <summary>
        /// 取得列舉描述下拉選單
        /// </summary>
        /// <typeparam name="T">列舉類型</typeparam>
        /// <param name="type">列舉類型</param>
        /// <returns></returns>
        public static SelectList GetEnumSelectListByDescription<T>( this Type type ) where T : struct
        {
            var dictionary = new Dictionary<int, string>();

            foreach ( var item in Enum.GetValues( type ) )
            {
                var value = ( int ) item;
                dictionary.Add( value, value.GetDescription<T>() );
            }

            return new SelectList( dictionary, "Key", "Value" );
        }
    }
}