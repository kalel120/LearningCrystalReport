using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;

namespace Dataedge.Report.LearningCrystalReport.DataAcess {
    public class ReportGateway {
        public DataTable GetAllOrders() {
            string connectionString = WebConfigurationManager.ConnectionStrings["DBCON"].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand objCommand = new SqlCommand();

            connection.Open();
            objCommand.CommandText = "spGetAllOrders";
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.Connection = connection;

            var objDataSet = new DataSet();
            var objDataAdapter = new SqlDataAdapter(objCommand);
            objDataAdapter.Fill(objDataSet, "Users");
            connection.Close();
            return objDataSet.Tables[0];
        }
    }
}