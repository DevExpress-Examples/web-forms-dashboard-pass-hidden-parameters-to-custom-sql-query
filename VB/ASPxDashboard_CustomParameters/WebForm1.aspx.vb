Imports DevExpress.DashboardWeb
Imports System
Imports System.Linq

Namespace ASPxDashboard_CustomParameters

    Public Partial Class WebForm1
        Inherits Web.UI.Page

        Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
            ASPxDashboard1.DashboardXmlPath = Server.MapPath("App_Data/dashboard1.xml")
        End Sub

        Protected Sub ASPxDashboard1_CustomParameters(ByVal sender As Object, ByVal e As CustomParametersWebEventArgs)
            Dim custIDParameter = e.Parameters.FirstOrDefault(Function(p) Equals(p.Name, "custIDDashboardParameter"))
            If custIDParameter IsNot Nothing Then
                custIDParameter.Value = "AROUT"
            End If
        End Sub
    End Class
End Namespace
