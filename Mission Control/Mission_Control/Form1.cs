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
        Mission  M = new Mission(500, "images/nanedi valles.jpg", "Default");

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
                AfficheJours.Nodes.Add((j.getNum()).ToString());
            }
        }

        public void refreshActivitée(int numJour)
        {

            AfficheActivitée.Nodes.Clear();

            foreach (Activitée a in M.getJouri(numJour).getActivitées())
            {
                AfficheActivitée.Nodes.Add(a.getLibelle());
            }
        }

        private void AfficheJours_AfterSelect(object sender, TreeViewEventArgs e)
        {
            int num = int.Parse(AfficheJours.SelectedNode.Text);

            refreshActivitée(num);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form map = new FormCarte();
            map.Show();
        }

        private void Activitee_jour_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void AfficheJours_EnabledChanged(object sender, EventArgs e)
        {
         
        }

        private void jourPrec_Click(object sender, EventArgs e)
        {

        }

        private void jourSuiv_Click(object sender, EventArgs e)
        {

        }

    }
}
