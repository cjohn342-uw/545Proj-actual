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
            if (Page.IsPostBack == true)
            {

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection proj = new SqlConnection("Server=tcp:545.database.windows.net,1433;Initial Catalog=545DB;Persist Security Info=False;User ID=log;Password=545Proj1;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            {
                SqlCommand insert = new SqlCommand("EXEC dbo.insertPet @name, @pet_type, @breed, @birthday, @description", proj);
                insert.Parameters.AddWithValue("@name", PetNameInsert.Text);
                insert.Parameters.AddWithValue("@pet_type", PetTypeInsert.Text);
                insert.Parameters.AddWithValue("@breed", BreedInsert.Text);
                insert.Parameters.AddWithValue("@birthday", BirthdayInsert.Text);
                insert.Parameters.AddWithValue("@description", petDescriptionInsert.Text);


                proj.Open();
                insert.ExecuteNonQuery();
                proj.Close();

                if (IsPostBack)
                {
                    PetNameInsert.Text = "";
                    PetTypeInsert.Text = "";
                    BreedInsert.Text = "";
                    BirthdayInsert.Text = "";
                    petDescriptionInsert.Text = "";
                }

            }
        }

        protected void adoptButton_Click(object sender, EventArgs e)
        {
            SqlConnection proj = new SqlConnection("Server=tcp:545.database.windows.net,1433;Initial Catalog=545DB;Persist Security Info=False;User ID=log;Password=545Proj1;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            {
                SqlCommand insert = new SqlCommand("EXEC dbo.adoptPet @id", proj);
                insert.Parameters.AddWithValue("@id", petID.Text);


                proj.Open();
                insert.ExecuteNonQuery();
                proj.Close();

                if (IsPostBack)
                {
                    petID.Text = "";
                }
            }
        }

        protected void prodButton_Click(object sender, EventArgs e)
        {
            SqlConnection proj = new SqlConnection("Server=tcp:545.database.windows.net,1433;Initial Catalog=545DB;Persist Security Info=False;User ID=log;Password=545Proj1;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            {
                SqlCommand insert = new SqlCommand("EXEC dbo.insertProduct @name, @description, @price, @quantity, @department", proj);
                insert.Parameters.AddWithValue("@name", productName.Text);
                insert.Parameters.AddWithValue("@description", prodDescription.Text);
                insert.Parameters.AddWithValue("@price", prodPrice.Text);
                insert.Parameters.AddWithValue("@quantity", prodQuantity.Text);
                insert.Parameters.AddWithValue("@department", prodDept.Text);


                proj.Open();
                insert.ExecuteNonQuery();
                proj.Close();

                if (IsPostBack)
                {
                    productName.Text = "";
                    prodDescription.Text = "";
                    prodPrice.Text = "";
                    prodQuantity.Text = "";
                    prodDept.Text = "";
                }
            }
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void UpdateButton_Click(object sender, EventArgs e)
        {
            SqlConnection proj = new SqlConnection("Server=tcp:545.database.windows.net,1433;Initial Catalog=545DB;Persist Security Info=False;User ID=log;Password=545Proj1;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            {
                if (updateProdName.Text != "Product Name")
                {
                    SqlCommand uProdName = new SqlCommand("EXEC dbo.updateProductName @sku, @name", proj);
                    uProdName.Parameters.AddWithValue("@sku", sku.Text);
                    uProdName.Parameters.AddWithValue("@name", updateProdName.Text);
                    proj.Open();
                    uProdName.ExecuteNonQuery();
                    proj.Close();
                }
                if (updateProdDesc.Text != "Product Description")
                {
                    SqlCommand uProdDesc = new SqlCommand("EXEC dbo.updateProductDescription @sku, @description", proj);
                    uProdDesc.Parameters.AddWithValue("@sku", sku.Text);
                    uProdDesc.Parameters.AddWithValue("@description", updateProdDesc.Text);
                    proj.Open();
                    uProdDesc.ExecuteNonQuery();
                    proj.Close();
                }
                if (updateProdPrice.Text != "Product Price")
                {
                    SqlCommand uProdPrice = new SqlCommand("EXEC dbo.updateProductPrice @sku, @price", proj);
                    uProdPrice.Parameters.AddWithValue("@sku", sku.Text);
                    uProdPrice.Parameters.AddWithValue("@price", updateProdPrice.Text);
                    proj.Open();
                    uProdPrice.ExecuteNonQuery();
                    proj.Close();
                }
                if (updateProdQuantity.Text != "Product Quantity")
                {
                    SqlCommand uProdQuantity = new SqlCommand("EXEC dbo.updateProductPrice @sku, @quantity", proj);
                    uProdQuantity.Parameters.AddWithValue("@sku", sku.Text);
                    uProdQuantity.Parameters.AddWithValue("@quantity", updateProdQuantity.Text);
                    proj.Open();
                    uProdQuantity.ExecuteNonQuery();
                    proj.Close();
                }
                if(updateProdDept.Text != "Product Department")
                {
                    SqlCommand uProdDept = new SqlCommand("EXEC dbo.updateProductDepartment @sku, @department", proj);
                    uProdDept.Parameters.AddWithValue("@sku", sku.Text);
                    uProdDept.Parameters.AddWithValue("@department", updateProdDept.Text);
                    proj.Open();
                    uProdDept.ExecuteNonQuery();
                    proj.Close();
                }


                if (IsPostBack)
                {
                    sku.Text = "Product SKU";
                    updateProdName.Text = "Product Name";
                    updateProdDesc.Text = "Product Description";
                    updateProdPrice.Text = "Product Price";
                    updateProdQuantity.Text = "Product Quantity";
                    updateProdDept.Text = "Product Department";
                }
            }
        }


    }
}