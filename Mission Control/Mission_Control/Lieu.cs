﻿using System;
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

        public void setNom(string nom)
        {
            this.nom = nom;
        }
        
    }
}
