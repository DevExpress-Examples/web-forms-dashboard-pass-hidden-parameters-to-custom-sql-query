Imports DevExpress.DashboardCommon
Imports DevExpress.DashboardWeb
Imports System
Imports System.Linq

Namespace ASPxDashboard_CustomParameters
    Partial Public Class WebForm1
        Inherits System.Web.UI.Page

        Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
            ASPxDashboard1.DashboardXmlPath = Server.MapPath("App_Data/dashboard1.xml")
        End Sub
        Protected Sub ASPxDashboard1_SetInitialDashboardState(ByVal sender As Object, ByVal e As SetInitialDashboardStateEventArgs)
            e.InitialState = InitializeDashboardState()
        End Sub

        Public Function InitializeDashboardState() As DashboardState
            Dim dashboardState As New DashboardState()
            Dim parameterState As New DashboardParameterState("CustomerIdDashboardParameter", "XXX", GetType(String))
            dashboardState.Parameters.Add(parameterState)
            Return dashboardState
        End Function

        Protected Sub ASPxDashboard1_CustomParameters(ByVal sender As Object, ByVal e As CustomParametersWebEventArgs)
            Dim custIDParameter = e.Parameters.FirstOrDefault(Function(p) p.Name = "CustomerIdDashboardParameter")
            If custIDParameter IsNot Nothing Then
                custIDParameter.Value = "AROUT"
            End If
        End Sub
    End Class
End Namespace