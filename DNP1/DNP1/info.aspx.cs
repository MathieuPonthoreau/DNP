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


public partial class info : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        if (Session["Login"] == null)
        {
            Response.Redirect("Login.aspx");
        }
    }



    protected void Button1_Click(object sender, EventArgs e)
    {

        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["theConnection"].ConnectionString);
        connection.Open();
        SqlCommand command = new SqlCommand("SELECT exercise.name AS Exercise, AVG(workout.series) AS Average_series, AVG(workout.repetition) AS Average_repetition, AVG(workout.duration) AS Average_duration, AVG(workout.duration)" +
                     "* AVG(workout.series) AS Average_Total_Time_Spend, AVG(workout.repetition) * AVG(workout.series) AS Average_Total_Repetition, SUM(workout.calories_burned) AS Total_Calories_Burned " +
                     "FROM workout INNER JOIN " +
                     "exercise ON workout.Id_Exercise = exercise.Id INNER JOIN " +
                     "[User] ON workout.Id_User = [User].Id " +
                     "WHERE workout.Id_User = "+ Session["Login"] + " GROUP BY exercise.name", connection);
        SqlDataAdapter sda = new SqlDataAdapter(command);
        DataTable dt = new DataTable();
        sda.Fill(dt);
        dataGridView.DataSource = dt;
        dataGridView.DataBind();
    }

    protected void Calendar1_SelectionChanged(object sender, EventArgs e)
    {

    }
}