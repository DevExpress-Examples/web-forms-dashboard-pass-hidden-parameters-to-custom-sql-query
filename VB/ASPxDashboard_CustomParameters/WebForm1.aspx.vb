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
            AddHandler ASPxDashboard1.CustomParameters, AddressOf Me.ASPxDashboard1_CustomParameters
        End Sub

        Protected Sub ASPxDashboard1_CustomParameters(ByVal sender As Object, ByVal e As CustomParametersWebEventArgs)
            Dim countryParam = e.Parameters.FirstOrDefault(Function(p) Equals(p.Name, "CountryDashboardParameter"))
            If countryParam IsNot Nothing Then
                countryParam.Value = "Brazil"
            End If
        End Sub
    End Class
End Namespace
