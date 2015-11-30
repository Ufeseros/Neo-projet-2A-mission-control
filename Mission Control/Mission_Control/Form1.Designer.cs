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
            this.AfficheJours.Size = new System.Drawing.Size(121, 657);
            this.AfficheJours.TabIndex = 1;
            this.AfficheJours.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.AfficheJours_AfterSelect);
            this.AfficheJours.EnabledChanged += new System.EventHandler(this.AfficheJours_EnabledChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 67);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 681);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.jourSuiv);
            this.Controls.Add(this.jourPrec);
            this.Controls.Add(this.AfficheActivitée);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.AfficheJours);
            this.Controls.Add(this.chargerMission);
            this.Name = "Form1";
            this.Text = "Controle de mission";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button chargerMission;
        private System.Windows.Forms.TreeView AfficheJours;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TreeView AfficheActivitée;
        private System.Windows.Forms.Button jourPrec;
        private System.Windows.Forms.Button jourSuiv;
        private System.Windows.Forms.Button button4;
    }
}

