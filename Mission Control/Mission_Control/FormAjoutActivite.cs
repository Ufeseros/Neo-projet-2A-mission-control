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
    public partial class FormAjoutActivite : Form
    {
        Activitée acti_temp = new Activitée();
        Lieu lieu_temp = new Lieu();
       // List<string> listeDesCategories;
        //List<string> listeDesLibelle;
        Form1 Parent;


        public FormAjoutActivite(Form1 Parent)
        {
            InitializeComponent();
            this.Parent = Parent;

            foreach (string s in valeursListes.listeCategories)
            {
                comboBoxCategorie.Items.Add(s);
            }

            for (int i = 0; i <= 24; i++)
            {
                comboBoxHD_H.Items.Add(i);
                comboBoxHF_H.Items.Add(i);
            }

            for (int i = 0; i <60; i+=10)
            {
                comboBoxHD_M.Items.Add(i);
                comboBoxHF_M.Items.Add(i);
            }
           

            foreach (Astronaute a in Parent.getMission().getAstronautes())
            {
                checkedListBoxAstronaute.Items.Add(a.getNom());
            }

           
            List<Lieu> list_lieux=Parent.getMission().getCarte().getLieux();


            foreach (Lieu l in list_lieux)
            {
                comboBoxLieux.Items.Add(l.getNom());
            }
        }


        private void afterHours_Select_D(object sender, EventArgs e)
        {
            comboBoxHD_M.Items.Clear();
   
            if (comboBoxHD_H.SelectedItem.ToString() == "24")
            {
                for (int i = 0; i <= 40; i+=10)
                {
                    comboBoxHD_M.Items.Add(i);
                }
            }
            else
            {
                for (int i = 0; i <60; i+=10)
                {
                    comboBoxHD_M.Items.Add(i);
                }
            }
           }

        private void afterHours_Select_F(object sender, EventArgs e)
        {

            comboBoxHF_M.Items.Clear();
            if (comboBoxHF_H.SelectedItem.ToString() == "24")
            {
                for (int i = 0; i <= 40; i+=10)
                {
                    comboBoxHF_M.Items.Add(i);
                }
            }
            else
            {
                for (int i = 0; i < 60; i+=10)
                {
                    comboBoxHF_M.Items.Add(i);
                }
            }

        }

        private int conversionHeureMinutes(string heure, string minutes)
        {
            int h = int.Parse(heure);
            int m = int.Parse(minutes);

            return 60*h + m;
        }

        private void pictureBox1_DoubleClick(object sender, MouseEventArgs e)
        {
            // recuperation des infos sur la carte
            int pixel_x=Parent.getMission().getCarte().getPixel_x();
            int pixel_y = Parent.getMission().getCarte().getPixel_y();
            int echelle = Parent.getMission().getCarte().getEchelle();

            //Changement de repere
            int newX = echelle*(e.X -pixel_x );
            int newY = echelle * (e.Y - pixel_y);

            //Modification des coordonnées:
            lieu_temp.setx(newX);
            lieu_temp.sety(newY);

            //Affichage des coordonnées
            maskedTextBoxX2.Text = lieu_temp.getx().ToString();
            maskedTextBoxY2.Text = lieu_temp.gety().ToString(); 
            
        }

        private Lieu findLieu()
        {
            return Parent.getMission().getCarte().getLieux()[comboBoxLieux.SelectedIndex];
        }


        private void buttonValider_Click(object sender, EventArgs e)
        {
            acti_temp.setCategorie(comboBoxCategorie.Text);
            acti_temp.setLibelle(comboBoxLibelle.Text);
            acti_temp.setDebut(conversionHeureMinutes(comboBoxHD_H.Text, comboBoxHD_M.Text));
            acti_temp.setFin(conversionHeureMinutes(comboBoxHF_H.Text, comboBoxHF_M.Text));
            acti_temp.setLieu(findLieu());
            acti_temp.setNumJour(Parent.getJourSelectione().getNum());

            if (checkedListBoxAstronaute.CheckedItems.Count != 0)
            for (int i = 0; i <= checkedListBoxAstronaute.CheckedItems.Count -1 ; i++)
            {
                //int j = checkedListBoxAstronaute.CheckedIndex[j];
                acti_temp.addParticipant(Parent.getMission().getAstronautes()[i]);
            }

            Parent.getJourSelectione().addActivitée(acti_temp);
            Parent.getJourSelectione().trierActivitée();
            Parent.refreshActivitée(Parent.getJourSelectione());
            this.Close();
        }

        private void comboBoxCategorie_SelectionChangeCommitted(object sender, EventArgs e)
        {
            
            switch (comboBoxCategorie.SelectedItem.ToString())
            {
                case "Living":
                    comboBoxLibelle.Items.Clear();
                    foreach (string s in valeursListes.listeLibelleLiving)
                    {
                        comboBoxLibelle.Items.Add(s);
                    }
                break;
                case "Science":
                    comboBoxLibelle.Items.Clear();
                    foreach (string s in valeursListes.listeLibelleScience)
                    {
                        comboBoxLibelle.Items.Add(s);
                    }
                break;
                case "Maintenance":
                    comboBoxLibelle.Items.Clear();
                    foreach (string s in valeursListes.listeLibelleMaintenance)
                    {
                        comboBoxLibelle.Items.Add(s);
                    }
                break;
                case "Communication":
                    comboBoxLibelle.Items.Clear();
                    foreach (string s in valeursListes.listeLibelleCommunication)
                    {
                        comboBoxLibelle.Items.Add(s);
                    }
                break;
                case "Repair":
                    comboBoxLibelle.Items.Clear();
                    foreach (string s in valeursListes.listeLibelleRepair)
                    {
                        comboBoxLibelle.Items.Add(s);
                    }
                break;
                case "Emergency":
                    comboBoxLibelle.Items.Clear();
                    foreach (string s in valeursListes.listeLibelleEmergency)
                    {
                        comboBoxLibelle.Items.Add(s);
                    }
                break;
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxLieux_SelectedIndexChanged(object sender, EventArgs e)
        {
            //A voir plus tard: afficher les coordonnées du lieu selectionné
            int i= comboBoxLieux.SelectedIndex;
            List<Lieu> list_lieux = Parent.getMission().getCarte().getLieux();
            Lieu monlieu = list_lieux[i];
            maskedTextBoxX1.Text = monlieu.getx().ToString();
            maskedTextBoxY1.Text = monlieu.gety().ToString();
        }

        private void btn_ajout_lieu_Click(object sender, EventArgs e)
        {
            lieu_temp.setNom(textBox1.Text);

            Carte carte = Parent.getMission().getCarte();
            carte.addLieu(lieu_temp);

            //Rafraichissement de la combobox
            comboBoxLieux.Items.Clear();
            List<Lieu> list_lieux = Parent.getMission().getCarte().getLieux();

            foreach (Lieu l in list_lieux)
            {
                comboBoxLieux.Items.Add(l.getNom());
            }
            //effacement des textbox
            textBox1.Clear();
            maskedTextBoxX2.Clear();
            maskedTextBoxY2.Clear();


        }

    }
}
