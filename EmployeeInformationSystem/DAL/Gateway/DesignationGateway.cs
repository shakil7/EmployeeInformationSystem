using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeInformationSystem.DAL.DAO;

namespace EmployeeInformationSystem.DAL.Gateway
{
    class DesignationGateway
    {
        private string connectionString = @"Server = USER-PC\SQLEXPRESS; Database = EmployeeDB; Integrated Security = True;";
        private SqlConnection aConnection;
        private SqlCommand aCommand;

        public DesignationGateway()
        {
            aConnection = new SqlConnection(connectionString);
        }

        public void Insert(Designation aDesignation)
        {
            string insertCommandString = "INSERT INTO tbl_designation VALUES('" + aDesignation.Code + "','" + aDesignation.Title + "')";
            aConnection.Open();
            aCommand = new SqlCommand(insertCommandString, aConnection);
            aCommand.ExecuteNonQuery();
            aConnection.Close();
        }

        public Designation Find(string code)
        {
            string selectQuery = "SELECT * FROM tbl_designation WHERE code = '" + code + "'";
            aConnection.Open();
            aCommand = new SqlCommand(selectQuery, aConnection);
            SqlDataReader aReader = aCommand.ExecuteReader();
            aReader.Read();
            Designation aDesignation = null;
            if (aReader.HasRows)
            {

                aDesignation = new Designation();
                aDesignation.Code = aReader["code"].ToString();
                aDesignation.Title = aReader["title"].ToString();
            }
            aReader.Close();
            aConnection.Close();
            return aDesignation;
        }
    }
}
