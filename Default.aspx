<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="manjuvs.Default" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Exception, High CPU, and High Memory Example</title>
    <link rel="stylesheet" type="text/css" href="styles.css" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <h1>App Service Performance Scenarios</h1>
            <div class="button-group">
                <asp:Button ID="Button1" runat="server" Text="Cause Crash" OnClick="Button1_Click" CssClass="btn btn-crash" />
                <asp:Button ID="Button2" runat="server" Text="Cause High CPU" OnClick="Button2_Click" CssClass="btn btn-cpu" />
                <asp:Button ID="Button3" runat="server" Text="Cause High Memory" OnClick="Button3_Click" CssClass="btn btn-memory" />               
            </div>
        </div>
    </form>
</body>
</html>