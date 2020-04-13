using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace ClientServerApp
{
    public partial class WebForm5 : System.Web.UI.Page
    {
        Shop management;
        String clientsTable;
        String login;
        String password;
        String connectionString;
        Client client;
        protected void Page_Load(object sender, EventArgs e)
        {
            login = Session["login"].ToString();
            password = Session["password"].ToString();
            clientsTable = "Clients";
            connectionString = @"Data Source = (localdb)\MSSQLLocalDB;" +
               @"Initial catalog = GoodsInShop;" + @"User ID = " + login + @"; password = " + password;
            client = (Client)Session["client"];
            management = new Shop();
            LoadData();
        }

        protected void fridges_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            Delete("Fridges", e, fridges);
            LoadData();
        }

        protected void fridges_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

        }
        protected void tvs_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            Delete("TVs", e, tvs);
            LoadData();
        }

        protected void washingMashines_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            Delete("Washing_mashines", e, washingMashines);
            LoadData();
        }
        private void Delete(String product, GridViewCommandEventArgs e, GridView gridID)
        {
            if (e.CommandName == "delete")
            {
                int index = Convert.ToInt32(e.CommandArgument);
                GridViewRow row = gridID.Rows[index];
                TableCell cellID = row.Cells[2];
                int id = Convert.ToInt32(cellID.Text);
                management.DeleteFromBasket(product, clientsTable, client.ID, id, connectionString);

            }
        }

        private void LoadData()
        {
            DataSet set = management.FillBasket(client.ID, connectionString, "Clients");
            client.Basket = set;
            fridges.DataSource = client.Basket.Tables["Fridges"];
            tvs.DataSource = client.Basket.Tables["TVs"];
            washingMashines.DataSource = client.Basket.Tables["Washing_mashines"];
            fridges.DataBind();
            tvs.DataBind();
            washingMashines.DataBind();
        }

        protected void tvs_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

        }

        protected void washingMashines_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

        }
    }
}