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
        Timer tempsLocalTerre = new Timer();

        public Form1()
        {
            InitializeComponent();
            tempsLocalTerre.Tick += (s, e) => {labelTempsLocal.Text = DateTime.Now.ToString(); };
            tempsLocalTerre.Interval = 333;
            tempsLocalTerre.Start();
        }

        private void chargerMission_Click(object sender, EventArgs e)
        {
           M = new Mission(500, "images/nanedi valles.jpg", "Mission test");
           refreshJours();
        }


        private void refreshJours()
        {
            AfficheJours.Nodes.Clear();

            TreeNode node;

            foreach (Jour j in M.getJours())
            {
                node = new TreeNode("Jour " + (j.getNum()).ToString());
                node.Tag = j;
                AfficheJours.Nodes.Add(node);
            }
        }

        private void refreshActivitée(Jour j)
        {

            AfficheActivitée.Nodes.Clear();

            TreeNode node;

            foreach (Activitée a in j.getActivitées())
            {
                node = new TreeNode(a.getLibelle());
                node.Tag = a;
                AfficheActivitée.Nodes.Add(node);
 
            }
        }

        private void AfficheJours_AfterSelect(object sender, TreeViewEventArgs e)
        {
            Jour j = (Jour)AfficheJours.SelectedNode.Tag;

            refreshActivitée(j);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form map = new FormCarte();
            map.Show();
        }

        private void Activitee_jour_AfterSelect(object sender, TreeViewEventArgs e)
        {
            groupBox1.Visible = true;
            Activitée a = (Activitée)AfficheActivitée.SelectedNode.Tag;

            LabelLibelleActivitee.Text = a.getLibelle();
            LabelCategorieActivitee.Text = a.getCategorie();
            labelHeureDebut.Text = conversionHeure(a.getDebut());
            labelHeureFin.Text = conversionHeure(a.getFin());
            labelLieu.Text = a.getLieu().getNom();
        }

        private string conversionHeure(int temps)
        {
            int heures = (int)Math.Truncate((double)temps/60);
            int minutes = temps - heures * 60;
            string result;

            if(heures < 10 && minutes < 10)
                result = "0"+heures + "h0" + minutes;
            else if(heures > 10 && minutes < 10)
                result = heures + "h0" + minutes;
            else if (heures < 10 && minutes > 10)
                result = "0" + heures + "h" + minutes;
            else
                result = heures + "h" + minutes;

            return result;

        }


        private void AfficheJours_EnabledChanged(object sender, EventArgs e)
        {
         
        }

        private void jourPrec_Click(object sender, EventArgs e)
        {
            if (AfficheJours.SelectedNode.PrevNode != null)
            {
                AfficheJours.SelectedNode = AfficheJours.SelectedNode.PrevNode;

                Jour j = (Jour)AfficheJours.SelectedNode.Tag;
                refreshActivitée(j);
               
            }
            AfficheJours.Focus();
        }

        private void jourSuiv_Click(object sender, EventArgs e)
        {
            if (AfficheJours.SelectedNode.NextNode!= null)
            {
                AfficheJours.SelectedNode = AfficheJours.SelectedNode.NextNode;

                int num = int.Parse(AfficheJours.SelectedNode.Text);

                Jour j = (Jour)AfficheJours.SelectedNode.Tag;
                refreshActivitée(j);
                
            }
            AfficheJours.Focus();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

    }
}
