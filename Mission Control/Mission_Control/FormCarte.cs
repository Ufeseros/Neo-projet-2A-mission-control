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
    public partial class FormCarte : Form
    {
        Form1 Parent;

        public FormCarte(Form1 Parent)
        {
            InitializeComponent();
            this.Parent = Parent;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void FormCarte_Load(object sender, EventArgs e)
        {
            TreeNode node;
            foreach (Lieu l in Parent.getMission().getCarte().getLieux())
            {
                node = new TreeNode(l.getNom());
                    node.Tag = l;
                    treeView1.Nodes.Add(node);
            }
        }
    }
}
