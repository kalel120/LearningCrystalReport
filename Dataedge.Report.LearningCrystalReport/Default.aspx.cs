using System;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;
using System.Web.UI;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using Dataedge.Report.LearningCrystalReport.Reports;

namespace Dataedge.Report.LearningCrystalReport
{
    public partial class Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //This method is for database code
        private static DataTable GetAllOrders()
        {
            string connectionString = WebConfigurationManager.ConnectionStrings["DBCON"].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand objCommand = new SqlCommand();

            DataSet objDataSet;
            try
            {
                connection.Open();
                objCommand.CommandText = "spGetAllOrders";
                objCommand.CommandType = CommandType.StoredProcedure;
                objCommand.Connection = connection;

                objDataSet = new DataSet();
                var objDataAdapter = new SqlDataAdapter(objCommand);
                objDataAdapter.Fill(objDataSet, "Users");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                objCommand.Dispose();
                if (connection.State != ConnectionState.Closed)
                {
                    connection.Close();
                }
            }
            return objDataSet.Tables[0];
        }

        protected void btnGenerateReport_Click(object sender, EventArgs e)
        {
            ReportDocument rptDocument = new ReportDocument();
            dsSample objDs = new dsSample();
            SimpleReports rpt = new SimpleReports();
            DataTable dataTable = GetAllOrders();
            objDs.Tables[0].Merge(dataTable);

            rptDocument.Load(Server.MapPath("~/Reports/SimpleReports.rpt"));
            rpt.SetDataSource(objDs);
            CrystalReportViewer1.ReportSource = rptDocument;
            CrystalReportViewer1.RefreshReport();

            //For PDF creation
            rpt.PrintOptions.PaperSize = PaperSize.PaperA4;
            rpt.PrintOptions.PaperSource = PaperSource.Auto;
            rpt.PrintOptions.PaperOrientation = PaperOrientation.Portrait;
            rpt.ExportToDisk(ExportFormatType.PortableDocFormat, Server.MapPath("~/Reports/samplePDF.pdf"));
            rpt.Dispose();
        }
    }
}
