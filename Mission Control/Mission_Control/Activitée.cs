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

        public Activitée(string categorie, string libelle, int tempsdébut, int tempsfin, int numJour, Lieu lieu)
        {
            this.categorie = categorie;
            this.libelle = libelle;
            this.tempsdébut = tempsdébut;
            this.tempsfin = tempsfin;
            this.numJour = numJour;
            this.lieu = lieu;


            participants = new List<Astronaute>();
        }

        public string getLibelle()
        {
            return libelle;
        }
        public void setLibelle(string libelle)
        {
            this.libelle = libelle;
        }
        public string getCategorie()
        {
            return categorie;
        }
        public void setCategorie(string categorie)
        {
            this.categorie = categorie;
        }
        public int getDebut()
        {
            return tempsdébut;
        }
        public void setDebut(int tempsdébut)
        {
            this.tempsdébut = tempsdébut;
        }

        public int getFin()
        {
            return tempsfin;
        }
        public void setFin(int tempsfin)
        {
            this.tempsfin = tempsfin;
        }

        public int getNumJour()
        {
            return numJour;
        }

        public void setNumJour(int numJour)
        {
            this.numJour=numJour;
        }

        public Lieu getLieu()
        {
            return lieu;
        }
        public void setLieu(Lieu lieu)
        {
            this.lieu = lieu;
        }

        public List<Astronaute> getListeAstronaute()
        {
            return participants;
        }
        public void addParticipant(Astronaute astronaute)
        {
            participants.Add(astronaute);

        }

        // generation xml
        public void genereXml(XmlDocument xmlDoc, XmlNode rootNode)
        {

            XmlNode nodeActivitee = xmlDoc.CreateElement("Activitee");

            XmlNode nodeCategorie = xmlDoc.CreateElement("Categorie");
            nodeCategorie.InnerText = categorie;
            nodeActivitee.AppendChild(nodeCategorie);

            XmlNode nodeLibelle = xmlDoc.CreateElement("Libelle");
            nodeLibelle.InnerText = libelle;
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

                 
            foreach (Astronaute astro in participants)
            {
                astro.genereXml(xmlDoc, nodeListeAstronaute);
            }
           

            nodeActivitee.AppendChild(nodeListeAstronaute);
            rootNode.AppendChild(nodeActivitee);
        }

        static
        public Activitée chargerXml(XmlNode rootNode)
        {
            XmlNode nodeActivitée = rootNode;

            string tmp_categorie = nodeActivitée.SelectSingleNode("Categorie").InnerText;
            string tmp_libelle = nodeActivitée.SelectSingleNode("Libelle").InnerText;
            int tmp_tempsdébut = int.Parse(nodeActivitée.SelectSingleNode("HeureDebut").InnerText);
            int tmp_tempsfin = int.Parse(nodeActivitée.SelectSingleNode("HeureFin").InnerText);
            int tmp_numJour = int.Parse(nodeActivitée.SelectSingleNode("NumJour").InnerText);
            Lieu tmp_lieu = Lieu.ChargerXml(nodeActivitée.SelectSingleNode("Lieu"));

        List<Astronaute> tmp_participants = new List<Astronaute>();

        XmlNode nodeLesAstronautes = nodeActivitée.SelectSingleNode("ListeAstronaute");

        foreach (XmlNode nodeAstro in nodeLesAstronautes.SelectNodes("Astronaute"))
        {
            tmp_participants.Add(Astronaute.chargerXml(nodeAstro));
        }

        Activitée result = new Activitée(tmp_categorie, tmp_libelle, tmp_tempsdébut, tmp_tempsfin, tmp_numJour, tmp_lieu);
        foreach (Astronaute a in tmp_participants)
        {
            result.addParticipant(a);
        }


        return result;

        }


    }
}
