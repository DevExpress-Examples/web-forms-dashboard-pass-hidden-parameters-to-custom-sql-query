using DevExpress.DashboardCommon;
using DevExpress.DashboardWeb;
using System;
using System.Linq;

namespace ASPxDashboard_CustomParameters
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ASPxDashboard1.DashboardXmlPath = Server.MapPath("App_Data/dashboard1.xml");
        }
        protected void ASPxDashboard1_SetInitialDashboardState(object sender, SetInitialDashboardStateEventArgs e)
        {
            e.InitialState = InitializeDashboardState();
        }

        public DashboardState InitializeDashboardState()
        {
            DashboardState dashboardState = new DashboardState();
            DashboardParameterState parameterState =
                new DashboardParameterState("CustomerIdDashboardParameter", "XXX", typeof(string));
            dashboardState.Parameters.Add(parameterState);
            return dashboardState;
        }

        protected void ASPxDashboard1_CustomParameters(object sender, CustomParametersWebEventArgs e)
        {
            var custIDParameter = e.Parameters.FirstOrDefault(p => p.Name == "CustomerIdDashboardParameter");
            if (custIDParameter != null)
            {
                custIDParameter.Value = "AROUT";
            }
        }
    }
}