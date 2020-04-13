<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CatalogPage.aspx.cs" Inherits="ClientServerApp.WebForm4" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Catalog page</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1 align="center">Catalog</h1>
            <asp:Label ID="test" runat="server" Text="" />
            <label>Fridges </label>
            <asp:GridView ID="fridges" runat="server" OnRowCommand="fridges_RowCommand">
                <Columns>
                    <asp:ButtonField runat="server" HeaderText="Buy" ButtonType="Button" Text="Buy" CommandName="Buy"/>
                    <asp:TemplateField HeaderText="Input number to buy">
                        <ItemTemplate>
                            <asp:TextBox ID="numberToBuy" runat="server"/>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:ButtonField runat ="server" HeaderText ="Add" ButtonType="Button" Text="+" CommandName="Plus" />
                    <asp:ButtonField runat ="server" HeaderText ="Take away" ButtonType="Button" Text="-" CommandName="Minus" />
                </Columns>
            </asp:GridView>

            <label>TVs</label>
            <asp:GridView ID="tvs" runat ="server" OnRowCommand="tvs_RowCommand">
                 <Columns>
                    <asp:ButtonField runat="server" HeaderText="Buy" ButtonType="Button" Text="Buy" CommandName="Buy"/>
                    <asp:TemplateField HeaderText="Input number to buy">
                        <ItemTemplate>
                            <asp:TextBox ID="numberToBuy" runat="server"/>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:ButtonField runat ="server" HeaderText ="Add" ButtonType="Button" Text="+" CommandName="Plus" />
                    <asp:ButtonField runat ="server" HeaderText ="Take away" ButtonType="Button" Text="-" CommandName="Minus" />
                </Columns>
            </asp:GridView>

            <label>Washing mashines</label>
            <asp:GridView ID="washingMashines" runat="server" OnRowCommand="washingMashines_RowCommand">
                 <Columns>
                    <asp:ButtonField runat="server" HeaderText="Buy" ButtonType="Button" Text="Buy" CommandName="Buy"/>
                    <asp:TemplateField HeaderText="Input number to buy">
                        <ItemTemplate>
                            <asp:TextBox ID="numberToBuy" runat="server"/>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:ButtonField runat ="server" HeaderText ="Add" ButtonType="Button" Text="+" CommandName="Plus" />
                    <asp:ButtonField runat ="server" HeaderText ="Take away" ButtonType="Button" Text="-" CommandName="Minus" />
                </Columns>
            </asp:GridView>
            <asp:Button ID="showProducts" runat="server" Text="Show Products" OnClick="showProducts_Click"/>
            <asp:Label ID="errorLabel" runat="server" Text="" />
            <asp:Button ID="toBasket" runat="server" Text="Watch my basket" OnClick="toBasket_Click" />
        </div>
    </form>
</body>
</html>

