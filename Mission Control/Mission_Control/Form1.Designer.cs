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
            this.chargerMission = new System.Windows.Forms.Button();
            this.AfficheJours = new System.Windows.Forms.TreeView();
            this.button1 = new System.Windows.Forms.Button();
            this.AfficheActivitée = new System.Windows.Forms.TreeView();
            this.jourPrec = new System.Windows.Forms.Button();
            this.jourSuiv = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LabelLibelleActivitee = new System.Windows.Forms.Label();
            this.LabelCategorieActivitee = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelTempsLocal = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelHeureDebut = new System.Windows.Forms.Label();
            this.labelHeureFin = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelLieu = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chargerMission
            // 
            this.chargerMission.Location = new System.Drawing.Point(12, 14);
            this.chargerMission.Name = "chargerMission";
            this.chargerMission.Size = new System.Drawing.Size(108, 23);
            this.chargerMission.TabIndex = 0;
            this.chargerMission.Text = "Charger mission";
            this.chargerMission.UseVisualStyleBackColor = true;
            this.chargerMission.Click += new System.EventHandler(this.chargerMission_Click);
            // 
            // AfficheJours
            // 
            this.AfficheJours.Location = new System.Drawing.Point(198, 12);
            this.AfficheJours.Name = "AfficheJours";
            this.AfficheJours.Size = new System.Drawing.Size(121, 392);
            this.AfficheJours.TabIndex = 1;
            this.AfficheJours.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.AfficheJours_AfterSelect);
            this.AfficheJours.EnabledChanged += new System.EventHandler(this.AfficheJours_EnabledChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Afficher la carte";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AfficheActivitée
            // 
            this.AfficheActivitée.Location = new System.Drawing.Point(372, 12);
            this.AfficheActivitée.Name = "AfficheActivitée";
            this.AfficheActivitée.Size = new System.Drawing.Size(438, 214);
            this.AfficheActivitée.TabIndex = 3;
            this.AfficheActivitée.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.Activitee_jour_AfterSelect);
            // 
            // jourPrec
            // 
            this.jourPrec.Location = new System.Drawing.Point(372, 233);
            this.jourPrec.Name = "jourPrec";
            this.jourPrec.Size = new System.Drawing.Size(75, 23);
            this.jourPrec.TabIndex = 4;
            this.jourPrec.Text = "<précedent";
            this.jourPrec.UseVisualStyleBackColor = true;
            this.jourPrec.Click += new System.EventHandler(this.jourPrec_Click);
            // 
            // jourSuiv
            // 
            this.jourSuiv.Location = new System.Drawing.Point(735, 233);
            this.jourSuiv.Name = "jourSuiv";
            this.jourSuiv.Size = new System.Drawing.Size(75, 23);
            this.jourSuiv.TabIndex = 5;
            this.jourSuiv.Text = "suivant>";
            this.jourSuiv.UseVisualStyleBackColor = true;
            this.jourSuiv.Click += new System.EventHandler(this.jourSuiv_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(552, 233);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 6;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelLieu);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.labelHeureFin);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.labelHeureDebut);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.LabelLibelleActivitee);
            this.groupBox1.Controls.Add(this.LabelCategorieActivitee);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(372, 286);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(437, 118);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Détails de l\'activitée";
            this.groupBox1.Visible = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // LabelLibelleActivitee
            // 
            this.LabelLibelleActivitee.AutoSize = true;
            this.LabelLibelleActivitee.Location = new System.Drawing.Point(94, 61);
            this.LabelLibelleActivitee.Name = "LabelLibelleActivitee";
            this.LabelLibelleActivitee.Size = new System.Drawing.Size(35, 13);
            this.LabelLibelleActivitee.TabIndex = 3;
            this.LabelLibelleActivitee.Text = "label4";
            // 
            // LabelCategorieActivitee
            // 
            this.LabelCategorieActivitee.AutoSize = true;
            this.LabelCategorieActivitee.Location = new System.Drawing.Point(110, 34);
            this.LabelCategorieActivitee.Name = "LabelCategorieActivitee";
            this.LabelCategorieActivitee.Size = new System.Drawing.Size(35, 13);
            this.LabelCategorieActivitee.TabIndex = 2;
            this.LabelCategorieActivitee.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Libelle :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Categorie :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelTempsLocal
            // 
            this.labelTempsLocal.AutoSize = true;
            this.labelTempsLocal.Location = new System.Drawing.Point(12, 86);
            this.labelTempsLocal.Name = "labelTempsLocal";
            this.labelTempsLocal.Size = new System.Drawing.Size(35, 13);
            this.labelTempsLocal.TabIndex = 8;
            this.labelTempsLocal.Text = "label3";
            this.labelTempsLocal.Click += new System.EventHandler(this.label3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(189, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Heure début :";
            // 
            // labelHeureDebut
            // 
            this.labelHeureDebut.AutoSize = true;
            this.labelHeureDebut.Location = new System.Drawing.Point(261, 35);
            this.labelHeureDebut.Name = "labelHeureDebut";
            this.labelHeureDebut.Size = new System.Drawing.Size(35, 13);
            this.labelHeureDebut.TabIndex = 5;
            this.labelHeureDebut.Text = "label4";
            // 
            // labelHeureFin
            // 
            this.labelHeureFin.AutoSize = true;
            this.labelHeureFin.Location = new System.Drawing.Point(261, 61);
            this.labelHeureFin.Name = "labelHeureFin";
            this.labelHeureFin.Size = new System.Drawing.Size(35, 13);
            this.labelHeureFin.TabIndex = 7;
            this.labelHeureFin.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(189, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Heure fin :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Lieu :";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // labelLieu
            // 
            this.labelLieu.AutoSize = true;
            this.labelLieu.Location = new System.Drawing.Point(84, 89);
            this.labelLieu.Name = "labelLieu";
            this.labelLieu.Size = new System.Drawing.Size(35, 13);
            this.labelLieu.TabIndex = 9;
            this.labelLieu.Text = "label5";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 681);
            this.Controls.Add(this.labelTempsLocal);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.jourSuiv);
            this.Controls.Add(this.jourPrec);
            this.Controls.Add(this.AfficheActivitée);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.AfficheJours);
            this.Controls.Add(this.chargerMission);
            this.Name = "Form1";
            this.Text = "Controle de mission";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox groupBox1;
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
    }
}

