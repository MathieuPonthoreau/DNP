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
        if(Session["Login"] != null)
        {
            
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["theConnection"].ConnectionString);
            connection.Open();
            SqlCommand getName = new SqlCommand("select firstName from [dbo].[User] where id = '"+ Session["Login"].ToString() + "'", connection);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(getName);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);

            string firstName = (string)getName.ExecuteScalar();

            TextBox1.Visible = false;
            TextBox2.Visible = false;
            Button1.Visible = false;
            HyperLink1.Visible = false;
            Label1.Visible = true;
            Label1.Text = "Hello "+firstName;
            Button2.Visible = true;


        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["theConnection"].ConnectionString);
        connection.Open();
        SqlCommand command = new SqlCommand("select id from [dbo].[User] where pseudo = '"+TextBox1.Text+ "' and password = '"+TextBox2.Text+"'", connection);

        SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
        DataTable dataTable = new DataTable();
        dataAdapter.Fill(dataTable);

        if(dataTable.Rows.Count > 0)
        {
            
            int userId = (int)command.ExecuteScalar();
            connection.Close();

            Session["Login"] = userId;
            Response.Redirect("Default.aspx");
        }
        else
        {
            Label1.Visible = true;
            Label1.Text = "Wrong";
        }
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        Session["Login"] = null;
        Response.Redirect("Default.aspx");
    }
}