using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Mission_Control
{
    public partial class Form1 : Form
    {
        Mission  M = new Mission(500, "images/nanedi valles.jpg", "Mission test");

        public Form1()
        {
            InitializeComponent();
        }

        private void chargerMission_Click(object sender, EventArgs e)
        {
           M = new Mission(500, "images/nanedi valles.jpg", "Mission test");
           refreshJours();
        }


        public void refreshJours()
        {
            foreach (Jour j in M.getJours())
            {
                AfficheJours.Nodes.Add(("Jour " + j.getNum()).ToString());
            }
        }

        private void AfficheJours_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form map = new FormCarte();
            map.Show();
        }

    }
}
