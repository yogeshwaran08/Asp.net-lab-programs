using System;
using System.Data.SqlClient;

public partial class index : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        btnsubmit.Visible = false;
    }

    protected void btnsubmit_Click(object sender, EventArgs e)
    {
        string connectionString = "Data Source=CYBERIANMAL;Initial Catalog=BankCustomer;Integrated Security=True";

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            try
            {
                connection.Open();

                string insertQuery = "INSERT INTO data (CustomerName, State, City, Email, Mobile, Aadhar) " +
                                     "VALUES (@CustomerName, @State, @City, @Email, @Mobile, @Aadhar);";

                using (SqlCommand insertCommand = new SqlCommand(insertQuery, connection))
                {
                    insertCommand.Parameters.AddWithValue("@CustomerName", txtname.Text);
                    insertCommand.Parameters.AddWithValue("@State", ddlstate.SelectedValue);
                    insertCommand.Parameters.AddWithValue("@City", ddlcity.SelectedValue);
                    insertCommand.Parameters.AddWithValue("@Email", txtmail.Text);
                    insertCommand.Parameters.AddWithValue("@Mobile", txtMob.Text);
                    insertCommand.Parameters.AddWithValue("@Aadhar", txtaadhaar.Text);

                    int rowsAffected = insertCommand.ExecuteNonQuery();
                    GrdCustomer.DataBind();
                }
            }
            catch (Exception ex)
            {
                Response.Write("Error: " + ex.Message);
            }

        }
    }

    protected void btnclear_Click(object sender, EventArgs e)
    {
        txtname.Text = "";
        txtMob.Text = "";
        txtmail.Text = "";
        txtaadhaar.Text = "";
        ddlstate.SelectedIndex = 0;
        ddlcity.SelectedIndex = 0;
    }

    protected void btnverify_Click(object sender, EventArgs e)
    {
        btnsubmit.Visible = true;

        if (txtaadhaar.Text.Length == 12)
        {
            lblaadhar.Text = "Aadhar verifed";
        }
        else
        {
            lblaadhar.Text = "Please enter a valid aadhar number";
        }
    }
}