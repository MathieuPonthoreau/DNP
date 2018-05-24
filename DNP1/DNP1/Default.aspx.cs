using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Data.Sql;

public partial class _Default : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["theConnection"].ConnectionString);
        connection.Open();
        SqlCommand command = new SqlCommand("select * from [dbo].[User] where pseudo =@pseudo and password =@password", connection);
        command.Parameters.AddWithValue("@pseudo", TextBox1.Text);
        command.Parameters.AddWithValue("@password", TextBox2.Text);

        SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
        DataTable dataTable = new DataTable();
        dataAdapter.Fill(dataTable);

        if(dataTable.Rows.Count > 0)
        {
            Response.Redirect("https://www.youtube.com/watch?v=P3ALwKeSEYs");
        }
        else
        {
            Label1.Visible = true;
            Label1.Text = "Wrong";
        }
    }
}