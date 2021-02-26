using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

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

        protected void SelectPet_Click(object sender, EventArgs e)
        {
            changeMe.Text = "Pet ID, Pet Name, Pet Type, Pet Breed, Birthday, Description";
            SqlConnection proj = new SqlConnection("Server=tcp:545.database.windows.net,1433;Initial Catalog=545DB;Persist Security Info=False;User ID=log;Password=545Proj1;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            {
                SqlCommand select = new SqlCommand("EXEC dbo.selectPet @pet_type, @breed", proj);
                select.Parameters.AddWithValue("@pet_type", selectPetType.Text);
                select.Parameters.AddWithValue("@breed", selectPetBreed.Text);

                proj.Open();
                SqlDataReader reader = select.ExecuteReader();

                while (reader.Read())
                {
                    ReadSingleRow((IDataRecord)reader, changeMe);
                }

                reader.Close();
                proj.Close();

            }
        }
        private static void ReadSingleRow(IDataRecord record, Label test)
        {
            test.Text += "<br />" + (String.Format("{0}, {1}, {2}, {3}, {4}, {5}", record[0], record[1], record[2], record[3], record[4], record[5]));
            System.Diagnostics.Debug.WriteLine(String.Format("{0}, {1}, {2}, {3}, {4}, {5}", record[0], record[1], record[2], record[3], record[4], record[5]));
        }
    }
}