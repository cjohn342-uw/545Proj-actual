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
            
            if (Page.IsPostBack == true)
            {

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //connect to SQL DB
            SqlConnection proj = new SqlConnection("Server=tcp:545.database.windows.net,1433;Initial Catalog=545DB;Persist Security Info=False;User ID=log;Password=545Proj1;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            {
                //calls command/sproc/stored proceedure to input and declares the fields that'll be sent in
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
            //connect to SQL DB
            SqlConnection proj = new SqlConnection("Server=tcp:545.database.windows.net,1433;Initial Catalog=545DB;Persist Security Info=False;User ID=log;Password=545Proj1;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            {
                //calls command/sproc/stored proceedure to input and declares the fields that'll be sent in
                SqlCommand insert = new SqlCommand("EXEC dbo.adoptPet @id", proj);
                insert.Parameters.AddWithValue("@id", petID.Text);


                proj.Open();
                //run the query
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
            //connect to SQL DB
            SqlConnection proj = new SqlConnection("Server=tcp:545.database.windows.net,1433;Initial Catalog=545DB;Persist Security Info=False;User ID=log;Password=545Proj1;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            {
                //calls command/sproc/stored proceedure to input and declares the fields that'll be sent in
                SqlCommand insert = new SqlCommand("EXEC dbo.insertProduct @name, @description, @price, @quantity, @department", proj);
                insert.Parameters.AddWithValue("@name", productName.Text);
                insert.Parameters.AddWithValue("@description", prodDescription.Text);
                insert.Parameters.AddWithValue("@price", prodPrice.Text);
                insert.Parameters.AddWithValue("@quantity", prodQuantity.Text);
                insert.Parameters.AddWithValue("@department", prodDept.Text);


                proj.Open();
                //run the query
                insert.ExecuteNonQuery();
                proj.Close();

                //if it is post back clear out fields
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
            //connect to SQL DB
            SqlConnection proj = new SqlConnection("Server=tcp:545.database.windows.net,1433;Initial Catalog=545DB;Persist Security Info=False;User ID=log;Password=545Proj1;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            {
                if (updateProdName.Text != "Product Name")
                {
                    //calls command/sproc/stored proceedure to input and declares the fields that'll be sent in
                    SqlCommand uProdName = new SqlCommand("EXEC dbo.updateProductName @sku, @name", proj);
                    uProdName.Parameters.AddWithValue("@sku", sku.Text);
                    uProdName.Parameters.AddWithValue("@name", updateProdName.Text);
                    proj.Open();
                    //run the query
                    uProdName.ExecuteNonQuery();
                    //always close the stuff
                    proj.Close();
                }
                if (updateProdDesc.Text != "Product Description")
                {
                    //calls command/sproc/stored proceedure to input and declares the fields that'll be sent in
                    SqlCommand uProdDesc = new SqlCommand("EXEC dbo.updateProductDescription @sku, @description", proj);
                    uProdDesc.Parameters.AddWithValue("@sku", sku.Text);
                    uProdDesc.Parameters.AddWithValue("@description", updateProdDesc.Text);
                    proj.Open();
                    //run the query
                    uProdDesc.ExecuteNonQuery();
                    //always close the stuff
                    proj.Close();
                }
                if (updateProdPrice.Text != "Product Price")
                {
                    //calls command/sproc/stored proceedure to input and declares the fields that'll be sent in
                    SqlCommand uProdPrice = new SqlCommand("EXEC dbo.updateProductPrice @sku, @price", proj);
                    uProdPrice.Parameters.AddWithValue("@sku", sku.Text);
                    uProdPrice.Parameters.AddWithValue("@price", updateProdPrice.Text);
                    proj.Open();
                    //run the query 
                    uProdPrice.ExecuteNonQuery();
                    //always close the stuff
                    proj.Close();
                }
                if (updateProdQuantity.Text != "Product Quantity")
                {
                    //calls command/sproc/stored proceedure to input and declares the fields that'll be sent in
                    SqlCommand uProdQuantity = new SqlCommand("EXEC dbo.updateProductQuantity @sku, @quantity", proj);
                    uProdQuantity.Parameters.AddWithValue("@sku", sku.Text);
                    uProdQuantity.Parameters.AddWithValue("@quantity", updateProdQuantity.Text);
                    proj.Open();
                    //run the query
                    uProdQuantity.ExecuteNonQuery();
                    //always close the stuff
                    proj.Close();
                }
                if(updateProdDept.Text != "Product Department")
                {
                    //calls command/sproc/stored proceedure to input and declares the fields that'll be sent in
                    SqlCommand uProdDept = new SqlCommand("EXEC dbo.updateProductDepartment @sku, @department", proj);
                    uProdDept.Parameters.AddWithValue("@sku", sku.Text);
                    uProdDept.Parameters.AddWithValue("@department", updateProdDept.Text);
                    proj.Open();
                    //run query
                    uProdDept.ExecuteNonQuery();
                    //always close the stuff
                    proj.Close();
                }


                if (IsPostBack)
                {
                    //sets all values back as they were b/c this one will update "" to the fields without this
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