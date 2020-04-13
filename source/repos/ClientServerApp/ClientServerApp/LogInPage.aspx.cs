using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace ClientServerApp
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        Shop management;
        protected void Page_Load(object sender, EventArgs e)
        {
            management = new Shop();
        }

        protected void login_Click(object sender, EventArgs e)
        {
            LoginCheck();
        }

        private void LoginCheck()
        {
            String loginName = "Login";
            String passwordName = "Password";
            String loginValue = loginInput.Text;
            String passwordValue = passwordInput.Text;
            String tableName = "Clients";
            String connectionToClient = @"Data Source = (localdb)\MSSQLLocalDB; " +
                @"Initial Catalog = GoodsInShop;" + @"Integrated security = True";
            String result = management.LogIn(connectionToClient, tableName, loginName, passwordName, loginValue, passwordValue);
            switch (result)
            {
                case ("Wrong login"):
                    resultLabel.Text = result;
                    break;
                case ("Wrong password"):
                    resultLabel.Text = result;
                    break;
                default:
                    String id = findByLogin(loginValue);
                    Session["id"] = id;
                    Session["login"] = loginValue;
                    Session["password"] = passwordValue;
                    Server.Transfer("CatalogPage.aspx");
                    break;
            }
        }

        private String findByLogin(String login)
        {
            String connectionString = @"Data Source = (localdb)\MSSQLLocalDB;" +
                @"Initial Catalog = GoodsInShop;" + @"Integrated Security = True";
            SqlConnection connection = new SqlConnection(connectionString);
            String commandString = @"Select Id from Clients where Login = " + management.Hash(login);
            SqlCommand command = new SqlCommand(commandString, connection);
            String id = "";
            using (connection)
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    id = reader[0].ToString();
                }
            }
            return id;
        }
    }
}