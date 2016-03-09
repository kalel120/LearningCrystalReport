using System;
using System.Data;
using System.Web.UI;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using Dataedge.Report.LearningCrystalReport.DataAcess;
using Dataedge.Report.LearningCrystalReport.Reports;

namespace Dataedge.Report.LearningCrystalReport {
    public partial class Default : Page {
        public ReportGateway ObjReportGateway { get; set; }

        protected void Page_Load(object sender, EventArgs e) {}

        protected void btnGenerateReport_Click(object sender, EventArgs e) {
            ReportDocument rptDocument = new ReportDocument();
            dsSample objDs = new dsSample();
            SimpleReports rpt = new SimpleReports();
            DataTable dataTable = ObjReportGateway.GetAllOrders();
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
