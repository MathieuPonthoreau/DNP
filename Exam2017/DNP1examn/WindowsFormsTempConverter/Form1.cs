using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TemperatureConverter;
using System.Xml;

namespace WindowsFormsTempConverter
{
    public partial class Form1 : Form
    {
        TemperatureConverter.Converter converter = new Converter();
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCtoF_Click(object sender, EventArgs e)
        {
            double temp = double.Parse(textBoxTemp.Text);
            double tempconvert = converter.CtoF(temp);
            labelResult.Text = tempconvert.ToString();
            listBoxResult.Items.Add(tempconvert + " C = " + temp + " F");
        }

        private void buttonFtoC_Click(object sender, EventArgs e)
        {
            double temp = double.Parse(textBoxTemp.Text);
            double tempconvert = converter.FtoC(temp);
            labelResult.Text = tempconvert.ToString();
            listBoxResult.Items.Add(tempconvert + " F = "+ temp + " C");
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Xml saved in ..\DNP1examn\WindowsFormsConvert\bin\Debug\savefile.xml
            XmlTextWriter xwWriter = new XmlTextWriter("savefile.xml", Encoding.Unicode);
            xwWriter.WriteStartDocument();
            xwWriter.WriteStartElement("temperatures");
            foreach (String item in listBoxResult.Items)
            {
                xwWriter.WriteStartElement("temp");
                xwWriter.WriteString(item);
                xwWriter.WriteEndElement();
            }
            xwWriter.WriteEndElement();
            xwWriter.WriteEndDocument();
            xwWriter.Close();
        }
    }
}
