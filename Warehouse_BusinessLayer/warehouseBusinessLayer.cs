using DataLayer_Warehare;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Warehouse_DataLayer;

namespace Warehouse_BusinessLayer
{
    public class warehouseBusinessLayer
    {
        public DataTable SelectDataFromWarehouseID(Guid ID)
        {
            return new warehouseDataLayer().SelectDataFromWarehouseID(ID);
        }
        public DataTable SelectDataFromMasterID(Guid ID)
        {
            return new warehouseDataLayer().SelectDataFromMasterID(ID);
        }

        public DataTable GetDateTime()
        {
            return new warehouseDataLayer().GetDateTime();
        }

        public DataTable RightsWarehouse(Guid ID)
        {
            return new warehouseDataLayer().RightsWarehouse(ID);
        }

        public DataTable searchAccount(string acc)
        {
            return new warehouseDataLayer().searchAccount(acc);
        }

        public DataTable ChangePassword(string pass, Guid ID)
        {
            return new warehouseDataLayer().ChangePassword(pass, ID);
        }

        public DataTable RightsCategory(Guid ID)
        {
            return new warehouseDataLayer().RightsCategory(ID);
        }

        public DataTable RightsStockIn(Guid iD)
        {
            return new warehouseDataLayer().RightsStockIn(iD);
        }

        public DataTable RightsMasterFile(Guid iD)
        {
            return new warehouseDataLayer().RightsMasterFile(iD);
        }

        public DataTable RightsStockOut(Guid iD)
        {
            return new warehouseDataLayer().RightsStockOut(iD);
        }

        public DataTable RightsStockAdjustment(Guid iD)
        {
            return new warehouseDataLayer().RightsStockAdjustment(iD);
        }

        public DataTable RightsStockTransfer(Guid iD)
        {
            return new warehouseDataLayer().RightsStockTransfer(iD);
        }

        public DataTable Warehousemasterfile(Guid ID, Guid Cat)
        {
            return new warehouseDataLayer().Warehousemasterfile(ID, Cat);
        }

        public DataTable GetDetails(string user, string pass)
        {
            return new warehouseDataLayer().GetDetails(user, pass);
        }

        public DataTable findModule()
        {
            return new warehouseDataLayer().findModule();
        }

        public DataTable findUser()
        {
            return new warehouseDataLayer().findUser();
        }

        public bool LogIn(string user, string pass)
        {
            return new warehouseDataLayer().LogIn(user, pass);
        }

        public bool CheckRights(string user, string pass)
        {
            return new warehouseDataLayer().CheckRights(user, pass);
        }

        public DataTable findStockTransfer()
        {
            return new warehouseDataLayer().findStockTransfer();
        }

        public DataTable findStockAdjustment()
        {
            return new warehouseDataLayer().findStockAdjustment();
        }

        public DataTable findStockOut()
        {
            return new warehouseDataLayer().findStockOut();
        }

        public DataTable findStockIn()
        {
            return new warehouseDataLayer().findStockIn();
        }

        public DataTable findMaster()
        {
            return new warehouseDataLayer().findMaster();
        }

        public DataTable SelectAll()
        {
            return new warehouseDataLayer().SelectAll();
        }
        public DataTable findWarehouse()
        {
            return new warehouseDataLayer().findWarehouse();
        }
        public DataTable SelectAllMaster()
        {
            return new warehouseDataLayer().SelectAllMaster();
        }
        public DataTable SelectDataFromCat()
        {
            return new warehouseDataLayer().SelectDataFromCat();
        }
        public DataTable SelectDataFromWar()
        {
            return new warehouseDataLayer().SelectDataFromWar();
        }
        public DataTable findItem(Guid wareID)
        {
            return new warehouseDataLayer().findItem(wareID);
        }
        public DataTable stockin(Guid vars, Guid wareID)
        {
            return new warehouseDataLayer().stockin(vars, wareID);
        }
        public DataTable SelectAllReceive()
        {
            return new warehouseDataLayer().SelectAllReceive();
        }
        
        public DataTable SelectDataFromStockID(Guid stock)
        {
            return new warehouseDataLayer().SelectDataFromStockID(stock);
        }
        public DataTable ReceiveDtl(Guid stockdtl)
        {
            return new warehouseDataLayer().SelectDataFromStockdtlID(stockdtl);
        }

        public DataTable RightsView(Guid iD)
        {
            return new warehouseDataLayer().RightsView(iD);
        }

        public DataTable SelectAllModule()
        {
            return new warehouseDataLayer().SelectAllModule();
        }

        public DataTable SelectAllRelease()
        {
            return new warehouseDataLayer().SelectAllRelease();
        }
        public DataTable SelectDataFromStockOutID(Guid stockout)
        {
            return new warehouseDataLayer().SelectDataFromStockOutID(stockout);
        }
        public DataTable SelectDataFromStockOutdtlID(Guid stockoutdtl)
        {
            return new warehouseDataLayer().SelectDataFromStockOutdtlID(stockoutdtl);
        }

        public bool checkIfExistWarehouse(Guid iD, string text, string v)
        {
            return new warehouseDataLayer().checkIfExistWarehouse(iD, text, v);
        }

        public bool checkIfExistMaster(Guid iD, string text, string v)
        {
            return new warehouseDataLayer().checkIfExistMaster(iD, text, v);
        }

        public bool checkIfUsedWarehouse(Guid iD)
        {
            return new warehouseDataLayer().checkIfUsedWarehouse(iD);
        }

        public DataTable ShowUser(Guid guid)
        {
            return new warehouseDataLayer().ShowUser(guid);
        }

        public DataTable NewShowUser()
        {
            return new warehouseDataLayer().NewShowUser();
        }

        public bool checkIfExistModule(Guid iD, string text, string v)
        {
            return new warehouseDataLayer().checkIfExistModule(iD, text, v);
        }

        public void DeleteWarehouse(Guid iD)
        {
            new warehouseDataLayer().DeleteWarehouse(iD);
        }

        public bool checkIfUsedMasterfile(Guid iD)
        {
            return new warehouseDataLayer().checkIfUsedMasterfile(iD);
        }

        public void DeleteMasterfile(Guid iD)
        {
            new warehouseDataLayer().DeleteMasterfile(iD);
        }

        public DataTable stockOut(Guid vars, Guid wareID)
        {
            return new warehouseDataLayer().stockOut(vars, wareID);
        }

        public DataTable printStockOut()
        {
            return new warehouseDataLayer().printStockOut();
        }

        public DataTable SelectAllAdjustment()
        {
            return new warehouseDataLayer().SelectAllAdjustment();
        }

        public DataTable SelectDataFromStockAdjustmentID(Guid guid)
        {
            return new warehouseDataLayer().SelectDataFromStockAdjustmentID(guid);
        }

        public DataTable SelectDataFromModuleID(Guid guid)
        {
            return new warehouseDataLayer().SelectDataFromModuleID(guid);
        }

        public DataTable SelectDataFromAdjustmentDtlID(Guid guid)
        {
            return new warehouseDataLayer().SelectDataFromAdjustmentDtlID(guid);
        }

        public DataTable SelectAllStockTransfer()
        {
            return new warehouseDataLayer().SelectAllStockTransfer();
        }

        public bool checkIfExistUsername(Guid iD, string text, string v)
        {
            return new warehouseDataLayer().checkIfExistUsername(iD, text,v);
        }

        public DataTable SelectDataFromTransferdtlID(Guid guid)
        {
            return new warehouseDataLayer().SelectDataFromTransferdtlID(guid);
        }

        public DataTable SelectDataFromTransferID(Guid guid)
        {
            return new warehouseDataLayer().SelectDataFromTransferID(guid);
        }

        public DataTable RemoveSameWarehouse(Guid guid)
        {
            return new warehouseDataLayer().RemoveSameWarehouse(guid);
        }

        public DataTable printStockIn()
        {
            return new warehouseDataLayer().printStockIn();
        }

        public DataTable SelectAllUser()
        {
            return new warehouseDataLayer().SelectAllUser();
        }

        public DataTable printStockAdjustment()
        {
            return new warehouseDataLayer().printStockAdjustment();
        }

        public DataTable printStockTransfer()
        {
            return new warehouseDataLayer().printStockTransfer();
        }

        public DataTable printMasterfile()
        {
            return new warehouseDataLayer().printMasterfile();
        }

        public DataTable SelectDataFromUserID(Guid guid)
        {
            return new warehouseDataLayer().SelectDataFromUserID(guid);
        }

        public DataTable printCategory()
        {
            return new warehouseDataLayer().printCategory();
        }

        public DataTable printWarehouse()
        {
            return new warehouseDataLayer().printWarehouse();
        }

        public DataTable printUsers()
        {
            return new warehouseDataLayer().printUsers();
        }

        public async Task<DataTable> GetAllItemsByDATEforAPI(DateTime date1, DateTime date2)
        {
            return await new warehouseDataLayer().GetAllItemsByDATEforAPI(date1, date2);
        }
    }
}
