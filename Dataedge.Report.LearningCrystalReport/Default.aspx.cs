using System;
using System.Data;
using System.Web.UI;
using Dataedge.Report.LearningCrystalReport.DataAcess;
using Dataedge.Report.LearningCrystalReport.Reports;

namespace Dataedge.Report.LearningCrystalReport {
    public partial class Default : Page {
        private ReportGateway _reportGateway = new ReportGateway();

        protected void Page_Load(object sender, EventArgs e) {
            dsSample objDs = new dsSample();
            SimpleReports rpt = new SimpleReports();
            DataTable dataTable = _reportGateway.GetAllOrders();
            objDs.Tables[0].Merge(dataTable);

            rpt.Load(Server.MapPath("~/Reports/SimpleReports.rpt"));
            rpt.SetDataSource(objDs);
            CrystalReportViewer1.ReportSource = rpt;
            CrystalReportViewer1.DisplayGroupTree = false;
            CrystalReportViewer1.RefreshReport();
        }
    }
}
