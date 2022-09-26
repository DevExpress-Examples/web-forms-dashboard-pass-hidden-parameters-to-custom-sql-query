using DevExpress.DashboardCommon;
using DevExpress.DashboardWeb;
using DevExpress.DataAccess.Web;
using System;
using System.Linq;

namespace ASPxDashboard_CustomParameters
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DashboardFileStorage dashboardFileStorage = new DashboardFileStorage("~/App_Data/Dashboards");
            ASPxDashboard1.SetConnectionStringsProvider(new ConfigFileConnectionStringsProvider());
            ASPxDashboard1.SetDashboardStorage(dashboardFileStorage);
        }


        protected void ASPxDashboard1_CustomParameters(object sender, CustomParametersWebEventArgs e)
        {
            var custIDParameter = e.Parameters.FirstOrDefault(p => p.Name == "CustomerIdDashboardParameter");
            if (custIDParameter != null)
            {
                custIDParameter.Value = "ALFKI";
            }
        }
    }
}