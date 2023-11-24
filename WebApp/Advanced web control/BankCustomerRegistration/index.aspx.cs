using System;
using System.Data.SqlClient;

public partial class index : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
    }

    protected void btnsubmit_Click(object sender, EventArgs e)
    {
        string connectionString = "Data Source=CYBERIANMAL;Integrated Security=SSPI;Initial Catalog=StudentDetail";

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            try
            {
                connection.Open();

                string insertQuery = "INSERT INTO data (name, email, mobile) " +
                                     "VALUES (@name, @email, @mobile);";

                using (SqlCommand insertCommand = new SqlCommand(insertQuery, connection))
                {
                    insertCommand.Parameters.AddWithValue("@name", txtname.Text);
                    insertCommand.Parameters.AddWithValue("@email", txtmail.Text);
                    insertCommand.Parameters.AddWithValue("@mobile", txtMob.Text);

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

    }

    
}