using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.Xml;

namespace Mission_Control
{
    public class Carte
    {
        private string image;
        private int echelle;
        private int pixel_x;
        private int pixel_y;
        private List<Lieu> liste_lieux;

        //Constructeurs

        public Carte(string image)
        {
            this.image = image;
            echelle = 5;
            pixel_x = 195;
            pixel_y = 295;
            liste_lieux= new List<Lieu>() ;
            liste_lieux.Add(new Lieu());
        }

        public Carte(int echelle,string image,int pixel_x, int pixel_y)
        {
            this.image = image;
            this.echelle = echelle;
            this.pixel_x = pixel_x;
            this.pixel_y = pixel_y;
            liste_lieux = new List<Lieu>();
        }

        //Accesseurs
        public List<Lieu> getLieux()
        {
            return liste_lieux;
        }

        public int getPixel_x()
        {
            return pixel_x;
        }
        public int getPixel_y()
        {
            return pixel_y;
        }
        public int getEchelle()
        {
            return echelle;
        }
        //Ajout d'un lieu
        public void addLieu(Lieu lieu)
        {
            liste_lieux.Add(lieu);
        }

        public void genereXml(XmlDocument xmlDoc, XmlNode rootNode)
        {
            XmlNode nodeCarte = xmlDoc.CreateElement("Carte");

            XmlNode nodeImage = xmlDoc.CreateElement("Image");
            nodeImage.InnerText = image;
            nodeCarte.AppendChild(nodeImage);


            XmlNode nodeEchelle = xmlDoc.CreateElement("Echelle");
            nodeEchelle.InnerText = echelle.ToString();
            nodeCarte.AppendChild(nodeEchelle);

            XmlNode nodeX = xmlDoc.CreateElement("x");
            nodeX.InnerText = pixel_x.ToString();
            nodeCarte.AppendChild(nodeX);

            XmlNode nodeY = xmlDoc.CreateElement("y");
            nodeY.InnerText = pixel_y.ToString();
            nodeCarte.AppendChild(nodeY);


            XmlNode nodeListeLieux = xmlDoc.CreateElement("ListeLieux");    

            foreach (Lieu l in liste_lieux)
            {
                l.genereXml(xmlDoc, nodeListeLieux);
            }
            nodeCarte.AppendChild(nodeListeLieux);
            
            rootNode.AppendChild(nodeCarte);
        }

        static
        public Carte chargerXml(XmlNode rootNode)
        {
            XmlNode nodeCarte = rootNode;

             string tmp_image = nodeCarte.SelectSingleNode("Image").InnerText;
             int tmp_echelle = int.Parse(nodeCarte.SelectSingleNode("Echelle").InnerText);
             int tmp_x = int.Parse(nodeCarte.SelectSingleNode("x").InnerText);
             int tmp_y = int.Parse(nodeCarte.SelectSingleNode("y").InnerText);
             List<Lieu> tmp_lieux = new List<Lieu>();

             XmlNode nodeLesLieux = nodeCarte.SelectSingleNode("ListeLieux");
             foreach (XmlNode nodeLieu in nodeLesLieux.SelectNodes("Lieu"))
             {
                    tmp_lieux.Add(Lieu.ChargerXml(nodeLieu));
             }
            
            Carte result = new Carte(tmp_echelle,tmp_image,tmp_x,tmp_y);
            foreach(Lieu l in tmp_lieux){
                result.addLieu(l);
            }

            return result;
        }

    }
}
