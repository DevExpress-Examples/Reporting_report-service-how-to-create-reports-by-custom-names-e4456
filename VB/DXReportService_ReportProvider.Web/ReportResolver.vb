Imports Microsoft.VisualBasic
Imports System.ComponentModel.Composition
Imports DevExpress.XtraReports.Service.Extensions

Namespace DXReportService_ReportProvider.Web
	<Export(GetType(IReportResolver))> _
	Public Class ReportResolver
		Implements IReportResolver
        Public Function Resolve(ByVal reportName As String, ByVal getParameters As Boolean) As DevExpress.XtraReports.UI.XtraReport Implements IReportResolver.Resolve
            If reportName = "MyReport" Then
                Return New XtraReport1()
            End If
            Return Nothing
        End Function
	End Class
End Namespace