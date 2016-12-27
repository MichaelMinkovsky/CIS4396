using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Utilities;

namespace RealEstateLibrary
{
    public class dbLogic
    {
        DBConnect objDb = new DBConnect();
        SqlCommand objCommand = new SqlCommand();

        
        public DataSet getMatchingHomes(int ID)
        {
            objCommand.Parameters.Clear();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "findMatchingHomeProcedure";

            SqlParameter newSqlParameter = new SqlParameter("@Id", ID);
            newSqlParameter.Direction = ParameterDirection.Input;
            newSqlParameter.SqlDbType = SqlDbType.Int;
            objCommand.Parameters.Add(newSqlParameter);
            DataSet myDataSet = objDb.GetDataSetUsingCmdObj(objCommand);

            return myDataSet;
        }
    }
}

