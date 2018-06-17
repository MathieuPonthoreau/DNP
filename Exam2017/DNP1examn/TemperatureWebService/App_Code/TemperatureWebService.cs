using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using TemperatureConverter;

/// <summary>
/// Description résumée de TemperatureWebService
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// Pour autoriser l'appel de ce service Web depuis un script à l'aide d'ASP.NET AJAX, supprimez les marques de commentaire de la ligne suivante. 
// [System.Web.Script.Services.ScriptService]
public class TemperatureWebService : System.Web.Services.WebService
{
    TemperatureConverter.Converter converter = new Converter();
    public TemperatureWebService()
    {
        //Supprimez les marques de commentaire dans la ligne suivante si vous utilisez des composants conçus 
        //InitializeComponent(); 
    }
    [WebMethod]
    public double ConvertToCelsius(double temperatureF)
    {
        return converter.FtoC(temperatureF);
    }
    [WebMethod]
    public double ConvertToFahrenheit(double temperatureC)
    {
        return converter.CtoF(temperatureC);
    }

}
