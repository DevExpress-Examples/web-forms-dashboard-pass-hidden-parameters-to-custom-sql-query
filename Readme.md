<!-- default file list -->
*Files to look at*:

* [WebForm1.aspx](./CS/ASPxDashboard_CustomParameters/WebForm1.aspx) (VB: [WebForm1.aspx](./VB/ASPxDashboard_CustomParameters/WebForm1.aspx))
* [WebForm1.aspx.cs](./CS/ASPxDashboard_CustomParameters/WebForm1.aspx.cs) (VB: [WebForm1.aspx.vb](./VB/ASPxDashboard_CustomParameters/WebForm1.aspx.vb))
<!-- default file list end -->
# ASPxDashboard - How to pass a hidden dashboard parameter to a custom SQL query
<!-- run online -->
**[[Run Online]](https://codecentral.devexpress.com/t491903/)**
<!-- run online end -->


The following example shows how to override an initial or user-defined <a href="https://docs.devexpress.com/Dashboard/117571/building-the-designer-and-viewer-applications/web-dashboard/asp.net-dashboard-control/manage-dashboard-parameters">dashboard parameter</a> value by changing it in the <a href="https://docs.devexpress.com/Dashboard/DevExpress.DashboardWeb.ASPxDashboard.CustomParameters">ASPxDashboard.CustomParameters</a> event handler. 

The effective parameter value is hidden from the end-user, and if you set the <a href="https://docs.devexpress.com/Dashboard/DevExpress.DashboardCommon.DashboardParameter.Visible">DashboardParameter.Visible</a> property to false, the parameter itself will also be hidden.

The dashboard in this example has a parameter named <strong>CustomerIdDashboardParameter</strong> which has a certain initial value. At runtime, its value is changed in the <a href="https://docs.devexpress.com/Dashboard/DevExpress.DashboardWeb.ASPxDashboard.SetInitialDashboardState">ASPxDashboard.SetInitialDashboardState</a> event handler. This value is displayed in the <a href="https://docs.devexpress.com/Dashboard/117571/building-the-designer-and-viewer-applications/web-dashboard/asp.net-dashboard-control/manage-dashboard-parameters">Dashboard Parameters dialog</a> and can be changed by the end-user.

However, by handling the <a href="https://docs.devexpress.com/Dashboard/DevExpress.DashboardWeb.ASPxDashboard.CustomParameters">ASPxDashboard.CustomParameters</a> event, we can validate the parameter value, ignore the value provided by the end-user and substitute it with another value.

We run a <a href="https://docs.devexpress.com/Dashboard/117193/creating-dashboards/creating-dashboards-on-the-web/providing-data/working-with-sql-data-sources/custom-sql-queries">custom SQL query</a> with a parameter named **CustomerIdParameter**. The query parameter is bound to the **CustomerIdDashboardParameter** dashboard parameter. We handle the <a href="https://docs.devexpress.com/Dashboard/DevExpress.DashboardWeb.ASPxDashboard.CustomParameters">ASPxDashboard.CustomParameters</a> event to change the parameter after it is set in the dashboard but before it is passed to a query.
