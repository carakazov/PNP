using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace ClientServerApp
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        Shop management;
        Client client;
        String login;
        String password;
        String connectionString;
        String clientsTable;
        protected void Page_Load(object sender, EventArgs e)
        {
            client = new Client(Session["id"].ToString());
            clientsTable = "Clients";
            connectionString = @"Data Source = (localdb)\MSSQLLocalDB;" +
               @"Initial catalog = GoodsInShop;" + @"User ID = " + login + @"; password = " + password;
            management = new Shop();
            DataSet set = management.FillBasket(client.ID, connectionString, clientsTable);
            client.Basket = set;  
        }


        private void LoadData()
        {
            DataSet catalog = management.ShowCatalog(connectionString);
            fridges.DataSource = catalog.Tables["Fridges"];
            fridges.DataBind();
            tvs.DataSource = catalog.Tables["TVs"];
            tvs.DataBind();
            washingMashines.DataSource = catalog.Tables["Washing_mashines"];
            washingMashines.DataBind();
        }

        protected void fridges_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            Buy("Fridges", e, fridges);
        }

        protected void tvs_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            Buy("TVs", e, tvs);
        }

        protected void washingMashines_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            Buy("Washing_mashines", e, washingMashines);
        }

        protected void showProducts_Click(object sender, EventArgs e)
        {
            login = Session["login"].ToString();
            password = Session["password"].ToString();
            LoadData();
        }

        public void Buy(String productType, GridViewCommandEventArgs e, GridView gridID)
        {
            if (e.CommandName == "Buy")
            {
                int index = Convert.ToInt32(e.CommandArgument);
                GridViewRow row = gridID.Rows[index];
                String clientID = client.ID;
                TableCell cellNumber = row.Cells[1];
                TextBox numberBox = cellNumber.FindControl("numberToBuy") as TextBox;
                int number = Convert.ToInt32(numberBox.Text);
                TableCell cellID = row.Cells[4];
                int id = Convert.ToInt32(cellID.Text);
                try
                {
                    management.ClientBuy(connectionString, clientsTable, clientID, productType, id, number);
                    LoadData();
                }
                catch //DoubleException exception)
                {
                    //errorLabel.Text = exception.Message;
                }
            }
            else if (e.CommandName == "Plus")
            {
                int index = Convert.ToInt32(e.CommandArgument);
                GridViewRow row = gridID.Rows[index];
                String clientID = client.ID;
                TableCell cellID = row.Cells[4];
                int id = Convert.ToInt32(cellID.Text);
                try
                {
                    management.AddOrSubtract(connectionString, clientsTable, clientID, productType, id, true);
                    LoadData();
                }
                catch 
                {
                    //errorLabel.Text = exception.Message;
                }
            }
            else
            {
                int index = Convert.ToInt32(e.CommandArgument);
                GridViewRow row = gridID.Rows[index];
                String clientID = client.ID;
                TableCell cellID = row.Cells[4];
                int id = Convert.ToInt32(cellID.Text);
                try
                {
                    management.AddOrSubtract(connectionString, clientsTable, clientID, productType, id, false);
                    LoadData();
                }
                catch 
                {
                    //errorLabel.Text = exception.Message;
                }
            }
        }

        protected void toBasket_Click(object sender, EventArgs e)
        {
            GoToBasket();
        }

        private void GoToBasket()
        {
            Session["client"] = client;
            Server.Transfer("BasketPage.aspx");
        }
    }
}