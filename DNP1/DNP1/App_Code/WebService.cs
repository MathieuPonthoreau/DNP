using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;

[WebService(Namespace = "http://exemple.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]

public class WebService : System.Web.Services.WebService
{

    public WebService()
    {
        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
    }

    [WebMethod]
    //Generate xml file from User data
    public List<string> getUser()
    {
        var liste = new List<string>();
        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["theConnection"].ConnectionString);
        connection.Open();
        SqlCommand getNumber = new SqlCommand("select MAX(id) from [dbo].[User] ", connection);
        int totalUser = (int)getNumber.ExecuteScalar();

        for (int i = 0; i <= totalUser; i++)
        {
            //Get First name
            SqlCommand getFirstName = new SqlCommand("select firstName from [dbo].[User] where id = " + i + "", connection);
            string firstName = (string)getFirstName.ExecuteScalar();
            if (firstName != null)
            {
                liste.Add("First name : "+firstName);
            }
            //Get Last name
            SqlCommand getName = new SqlCommand("select lastName from [dbo].[User] where id = " + i + "", connection);
            string lastName = (string)getName.ExecuteScalar();
            if (lastName != null)
            {
                liste.Add("Last name : "+lastName);
            }
            //Get Pseudonyme
            SqlCommand getPseudo = new SqlCommand("select pseudo from [dbo].[User] where id = " + i + "", connection);
            string pseudo = (string)getPseudo.ExecuteScalar();
            if (pseudo != null)
            {
                liste.Add("Pseudonyme : "+pseudo);
            }
        }
        connection.Close();
        return liste;
    }
}
