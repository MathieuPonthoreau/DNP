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
[WebService(Namespace = "http://tempuri.org/")]
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
    public string HelloWorld()
    {
        return "Hello World";
    }

    [WebMethod]
    public List<string> getUser()
    {
        var liste = new List<string>();
        for (int i = 1; i < 3; i++)
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["theConnection"].ConnectionString);
            connection.Open();
            SqlCommand getName = new SqlCommand("select firstName from [dbo].[User] where id = "+i+"", connection);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(getName);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);

            string firstName = (string)getName.ExecuteScalar();
            liste.Add(firstName);
        }
        return liste;
    }
}
