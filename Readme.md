<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128579884/16.2.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T491903)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [WebForm1.aspx](./CS/ASPxDashboard_CustomParameters/WebForm1.aspx) (VB: [WebForm1.aspx](./VB/ASPxDashboard_CustomParameters/WebForm1.aspx))
* [WebForm1.aspx.cs](./CS/ASPxDashboard_CustomParameters/WebForm1.aspx.cs) (VB: [WebForm1.aspx.vb](./VB/ASPxDashboard_CustomParameters/WebForm1.aspx.vb))
<!-- default file list end -->
# ASPxDashboard - How to pass a hidden dashboard parameter to a custom SQL query


<p>The following example shows how to override an initial or user-defined <a href="https://docs.devexpress.com/Dashboard/117571/building-the-designer-and-viewer-applications/web-dashboard/asp.net-dashboard-control/manage-dashboard-parameters">dashboard parameter</a> value by changing it in the <a href="https://docs.devexpress.com/Dashboard/DevExpress.DashboardWeb.ASPxDashboard.CustomParameters">ASPxDashboard.CustomParameters</a> event handler. The effective parameter value is hidden from the end-user, and if you set the <a href="https://docs.devexpress.com/Dashboard/DevExpress.DashboardCommon.DashboardParameter.Visible">DashboardParameter.Visible</a> property to false, the parameter itself will also be hidden.<br>The dashboard in this example has a parameter named <strong>CustomerIdDashboardParameter</strong> which has a certain initial value. At runtime, its value is changed in the <a href="https://docs.devexpress.com/Dashboard/DevExpress.DashboardWeb.ASPxDashboard.SetInitialDashboardState">ASPxDashboard.SetInitialDashboardState</a> event handler. This value is displayed in the <a href="https://docs.devexpress.com/Dashboard/117571/building-the-designer-and-viewer-applications/web-dashboard/asp.net-dashboard-control/manage-dashboard-parameters">Dashboard Parameters dialog</a> and can be changed by the end-user.<br>However, by handling the <a href="https://docs.devexpress.com/Dashboard/DevExpress.DashboardWeb.ASPxDashboard.CustomParameters">ASPxDashboard.CustomParameters</a> event, we can validate the parameter value and ignore the value provided by the end-user.To accomplish this, the data is obtained using a <a href="https://docs.devexpress.com/Dashboard/117193/creating-dashboards/creating-dashboards-on-the-web/providing-data/working-with-sql-data-sources/custom-sql-queries">custom SQL query</a> with a parameter named <strong>CustomerIdParameter. </strong>The query parameter is bound to the <strong>CustomerIdDashboardParameter</strong> dashboard parameter. The value of this parameter is changed at runtime by handling the <a href="https://docs.devexpress.com/Dashboard/DevExpress.DashboardWeb.ASPxDashboard.CustomParameters">ASPxDashboard.CustomParameters</a> event which is raised before the ASPxDashboard sends a query to a database. Thus, only the value passed in the <a href="https://docs.devexpress.com/Dashboard/DevExpress.DashboardWeb.ASPxDashboard.CustomParameters">ASPxDashboard.CustomParameters</a> event is in effect. <br><br></p>

<br/>


