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

        protected void ASPxDashboard1_CustomParameters(object sender, CustomParametersWebEventArgs e)
        {
            var custIDParameter = e.Parameters.FirstOrDefault(p => p.Name == "custIDDashboardParameter");
            if (custIDParameter != null)
            {
                custIDParameter.Value = "AROUT";
            }
        }
    }
}