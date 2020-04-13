using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using ClientServerApp.ServiceReference1;

namespace ClientServerApp
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        DataSet goodsList;
        Shop management = new Shop();
        protected void Page_Load(object sender, EventArgs e)
        {
            management.AdminLogin(@"Data source = (localdb)\MSSQLLocalDB;" + @"Initial Catalog = GoodsInShop;" +
            @"Integrated security = true", "Clients");
        }

        protected void showButton_Click(object sender, EventArgs e)
        {
            management.AdminLogin(@"Data source = (localdb)\MSSQLLocalDB;" + @"Initial Catalog = GoodsInShop;" +
            @"Integrated security = true", "Clients");
            ReadData();
        }

        private void ReadData()
        {
            try
            {
                errorLabel.Text = "";
                String type = productType.SelectedValue;
                productTypeLabel.Text = productType.SelectedValue;
                goodsList = management.ShowAllGoodsOfType(type);
                goodsGrid.DataSource = goodsList.Tables[type];
                goodsGrid.DataBind();
            }
            catch
            {
                errorLabel.Text = "You forgot to choose";
            }
        }

        protected void goodsGrid_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            management.AdminLogin(@"Data source = (localdb)\MSSQLLocalDB;" + @"Initial Catalog = GoodsInShop;" +
            @"Integrated security = true", "Clients");
            if (e.CommandName == "Buy")
            {
                int index = Convert.ToInt32(e.CommandArgument);
                GridViewRow row = goodsGrid.Rows[index];
                TableCell cell = row.Cells[1];
                TableCell maxNumberCell = row.Cells[11];
                int maxNumber = Convert.ToInt32(maxNumberCell.Text);
                TextBox temporaryBox = cell.FindControl("numberToBuy") as TextBox;
                int number;
                try
                {
                    number = Convert.ToInt32(temporaryBox.Text);
                    errorLabel.Text = temporaryBox.Text;
                    if (number > maxNumber)
                    {
                        //throw new NumberException("Warehause does not have that much");
                    }
                    String type = productTypeLabel.Text;
                    TableCell idCell = row.Cells[2];
                    int id = Convert.ToInt32(idCell.Text);
                    int num = Convert.ToInt32(temporaryBox.Text);
                    String clientConnectionString = @"Data source = (localdb)\MSSQLLocalDB; " +
                        @"Initial Catalog = GoodsInShop; " + @"Integrated Security = True";
                    management.BuyProduct(type, id, num, clientConnectionString);
                    ReadData();
                }
                //catch (NumberException exception)
                //{
                   // errorLabel.Text = exception.Message;
                //}
                catch
                {
                    errorLabel.Text = "Please input number";
                }
            }
        }
    }
}