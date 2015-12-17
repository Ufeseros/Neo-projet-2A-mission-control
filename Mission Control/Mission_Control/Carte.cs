using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
            liste_lieux.Add(new Lieu());
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

    }
}
