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
        public string con = "Data Source=.;Initial Catalog=Warehouse;Integrated Security=True";
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
