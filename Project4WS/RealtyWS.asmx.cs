using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data.SqlClient;
using System.Data;
using RealEstateLibrary;
using Utilities;

namespace Project4WS
{
    /// <summary>
    /// Summary description for RealtyWS
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class RealtyWS : System.Web.Services.WebService
    {
        dbLogic newdbLogic = new dbLogic();
        DBConnect objDb = new DBConnect();
        SqlCommand objCommand = new SqlCommand();


        [WebMethod]
        public DataSet findMatchingHomes(int ID)
        {
            DataSet matchingHomes;
            return matchingHomes = newdbLogic.getMatchingHomes(ID) ;
        }

        

        [WebMethod]
        public void updateHome(string address, string city, string state, float listingPrice, int squareFootage, string availability, int numBedrooms, int numBathrooms, string homeType, int Id)
        {
            objCommand.Parameters.Clear();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "updateHomeProcedure"; 

            SqlParameter mySqlParameter = new SqlParameter("@Address", address);
            mySqlParameter.Direction = ParameterDirection.Input;
            mySqlParameter.SqlDbType = SqlDbType.VarChar;
            objCommand.Parameters.Add(mySqlParameter);
            

            mySqlParameter = new SqlParameter("@City", city);
            mySqlParameter.Direction = ParameterDirection.Input;
            mySqlParameter.SqlDbType = SqlDbType.VarChar;
            objCommand.Parameters.Add(mySqlParameter);

            mySqlParameter = new SqlParameter("@State", state);
            mySqlParameter.Direction = ParameterDirection.Input;
            mySqlParameter.SqlDbType = SqlDbType.VarChar;
            objCommand.Parameters.Add(mySqlParameter);

            mySqlParameter = new SqlParameter("@ListingPrice", listingPrice);
            mySqlParameter.Direction = ParameterDirection.Input;
            mySqlParameter.SqlDbType = SqlDbType.Float;
            objCommand.Parameters.Add(mySqlParameter);

            mySqlParameter = new SqlParameter("@SquareFootage", squareFootage);
            mySqlParameter.Direction = ParameterDirection.Input;
            mySqlParameter.SqlDbType = SqlDbType.Int;
            objCommand.Parameters.Add(mySqlParameter);

            mySqlParameter = new SqlParameter("@Availability", availability);
            mySqlParameter.Direction = ParameterDirection.Input;
            mySqlParameter.SqlDbType = SqlDbType.VarChar;
            objCommand.Parameters.Add(mySqlParameter);

            mySqlParameter = new SqlParameter("@numBedrooms", numBedrooms);
            mySqlParameter.Direction = ParameterDirection.Input;
            mySqlParameter.SqlDbType = SqlDbType.Int;
            objCommand.Parameters.Add(mySqlParameter);

            mySqlParameter = new SqlParameter("@numBathrooms", numBathrooms);
            mySqlParameter.Direction = ParameterDirection.Input;
            mySqlParameter.SqlDbType = SqlDbType.Int;
            objCommand.Parameters.Add(mySqlParameter);

            mySqlParameter = new SqlParameter("@Type", homeType);
            mySqlParameter.Direction = ParameterDirection.Input;
            mySqlParameter.SqlDbType = SqlDbType.VarChar;
            objCommand.Parameters.Add(mySqlParameter); 
              
            mySqlParameter = new SqlParameter("@Id", Id);
            mySqlParameter.Direction = ParameterDirection.Input;
            mySqlParameter.SqlDbType = SqlDbType.Int;
            objCommand.Parameters.Add(mySqlParameter);
               
             
              
            DataSet myDS = objDb.GetDataSetUsingCmdObj(objCommand);
                 
        }

        [WebMethod]
        public void addHome(string address, string city, string state, float listingPrice, int squareFootage, string availability, int numBedrooms, int numBathrooms, string homeType, int Id)
        {
            objCommand.Parameters.Clear();

            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "updateHomeProcedure";

            SqlParameter mySqlParameter = new SqlParameter("@Address", address);
            mySqlParameter.Direction = ParameterDirection.Input;
            mySqlParameter.SqlDbType = SqlDbType.VarChar;
            objCommand.Parameters.Add(mySqlParameter);

            mySqlParameter = new SqlParameter("@City", city);
            mySqlParameter.Direction = ParameterDirection.Input;
            mySqlParameter.SqlDbType = SqlDbType.VarChar;
            objCommand.Parameters.Add(mySqlParameter);

            mySqlParameter = new SqlParameter("@State", state);
            mySqlParameter.Direction = ParameterDirection.Input;
            mySqlParameter.SqlDbType = SqlDbType.VarChar;
            objCommand.Parameters.Add(mySqlParameter);

            mySqlParameter = new SqlParameter("@ListingPrice", listingPrice);
            mySqlParameter.Direction = ParameterDirection.Input;
            mySqlParameter.SqlDbType = SqlDbType.Float;
            objCommand.Parameters.Add(mySqlParameter);

            mySqlParameter = new SqlParameter("@SquareFootage", squareFootage);
            mySqlParameter.Direction = ParameterDirection.Input;
            mySqlParameter.SqlDbType = SqlDbType.Int;
            objCommand.Parameters.Add(mySqlParameter);

            mySqlParameter = new SqlParameter("@Availability", availability);
            mySqlParameter.Direction = ParameterDirection.Input;
            mySqlParameter.SqlDbType = SqlDbType.VarChar;
            objCommand.Parameters.Add(mySqlParameter);

            mySqlParameter = new SqlParameter("@numBedrooms", numBedrooms);
            mySqlParameter.Direction = ParameterDirection.Input;
            mySqlParameter.SqlDbType = SqlDbType.Int;
            objCommand.Parameters.Add(mySqlParameter);

            mySqlParameter = new SqlParameter("@numBathrooms", numBathrooms);
            mySqlParameter.Direction = ParameterDirection.Input;
            mySqlParameter.SqlDbType = SqlDbType.Int;
            objCommand.Parameters.Add(mySqlParameter);

            mySqlParameter = new SqlParameter("@Type", homeType);
            mySqlParameter.Direction = ParameterDirection.Input;
            mySqlParameter.SqlDbType = SqlDbType.VarChar;
            objCommand.Parameters.Add(mySqlParameter);

            mySqlParameter = new SqlParameter("@Id", Id);
            mySqlParameter.Direction = ParameterDirection.Input;
            mySqlParameter.SqlDbType = SqlDbType.Int;
            objCommand.Parameters.Add(mySqlParameter);



            DataSet myDS = objDb.GetDataSetUsingCmdObj(objCommand);

        }


        [WebMethod]
        public void deleteHome(int Id)
        {
            objCommand.Parameters.Clear();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "deleteHomeProcedure"; 

            SqlParameter mySqlParameter = new SqlParameter("@Id", Id);
            mySqlParameter.Direction = ParameterDirection.Input;
            mySqlParameter.SqlDbType = SqlDbType.Int;
            objCommand.Parameters.Add(mySqlParameter);

            DataSet myDS = objDb.GetDataSetUsingCmdObj(objCommand);
        }

        [WebMethod]
        public DataSet findHomeByCityStateBudget(string city, string state, float budget, int realtorID)
        {
            objCommand.Parameters.Clear();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "findHomeProcedure1";

            SqlParameter mySqlParameter = new SqlParameter("@City", city);
            mySqlParameter.Direction = ParameterDirection.Input;
            mySqlParameter.SqlDbType = SqlDbType.VarChar;
            objCommand.Parameters.Add(mySqlParameter);

            mySqlParameter = new SqlParameter("@State", state);
            mySqlParameter.Direction = ParameterDirection.Input;
            mySqlParameter.SqlDbType = SqlDbType.VarChar;
            objCommand.Parameters.Add(mySqlParameter);

            mySqlParameter = new SqlParameter("@ListingPrice", budget);
            mySqlParameter.Direction = ParameterDirection.Input;
            mySqlParameter.SqlDbType = SqlDbType.Float;
            objCommand.Parameters.Add(mySqlParameter);

            mySqlParameter = new SqlParameter("@RealtorID", realtorID);
            mySqlParameter.Direction = ParameterDirection.Input;
            mySqlParameter.SqlDbType = SqlDbType.Int;
            objCommand.Parameters.Add(mySqlParameter);

            DataSet myDS = objDb.GetDataSetUsingCmdObj(objCommand);

            return myDS;
        }

        [WebMethod]
        public DataSet findHomeByBudgetSizeType(float budget, int size, string homeType, int realtorID)
        {
            objCommand.Parameters.Clear();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "findHomeProcedure2";

            SqlParameter mySqlParameter = new SqlParameter("@ListingPrice", budget);
            mySqlParameter.Direction = ParameterDirection.Input;
            mySqlParameter.SqlDbType = SqlDbType.Float;
            objCommand.Parameters.Add(mySqlParameter);

            mySqlParameter = new SqlParameter("@SquareFootage", size);
            mySqlParameter.Direction = ParameterDirection.Input;
            mySqlParameter.SqlDbType = SqlDbType.Int;
            objCommand.Parameters.Add(mySqlParameter);

            mySqlParameter = new SqlParameter("@Type", homeType);
            mySqlParameter.Direction = ParameterDirection.Input;
            mySqlParameter.SqlDbType = SqlDbType.VarChar;
            objCommand.Parameters.Add(mySqlParameter);

            mySqlParameter = new SqlParameter("@RealtorID", realtorID);
            mySqlParameter.Direction = ParameterDirection.Input;
            mySqlParameter.SqlDbType = SqlDbType.Int;
            objCommand.Parameters.Add(mySqlParameter);

            DataSet myDS = objDb.GetDataSetUsingCmdObj(objCommand);

            return myDS;
        }

        [WebMethod]
        public void addRequest(string requestPersonName, DateTime date, DateTime time, int houseID, int realtorID)
        {
            objCommand.Parameters.Clear();

            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "insertRequestsProcedure";

            SqlParameter mySqlParameter = new SqlParameter("@RequestPersonName", requestPersonName);
            mySqlParameter.Direction = ParameterDirection.Input;
            mySqlParameter.SqlDbType = SqlDbType.VarChar;
            objCommand.Parameters.Add(mySqlParameter);

            mySqlParameter = new SqlParameter("@Date", date);
            mySqlParameter.Direction = ParameterDirection.Input;
            mySqlParameter.SqlDbType = SqlDbType.Date;
            objCommand.Parameters.Add(mySqlParameter);

            TimeSpan newTime = time.TimeOfDay;
            mySqlParameter = new SqlParameter("@Time", newTime);
            mySqlParameter.Direction = ParameterDirection.Input;
            mySqlParameter.SqlDbType = SqlDbType.Time;
            objCommand.Parameters.Add(mySqlParameter);

            mySqlParameter = new SqlParameter("@HouseID", houseID);
            mySqlParameter.Direction = ParameterDirection.Input;
            mySqlParameter.SqlDbType = SqlDbType.Int;
            objCommand.Parameters.Add(mySqlParameter);

            mySqlParameter = new SqlParameter("@RealtorID", realtorID);
            mySqlParameter.Direction = ParameterDirection.Input;
            mySqlParameter.SqlDbType = SqlDbType.Int;
            objCommand.Parameters.Add(mySqlParameter);

            DataSet myDS = objDb.GetDataSetUsingCmdObj(objCommand);

        }

        [WebMethod]
        public DataSet displayAppointments(int Id)
        {
            objCommand.Parameters.Clear();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "displayAppointmentsProcedure";

            SqlParameter mySqlParameter = new SqlParameter("@RealtorID", Id);
            mySqlParameter.Direction = ParameterDirection.Input;
            mySqlParameter.SqlDbType = SqlDbType.Int;
            objCommand.Parameters.Add(mySqlParameter);

            DataSet myDS = objDb.GetDataSetUsingCmdObj(objCommand);

            return myDS;
        }

    }
}
