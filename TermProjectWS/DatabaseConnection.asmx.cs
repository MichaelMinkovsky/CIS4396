using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;
using System.Collections;
using System.Net;
using System.Xml;
using System.Data.SqlClient;
using Utilities;
using TPLibrary;

namespace TermProjectWS
{
    /// <summary>
    /// Summary description for DatabaseConnection
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class DatabaseConnection : System.Web.Services.WebService
    {
        static DBConnect objDb = new DBConnect();
        static SqlCommand objCommand = new SqlCommand();

        [WebMethod]
        public DataSet ReturnUsers()
        {
            objCommand.Parameters.Clear();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "TPReturnUsers"; 
            DataSet myDS = objDb.GetDataSetUsingCmdObj(objCommand);
            return myDS;
        }

        [WebMethod]
        public DataSet ReturnSecurityQuestion()
        {
            objCommand.Parameters.Clear();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "TPUserQuestions";
            DataSet myDS = objDb.GetDataSetUsingCmdObj(objCommand);
            return myDS;
        }

        [WebMethod]
        public DataSet ReturnStateNames()
        {
            objCommand.Parameters.Clear();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "GetStateProcedure1";
            DataSet myDS = objDb.GetDataSetUsingCmdObj(objCommand);
            return myDS;
        }

        [WebMethod]
        public void InsertToUserDataTable(string fName, string Lname, string state, string address, string city,
            string email, string user, string pass, string question1, string answer1,string question2,string answer2,string question3,string answer3)
        {
          string  FontColor = "Black";
          string  BgColor = "white";
          string  Font = "Courier";

            objCommand.Parameters.Clear();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "TPUserInsert";

            SqlParameter insertParametr = new SqlParameter("@FirstName", fName);
            insertParametr.Direction = ParameterDirection.Input;
            insertParametr.SqlDbType = SqlDbType.Char;
            objCommand.Parameters.Add(insertParametr);

            insertParametr = new SqlParameter("@LastName",Lname);
            insertParametr.Direction = ParameterDirection.Input;
            insertParametr.SqlDbType = SqlDbType.Char;
            objCommand.Parameters.Add(insertParametr);

            insertParametr = new SqlParameter("@Username", user);
            insertParametr.Direction = ParameterDirection.Input;
            insertParametr.SqlDbType = SqlDbType.Char;
            objCommand.Parameters.Add(insertParametr);

            insertParametr = new SqlParameter("@Password", pass);
            insertParametr.Direction = ParameterDirection.Input;
            insertParametr.SqlDbType = SqlDbType.Char;
            objCommand.Parameters.Add(insertParametr);

            insertParametr = new SqlParameter("@EmailAddress", email);
            insertParametr.Direction = ParameterDirection.Input;
            insertParametr.SqlDbType = SqlDbType.Char;
            objCommand.Parameters.Add(insertParametr);

            insertParametr = new SqlParameter("@Address", address);
            insertParametr.Direction = ParameterDirection.Input;
            insertParametr.SqlDbType = SqlDbType.Char;
            objCommand.Parameters.Add(insertParametr);

            insertParametr = new SqlParameter("@City", city);
            insertParametr.Direction = ParameterDirection.Input;
            insertParametr.SqlDbType = SqlDbType.Char;
            objCommand.Parameters.Add(insertParametr);

            insertParametr = new SqlParameter("@State", state);
            insertParametr.Direction = ParameterDirection.Input;
            insertParametr.SqlDbType = SqlDbType.Char;
            objCommand.Parameters.Add(insertParametr);

            insertParametr = new SqlParameter("@Question1", question1);
            insertParametr.Direction = ParameterDirection.Input;
            insertParametr.SqlDbType = SqlDbType.Char;
            objCommand.Parameters.Add(insertParametr);

            insertParametr = new SqlParameter("@Answer1", answer1);
            insertParametr.Direction = ParameterDirection.Input;
            insertParametr.SqlDbType = SqlDbType.Char;
            objCommand.Parameters.Add(insertParametr);

            insertParametr = new SqlParameter("@Question2", question2);
            insertParametr.Direction = ParameterDirection.Input;
            insertParametr.SqlDbType = SqlDbType.Char;
            objCommand.Parameters.Add(insertParametr);

            insertParametr = new SqlParameter("@Answer2", answer2);
            insertParametr.Direction = ParameterDirection.Input;
            insertParametr.SqlDbType = SqlDbType.Char;
            objCommand.Parameters.Add(insertParametr);

            insertParametr = new SqlParameter("@Question3", question3);
            insertParametr.Direction = ParameterDirection.Input;
            insertParametr.SqlDbType = SqlDbType.Char;
            objCommand.Parameters.Add(insertParametr);

            insertParametr = new SqlParameter("@Answer3", answer3);
            insertParametr.Direction = ParameterDirection.Input;
            insertParametr.SqlDbType = SqlDbType.Char;
            objCommand.Parameters.Add(insertParametr);

            insertParametr = new SqlParameter("@Font", Font);
            insertParametr.Direction = ParameterDirection.Input;
            insertParametr.SqlDbType = SqlDbType.Char;
            objCommand.Parameters.Add(insertParametr);

            insertParametr = new SqlParameter("@FontColor", FontColor);
            insertParametr.Direction = ParameterDirection.Input;
            insertParametr.SqlDbType = SqlDbType.Char;
            objCommand.Parameters.Add(insertParametr);

            insertParametr = new SqlParameter("@BgColor", BgColor);
            insertParametr.Direction = ParameterDirection.Input;
            insertParametr.SqlDbType = SqlDbType.Char;
            objCommand.Parameters.Add(insertParametr);

            insertParametr = new SqlParameter("@LoginSetting", "none");
            insertParametr.Direction = ParameterDirection.Input;
            insertParametr.SqlDbType = SqlDbType.Char;
            objCommand.Parameters.Add(insertParametr);

            objDb.DoUpdateUsingCmdObj(objCommand);
        }

        [WebMethod]
        public void InsertUserPreferences(string font, string FontColor, string background, string username)
        {
            objCommand.Parameters.Clear();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "TPUserUpdateFont";

            SqlParameter insertParametr = new SqlParameter("@Font", font);
            insertParametr.Direction = ParameterDirection.Input;
            insertParametr.SqlDbType = SqlDbType.Char;
            objCommand.Parameters.Add(insertParametr);

            insertParametr = new SqlParameter("@FontColor", FontColor);
            insertParametr.Direction = ParameterDirection.Input;
            insertParametr.SqlDbType = SqlDbType.Char;
            objCommand.Parameters.Add(insertParametr);

            insertParametr = new SqlParameter("@BgColor", background);
            insertParametr.Direction = ParameterDirection.Input;
            insertParametr.SqlDbType = SqlDbType.Char;
            objCommand.Parameters.Add(insertParametr);

            insertParametr = new SqlParameter("@Username", username);
            insertParametr.Direction = ParameterDirection.Input;
            insertParametr.SqlDbType = SqlDbType.Char;
            objCommand.Parameters.Add(insertParametr);

            objDb.DoUpdateUsingCmdObj(objCommand);

        }

    }
}
