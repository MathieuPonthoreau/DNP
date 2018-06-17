using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void ButtonCtoF_Click(object sender, EventArgs e)
    {
        TemperatureService.TemperatureWebServiceSoapClient temperature =
            new TemperatureService.TemperatureWebServiceSoapClient();
        double result =
            temperature.ConvertToFahrenheit(Convert.ToDouble(TextBoxCtoF.Text));
        LabelResult.Text = result.ToString();
    }

    protected void ButtonFtoC_Click(object sender, EventArgs e)
    {
        TemperatureService.TemperatureWebServiceSoapClient temperature =
            new TemperatureService.TemperatureWebServiceSoapClient();
        double result =
            temperature.ConvertToCelsius(Convert.ToDouble(TextBoxFtoC.Text));
        LabelResult.Text = result.ToString();
    }
}