<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminPage.aspx.cs" Inherits="ClientServerApp.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>AdminPage</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <label>Choose product </label>
            <asp:RadioButtonList ID="productType" runat="server">
                <asp:ListItem value="Fridges">Fridges</asp:ListItem>
                <asp:ListItem value="TVs">Televisions</asp:ListItem>
                <asp:ListItem value="Washing_mashines">Washing mashines</asp:ListItem>
            </asp:RadioButtonList>
            <asp:Button ID="showButton" text="Show poducts" runat="server" OnClick="showButton_Click" />
        </div>
        <div>
            <asp:Label ID="productTypeLabel" Text ="" runat="server" />
            <asp:GridView ID="goodsGrid" runat="server" OnRowCommand="goodsGrid_RowCommand">
                <Columns>
                    <asp:ButtonField runat="server" HeaderText="Buy" ButtonType="Button" Text="Buy" CommandName="Buy"/>
                    <asp:TemplateField HeaderText="Input number to buy">
                        <ItemTemplate>
                            <asp:TextBox ID="numberToBuy" runat="server"/>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
             <asp:Label runat="server" ID="errorLabel" Text=""/>
            <asp:Label runat="server" ID="test" />
        </div>
    </form>
</body>
</html>
