using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse
{
    public class CompareValidator
    {
        public static Decimal decCompare;
        public static DateTime datetimeCompare;
        public static Guid guidCompare;
        public static int integerCompare;
        public static Boolean booleanCompare;
        public static String stringCompare;
        public static Guid myGuid(String s)
        {
            Guid id = new Guid();
            return id = Guid.TryParse(s, out guidCompare) ? guidCompare : Guid.Empty;
        }
        public static Boolean myBoolean(String s)
        {
            String bol = s == "1" ? "true" : s;
            Boolean id = new Boolean();
            return id = Boolean.TryParse(bol, out booleanCompare) ? booleanCompare : false;
        }
        public static Decimal myDecimal(String s)
        {
            Decimal id = new Decimal();
            s = s == null ? "0" : s.Replace(",", "");
            return id = Decimal.TryParse(s, out decCompare) ? decCompare : 0;
        }
        public static DateTime myDateTime(String s)
        {
            DateTime id = new DateTime();
            return id = DateTime.TryParse(s, out datetimeCompare) ? datetimeCompare : DateTime.Now;
        }

        public static Int32 myInteger(String s)
        {
            Int32 id = new Int32();
            s = s == null ? "0" : s.Replace(",", "");
            return id = Int32.TryParse(s, out integerCompare) ? integerCompare : 0;
        }
    }
}
