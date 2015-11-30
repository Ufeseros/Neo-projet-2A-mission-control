using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mission_Control
{
    class Activitée
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
    }
}
