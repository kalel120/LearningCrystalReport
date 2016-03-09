using System;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;

namespace Dataedge.Report.LearningCrystalReport.DataAcess {
    public class ReportGateway {
        public DataTable GetAllOrders() {
            string connectionString = WebConfigurationManager.ConnectionStrings["DBCON"].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand objCommand = new SqlCommand();

            DataSet objDataSet;
            try {
                connection.Open();
                objCommand.CommandText = "spGetAllOrders";
                objCommand.CommandType = CommandType.StoredProcedure;
                objCommand.Connection = connection;

                objDataSet = new DataSet();
                var objDataAdapter = new SqlDataAdapter(objCommand);
                objDataAdapter.Fill(objDataSet, "Users");
            }
            catch (Exception ex) {
                throw new Exception(ex.Message);
            }
            finally {
                objCommand.Dispose();
                if (connection.State != ConnectionState.Closed) {
                    connection.Close();
                }
            }
            return objDataSet.Tables[0];
        }
    }
}