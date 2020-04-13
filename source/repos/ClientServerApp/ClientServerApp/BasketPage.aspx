<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BasketPage.aspx.cs" Inherits="ClientServerApp.WebForm5" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>BasketPage</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1 align="center">My basket</h1>
            <label>Fridges </label>
            <asp:GridView runat="server" ID="fridges" onRowCommand="fridges_RowCommand" OnRowDeleting="fridges_RowDeleting">
                <Columns>
                    <asp:ButtonField runat="server" HeaderText="Delete from basket" ButtonType="Button" Text="Delete" CommandName="delete" />
                </Columns>
            </asp:GridView>

            <label>TVs </label>
            <asp:GridView runat="server" ID="tvs" onRowCommand="tvs_RowCommand" OnRowDeleting="tvs_RowDeleting" >
                <Columns>
                    <asp:ButtonField runat="server" HeaderText="Delete from basket" ButtonType="Button" Text="Delete" CommandName="delete" />
                </Columns>
            </asp:GridView>

            <label>Washing mashines </label>
            <asp:GridView runat="server" ID="washingMashines" onRowCommand="washingMashines_RowCommand" OnRowDeleting ="washingMashines_RowDeleting">
                <Columns>
                    <asp:ButtonField runat="server" HeaderText="Delete from basket" ButtonType="Button" Text="Delete" CommandName="delete" />
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>

