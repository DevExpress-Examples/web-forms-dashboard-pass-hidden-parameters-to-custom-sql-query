Imports DevExpress.DashboardWeb
Imports DevExpress.DataAccess.Web
Imports System
Imports System.Linq

Namespace ASPxDashboard_CustomParameters

    Public Partial Class WebForm1
        Inherits Web.UI.Page

        Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
            Dim dashboardFileStorage As DashboardFileStorage = New DashboardFileStorage("~/App_Data/Dashboards")
            ASPxDashboard1.SetConnectionStringsProvider(New ConfigFileConnectionStringsProvider())
            ASPxDashboard1.SetDashboardStorage(dashboardFileStorage)
        End Sub

        Protected Sub ASPxDashboard1_CustomParameters(ByVal sender As Object, ByVal e As CustomParametersWebEventArgs)
            Dim custIDParameter = e.Parameters.FirstOrDefault(Function(p) Equals(p.Name, "CustomerIdDashboardParameter"))
            If custIDParameter IsNot Nothing Then
                custIDParameter.Value = "ALFKI"
            End If
        End Sub
    End Class
End Namespace
