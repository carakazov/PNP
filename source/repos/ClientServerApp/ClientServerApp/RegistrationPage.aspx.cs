using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ClientServerApp
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        Shop management;
        protected void Page_Load(object sender, EventArgs e)
        {
            management = new Shop();
        }

        protected void registrationButton_Click(object sender, EventArgs e)
        {
            String[] list = listCreate();
            String connectionString = @"Data Source = (localdb)\MSSQLLocalDB;" + @"Initial Catalog = GoodsInShop;" +
                @"Integrated Security = True";
            try
            {
                management.NewClient(connectionString, "Clients", list);
                Server.Transfer("LogInPage.aspx");
            }
            catch
            {
                duplicateLogin.Text = "Such login allready exists";
            }
        }

        private String[] listCreate()
        {
            String[] list = new string[6];
            list[0] = loginInput.Text;
            list[1] = passwordInput.Text;
            list[2] = surnameInput.Text;
            list[3] = nameInput.Text;
            list[4] = phoneInput.Text;
            if (mailInput.Text != "")
            {
                list[5] = mailInput.Text;
            }
            else
            {
                list[5] = "null";
            }
            return list;
        }
    }
}