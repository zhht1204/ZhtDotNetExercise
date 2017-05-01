<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SearchForm.aspx.cs" Inherits="D20170420USL.SearchForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="formMain" runat="server" action="TestForm.aspx">
        <table>
            <tr>
                <td>用户名：</td>
                <td><input id="username" name="username" /></td>
            </tr>
            <tr>
                <td>请输入要搜索的书名：</td>
                <td><input id="bookName" name="bookName"/></td>
            </tr>
            <tr>
                <td></td>
                <td><input type="submit" value="提交" /></td>
            </tr>
        </table>
    </form>
</body>
</html>
