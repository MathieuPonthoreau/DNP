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
        if (Session["Login"] == null) //If User not connected
        {
            Response.Redirect("Login.aspx");
        }
        //Get User Lvl
        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["theConnection"].ConnectionString);
        connection.Open();
        SqlCommand getlevel = new SqlCommand("select level from [dbo].[User] where id = '" + Session["Login"].ToString() + "'", connection);
        int level = (int)getlevel.ExecuteScalar();
        if (level != 2) //If User isn't an Admin
        {
            Response.Redirect("Default.aspx");
        }
    }
}