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
            //creating bool so if there's an error we don't say success
            bool errorExists = false;

            //connect to SQL DB
            SqlConnection proj = new SqlConnection("Server=tcp:545.database.windows.net,1433;Initial Catalog=545DB;Persist Security Info=False;User ID=log;Password=545Proj1;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            {
                //calls command/sproc/stored proceedure to input and declares the fields that'll be sent in
                SqlCommand insert = new SqlCommand("EXEC dbo.purchaseProduct @sku, @quantity", proj);
                insert.Parameters.AddWithValue("@sku", sku.Text);
                insert.Parameters.AddWithValue("@quantity", quantity.Text);


                proj.Open();

                try
                {
                    insert.ExecuteNonQuery();
                }
                catch(Exception ex)
                {
                    //Displays error text to show what the issue thrown from DB is
                    ErrorText.Text = "There were not enough of that item, Please contact us at (888)555-5555 to request more.";
                    errorExists = true;
                    
                }
                //always close the stuff
                proj.Close();

                if (IsPostBack)
                {
                    sku.Text = "";
                    quantity.Text = "";
                    if (!errorExists)
                    {
                        //lets user know their purchase was successful and deletes error if exists
                        PurchaseItem.Text = "Your Purchase was Successful! Thanks for shopping";
                        ErrorText.Text = "";
                    }
                    else
                    {
                        //removes success if error exists
                        PurchaseItem.Text = "";
                    }
                    
                }
            }
        }

        protected void SelectPet_Click(object sender, EventArgs e)
        {
            //so we don't lose the headers
            changeMe.Text = "Pet ID, Pet Name, Pet Type, Pet Breed, Color, Birthday, Description";
            //connect to SQL DB
            SqlConnection proj = new SqlConnection("Server=tcp:545.database.windows.net,1433;Initial Catalog=545DB;Persist Security Info=False;User ID=log;Password=545Proj1;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            {
                //calls command/sproc/stored proceedure to input and declares the fields that'll be sent in
                SqlCommand select = new SqlCommand("EXEC dbo.selectPet @input", proj);
                select.Parameters.AddWithValue("@input", selectPetType.Text);

                proj.Open();
                SqlDataReader reader = select.ExecuteReader();
                
                //appends rows below the header while they exist
                while (reader.Read())
                {
                    ReadSingleRowPets((IDataRecord)reader, changeMe);
                }

                //always close the stuff
                reader.Close();
                proj.Close();

            }
        }
        private static void ReadSingleRowPets(IDataRecord record, Label test)
        {
            //pulls all the fields and formats them as expected
            test.Text += "<br />" + (String.Format("{0}, {1}, {2}, {3}, {4}, {5}, {6}", record[0], record[1], record[2], record[3], record[4], record[5], record[6]));
            //System.Diagnostics.Debug.WriteLine(String.Format("{0}, {1}, {2}, {3}, {4}, {5}, {6}", record[0], record[1], record[2], record[3], record[4], record[5], record[6]));
        }

        private static void ReadSingleRow(IDataRecord record, Label test)
        {
            //pulls all the fields and formats them as expected
            test.Text += "<br />" + (String.Format("{0}, {1}, {2}, {3}, {4}, {5}", record[0], record[1], record[2], record[3], record[4], record[5]));
            //System.Diagnostics.Debug.WriteLine(String.Format("{0}, {1}, {2}, {3}, {4}, {5}, {6}", record[0], record[1], record[2], record[3], record[4], record[5], record[6]));
        }

        protected void selectProdName_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Search_Click(object sender, EventArgs e)
        {
            //so we don't lose the headers
            changeMe2.Text = "SKU, Price, Product Name, Description, Department, Qantity";
            //connect to SQL DB
            SqlConnection proj = new SqlConnection("Server=tcp:545.database.windows.net,1433;Initial Catalog=545DB;Persist Security Info=False;User ID=log;Password=545Proj1;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            {
                //calls command/sproc/stored proceedure to input and declares the fields that'll be sent in
                SqlCommand select = new SqlCommand("EXEC dbo.selectProducts @input", proj);
                select.Parameters.AddWithValue("@input", selectProdField.Text);

                proj.Open();
                SqlDataReader reader = select.ExecuteReader();

                //appends rows below the header while they exist
                while (reader.Read())
                {
                    ReadSingleRow((IDataRecord)reader, changeMe2);
                }

                //always close the stuff
                reader.Close();
                proj.Close();

            }
        }

        protected void selectPetType_TextChanged(object sender, EventArgs e)
        {

        }
    }
}