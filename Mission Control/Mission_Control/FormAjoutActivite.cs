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

        public FormAjoutActivite()
        {
            InitializeComponent();

            foreach (string s in valeursListes.listeCategories)
            {
                comboBoxCategorie.Items.Add(s);
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_DoubleClick(object sender, MouseEventArgs e)
        {
            acti_temp.setCoord(e.X, e.Y);
            Lieu monLieu=acti_temp.getLieu();
            label2.Text=monLieu.ToString();
        }
    }
}
