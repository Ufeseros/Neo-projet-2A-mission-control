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
<<<<<<< HEAD

            foreach (string s in valeursListes.listeCategories)
            {
                comboBoxCategorie.Items.Add(s);
            }

=======
           
>>>>>>> origin/master
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

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
<<<<<<< HEAD
            acti_temp.setCoord(e.X, e.Y);
            Lieu monLieu=acti_temp.getLieu();
            label2.Text=monLieu.ToString();
=======
            int x = Cursor.Position.X;
            int y = Cursor.Position.Y;
            acti_temp.setCoord(x,y);
            Lieu monLieu = acti_temp.getLieu();
            label2.Text = monLieu.ToString();

>>>>>>> origin/master
        }
       
        
    }
}
