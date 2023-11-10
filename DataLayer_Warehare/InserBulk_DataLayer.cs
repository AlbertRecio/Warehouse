using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse_DataLayer
{
    public class InserBulk_DataLayer : DataAccess
    {
        public DataTable InserBulk(DataTable dt, string yourPRoc, string d)
        {
            DataTable dts = new DataTable();
            SqlConnection sqlConnection = new SqlConnection(con);
            sqlConnection.Close();
            sqlConnection.Open();
            try
            {
                //        dt.Columns["CheckDate"].SetOrdinal(dt.Columns.Count - 2);
                // dt.Columns.Remove("MemberID");

            }
            catch (Exception) { }   
            // to sql (BULK)
            SqlCommand command = sqlConnection.CreateCommand();
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.CommandText = yourPRoc;
            SqlParameter parameter = new SqlParameter();
            parameter.ParameterName = d;
            parameter.SqlDbType = System.Data.SqlDbType.Structured;
            parameter.Value = dt;
            command.Parameters.Add(parameter);
            dts.Load(command.ExecuteReader());
            return dts;
        }
        public DataTable InserBulkWithParam(DataTable dt,Guid id, string yourPRoc, string d, string i)
        {
            DataTable dts = new DataTable();
            SqlConnection sqlConnection = new SqlConnection(con);
            sqlConnection.Close();
            sqlConnection.Open();
            try
            {
                //        dt.Columns["CheckDate"].SetOrdinal(dt.Columns.Count - 2);
                // dt.Columns.Remove("MemberID");

            }
            catch (Exception) { }
            // to sql (BULK)
            SqlCommand command = sqlConnection.CreateCommand();
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.CommandText = yourPRoc;

            SqlParameter parameter = new SqlParameter();
            parameter.ParameterName = d;
            parameter.SqlDbType = System.Data.SqlDbType.Structured;
            parameter.Value = dt;

           

            command.Parameters.Add(parameter);
            command.Parameters.Add(i, SqlDbType.UniqueIdentifier).Value = id;
            dts.Load(command.ExecuteReader());
            return dts;

        }
    }
}
