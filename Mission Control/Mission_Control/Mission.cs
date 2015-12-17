using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.Xml;

namespace Mission_Control
{
    public class Mission
    {
        private int Durée;
        private Carte carte;
        private string nom;
        private List<Jour> jours;
        private List<Astronaute> astronautes;
        private int TempsMission;


        public Mission(int Durée, string image, string nom)
        {
            this.Durée = Durée;
            this.carte = new Carte(image);
            this.nom = nom;
            jours = new List<Jour>();
            astronautes = new List<Astronaute>();
            for (int i = 1; i <= Durée; i++)
            {
                jours.Add(new Jour(i));
            }

            TempsMission = 88780;
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

        public void incrTemps()
        {
            TempsMission++;
        }

        public int getTemps()
        {
            return TempsMission;
        }

        public List<Astronaute> getAstronautes()
        {
            return astronautes;
        }
        public Carte getCarte()
        {
            return carte;
        }



        //XML
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
            //XmlNode nodeCarte = xmlDoc.CreateElement("Carte");
            //nodeCarte.InnerText = carte;
            //nodeMission.AppendChild(nodeCarte);

            // Jours

            XmlNode nodeListeJours= xmlDoc.CreateElement("ListeJour");

            // temps Mission

            XmlNode nodeTemps = xmlDoc.CreateElement("Temps");
            nodeTemps.InnerText = TempsMission.ToString();
            nodeMission.AppendChild(nodeTemps);

           
            foreach (Jour j in jours)
            {
                j.genereXml(xmlDoc, nodeListeJours);
            }
           

            nodeMission.AppendChild(nodeListeJours);

        }

        public void chargerXml(XmlDocument xmlDoc )
        {

     // on recupere une liste de noeud "Mission"
                 XmlNodeList nodelistMissions =  xmlDoc.GetElementsByTagName("Mission");
                 foreach (XmlNode nodeMission in nodelistMissions)
                 {
                     int duree_mission = int.Parse(nodeMission.SelectSingleNode("Duree").InnerText);
                     this.Durée = duree_mission;

                     string nom_mission = nodeMission.SelectSingleNode("Nom").InnerText;
                     this.nom = nom_mission;

                     //string carte_mission = nodeMission.SelectSingleNode("Carte").InnerText;
                     //this.carte = carte_mission;

                     int temps_mission = int.Parse(nodeMission.SelectSingleNode("Temps").InnerText);
                     this.TempsMission = temps_mission;

                     // TO DO : 
                     // Modification du temps mission selon le temps ou l'application n'as pas été allumée
                     // il faudra garder la date de la derniere save et comparer avec le temps local

                     // Jour.chargerXml ; 


                 }
        
        }
    }
}
