using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.Xml;

namespace Mission_Control
{
    public class Lieu
    {
        private int x;
        private int y;
        private string nom;

        public Lieu()
        {
            this.x =0;
            this.y = 0;
            this.nom = "base";
        }

        public Lieu(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public Lieu(int x, int y, string nom)
        {
            this.x = x;
            this.y = y;
            this.nom = nom;
        }

        public void setNom(string nom)
        {
            this.nom = nom;
        }

        public string getNom()
        {
            return nom;
        }

        public int getx()
        {
            return x ;
        }
        public void setx(int x)
        {
            this.x = x;
            
        }
        public int gety()
        {
            return y;
        }
        public void sety(int y)
        {
            this.y = y;

        }
        public override string ToString()
        {
            string textCoord=String.Format("Coordonnées: {0},{1}",x,y);
            return textCoord;
        }

        public void genereXml(XmlDocument xmlDoc, XmlNode rootNode)
        {
            XmlNode nodeLieu = xmlDoc.CreateElement("Lieu");

            XmlNode nodeX = xmlDoc.CreateElement("x");
            nodeX.InnerText = x.ToString();
            nodeLieu.AppendChild(nodeX);

            XmlNode nodeY = xmlDoc.CreateElement("y");
            nodeY.InnerText = y.ToString();
            nodeLieu.AppendChild(nodeY);

            XmlNode nodeNomLieu = xmlDoc.CreateElement("nom");
            nodeNomLieu.InnerText = nom;
            nodeLieu.AppendChild(nodeNomLieu);

            rootNode.AppendChild(nodeLieu);
        }

        // Le root node doit toujours etre le node "lieu" 
        static
        public Lieu ChargerXml(XmlNode rootNode)
        {

            XmlNode nodeLieu = rootNode;

            int tmp_x = int.Parse(nodeLieu.SelectSingleNode("x").InnerText);
            int tmp_y = int.Parse(nodeLieu.SelectSingleNode("y").InnerText);
            string tmp_nom = nodeLieu.SelectSingleNode("nom").InnerText;
            

            Lieu result = new Lieu(tmp_x,tmp_y,tmp_nom);
            return result;
        }
    }
}
