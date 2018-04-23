using System.ComponentModel.Composition;
using DevExpress.XtraReports.Service.Extensions;

namespace DXReportService_ReportProvider.Web {
    [Export(typeof(IReportResolver))]
    public class ReportResolver : IReportResolver {
        public DevExpress.XtraReports.UI.XtraReport Resolve(string reportName, bool getParameters) {
            if(reportName == "MyReport") {
                return new XtraReport1();
            }
            return null;
        }
    }
}