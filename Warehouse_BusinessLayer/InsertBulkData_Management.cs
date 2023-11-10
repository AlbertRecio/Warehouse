using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Warehouse_DataLayer;

namespace Warehouse_BusinessLayer
{
    public class InsertBulkData_Management
    {
        public DataTable InserBulk(DataTable dt, string yourPRoc, string d)
        {
            return new InserBulk_DataLayer().InserBulk(dt, yourPRoc, d);
        }
        public DataTable InserBulkWithParam(DataTable dt, Guid id, string yourPRoc, string d, string i)
        {
            return new InserBulk_DataLayer().InserBulkWithParam(dt, id, yourPRoc, d, i);
        }

        public DataTable InserBulkUSer(DataTable dt, string yourPRoc, string d)
        {
            return new InserBulk_DataLayer().InserBulk(dt, yourPRoc, d);
        }
    }
}
