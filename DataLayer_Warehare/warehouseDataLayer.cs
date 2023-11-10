using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse_DataLayer
{
    public class warehouseDataLayer : DataAccess
    {
        public DataTable SelectDataFromWarehouseID(Guid ID)
        {
            DataTable dt = new DataTable();
            dbcmd = db.GetStoredProcCommand("selectallbyWarehouseID");
            db.AddInParameter(dbcmd, "@WarehouseID", DbType.Guid, ID);
            dt.Load(db.ExecuteReader(dbcmd));
            return dt;
        }
        public DataTable SelectAll()
        {
            DataTable dt = new DataTable();
            dbcmd = db.GetStoredProcCommand("selectallWarehouse");
            dt.Load(db.ExecuteReader(dbcmd));
            return dt;
        }

        public DataTable GetDateTime()
        {
            DataTable dt = new DataTable();
            dbcmd = db.GetStoredProcCommand("SP_GetDateTime");
            dt.Load(db.ExecuteReader(dbcmd));
            return dt;
        }

        public DataTable WarehouserRights(object ID)
        {
            DataTable dt = new DataTable();
            dbcmd = db.GetStoredProcCommand("WarehouserRights");
            db.AddInParameter(dbcmd, "@UserID", DbType.Guid, ID);
            dt.Load(db.ExecuteReader(dbcmd));
            return dt;
        }

        public DataTable searchAccount(string acc)
        {
            DataTable dt = new DataTable();
            dbcmd = db.GetStoredProcCommand("searchAccount");
            db.AddInParameter(dbcmd, "@acc", DbType.String, acc);
            dt.Load(db.ExecuteReader(dbcmd));
            return dt;
        }

        public DataTable ChangePassword(string pass,Guid ID)
        {
            DataTable dt = new DataTable();
            dbcmd = db.GetStoredProcCommand("ChangePassword");
            db.AddInParameter(dbcmd, "@pass", DbType.String, pass);
            db.AddInParameter(dbcmd, "@UserID", DbType.Guid, ID);
            dt.Load(db.ExecuteReader(dbcmd));
            return dt;
        }

        public DataTable RightsStockIn(Guid iD)
        {
            DataTable dt = new DataTable();
            dbcmd = db.GetStoredProcCommand("RightsStockIn");
            db.AddInParameter(dbcmd, "@UserID", DbType.Guid, iD);
            dt.Load(db.ExecuteReader(dbcmd));
            return dt;
        }

        public DataTable RightsStockAdjustment(Guid iD)
        {
            DataTable dt = new DataTable();
            dbcmd = db.GetStoredProcCommand("RightsStockAdjustment");
            db.AddInParameter(dbcmd, "@UserID", DbType.Guid, iD);
            dt.Load(db.ExecuteReader(dbcmd));
            return dt;
        }

        public DataTable RightsStockTransfer(Guid iD)
        {
            DataTable dt = new DataTable();
            dbcmd = db.GetStoredProcCommand("RightsStockTransfer");
            db.AddInParameter(dbcmd, "@UserID", DbType.Guid, iD);
            dt.Load(db.ExecuteReader(dbcmd));
            return dt;
        }

        public DataTable RightsStockOut(Guid iD)
        {
            DataTable dt = new DataTable();
            dbcmd = db.GetStoredProcCommand("RightsStockOut");
            db.AddInParameter(dbcmd, "@UserID", DbType.Guid, iD);
            dt.Load(db.ExecuteReader(dbcmd));
            return dt;
        }

        public DataTable RightsMasterFile(Guid iD)
        {
            DataTable dt = new DataTable();
            dbcmd = db.GetStoredProcCommand("RightsMasterFile");
            db.AddInParameter(dbcmd, "@UserID", DbType.Guid, iD);
            dt.Load(db.ExecuteReader(dbcmd));
            return dt;
        }

        public DataTable RightsCategory(Guid iD)
        {
            DataTable dt = new DataTable();
            dbcmd = db.GetStoredProcCommand("RightsCategory");
            db.AddInParameter(dbcmd, "@UserID", DbType.Guid, iD);
            dt.Load(db.ExecuteReader(dbcmd));
            return dt;
        }

        public DataTable RightsWarehouse(object iD)
        {
            DataTable dt = new DataTable();
            dbcmd = db.GetStoredProcCommand("RightsWarehouse");
            db.AddInParameter(dbcmd, "@UserID", DbType.Guid, iD);
            dt.Load(db.ExecuteReader(dbcmd));
            return dt;
        }

        public DataTable SelectAllMaster()
        {
            DataTable dt = new DataTable();
            dbcmd = db.GetStoredProcCommand("selectallmaster");
            dt.Load(db.ExecuteReader(dbcmd));
            return dt;
        }

        public DataTable GetDetails(string user, string pass)
        {
            DataTable dt = new DataTable();
            dbcmd = db.GetStoredProcCommand("GetUserDetails");
            db.AddInParameter(dbcmd, "@User", DbType.String, user);
            db.AddInParameter(dbcmd, "@Pass", DbType.String, pass);
            dt.Load(db.ExecuteReader(dbcmd));
            return dt;
        }

        public DataTable findModule()
        {
            DataTable dt = new DataTable();
            dbcmd = db.GetStoredProcCommand("findallmodule");
            dt.Load(db.ExecuteReader(dbcmd));
            return dt;
        }

        public DataTable findUser()
        {
            DataTable dt = new DataTable();
            dbcmd = db.GetStoredProcCommand("findUser");
            dt.Load(db.ExecuteReader(dbcmd));
            return dt;
        }

        public bool CheckRights(string user, string pass)
        {
            bool b = new bool();
            dbcmd = db.GetStoredProcCommand("SP_CheckRights");
            db.AddInParameter(dbcmd, "@Username", DbType.String, user);
            db.AddInParameter(dbcmd, "@Password", DbType.String, pass);
            return b = bool.Parse(db.ExecuteScalar(dbcmd).ToString());
        }

        public DataTable RightsView(Guid iD)
        {
            DataTable dt = new DataTable();
            dbcmd = db.GetStoredProcCommand("RightsView");
            db.AddInParameter(dbcmd, "@UserID", DbType.Guid, iD);
            dt.Load(db.ExecuteReader(dbcmd));
            return dt;
        }

        public bool LogIn(string user, string pass)
        {
            bool b = new bool();
            dbcmd = db.GetStoredProcCommand("SP_Login");
            db.AddInParameter(dbcmd, "@Username", DbType.String, user);
            db.AddInParameter(dbcmd, "@Password", DbType.String, pass);
            return b = bool.Parse(db.ExecuteScalar(dbcmd).ToString());
        }

        public DataTable findStockTransfer()
        {
            DataTable dt = new DataTable();
            dbcmd = db.GetStoredProcCommand("selectAllTransfer");
            dt.Load(db.ExecuteReader(dbcmd));
            return dt;
        }

        public DataTable findStockAdjustment()
        {
            DataTable dt = new DataTable();
            dbcmd = db.GetStoredProcCommand("findStockAdjustment");
            dt.Load(db.ExecuteReader(dbcmd));
            return dt;
        }

        public DataTable findStockOut()
        {
            DataTable dt = new DataTable();
            dbcmd = db.GetStoredProcCommand("findStockOut");
            dt.Load(db.ExecuteReader(dbcmd));
            return dt;
        }

        public DataTable findStockIn()
        {
            DataTable dt = new DataTable();
            dbcmd = db.GetStoredProcCommand("findStockIn");
            dt.Load(db.ExecuteReader(dbcmd));
            return dt;
        }

        public DataTable findWarehouse()
        {
            DataTable dt = new DataTable();
            dbcmd = db.GetStoredProcCommand("findWarehouse");
            dt.Load(db.ExecuteReader(dbcmd));
            return dt;
        }

        public DataTable SelectAllModule()
        {
            DataTable dt = new DataTable();
            dbcmd = db.GetStoredProcCommand("SelectAllModule");
            dt.Load(db.ExecuteReader(dbcmd));
            return dt;
        }

        public DataTable findMaster()
        {
            DataTable dt = new DataTable();
            dbcmd = db.GetStoredProcCommand("findMaster");
            dt.Load(db.ExecuteReader(dbcmd));
            return dt;
        }


        public DataTable SelectDataFromCat()
        {
            DataTable dt = new DataTable();
            dbcmd = db.GetStoredProcCommand("selectallCatID");
            dt.Load(db.ExecuteReader(dbcmd));
            return dt;
        }
        public DataTable SelectDataFromMasterID(Guid ID)
        {
            DataTable dt = new DataTable();
            dbcmd = db.GetStoredProcCommand("SelectDataFromMasterID");
            db.AddInParameter(dbcmd, "@masterID", DbType.Guid, ID);
            dt.Load(db.ExecuteReader(dbcmd));
            return dt;
        }
        public DataTable Warehousemasterfile(Guid ID, Guid Cat)
        {
            DataTable dt = new DataTable();
            dbcmd = db.GetStoredProcCommand("showWarehousemasterfile");
            db.AddInParameter(dbcmd, "@masterID", DbType.Guid, ID);
            db.AddInParameter(dbcmd, "@CategoryID", DbType.Guid, Cat);
            dt.Load(db.ExecuteReader(dbcmd));
            return dt;
        }

        public DataTable NewShowUser()
        {
            DataTable dt = new DataTable();
            dbcmd = db.GetStoredProcCommand("NewShowUser");
            dt.Load(db.ExecuteReader(dbcmd));
            return dt;
        }

        public bool checkIfExistModule(Guid iD, string text, string v)
        {
            bool b = new bool();
            dbcmd = db.GetStoredProcCommand("SP_CheckExistModule");
            db.AddInParameter(dbcmd, "@ModuleID", DbType.Guid, iD);
            db.AddInParameter(dbcmd, "@Name", DbType.String, text);
            db.AddInParameter(dbcmd, "@Action", DbType.String, v);
            return b = bool.Parse(db.ExecuteScalar(dbcmd).ToString());
        }

        public async Task<DataTable> GetAllItemsByDATEforAPI(DateTime date1, DateTime date2)
        {
            DataTable dt = new DataTable();
            using (dbcmd = db.GetStoredProcCommand("SP_GetAllItemsByDATEforAPI"))
            {

                db.AddInParameter(dbcmd, "@StartDate", DbType.DateTime, date1);
                db.AddInParameter(dbcmd, "@EndDate", DbType.DateTime, date2);
                using (IDataReader DR = db.ExecuteReader(dbcmd))
                {
                    dbcmd.CommandTimeout = 0;
                    dt.Load(DR);

                }
            }
            return dt;
        }

        public DataTable ShowUser(Guid guid)
        {
            DataTable dt = new DataTable();
            dbcmd = db.GetStoredProcCommand("ShowUser");
            db.AddInParameter(dbcmd, "@User", DbType.Guid, guid);
            dt.Load(db.ExecuteReader(dbcmd));
            return dt;
        }

        public DataTable SelectDataFromWar()
        {
            DataTable dt = new DataTable();
            dbcmd = db.GetStoredProcCommand("selectallWarID");
            dt.Load(db.ExecuteReader(dbcmd));
            return dt;
        }

        public DataTable printUsers()
        {
            DataTable dt = new DataTable();
            dbcmd = db.GetStoredProcCommand("printUsers");
            dt.Load(db.ExecuteReader(dbcmd));
            return dt;
        }

        public DataTable SelectDataFromModuleID(Guid guid)
        {
            DataTable dt = new DataTable();
            dbcmd = db.GetStoredProcCommand("SelectDataFromModuleID");
            db.AddInParameter(dbcmd, "@moduleID", DbType.Guid, guid);
            dt.Load(db.ExecuteReader(dbcmd));
            return dt;
        }

        public DataTable findItem(Guid wareID)
        {
            DataTable dt = new DataTable();
            dbcmd = db.GetStoredProcCommand("findItem");
            db.AddInParameter(dbcmd, "@warehouse", DbType.Guid, wareID);
            dt.Load(db.ExecuteReader(dbcmd));
            return dt;
        }

        public bool checkIfExistWarehouse(Guid iD, string desc, string action)
        {
            bool b = new bool();
            dbcmd = db.GetStoredProcCommand("SP_CheckExistWarehouse");
            db.AddInParameter(dbcmd, "@WarehouseID", DbType.Guid, iD);
            db.AddInParameter(dbcmd, "@Desc", DbType.String, desc);
            db.AddInParameter(dbcmd, "@Action", DbType.String, action);
            return b = bool.Parse(db.ExecuteScalar(dbcmd).ToString());
        }

        public DataTable printStockOut()
        {
            DataTable dt = new DataTable();
            dbcmd = db.GetStoredProcCommand("printStockOut");
            dt.Load(db.ExecuteReader(dbcmd));
            return dt;
        }

        public bool checkIfExistUsername(Guid iD, string text, string v)
        {
            bool b = new bool();
            dbcmd = db.GetStoredProcCommand("SP_CheckIfExistUsername");
            db.AddInParameter(dbcmd, "@UserID", DbType.Guid, iD);
            db.AddInParameter(dbcmd, "@Username", DbType.String, text);
            db.AddInParameter(dbcmd, "@Action", DbType.String, v);
            return b = bool.Parse(db.ExecuteScalar(dbcmd).ToString());
        }

        public DataTable SelectAllAdjustment()
        {
            DataTable dt = new DataTable();
            dbcmd = db.GetStoredProcCommand("SelectAllAdjustment");
            dt.Load(db.ExecuteReader(dbcmd));
            return dt;
        }

        public DataTable SelectAllUser()
        {
            DataTable dt = new DataTable();
            dbcmd = db.GetStoredProcCommand("SelectAllUser");
            dt.Load(db.ExecuteReader(dbcmd));
            return dt;
        }

        public DataTable SelectDataFromStockAdjustmentID(Guid guid)
        {
            DataTable dt = new DataTable();
            dbcmd = db.GetStoredProcCommand("SelectDataFromStockAdjustmentID");
            db.AddInParameter(dbcmd, "@adjustID", DbType.Guid, guid);
            dt.Load(db.ExecuteReader(dbcmd));
            return dt;
        }

        public DataTable SelectDataFromUserID(Guid guid)
        {
            DataTable dt = new DataTable();
            dbcmd = db.GetStoredProcCommand("SelectDataFromUserID");
            db.AddInParameter(dbcmd, "@UserID", DbType.Guid, guid);
            dt.Load(db.ExecuteReader(dbcmd));
            return dt;
        }

        public DataTable SelectDataFromTransferdtlID(Guid guid)
        {
            DataTable dt = new DataTable();
            dbcmd = db.GetStoredProcCommand("SelectDataFromTransferdtlID");
            db.AddInParameter(dbcmd, "@transfer", DbType.Guid, guid);
            dt.Load(db.ExecuteReader(dbcmd));
            return dt;
        }

        public DataTable printStockAdjustment()
        {
            DataTable dt = new DataTable();
            dbcmd = db.GetStoredProcCommand("printStockAdjustment");
            dt.Load(db.ExecuteReader(dbcmd));
            return dt;
        }

        public DataTable printMasterfile()
        {
            DataTable dt = new DataTable();
            dbcmd = db.GetStoredProcCommand("printMasterfile");
            dt.Load(db.ExecuteReader(dbcmd));
            return dt;
        }

        public DataTable printWarehouse()
        {
            DataTable dt = new DataTable();
            dbcmd = db.GetStoredProcCommand("printWarehouse");
            dt.Load(db.ExecuteReader(dbcmd));
            return dt;
        }

        public DataTable printCategory()
        {
            DataTable dt = new DataTable();
            dbcmd = db.GetStoredProcCommand("printCategory");
            dt.Load(db.ExecuteReader(dbcmd));
            return dt;
        }

        public DataTable printStockTransfer()
        {
            DataTable dt = new DataTable();
            dbcmd = db.GetStoredProcCommand("printStockTransfer");
            dt.Load(db.ExecuteReader(dbcmd));
            return dt;
        }

        public DataTable printStockIn()
        {
            DataTable dt = new DataTable();
            dbcmd = db.GetStoredProcCommand("printStockIn");
            dt.Load(db.ExecuteReader(dbcmd));
            return dt;
        }

        public DataTable RemoveSameWarehouse(Guid guid)
        {
            DataTable dt = new DataTable();
            dbcmd = db.GetStoredProcCommand("RemoveSameWarehouse");
            db.AddInParameter(dbcmd, "@same", DbType.Guid, guid);
            dt.Load(db.ExecuteReader(dbcmd));
            return dt;
        }

        public DataTable SelectDataFromTransferID(Guid guid)
        {
            DataTable dt = new DataTable();
            dbcmd = db.GetStoredProcCommand("SelectDataFromTransferID");
            db.AddInParameter(dbcmd, "@transfer", DbType.Guid, guid);
            dt.Load(db.ExecuteReader(dbcmd));
            return dt;
        }

        public DataTable SelectAllStockTransfer()
        {
            DataTable dt = new DataTable();
            dbcmd = db.GetStoredProcCommand("SelectAllStockTransfer");
            dt.Load(db.ExecuteReader(dbcmd));
            return dt;
        }

        public DataTable SelectDataFromAdjustmentDtlID(Guid guid)
        {
            DataTable dt = new DataTable();
            dbcmd = db.GetStoredProcCommand("SelectDataFromStockAdjustmentDtlID");
            db.AddInParameter(dbcmd, "@adjustID", DbType.Guid, guid);
            dt.Load(db.ExecuteReader(dbcmd));
            return dt;
        }

        public DataTable stockOut(Guid vars, Guid wareID)
        {
            DataTable dt = new DataTable();
            dbcmd = db.GetStoredProcCommand("stockin");
            db.AddInParameter(dbcmd, "@warehouse", DbType.Guid, vars);
            db.AddInParameter(dbcmd, "@wareID", DbType.Guid, wareID);
            dt.Load(db.ExecuteReader(dbcmd));
            return dt;
        }

        public void DeleteMasterfile(Guid iD)
        {
            dbcmd = db.GetStoredProcCommand("SP_DeleteMasterfile");
            db.AddInParameter(dbcmd, "@MasterID", DbType.Guid, iD);
            db.ExecuteNonQuery(dbcmd);
        }

        public bool checkIfUsedMasterfile(Guid iD)
        {
            bool b = new bool();
            dbcmd = db.GetStoredProcCommand("SP_CheckUsedMasterfile");
            db.AddInParameter(dbcmd, "@MasterID", DbType.Guid, iD);
            return b = bool.Parse(db.ExecuteScalar(dbcmd).ToString());
        }

        public void DeleteWarehouse(Guid iD)
        {
            dbcmd = db.GetStoredProcCommand("SP_DeleteWarehouse");
            db.AddInParameter(dbcmd, "@WarehouseID", DbType.Guid, iD);
            db.ExecuteNonQuery(dbcmd);
        }

        public bool checkIfUsedWarehouse(Guid iD)
        {
            bool b = new bool();
            dbcmd = db.GetStoredProcCommand("SP_CheckUsedWarehouse");
            db.AddInParameter(dbcmd, "@WarehouseID", DbType.Guid, iD);
            return b = bool.Parse(db.ExecuteScalar(dbcmd).ToString());
        }


        public bool checkIfExistMaster(Guid iD, string desc, string action)
        {
            bool b = new bool();
            dbcmd = db.GetStoredProcCommand("SP_CheckExistMasterfile");
            db.AddInParameter(dbcmd, "@MasterID", DbType.Guid, iD);
            db.AddInParameter(dbcmd, "@Desc", DbType.String, desc);
            db.AddInParameter(dbcmd, "@Action", DbType.String, action);
            return b = bool.Parse(db.ExecuteScalar(dbcmd).ToString());
        }
        public DataTable stockin(Guid vars, Guid wareID)
        {
            DataTable dt = new DataTable();
            dbcmd = db.GetStoredProcCommand("stockin");
            db.AddInParameter(dbcmd, "@warehouse", DbType.Guid, vars);
            db.AddInParameter(dbcmd, "@wareID", DbType.Guid, wareID);
            dt.Load(db.ExecuteReader(dbcmd));
            return dt;
        }

        public DataTable SelectAllReceive()
        {
            DataTable dt = new DataTable();
            dbcmd = db.GetStoredProcCommand("SelectAllReceive");
            dt.Load(db.ExecuteReader(dbcmd));
            return dt;
        }
        public DataTable SelectDataFromStockID(Guid stock)
        {
            DataTable dt = new DataTable();
            dbcmd = db.GetStoredProcCommand("SelectAllReceiveByID");
            db.AddInParameter(dbcmd, "@stock", DbType.Guid, stock);
            dt.Load(db.ExecuteReader(dbcmd));
            return dt; 
        }
        public DataTable SelectDataFromStockdtlID(Guid stock)
        {
            DataTable dt = new DataTable();
            dbcmd = db.GetStoredProcCommand("SelectAllReceiveDtlByID");
            db.AddInParameter(dbcmd, "@stockdtl", DbType.Guid, stock);
            dt.Load(db.ExecuteReader(dbcmd));
            return dt;
        }
        public DataTable SelectAllRelease()
        {
            DataTable dt = new DataTable();
            dbcmd = db.GetStoredProcCommand("SelectAllRelease");
            dt.Load(db.ExecuteReader(dbcmd));
            return dt;
        }
        
        public DataTable SelectDataFromStockOutID(Guid stockout)
        {
            DataTable dt = new DataTable();
            dbcmd = db.GetStoredProcCommand("SelectAllReleaseByID");
            db.AddInParameter(dbcmd, "@stockout", DbType.Guid, stockout);
            dt.Load(db.ExecuteReader(dbcmd));
            return dt;
        }
        public DataTable SelectDataFromStockOutdtlID(Guid stockout)
        {
            DataTable dt = new DataTable();
            dbcmd = db.GetStoredProcCommand("SelectAllReleaseDtlByID");
            db.AddInParameter(dbcmd, "@stockoutdtl", DbType.Guid, stockout);
            dt.Load(db.ExecuteReader(dbcmd));
            return dt;
        }
    }
}

