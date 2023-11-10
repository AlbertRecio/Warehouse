using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse_DataLayer
{
    public class DataAccess
    {
        public Database db;
        public DbCommand dbcmd;
        public string con = "Data Source=192.168.1.26;Initial Catalog=Warehouse;User ID=sa;Password=nuts@admin2015";
        public DataAccess()
        {
            try
            {
                db = new SqlDatabase(con);
            }
            catch (Exception EX)
            {
            }
        }
    }
}
