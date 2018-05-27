using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;

/// <summary>
/// Summary description for WebService
/// </summary>
[WebService(Namespace = "http://exemple.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]
public class WebService : System.Web.Services.WebService
{

    public WebService()
    {

        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
    }

    [WebMethod]
    public List<string> getUser()
    {
        var liste = new List<string>();
        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["theConnection"].ConnectionString);
        connection.Open();
        SqlCommand getNumber = new SqlCommand("select MAX(id) from [dbo].[User] ", connection);


        int totalUser = (int)getNumber.ExecuteScalar();

        for (int i = 0; i <= totalUser; i++)
        {


            

            SqlCommand getFirstName = new SqlCommand("select firstName from [dbo].[User] where id = " + i + "", connection);

            string firstName = (string)getFirstName.ExecuteScalar();
            if (firstName != null)
            {
                liste.Add("First name : "+firstName);
            }

            SqlCommand getName = new SqlCommand("select lastName from [dbo].[User] where id = " + i + "", connection);

            string lastName = (string)getName.ExecuteScalar();
            if (lastName != null)
            {
                liste.Add("Last name : "+lastName);
            }

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
