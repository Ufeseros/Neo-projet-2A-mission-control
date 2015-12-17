namespace Mission_Control
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.chargerMission = new System.Windows.Forms.Button();
            this.AfficheJours = new System.Windows.Forms.TreeView();
            this.button1 = new System.Windows.Forms.Button();
            this.AfficheActivitée = new System.Windows.Forms.TreeView();
            this.jourPrec = new System.Windows.Forms.Button();
            this.jourSuiv = new System.Windows.Forms.Button();
            this.boutonAjoutActivitée = new System.Windows.Forms.Button();
            this.groupBoxActivitée = new System.Windows.Forms.GroupBox();
            this.labelLieu = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelHeureFin = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelHeureDebut = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LabelLibelleActivitee = new System.Windows.Forms.Label();
            this.LabelCategorieActivitee = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelTempsLocal = new System.Windows.Forms.Label();
            this.sauvegarderMission = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.afficheAstronautes = new System.Windows.Forms.TreeView();
            this.label5 = new System.Windows.Forms.Label();
            this.ajouterAstronaute = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.confirmationAjoutAstronaute = new System.Windows.Forms.Button();
            this.textBoxAjoutAstronaute = new System.Windows.Forms.TextBox();
            this.bouttonSupprimerActivitée = new System.Windows.Forms.Button();
            this.labelTempsLocalMars = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.buttonRefreshJour = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelJournum = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.treeViewAstronauteActivitée = new System.Windows.Forms.TreeView();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBoxActivitée.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chargerMission
            // 
            this.chargerMission.Location = new System.Drawing.Point(12, 23);
            this.chargerMission.Name = "chargerMission";
            this.chargerMission.Size = new System.Drawing.Size(130, 23);
            this.chargerMission.TabIndex = 0;
            this.chargerMission.Text = "Charger mission";
            this.chargerMission.UseVisualStyleBackColor = true;
            this.chargerMission.Click += new System.EventHandler(this.chargerMission_Click);
            // 
            // AfficheJours
            // 
            this.AfficheJours.Location = new System.Drawing.Point(198, 12);
            this.AfficheJours.Name = "AfficheJours";
            this.AfficheJours.Size = new System.Drawing.Size(121, 532);
            this.AfficheJours.StateImageList = this.imageList1;
            this.AfficheJours.TabIndex = 1;
            this.AfficheJours.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.AfficheJours_AfterSelect);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 81);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Afficher la carte";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AfficheActivitée
            // 
            this.AfficheActivitée.Location = new System.Drawing.Point(349, 33);
            this.AfficheActivitée.Name = "AfficheActivitée";
            this.AfficheActivitée.Size = new System.Drawing.Size(438, 128);
            this.AfficheActivitée.TabIndex = 3;
            this.AfficheActivitée.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.Activitee_jour_AfterSelect);
            // 
            // jourPrec
            // 
            this.jourPrec.Location = new System.Drawing.Point(349, 167);
            this.jourPrec.Name = "jourPrec";
            this.jourPrec.Size = new System.Drawing.Size(75, 23);
            this.jourPrec.TabIndex = 4;
            this.jourPrec.Text = "<précedent";
            this.jourPrec.UseVisualStyleBackColor = true;
            this.jourPrec.Click += new System.EventHandler(this.jourPrec_Click);
            // 
            // jourSuiv
            // 
            this.jourSuiv.Location = new System.Drawing.Point(712, 167);
            this.jourSuiv.Name = "jourSuiv";
            this.jourSuiv.Size = new System.Drawing.Size(75, 23);
            this.jourSuiv.TabIndex = 5;
            this.jourSuiv.Text = "suivant>";
            this.jourSuiv.UseVisualStyleBackColor = true;
            this.jourSuiv.Click += new System.EventHandler(this.jourSuiv_Click);
            // 
            // boutonAjoutActivitée
            // 
            this.boutonAjoutActivitée.Enabled = false;
            this.boutonAjoutActivitée.Location = new System.Drawing.Point(446, 167);
            this.boutonAjoutActivitée.Name = "boutonAjoutActivitée";
            this.boutonAjoutActivitée.Size = new System.Drawing.Size(121, 23);
            this.boutonAjoutActivitée.TabIndex = 6;
            this.boutonAjoutActivitée.Text = "Ajouter une activitée";
            this.boutonAjoutActivitée.UseVisualStyleBackColor = true;
            this.boutonAjoutActivitée.Click += new System.EventHandler(this.boutonAjoutActivitée_Click);
            // 
            // groupBoxActivitée
            // 
            this.groupBoxActivitée.Controls.Add(this.label9);
            this.groupBoxActivitée.Controls.Add(this.treeViewAstronauteActivitée);
            this.groupBoxActivitée.Controls.Add(this.labelLieu);
            this.groupBoxActivitée.Controls.Add(this.label4);
            this.groupBoxActivitée.Controls.Add(this.labelHeureFin);
            this.groupBoxActivitée.Controls.Add(this.label6);
            this.groupBoxActivitée.Controls.Add(this.labelHeureDebut);
            this.groupBoxActivitée.Controls.Add(this.label3);
            this.groupBoxActivitée.Controls.Add(this.LabelLibelleActivitee);
            this.groupBoxActivitée.Controls.Add(this.LabelCategorieActivitee);
            this.groupBoxActivitée.Controls.Add(this.label2);
            this.groupBoxActivitée.Controls.Add(this.label7);
            this.groupBoxActivitée.Controls.Add(this.label1);
            this.groupBoxActivitée.Location = new System.Drawing.Point(349, 196);
            this.groupBoxActivitée.Name = "groupBoxActivitée";
            this.groupBoxActivitée.Size = new System.Drawing.Size(438, 126);
            this.groupBoxActivitée.TabIndex = 7;
            this.groupBoxActivitée.TabStop = false;
            this.groupBoxActivitée.Text = "Détails de l\'activitée";
            this.groupBoxActivitée.Visible = false;
            // 
            // labelLieu
            // 
            this.labelLieu.AutoSize = true;
            this.labelLieu.Location = new System.Drawing.Point(47, 95);
            this.labelLieu.Name = "labelLieu";
            this.labelLieu.Size = new System.Drawing.Size(35, 13);
            this.labelLieu.TabIndex = 9;
            this.labelLieu.Text = "label5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Lieu :";
            // 
            // labelHeureFin
            // 
            this.labelHeureFin.AutoSize = true;
            this.labelHeureFin.Location = new System.Drawing.Point(73, 82);
            this.labelHeureFin.Name = "labelHeureFin";
            this.labelHeureFin.Size = new System.Drawing.Size(35, 13);
            this.labelHeureFin.TabIndex = 7;
            this.labelHeureFin.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Heure fin :";
            // 
            // labelHeureDebut
            // 
            this.labelHeureDebut.AutoSize = true;
            this.labelHeureDebut.Location = new System.Drawing.Point(78, 69);
            this.labelHeureDebut.Name = "labelHeureDebut";
            this.labelHeureDebut.Size = new System.Drawing.Size(35, 13);
            this.labelHeureDebut.TabIndex = 5;
            this.labelHeureDebut.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Heure début :";
            // 
            // LabelLibelleActivitee
            // 
            this.LabelLibelleActivitee.AutoSize = true;
            this.LabelLibelleActivitee.Location = new System.Drawing.Point(55, 46);
            this.LabelLibelleActivitee.Name = "LabelLibelleActivitee";
            this.LabelLibelleActivitee.Size = new System.Drawing.Size(35, 13);
            this.LabelLibelleActivitee.TabIndex = 3;
            this.LabelLibelleActivitee.Text = "label4";
            // 
            // LabelCategorieActivitee
            // 
            this.LabelCategorieActivitee.AutoSize = true;
            this.LabelCategorieActivitee.Location = new System.Drawing.Point(71, 32);
            this.LabelCategorieActivitee.Name = "LabelCategorieActivitee";
            this.LabelCategorieActivitee.Size = new System.Drawing.Size(35, 13);
            this.LabelCategorieActivitee.TabIndex = 2;
            this.LabelCategorieActivitee.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Libelle :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Categorie :";
            // 
            // labelTempsLocal
            // 
            this.labelTempsLocal.AutoSize = true;
            this.labelTempsLocal.Location = new System.Drawing.Point(12, 127);
            this.labelTempsLocal.Name = "labelTempsLocal";
            this.labelTempsLocal.Size = new System.Drawing.Size(59, 13);
            this.labelTempsLocal.TabIndex = 8;
            this.labelTempsLocal.Text = "temps terre";
            // 
            // sauvegarderMission
            // 
            this.sauvegarderMission.Location = new System.Drawing.Point(12, 52);
            this.sauvegarderMission.Name = "sauvegarderMission";
            this.sauvegarderMission.Size = new System.Drawing.Size(130, 23);
            this.sauvegarderMission.TabIndex = 9;
            this.sauvegarderMission.Text = "Sauvegader mission";
            this.sauvegarderMission.UseVisualStyleBackColor = true;
            this.sauvegarderMission.Click += new System.EventHandler(this.sauvegarderMission_Click);
            // 
            // afficheAstronautes
            // 
            this.afficheAstronautes.Location = new System.Drawing.Point(832, 28);
            this.afficheAstronautes.Name = "afficheAstronautes";
            this.afficheAstronautes.Size = new System.Drawing.Size(121, 98);
            this.afficheAstronautes.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(829, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Tout les Astronautes";
            // 
            // ajouterAstronaute
            // 
            this.ajouterAstronaute.Location = new System.Drawing.Point(832, 177);
            this.ajouterAstronaute.Name = "ajouterAstronaute";
            this.ajouterAstronaute.Size = new System.Drawing.Size(121, 23);
            this.ajouterAstronaute.TabIndex = 12;
            this.ajouterAstronaute.Text = "Ajouter un astronaute";
            this.ajouterAstronaute.UseVisualStyleBackColor = true;
            this.ajouterAstronaute.Click += new System.EventHandler(this.ajouterAstronaute_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(832, 132);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(121, 39);
            this.button3.TabIndex = 13;
            this.button3.Text = "Supprimer un astronaute";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.confirmationAjoutAstronaute);
            this.groupBox2.Controls.Add(this.textBoxAjoutAstronaute);
            this.groupBox2.Location = new System.Drawing.Point(837, 210);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(159, 81);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "nom de l\'astronaute";
            this.groupBox2.Visible = false;
            // 
            // confirmationAjoutAstronaute
            // 
            this.confirmationAjoutAstronaute.Location = new System.Drawing.Point(41, 44);
            this.confirmationAjoutAstronaute.Name = "confirmationAjoutAstronaute";
            this.confirmationAjoutAstronaute.Size = new System.Drawing.Size(75, 23);
            this.confirmationAjoutAstronaute.TabIndex = 1;
            this.confirmationAjoutAstronaute.Text = "Ajouter";
            this.confirmationAjoutAstronaute.UseVisualStyleBackColor = true;
            this.confirmationAjoutAstronaute.Click += new System.EventHandler(this.confirmationAjoutAstronaute_Click);
            // 
            // textBoxAjoutAstronaute
            // 
            this.textBoxAjoutAstronaute.Location = new System.Drawing.Point(6, 19);
            this.textBoxAjoutAstronaute.Name = "textBoxAjoutAstronaute";
            this.textBoxAjoutAstronaute.Size = new System.Drawing.Size(147, 20);
            this.textBoxAjoutAstronaute.TabIndex = 0;
            // 
            // bouttonSupprimerActivitée
            // 
            this.bouttonSupprimerActivitée.Enabled = false;
            this.bouttonSupprimerActivitée.Location = new System.Drawing.Point(573, 167);
            this.bouttonSupprimerActivitée.Name = "bouttonSupprimerActivitée";
            this.bouttonSupprimerActivitée.Size = new System.Drawing.Size(121, 23);
            this.bouttonSupprimerActivitée.TabIndex = 15;
            this.bouttonSupprimerActivitée.Text = "Suprimer l\'activitée";
            this.bouttonSupprimerActivitée.UseVisualStyleBackColor = true;
            this.bouttonSupprimerActivitée.Click += new System.EventHandler(this.bouttonSupprimerActivitée_Click);
            // 
            // labelTempsLocalMars
            // 
            this.labelTempsLocalMars.AutoSize = true;
            this.labelTempsLocalMars.Location = new System.Drawing.Point(12, 156);
            this.labelTempsLocalMars.Name = "labelTempsLocalMars";
            this.labelTempsLocalMars.Size = new System.Drawing.Size(60, 13);
            this.labelTempsLocalMars.TabIndex = 16;
            this.labelTempsLocalMars.Text = "temps mars";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "astronaut_256.png");
            // 
            // buttonRefreshJour
            // 
            this.buttonRefreshJour.Location = new System.Drawing.Point(198, 560);
            this.buttonRefreshJour.Name = "buttonRefreshJour";
            this.buttonRefreshJour.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonRefreshJour.Size = new System.Drawing.Size(75, 23);
            this.buttonRefreshJour.TabIndex = 17;
            this.buttonRefreshJour.Text = "refresh";
            this.buttonRefreshJour.UseVisualStyleBackColor = true;
            this.buttonRefreshJour.Click += new System.EventHandler(this.buttonRefreshJour_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(21, 34);
            this.richTextBox1.MaxLength = 1000;
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(399, 203);
            this.richTextBox1.TabIndex = 18;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.richTextBox1);
            this.groupBox1.Location = new System.Drawing.Point(349, 328);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(438, 251);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Compte rendu du jour";
            // 
            // labelJournum
            // 
            this.labelJournum.AutoSize = true;
            this.labelJournum.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJournum.Location = new System.Drawing.Point(527, 5);
            this.labelJournum.Name = "labelJournum";
            this.labelJournum.Size = new System.Drawing.Size(51, 25);
            this.labelJournum.TabIndex = 20;
            this.labelJournum.Text = "Jour";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Categorie :";
            // 
            // treeViewAstronauteActivitée
            // 
            this.treeViewAstronauteActivitée.Location = new System.Drawing.Point(278, 32);
            this.treeViewAstronauteActivitée.Name = "treeViewAstronauteActivitée";
            this.treeViewAstronauteActivitée.Size = new System.Drawing.Size(117, 85);
            this.treeViewAstronauteActivitée.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(275, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Astronautes participants";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 681);
            this.Controls.Add(this.labelJournum);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonRefreshJour);
            this.Controls.Add(this.labelTempsLocalMars);
            this.Controls.Add(this.bouttonSupprimerActivitée);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.ajouterAstronaute);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.afficheAstronautes);
            this.Controls.Add(this.sauvegarderMission);
            this.Controls.Add(this.labelTempsLocal);
            this.Controls.Add(this.groupBoxActivitée);
            this.Controls.Add(this.boutonAjoutActivitée);
            this.Controls.Add(this.jourSuiv);
            this.Controls.Add(this.jourPrec);
            this.Controls.Add(this.AfficheActivitée);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.AfficheJours);
            this.Controls.Add(this.chargerMission);
            this.Name = "Form1";
            this.Text = "Controle de mission";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxActivitée.ResumeLayout(false);
            this.groupBoxActivitée.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button chargerMission;
        private System.Windows.Forms.TreeView AfficheJours;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TreeView AfficheActivitée;
        private System.Windows.Forms.Button jourPrec;
        private System.Windows.Forms.Button jourSuiv;
        private System.Windows.Forms.Button boutonAjoutActivitée;
        private System.Windows.Forms.GroupBox groupBoxActivitée;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LabelLibelleActivitee;
        private System.Windows.Forms.Label LabelCategorieActivitee;
        private System.Windows.Forms.Label labelTempsLocal;
        private System.Windows.Forms.Label labelHeureFin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelHeureDebut;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelLieu;
        private System.Windows.Forms.Button sauvegarderMission;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TreeView afficheAstronautes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button ajouterAstronaute;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button confirmationAjoutAstronaute;
        private System.Windows.Forms.TextBox textBoxAjoutAstronaute;
        private System.Windows.Forms.Button bouttonSupprimerActivitée;
        private System.Windows.Forms.Label labelTempsLocalMars;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button buttonRefreshJour;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelJournum;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TreeView treeViewAstronauteActivitée;
        private System.Windows.Forms.Label label7;
    }
}

