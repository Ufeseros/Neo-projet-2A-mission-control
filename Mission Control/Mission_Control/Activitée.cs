using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.Xml;


namespace Mission_Control
{
    public class Activitée
    {
        private string categorie;
        private string libelle;
        private int tempsdébut;         //  exprimé en minutes
        private int tempsfin;           // exprimé en minutes
        private int numJour;
        private Lieu lieu;
        private List<Astronaute> participants;

        public Activitée()
        {
            categorie = "Living";
            libelle = "Private";
            tempsdébut = 0;
            tempsfin = 0;
            numJour = 1;
            lieu = new Lieu(0,0,"default");
            participants = new List<Astronaute>();
        }

        public Activitée(string categorie, string libelle, int tempsdébut, int tempsfin, int numJour)
        {
            this.categorie = categorie;
            this.libelle = libelle;
            this.tempsdébut = tempsdébut;
            this.tempsfin = tempsfin;
            this.numJour = numJour;

            lieu = new Lieu(0, 0, "default");    // temporaire

            participants = new List<Astronaute>();
        }

        public string getLibelle()
        {
            return libelle;
        }

        public string getCategorie()
        {
            return categorie;
        }

        public int getDebut()
        {
            return tempsdébut;
        }

        public int getFin()
        {
            return tempsfin;
        }

        public Lieu getLieu()
        {
            return lieu;
        }
        public void setCoord(int x, int y)
        {
            this.lieu.setx(x);
            this.lieu.sety(y);
            
        }

        // generation xml
        public void genereXml(XmlDocument xmlDoc, XmlNode rootNode)
        {

            XmlNode nodeActivitee = xmlDoc.CreateElement("Activitee");

            XmlNode nodeCategorie = xmlDoc.CreateElement("Categorie");
            nodeCategorie.InnerText = categorie;
            nodeActivitee.AppendChild(nodeCategorie);

            XmlNode nodeLibelle = xmlDoc.CreateElement("Libelle");
            nodeLibelle.InnerText = categorie;
            nodeActivitee.AppendChild(nodeLibelle);

            XmlNode nodeDebut = xmlDoc.CreateElement("HeureDebut");
            nodeDebut.InnerText = tempsdébut.ToString();
            nodeActivitee.AppendChild(nodeDebut);

            XmlNode nodeFin = xmlDoc.CreateElement("HeureFin");
            nodeFin.InnerText = tempsfin.ToString();
            nodeActivitee.AppendChild(nodeFin);

            XmlNode nodeNumJour = xmlDoc.CreateElement("NumJour");
            nodeNumJour.InnerText = numJour.ToString();
            nodeActivitee.AppendChild(nodeNumJour);

            lieu.genereXml(xmlDoc, nodeActivitee);

            XmlNode nodeListeAstronaute = xmlDoc.CreateElement("ListeAstronaute");

            /*          
            foreach (Astronaute as in paritcipants)
            {
                as.genereXml(xmlDoc, NodeListeJours);
            }
            */

            nodeActivitee.AppendChild(nodeListeAstronaute);
            rootNode.AppendChild(nodeActivitee);
        }


    }
}
