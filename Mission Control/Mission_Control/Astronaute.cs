using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.Xml;

namespace Mission_Control
{
    public class Astronaute
    {
        private string nom;

        public Astronaute(string nom)
        {
            this.nom = nom;
        }

        public string getNom(){
        return nom;
        }


        public void genereXml(XmlDocument xmlDoc, XmlNode rootNode)
        {
            XmlNode nodeAstronaute = xmlDoc.CreateElement("Astronaute");

            XmlNode nodeNom = xmlDoc.CreateElement("nom");
            nodeNom.InnerText = nom.ToString();
            nodeAstronaute.AppendChild(nodeNom);

            rootNode.AppendChild(nodeAstronaute);
        }

        static
        public Astronaute chargerXml(XmlNode rootNode)
        {
            XmlNode nodeAstronaute = rootNode;

            string tmp_nom = nodeAstronaute.SelectSingleNode("nom").InnerText;

            Astronaute result = new Astronaute(tmp_nom);
            return result;
        }
    }
}
