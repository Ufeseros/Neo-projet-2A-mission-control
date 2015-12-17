namespace Mission_Control
{
    partial class FormAjoutActivite
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBoxCategorie = new System.Windows.Forms.ComboBox();
            this.comboBoxLibelle = new System.Windows.Forms.ComboBox();
            this.comboBoxHD_H = new System.Windows.Forms.ComboBox();
            this.comboBoxHF_H = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkedListBoxAstronaute = new System.Windows.Forms.CheckedListBox();
            this.buttonValider = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxHF_M = new System.Windows.Forms.ComboBox();
            this.comboBoxHD_M = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxCategorie
            // 
            this.comboBoxCategorie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCategorie.FormattingEnabled = true;
            this.comboBoxCategorie.Location = new System.Drawing.Point(70, 124);
            this.comboBoxCategorie.Name = "comboBoxCategorie";
            this.comboBoxCategorie.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCategorie.TabIndex = 0;
            this.comboBoxCategorie.SelectionChangeCommitted += new System.EventHandler(this.comboBoxCategorie_SelectionChangeCommitted);
            // 
            // comboBoxLibelle
            // 
            this.comboBoxLibelle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLibelle.FormattingEnabled = true;
            this.comboBoxLibelle.Location = new System.Drawing.Point(255, 124);
            this.comboBoxLibelle.Name = "comboBoxLibelle";
            this.comboBoxLibelle.Size = new System.Drawing.Size(121, 21);
            this.comboBoxLibelle.TabIndex = 1;
            // 
            // comboBoxHD_H
            // 
            this.comboBoxHD_H.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxHD_H.FormattingEnabled = true;
            this.comboBoxHD_H.Location = new System.Drawing.Point(70, 151);
            this.comboBoxHD_H.Name = "comboBoxHD_H";
            this.comboBoxHD_H.Size = new System.Drawing.Size(50, 21);
            this.comboBoxHD_H.TabIndex = 2;
            this.comboBoxHD_H.SelectedIndexChanged += new System.EventHandler(this.afterHours_Select_D);
            // 
            // comboBoxHF_H
            // 
            this.comboBoxHF_H.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxHF_H.FormattingEnabled = true;
            this.comboBoxHF_H.Location = new System.Drawing.Point(255, 151);
            this.comboBoxHF_H.Name = "comboBoxHF_H";
            this.comboBoxHF_H.Size = new System.Drawing.Size(47, 21);
            this.comboBoxHF_H.TabIndex = 3;
            this.comboBoxHF_H.SelectedIndexChanged += new System.EventHandler(this.afterHours_Select_F);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Mission_Control.Properties.Resources.nanedi_valles;
            this.pictureBox1.Location = new System.Drawing.Point(584, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(311, 589);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ajouter une Activité";
            // 
            // checkedListBoxAstronaute
            // 
            this.checkedListBoxAstronaute.FormattingEnabled = true;
            this.checkedListBoxAstronaute.Location = new System.Drawing.Point(68, 226);
            this.checkedListBoxAstronaute.Name = "checkedListBoxAstronaute";
            this.checkedListBoxAstronaute.Size = new System.Drawing.Size(297, 229);
            this.checkedListBoxAstronaute.TabIndex = 7;
            this.checkedListBoxAstronaute.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // buttonValider
            // 
            this.buttonValider.Location = new System.Drawing.Point(70, 471);
            this.buttonValider.Name = "buttonValider";
            this.buttonValider.Size = new System.Drawing.Size(121, 45);
            this.buttonValider.TabIndex = 8;
            this.buttonValider.Text = "Valider";
            this.buttonValider.UseVisualStyleBackColor = true;
            this.buttonValider.Click += new System.EventHandler(this.buttonValider_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(244, 471);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 45);
            this.button2.TabIndex = 9;
            this.button2.Text = "Annuler";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(244, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Coordonnées : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Cattegorie";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(212, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Libelle";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(199, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "HeureFin";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(-1, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "HeureDebut";
            // 
            // comboBoxHF_M
            // 
            this.comboBoxHF_M.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxHF_M.FormattingEnabled = true;
            this.comboBoxHF_M.Location = new System.Drawing.Point(326, 151);
            this.comboBoxHF_M.Name = "comboBoxHF_M";
            this.comboBoxHF_M.Size = new System.Drawing.Size(50, 21);
            this.comboBoxHF_M.TabIndex = 15;
            // 
            // comboBoxHD_M
            // 
            this.comboBoxHD_M.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxHD_M.FormattingEnabled = true;
            this.comboBoxHD_M.Location = new System.Drawing.Point(141, 151);
            this.comboBoxHD_M.Name = "comboBoxHD_M";
            this.comboBoxHD_M.Size = new System.Drawing.Size(50, 21);
            this.comboBoxHD_M.TabIndex = 16;
            // 
            // FormAjoutActivite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 682);
            this.Controls.Add(this.comboBoxHD_M);
            this.Controls.Add(this.comboBoxHF_M);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonValider);
            this.Controls.Add(this.checkedListBoxAstronaute);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.comboBoxHF_H);
            this.Controls.Add(this.comboBoxHD_H);
            this.Controls.Add(this.comboBoxLibelle);
            this.Controls.Add(this.comboBoxCategorie);
            this.Name = "FormAjoutActivite";
            this.Text = "FormAjoutActivite";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxCategorie;
        private System.Windows.Forms.ComboBox comboBoxLibelle;
        private System.Windows.Forms.ComboBox comboBoxHD_H;
        private System.Windows.Forms.ComboBox comboBoxHF_H;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox checkedListBoxAstronaute;
        private System.Windows.Forms.Button buttonValider;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxHF_M;
        private System.Windows.Forms.ComboBox comboBoxHD_M;
    }
}