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

        public Mission(int Durée, string nom, Carte carte, int TempsMission, List<Jour> jours, List<Astronaute> astronautes){
            this.Durée = Durée;
            this.nom = nom;
            this.carte = carte;
            this.TempsMission = TempsMission;
            this.jours = jours;
            this.astronautes = astronautes;
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

            // temps Mission

            XmlNode nodeTemps = xmlDoc.CreateElement("Temps");
            nodeTemps.InnerText = TempsMission.ToString();
            nodeMission.AppendChild(nodeTemps);


            // Carte mission
            carte.genereXml(xmlDoc, nodeMission);


            // astronautes

            XmlNode nodeListeAstronaute = xmlDoc.CreateElement("ListeAstronaute");
            foreach (Astronaute astro in astronautes)
            {
                astro.genereXml(xmlDoc, nodeListeAstronaute);
            }
            nodeMission.AppendChild(nodeListeAstronaute);


            // Jours

            XmlNode nodeListeJours= xmlDoc.CreateElement("ListeJour");

            foreach (Jour j in jours)
            {
                j.genereXml(xmlDoc, nodeListeJours);
            }
            nodeMission.AppendChild(nodeListeJours);


        }

        static
        public Mission chargerXml(XmlDocument xmlDoc )
        {
    
                XmlNode nodeMission = xmlDoc.SelectSingleNode("Mission");

                     int tmp_duree_mission = int.Parse(nodeMission.SelectSingleNode("Duree").InnerText);
                     string tmp_nom_mission = nodeMission.SelectSingleNode("Nom").InnerText;
                     Carte tmp_carte = Carte.chargerXml(nodeMission.SelectSingleNode("Carte"));

                     int tmp_temps_mission = int.Parse(nodeMission.SelectSingleNode("Temps").InnerText);


                     List<Jour> tmp_listeJour = new List<Jour>();
                     XmlNode nodeListeJour = nodeMission.SelectSingleNode("ListeJour");
                     foreach (XmlNode nodeJour in  nodeListeJour.SelectNodes("Jour"))
                     {
                        tmp_listeJour.Add(Jour.chargerXml(nodeJour));
                     }

                     List<Astronaute> tmp_listeAstronaute = new List<Astronaute>();
                     XmlNode nodeListeAstronaute = nodeMission.SelectSingleNode("ListeAstronaute");
                     foreach (XmlNode nodeAstronaute in nodeListeJour.SelectNodes("Astronaute"))
                     {
                         tmp_listeAstronaute.Add(Astronaute.chargerXml(nodeAstronaute));
                     }

                      Mission result = new Mission(tmp_duree_mission,tmp_nom_mission,tmp_carte,tmp_temps_mission,tmp_listeJour,tmp_listeAstronaute);
                      return result;

                 }
    
        }
    }

