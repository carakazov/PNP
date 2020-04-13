<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LogInPage.aspx.cs" Inherits="ClientServerApp.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1 align ="center">
                Login page
            </h1>
            <p>
                <label>Login </label>
                <asp:TextBox ID="loginInput" runat="server" />
            </p>
            <p>
                <label>Password </label>
                <asp:TextBox ID="passwordInput" runat="server" />
            </p>
            <p>
                <asp:Button ID="log" runat="server" Text="Log in" OnClick="login_Click" />
            </p>
            <p>
                <asp:Label ID="resultLabel" runat="server" Text="" />
            </p>
        </div>
    </form>
</body>
</html>
