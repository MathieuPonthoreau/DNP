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
        //Get Year from 1950 to this year
        for (int YLoop = DateTime.Now.Year; YLoop >= 1950; YLoop--)
        {
            DropDownListYear.Items.Add(YLoop.ToString());
        }
        //If User is login
        if (Session["Login"] == null)
        {
            Response.Redirect("Login.aspx");
        }
    }



    protected void Button1_Click(object sender, EventArgs e)
    {
        //Get all workout about the user and the date previously selected
        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["theConnection"].ConnectionString);
        connection.Open();
        SqlCommand command = new SqlCommand("SELECT exercise.name AS Exercise, AVG(workout.series) AS \"Average series\", AVG(workout.repetition) AS \"Average repetition\", AVG(workout.duration) AS \"Average duration\", AVG(workout.duration)" +
                     "* AVG(workout.series) AS \"Average Total Time Spend\", AVG(workout.repetition) * AVG(workout.series) AS \"Average Total Repetition\", SUM(workout.calories_burned) AS \"Total Calories Burned\" " +
                     "FROM workout INNER JOIN " +
                     "exercise ON workout.Id_Exercise = exercise.Id INNER JOIN " +
                     "[User] ON workout.Id_User = [User].Id " +
                     "WHERE workout.Id_User = " + Session["Login"] + " AND MONTH(workout.date) = " + DropDownListMonth.SelectedItem.Text + "AND YEAR(workout.date) = " + DropDownListYear.SelectedItem.Text + " GROUP BY exercise.name", connection);
        SqlDataAdapter sda = new SqlDataAdapter(command);
        DataTable dt = new DataTable();
        sda.Fill(dt);
        //Display data in the data grid view
        dataGridView.DataSource = dt;
        dataGridView.DataBind();

        //Get total calories of the user and the date previously selected
        SqlCommand getCalorie = new SqlCommand("SELECT SUM(workout.calories_burned) FROM workout WHERE workout.Id_User = " + Session["Login"] + " AND MONTH(workout.date) = " + DropDownListMonth.SelectedItem.Text + "AND YEAR(workout.date) = " + DropDownListYear.SelectedItem.Text, connection);
        var TotalC = getCalorie.ExecuteScalar();
        if (TotalC.GetType() != typeof(DBNull))//If a workout exist
        {
            Label1.Text = "Congratulation you have burned " + TotalC + " calories during this month !!";
        }
        else
        {
            Label1.Text = " ";
        }
    }
}