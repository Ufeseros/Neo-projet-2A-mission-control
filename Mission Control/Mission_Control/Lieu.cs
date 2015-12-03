using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mission_Control
{
    class Lieu
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
        public void setx(int x)
        {
            this.x = x;
            
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
    }
}
