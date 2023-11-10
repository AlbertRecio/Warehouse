using DataLayer_Warehare;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse_BusinessLayer
{
    public class categoryBusinessLayer
    {
        public DataTable SelectAll()
        {
            return new categoryDataLayer().SelectAll();
        }
        public DataTable SelectDataFromCategoryID(Guid ID)
        {
            return new categoryDataLayer().SelectDataFromCategoryID(ID);
        }
        public DataTable findCategory()
        {
            return new categoryDataLayer().findCategory();
        }

        public bool checkIfExist(Guid iD, string desc,string action)
        {
            return new categoryDataLayer().checkIfExist(iD,desc, action);
        }

        public bool checkIfUsed(Guid iD)
        {
            return new categoryDataLayer().checkIfUsed(iD);
        }

        public void DeleteCategory(Guid iD)
        {
            new categoryDataLayer().DeleteCategory(iD);
        }

    
    }
}
