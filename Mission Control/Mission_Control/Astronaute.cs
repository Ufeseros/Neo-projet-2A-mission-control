using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mission_Control
{
    class Astronaute
    {
        private string nom;

        public Astronaute(string nom)
        {
            this.nom = nom;
        }

        public string getNom(){
        return nom;
        }
    }
}
