using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceHelper
{
    public class StringParse
    {
        //解析barCode字符串
        public static string ObjectToBarCode(Object value)
        {
            string returnValue = string.Empty;
            if (value == null || value is null)
            {
                returnValue = "";
            }
            else
            {
                if (value.ToString().Contains(";"))
                {
                    returnValue = value.ToString().Split(';')[0].Trim();
                }
                else
                {
                    returnValue = value.ToString().Trim();
                }
            }
            return returnValue;
        }
        public static string ObjectToString(Object value)
        {
            string returnValue = string.Empty;
            if (value == null || value is null)
            {
                returnValue = "";
            }
            else
            {
                returnValue = value.ToString().Trim();
            }
            return returnValue;
        }
        public static long ObjectToLong(Object value)
        {
            long returnValue = 0L;
            if (value == null || value is null)
            {
                returnValue = 0L;
            }
            else
            {
                long.TryParse(value.ToString(), out returnValue);
            }
            return returnValue;
        }

        public static int ObjectToInt(Object value)
        {
            int returnValue = 0;
            if (value == null || value is null)
            {
                returnValue = 0;
            }
            else
            {
                int.TryParse(value.ToString(), out returnValue);
            }
            return returnValue;
        }
        public static decimal ObjectToDecimal(Object value)
        {
            decimal returnValue = 0L;
            if (value == null || value is null)
            {
                returnValue = 0L;
            }
            else
            {
                decimal.TryParse(value.ToString(), out returnValue);
            }
            return returnValue;
        }
    }
}
