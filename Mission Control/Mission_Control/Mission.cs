using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.Xml;

namespace Mission_Control
{
    class Mission
    {
        private int Durée;
        private string carte;
        private string nom;
        private List<Jour> jours;
        private List<Astronaute> astronautes;

        public Mission(int Durée, string carte, string nom)
        {
            this.Durée = Durée;
            this.carte = carte;
            this.nom = nom;
            jours = new List<Jour>();
            astronautes = new List<Astronaute>();
            for (int i = 1; i <= Durée; i++)
            {
                jours.Add(new Jour(i));
            }
        }

        public List<Jour> getJours(){
            return jours;
        }

        public Jour getJouri(int i)
        {
            foreach (Jour j in jours)
            {
                if (j.getNum() == i)
                    return j;
            }
            return jours.First();
        }

        public void setNom(string nom)
        {
            this.nom = nom;
        }

        public void addAstronaute(string nom)
        {
           astronautes.Add(new Astronaute(nom));
        }

        public List<Astronaute> getAstronautes()
        {
            return astronautes;
        }

        public void genereXml(XmlDocument xmlDoc)
        {
            XmlNode nodeMission = xmlDoc.CreateElement("Mission");
            xmlDoc.AppendChild(nodeMission);

            // durée mission
            XmlNode nodeDuree = xmlDoc.CreateElement("Duree");
            nodeDuree.InnerText = Durée.ToString();
            nodeMission.AppendChild(nodeDuree);

            // nom mission
            XmlNode nodeNom = xmlDoc.CreateElement("Nom");
            nodeNom.InnerText = nom;
            nodeMission.AppendChild(nodeNom);

            // Carte mission
            XmlNode nodeCarte = xmlDoc.CreateElement("Carte");
            nodeCarte.InnerText = carte;
            nodeMission.AppendChild(nodeCarte);

            // Jours

            XmlNode nodeListeJours= xmlDoc.CreateElement("ListeJour");

           
            foreach (Jour j in jours)
            {
                j.genereXml(xmlDoc, nodeListeJours);
            }
           

            nodeMission.AppendChild(nodeListeJours);

        }
    }
}
