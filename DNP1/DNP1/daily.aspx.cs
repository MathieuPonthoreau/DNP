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
    //this function is executed when the page load
    protected void Page_Load(object sender, EventArgs e)
    {
		if (Session["Login"] != null) //check if the users is logged in
        {
            SqlDataSource2.SelectCommand = "SELECT name FROM exercise where exercise.type ='cardio'";

            Label1.Visible = false;
        }
        else //return the login page if the user isn't logged in
        {
            Response.Redirect("Login.aspx");
        }
    }

    protected void saveWorkout(object sender, EventArgs e)
    {
        if ( //check if the textbox are filled
           TextBox1.Text.Length != 0
           && TextBox2.Text.Length != 0
           && TextBox3.Text.Length != 0
           && Session["Login"] != null
           )
        {
            //check if only integers are used
            if (!Int32.TryParse(TextBox1.Text, out int result) || !Int32.TryParse(TextBox2.Text, out int result2) || !Int32.TryParse(TextBox3.Text, out int result3) )
            {
                //Please only use intergers
                Label1.Visible = true;
                Label1.Text = "Please only use intergers";
            }
            else
            {

                SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["theConnection"].ConnectionString);
                connection.Open();

                string Exercise = DropDownList2.Text.ToString();

                SqlCommand command = new SqlCommand(
                    "SELECT exercise.id, exercise.calorie, exercise.type " +
                    "FROM [dbo].[exercise] " +
                    "WHERE exercise.name ='" + Exercise + "'"
                    , connection); //return the information of the exercice for the workout

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

                int series = Int32.Parse(TextBox1.Text);
                int repetition = Int32.Parse(TextBox2.Text);
                int duration = Int32.Parse(TextBox3.Text);

                SqlCommand workout = new SqlCommand(
                    "insert into [dbo].[Workout] (date, Id_Exercise, Id_User, series, repetition,duration,calories_burned)values(GETDATE()," + Id_Exercise + "," + Session["Login"] + "," + series + ", " + repetition + ", " + duration + ", " + calorie * series * repetition + ")"
                    , connection); //create sql request to upload a workout

                SqlDataReader sdr = workout.ExecuteReader();//save the new workout

                Label1.Visible = true;
                Label1.Text = "Workout saved";
                TextBox1.Text = "";
                TextBox2.Text = "";
                TextBox3.Text = "";

            }
        }
        else
        {
            //fill all of the parametters
            Label1.Visible = true;
            Label1.Text = "fill all of the parametters";
        }

    }

    //change the exercice depending on which type is selected 
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        string type = DropDownList1.Text;
        SqlDataSource2.SelectCommand = "SELECT name FROM exercise where exercise.type ='"+type+"'";
    }
}