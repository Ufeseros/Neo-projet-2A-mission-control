﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.Xml;
using System.IO;

namespace Mission_Control
{
    public partial class Form1 : Form
    {
        Mission M = new Mission(500, "images/nanedi valles.jpg", "Default");
        Timer tempsLocalTerre = new Timer();
        XmlDocument xmlDoc = new XmlDocument();

        public Form1()
        {
            InitializeComponent();
            tempsLocalTerre.Tick += (s, e) => {labelTempsLocal.Text = DateTime.Now.ToString(); };
            tempsLocalTerre.Interval = 333;
            tempsLocalTerre.Start();
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
                node = new TreeNode(conversionHeure(a.getDebut())+" "+a.getLibelle());
                node.Tag = a;
                AfficheActivitée.Nodes.Add(node);
            }
        }

        private void refreshAstronautes()
        {
            afficheAstronautes.Nodes.Clear();

            TreeNode node;

            foreach (Astronaute a in M.getAstronautes())
            {
                node = new TreeNode(a.getNom());
                node.Tag = a;
                afficheAstronautes.Nodes.Add(node);
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


        private void chargerMission_Click(object sender, EventArgs e)
        {
            refreshJours();
        }


        private void sauvegarderMission_Click(object sender, EventArgs e)
        {
            xmlDoc = new XmlDocument();
            saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "XML-File | *.xml";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                
                string nomFichier = Path.GetFileNameWithoutExtension(saveFileDialog1.FileName);
                M.setNom(nomFichier);
                M.genereXml(xmlDoc);
                xmlDoc.Save(saveFileDialog1.FileName);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            refreshJours();
            refreshAstronautes();
        }

        private void ajouterAstronaute_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = true;
        }

        private void confirmationAjoutAstronaute_Click(object sender, EventArgs e)
        {

            M.addAstronaute(textBoxAjoutAstronaute.Text);
            refreshAstronautes();
            groupBox2.Visible = false;
        }
    }
}
