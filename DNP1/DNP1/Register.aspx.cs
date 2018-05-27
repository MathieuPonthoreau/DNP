using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data.SqlClient;
using System.Configuration;
using System.Data;

public partial class Register : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void ButtonRegister_Click(object sender, EventArgs e)
    {
        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["theConnection"].ConnectionString);
        connection.Open();
        //verify data
        SqlCommand speudoUnique = new SqlCommand("select * from [dbo].[User] where pseudo = '" + TextBoxRegisterPseudo.Text + "'", connection);
        if (
            TextBoxRegisterFirstName.Text.Length != 0
            && TextBoxRegisterLastName.Text.Length != 0
            && TextBoxRegisterPassword1.Text.Length != 0
            && TextBoxRegisterPassword2.Text == TextBoxRegisterPassword1.Text
            && TextBoxRegisterPseudo.Text.Length != 0
            && (RadioButtonRegisterMale.Checked || RadioButtonRegisterFemale.Checked)

            )
        {
            //verify if the login is already taken
            SqlDataAdapter dataAdapter = new SqlDataAdapter(speudoUnique);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);

            if (dataTable.Rows.Count == 0)
            {


                string sex;
                if (RadioButtonRegisterMale.Checked)
                {
                    sex = "M";
                }
                else
                {
                    sex = "F";
                }
                //create the user
                SqlCommand registration = new SqlCommand(
                    "insert into [dbo].[User] (firstName, lastName, pseudo, password, sex)values('" + TextBoxRegisterFirstName.Text + "', '" + TextBoxRegisterLastName.Text + "', '" + TextBoxRegisterPseudo.Text + "','" + TextBoxRegisterPassword1.Text + "', '" + sex + "')"
                    , connection);

                SqlDataReader sdr = registration.ExecuteReader();
                
                SqlCommand command = new SqlCommand("select id from [dbo].[User] where pseudo = '" + TextBoxRegisterPseudo.Text + "' and password = '" + TextBoxRegisterPassword1.Text + "'", connection);
                connection.Close();
                connection.Open();

                //log the new user
                int userId = (int)command.ExecuteScalar();
                connection.Close();
                Session["Login"] = userId;
                Response.Redirect("Default.aspx");

            }
            else
            {
                Label1.Visible = true;
                Label1.Text = "This pseudonyme is already taken";
            }
        }
        else
        {
            Label1.Visible = true;
            Label1.Text = "incorect informations";
        }


    }
}