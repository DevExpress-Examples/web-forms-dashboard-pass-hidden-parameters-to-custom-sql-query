<%@ Page Language="VB" AutoEventWireup="true" CodeBehind="WebForm1.aspx.vb" 
    Inherits="ASPxDashboard_CustomParameters.WebForm1" %>

<%@ Register Assembly="DevExpress.Dashboard.v17.2.Web, Version=17.2.18.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" 
    Namespace="DevExpress.DashboardWeb" TagPrefix="dx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="position:absolute; left:0; right:0; top:0; bottom:0;">
        <dx:ASPxDashboard ID="ASPxDashboard1" runat="server" 
            WorkingMode="Viewer"
            OnSetInitialDashboardState="ASPxDashboard1_SetInitialDashboardState"
            OnCustomParameters="ASPxDashboard1_CustomParameters" 
            Height="100%" Width="100%">
        </dx:ASPxDashboard>
    </div>
    </form>
</body>
</html>
