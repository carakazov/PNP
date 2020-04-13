using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;


namespace ClientServerApp
{
   
        public class Client
        {
            private String id;
            private DataSet basket;
            private int total;

            public int Total
            {
                set { total = value; }
                get { return total; }
            }

            public Client(String id)
            {
                this.id = id;
            }

            public DataSet Basket
            {
                set { basket = value; }
                get { return basket; }
            }
            public String ID
            {
                get { return id; }
            }
        }
    
}