using CrystalDecisions.CrystalReports.Engine;
using FerPROJ.FerCLASS;
using FerPROJ.FerFORMS;
using PointOfSaleDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSaleReports
{
    public class TReports
    {
        private Dictionary<TReportsList, Func<string, ReportDocument>> reportFunctions;
        public TReports()
        {
            reportFunctions = new Dictionary<TReportsList, Func<string, ReportDocument>>
            {
                { TReportsList.SalesReceipt, SalesReceiptReport },
            };
        }
        public enum TReportsList
        {
            SalesReceipt,
        }


        private ReportDocument SalesReceiptReport(string transNo)
        {
            var rpt = new crSalesReceipt();
            string sSelect = $"SELECT * FROM tblsales WHERE TransNo = '{transNo}'";
            string sSelectD = $"SELECT * FROM tblsalesdetails WHERE TransNo = '{transNo}'";

            rpt.Database.Tables[1].SetDataSource(new SalesDB().GetData(sSelect));
            rpt.Database.Tables[0].SetDataSource(new SalesDB().GetData(sSelectD));

            return rpt;

        }



        public void PreviewReport(TReportsList reportType, string transNo)
        {
            FrmCRSplasherMain.ShowSplash();
            ReportDocument report = GetReport(reportType, transNo); ;
            if (report != null)
            {
                CustomGenerateReport.GenerateReport(report);
            }
            FrmCRSplasherMain.CloseSplash();
        }

        private ReportDocument GetReport(TReportsList reportType, string transNo)
        {
            if (reportFunctions.TryGetValue(reportType, out Func<string, ReportDocument> reportFunction))
            {
                return reportFunction(transNo);
            }

            throw new ArgumentOutOfRangeException(nameof(reportType), "Unknown report type");
        }
    }
}
