using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data.SqlClient;
using System.Configuration;

public partial class Register : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void ButtonRegister_Click(object sender, EventArgs e)
    {
        
        if(
            TextBoxRegisterFirstName.Text.Length != 0 
            && TextBoxRegisterLastName.Text.Length != 0 
            && TextBoxRegisterPassword1.Text.Length != 0 
            && TextBoxRegisterPassword2.Text == TextBoxRegisterPassword1.Text 
            && TextBoxRegisterPseudo.Text.Length != 0
            &&(RadioButtonRegisterMale.Checked || RadioButtonRegisterFemale.Checked)
            )
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["theConnection"].ConnectionString);
            connection.Open();
            string sex;
            if (RadioButtonRegisterMale.Checked)
            {
                sex = "M";
            }
            else
            {
                sex = "F";
            }

            SqlCommand registration = new SqlCommand(
                "insert into [dbo].[User] (firstName, lastName, pseudo, password, sex)values('"+ TextBoxRegisterFirstName.Text + "', '"+ TextBoxRegisterLastName.Text + "', '" + TextBoxRegisterPseudo.Text + "','" + TextBoxRegisterPassword1.Text + "', '"+sex+"')"
                , connection);

            SqlDataReader sdr = registration.ExecuteReader();

            Label1.Visible = true;
            Label1.Text = "informations save";
        }
        else
        {
            Label1.Visible = true;
            Label1.Text = "incorect informations";
        }
        
         
    }
}