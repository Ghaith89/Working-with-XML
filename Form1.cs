using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace XMLSchreiber
{
    public partial class Form1 : Form
    {
        string xmlDateiname;
        public Form1()
        {
            InitializeComponent();
            xmlDateiname = System.IO.Path.ChangeExtension(Application.ExecutablePath, ".xml");
        }

        private void Übernehmen_button1_Click(object sender, EventArgs e)
        {
            EingabeFeld.Items.Add(textBox1.Text);
            textBox1.Clear();
        }

        private void Speichern_button2_Click(object sender, EventArgs e)
        {
            XMLSchreiben();
        }

        void XMLSchreiben()
        {
            XmlWriterSettings Einstellungen = new XmlWriterSettings();
            Einstellungen.Indent = true ;

            int NumEingaben = EingabeFeld.Items.Count;

            //eine Instanz von XMLwriter erstellen
            XmlWriter XMLschreiber = XmlWriter.Create(xmlDateiname, Einstellungen);

            XMLschreiber.WriteStartDocument();
            XMLschreiber.WriteStartElement("HauptEintrag");
            for (int i=0; i< NumEingaben; i++)
            {
                XMLschreiber.WriteStartElement("eintrag");
                XMLschreiber.WriteElementString("name", Convert.ToString(EingabeFeld.Items[i]));
                XMLschreiber.WriteEndElement();
            }
            XMLschreiber.WriteEndElement();
            XMLschreiber.WriteEndDocument();
            XMLschreiber.Close();

        }
    }
}
