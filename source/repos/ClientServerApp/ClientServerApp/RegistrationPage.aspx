<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegistrationPage.aspx.cs" Inherits="ClientServerApp.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Registration Page</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1 align ="center">Registration form</h1>
            <p>
                <label>Login </label>
                <asp:TextBox ID="loginInput" runat="server" />
                <asp:Label ID="duplicateLogin" runat="server" Text="" />
            </p>
            <p>
                <label>Password </label>
                <asp:TextBox ID="passwordInput" runat="server" />
            </p>
            <p>
                <label>Surname </label>
                <asp:TextBox ID="surnameInput" runat="server" />
            </p>
            <p>
                <label>Name </label>
                <asp:TextBox ID="nameInput" runat="server" />
            </p>
            <p>
                <label>Phone number </label>
                <asp:TextBox ID="phoneInput" runat="server" />
            </p>
            <p>
                <label>E-mail </label>
                <asp:TextBox ID="mailInput" runat="server" />
            </p>
            <p>
                <asp:Button Text="Registrate" ID="registrationButton" runat="server" OnClick="registrationButton_Click" />
            </p>
        </div>
    </form>
</body>
</html>