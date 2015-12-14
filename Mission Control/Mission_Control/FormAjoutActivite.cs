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
        List<string> listeDesCategories;
        List<string> listeDesLibelle;
        Form1 Parent;


        public FormAjoutActivite(Form1 Parent)
        {
            InitializeComponent();
            this.Parent = Parent;

            foreach (string s in valeursListes.listeCategories)
            {
                comboBoxCategorie.Items.Add(s);
            }
        }






        private void pictureBox1_DoubleClick(object sender, MouseEventArgs e)
        {
            acti_temp.setCoord(e.X, e.Y);
            Lieu monLieu=acti_temp.getLieu();
            label2.Text=monLieu.ToString();
        }

        private void buttonValider_Click(object sender, EventArgs e)
        {
            // ici traitement d'ajout d'activitée
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

    }
}
