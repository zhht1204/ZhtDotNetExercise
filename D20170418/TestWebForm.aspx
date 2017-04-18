<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TestWebForm.aspx.cs" Inherits="D20170418.TestWebForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>D20170419</title>
</head>
<body>

    <form id="testForm" runat="server">
        <div>
            <asp:Button ID="ButtonShowCalendar" runat="server" Text="显示日历" OnClick="ToggleCalendar"/>
            <asp:Calendar ID="Calendar" runat="server"></asp:Calendar>
        </div>
    </form>
</body>
</html>
