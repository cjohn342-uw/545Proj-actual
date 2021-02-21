using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace _545Proj
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //abc
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection proj = new SqlConnection("Server=tcp:545.database.windows.net,1433;Initial Catalog=545DB;Persist Security Info=False;User ID=log;Password=545Proj1;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            {
                SqlCommand insert = new SqlCommand();
            }
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}