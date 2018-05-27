using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data.SqlClient;
using System.Configuration;
using System.Data;

public partial class daily : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
		if (Session["Login"] != null)
        {
        }
        else
        {
            Response.Redirect("Login.aspx");
        }
    }

    protected void saveWorkout(object sender, EventArgs e)
    {
        if (
           TextBox1.Text.Length != 0
           && TextBox2.Text.Length != 0
           && TextBox3.Text.Length != 0
           && Session["Login"] != null
           )
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["theConnection"].ConnectionString);
            connection.Open();

            string Exercise = DropDownList2.Text.ToString();

            SqlCommand command = new SqlCommand(
                "SELECT exercise.id, exercise.calorie, exercise.type " +
                "FROM [dbo].[exercise] " +
                "WHERE exercise.name ='" + Exercise+ "'"
                , connection);

            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);

            int Id_Exercise = 1;
            int calorie = 1;

            foreach (DataRow row in dataTable.Rows)
            {
                Id_Exercise = Int32.Parse(row["id"].ToString());
                calorie = Int32.Parse(row["calorie"].ToString());
            }


            string Id_User = "";
            int series = Int32.Parse(TextBox1.Text);
            int repetition = Int32.Parse(TextBox2.Text);
            int duration = Int32.Parse(TextBox3.Text);

            SqlCommand workout = new SqlCommand(
                "insert into [dbo].[Workout] (date, Id_Exercise, Id_User, series, repetition,duration,calories_burned)values(GETDATE()," + Id_Exercise+"," +Session["Login"]+"," + series + ", " + repetition + ", "+ duration + ", " + calorie*series*repetition + ")"
                , connection);

            SqlDataReader sdr = workout.ExecuteReader();
            Response.Redirect("info.aspx");
        }
        else
        {
            
        }

    }



    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}