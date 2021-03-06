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
        Timer temps = new Timer();
        XmlDocument xmlDoc = new XmlDocument();

        public Form1()
        {
            InitializeComponent();
            temps.Tick += (s, e) => { labelTempsLocal.Text = DateTime.Now.ToString();
                                      M.incrTemps();
                                      labelTempsLocalMars.Text = ConversionTempsLocalMars(M.getTemps());                                 
                                                                                    };
            temps.Interval = 1000;
            temps.Start();
        }

        public Mission getMission()
        {
            return M;
        }

        private void refreshJours()
        {
            AfficheJours.Nodes.Clear();

            TreeNode node;

            foreach (Jour j in M.getJours())
            {
                node = new TreeNode("Jour " + (j.getNum()).ToString());
                node.Tag = j;

                if (M.getTemps() > 88800 * j.getNum())
                {
                    node.BackColor = Color.Gray;
                    node.ForeColor = Color.White;
                }
                else if (M.getTemps() <= 88800 * j.getNum() && M.getTemps() >= 88800 * (j.getNum() - 1))
                {
                    node.BackColor = Color.Blue;
                    node.ForeColor = Color.White;
                }
                else 
                {
                    node.BackColor = Color.Green;
                    node.ForeColor = Color.White;
                }

                if (j.contientSortie())
                {
                    node.StateImageIndex = 0;
                }
                AfficheJours.Nodes.Add(node);
            }
        }

        public void refreshActivitée(Jour j)
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
            Jour j = getJourSelectione();

            refreshActivitée(j);

            if (j.getNum() > getMission().getTemps() / 88800)
            {
                boutonAjoutActivitée.Enabled = true;
            }
            else
            {
                boutonAjoutActivitée.Enabled = false;
            }

            bouttonSupprimerActivitée.Enabled = false;
            groupBoxActivitée.Visible = false;
            richTextBox1.Text = getJourSelectione().getCompteRendu();
            labelJournum.Text = "Jour " + getJourSelectione().getNum();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form map = new FormCarte(this);
            map.Show();
        }

        private void Activitee_jour_AfterSelect(object sender, TreeViewEventArgs e)
        {


            if (getJourSelectione().getNum() > getMission().getTemps() / 88800)
            {
                bouttonSupprimerActivitée.Enabled = true;
            }
            else
            {
                bouttonSupprimerActivitée.Enabled = false;
            }

            groupBoxActivitée.Visible = true;
            Activitée a = (Activitée)AfficheActivitée.SelectedNode.Tag;

            LabelLibelleActivitee.Text = a.getLibelle();
            LabelCategorieActivitee.Text = a.getCategorie();
            labelHeureDebut.Text = conversionHeure(a.getDebut());
            labelHeureFin.Text = conversionHeure(a.getFin());
            labelLieu.Text = a.getLieu().getNom();

            treeViewAstronauteActivitée.Nodes.Clear();
            foreach (Astronaute astro in a.getListeAstronaute())
            {
                TreeNode node = new TreeNode(astro.getNom());
                node.Tag = astro;
                treeViewAstronauteActivitée.Nodes.Add(node);
            }




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

        private string ConversionTempsLocalMars(int temps)
        {
            int jours = (int)Math.Truncate((double)temps / 88800);
            int minutes = (temps - jours * 88800) / 60;
            int sec = temps - jours * 88800 - minutes * 60;

            if(sec>10)
            return "Day " + (jours+1) + " - " + conversionHeure(minutes) +":" + sec;
            else
            return "Day " + (jours + 1) + " - " + conversionHeure(minutes) + ":0" + sec;        
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

                Jour j = (Jour)AfficheJours.SelectedNode.Tag;
                refreshActivitée(j);
                
            }
            AfficheJours.Focus();
        }


        private void chargerMission_Click(object sender, EventArgs e)
        {

            openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "XML-File | *.xml";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                xmlDoc = new XmlDocument();
                xmlDoc.Load(openFileDialog1.FileName);
                M = Mission.chargerXml(xmlDoc);
            }
            refreshJours();
            refreshAstronautes();
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

        private void boutonAjoutActivitée_Click(object sender, EventArgs e)
        {
            Form nouvelleActivitee = new FormAjoutActivite(this);
            nouvelleActivitee.Show();
        }

        public Jour getJourSelectione()
        {
            return (Jour)AfficheJours.SelectedNode.Tag;
        }

        private void bouttonSupprimerActivitée_Click(object sender, EventArgs e)
        {
            getJourSelectione().supprimeActivitée((Activitée)AfficheActivitée.SelectedNode.Tag);
            refreshActivitée(getJourSelectione());
            bouttonSupprimerActivitée.Enabled = false;
            groupBoxActivitée.Visible = false;
        }

        private void buttonRefreshJour_Click(object sender, EventArgs e)
        {
            refreshJours();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            getJourSelectione().setCompteRendu(richTextBox1.Text);
        }
    }
}
