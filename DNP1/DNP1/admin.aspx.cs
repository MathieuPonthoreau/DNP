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

public partial class admin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["Login"] == null)
        {
            Response.Redirect("Login.aspx");
        }
        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["theConnection"].ConnectionString);
        connection.Open();
        SqlCommand getlevel = new SqlCommand("select level from [dbo].[User] where id = '" + Session["Login"].ToString() + "'", connection);
        int level = (int)getlevel.ExecuteScalar();
        if (level != 2)
        {
            Response.Redirect("Default.aspx");
        }
    }
}