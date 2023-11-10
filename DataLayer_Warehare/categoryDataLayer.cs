using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Warehouse_DataLayer;

namespace DataLayer_Warehare
{
    public class categoryDataLayer : DataAccess
    {
        public DataTable SelectDataFromCategoryID(Guid ID)
        {
            DataTable dt = new DataTable();
            dbcmd = db.GetStoredProcCommand("selectallbyCategoryID");
            db.AddInParameter(dbcmd, "@CategoryID", DbType.Guid, ID);
            dt.Load(db.ExecuteReader(dbcmd));
            return dt;
        }
        public DataTable SelectAll()
        {
            DataTable dt = new DataTable();
            dbcmd = db.GetStoredProcCommand("selectallCategory");
            dt.Load(db.ExecuteReader(dbcmd));
            return dt;
        }

        public bool checkIfExist(Guid iD, string desc,string action)
        {
            bool b = new bool();
            dbcmd = db.GetStoredProcCommand("SP_CheckExistCategory");
            db.AddInParameter(dbcmd, "@CategoryID", DbType.Guid, iD);
            db.AddInParameter(dbcmd, "@Desc", DbType.String, desc); 
            db.AddInParameter(dbcmd, "@Action", DbType.String, action);
            return b = bool.Parse(db.ExecuteScalar(dbcmd).ToString());
        }

        public void DeleteCategory(Guid iD)
        { 
            dbcmd = db.GetStoredProcCommand("SP_DeleteCategory");
            db.AddInParameter(dbcmd, "@CategoryID", DbType.Guid, iD);
            db.ExecuteNonQuery(dbcmd);
        }

        public bool checkIfUsed(Guid iD)
        {
            bool b = new bool();
            dbcmd = db.GetStoredProcCommand("SP_CheckUsedCategory");
            db.AddInParameter(dbcmd, "@CategoryID", DbType.Guid, iD);
            return b = bool.Parse(db.ExecuteScalar(dbcmd).ToString());
        }

        public DataTable findCategory()
        {
            DataTable dt = new DataTable();
            dbcmd = db.GetStoredProcCommand("findCategory");
            dt.Load(db.ExecuteReader(dbcmd));
            return dt;
        }
    }
}
