using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace _545Proj
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Purchase_Click(object sender, EventArgs e)
        {
            SqlConnection proj = new SqlConnection("Server=tcp:545.database.windows.net,1433;Initial Catalog=545DB;Persist Security Info=False;User ID=log;Password=545Proj1;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            {
                SqlCommand insert = new SqlCommand("EXEC dbo.purchaseProduct @sku, @quantity", proj);
                insert.Parameters.AddWithValue("@sku", sku.Text);
                insert.Parameters.AddWithValue("@quantity", quantity.Text);


                proj.Open();
                insert.ExecuteNonQuery();
                proj.Close();

                if (IsPostBack)
                {
                    sku.Text = "";
                    quantity.Text = "";
                }
            }
        }
    }
}