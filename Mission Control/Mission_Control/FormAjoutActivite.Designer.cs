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
            this.numericUpDownY = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownX = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.maskedTextBoxY1 = new System.Windows.Forms.MaskedTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.maskedTextBoxX1 = new System.Windows.Forms.MaskedTextBox();
            this.btn_ajout_lieu = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxLieux = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxHD_M = new System.Windows.Forms.ComboBox();
            this.comboBoxHF_M = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonAnnuler = new System.Windows.Forms.Button();
            this.buttonValider = new System.Windows.Forms.Button();
            this.checkedListBoxAstronaute = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBoxHF_H = new System.Windows.Forms.ComboBox();
            this.comboBoxHD_H = new System.Windows.Forms.ComboBox();
            this.comboBoxLibelle = new System.Windows.Forms.ComboBox();
            this.comboBoxCategorie = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDownY
            // 
            this.numericUpDownY.Location = new System.Drawing.Point(248, 275);
            this.numericUpDownY.Maximum = new decimal(new int[] {
            1450,
            0,
            0,
            0});
            this.numericUpDownY.Minimum = new decimal(new int[] {
            1455,
            0,
            0,
            -2147483648});
            this.numericUpDownY.Name = "numericUpDownY";
            this.numericUpDownY.Size = new System.Drawing.Size(58, 20);
            this.numericUpDownY.TabIndex = 61;
            // 
            // numericUpDownX
            // 
            this.numericUpDownX.Location = new System.Drawing.Point(162, 275);
            this.numericUpDownX.Maximum = new decimal(new int[] {
            575,
            0,
            0,
            0});
            this.numericUpDownX.Minimum = new decimal(new int[] {
            978,
            0,
            0,
            -2147483648});
            this.numericUpDownX.Name = "numericUpDownX";
            this.numericUpDownX.Size = new System.Drawing.Size(58, 20);
            this.numericUpDownX.TabIndex = 60;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(365, 217);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(17, 13);
            this.label11.TabIndex = 59;
            this.label11.Text = "Y:";
            // 
            // maskedTextBoxY1
            // 
            this.maskedTextBoxY1.Enabled = false;
            this.maskedTextBoxY1.Location = new System.Drawing.Point(388, 214);
            this.maskedTextBoxY1.Name = "maskedTextBoxY1";
            this.maskedTextBoxY1.Size = new System.Drawing.Size(41, 20);
            this.maskedTextBoxY1.TabIndex = 58;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(278, 217);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(17, 13);
            this.label12.TabIndex = 57;
            this.label12.Text = "X:";
            // 
            // maskedTextBoxX1
            // 
            this.maskedTextBoxX1.Enabled = false;
            this.maskedTextBoxX1.Location = new System.Drawing.Point(301, 214);
            this.maskedTextBoxX1.Name = "maskedTextBoxX1";
            this.maskedTextBoxX1.Size = new System.Drawing.Size(41, 20);
            this.maskedTextBoxX1.TabIndex = 56;
            // 
            // btn_ajout_lieu
            // 
            this.btn_ajout_lieu.Location = new System.Drawing.Point(312, 274);
            this.btn_ajout_lieu.Name = "btn_ajout_lieu";
            this.btn_ajout_lieu.Size = new System.Drawing.Size(110, 42);
            this.btn_ajout_lieu.TabIndex = 55;
            this.btn_ajout_lieu.Text = "Ajouter lieu";
            this.btn_ajout_lieu.UseVisualStyleBackColor = true;
            this.btn_ajout_lieu.Click += new System.EventHandler(this.btn_ajout_lieu_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(126, 303);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 13);
            this.label10.TabIndex = 54;
            this.label10.Text = "nom:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(162, 300);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(144, 20);
            this.textBox1.TabIndex = 53;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(226, 277);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(17, 13);
            this.label9.TabIndex = 52;
            this.label9.Text = "Y:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(139, 277);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 13);
            this.label8.TabIndex = 51;
            this.label8.Text = "X:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(66, 252);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 13);
            this.label7.TabIndex = 50;
            this.label7.Text = "Ajouter un lieu :";
            // 
            // comboBoxLieux
            // 
            this.comboBoxLieux.FormattingEnabled = true;
            this.comboBoxLieux.Location = new System.Drawing.Point(139, 214);
            this.comboBoxLieux.Name = "comboBoxLieux";
            this.comboBoxLieux.Size = new System.Drawing.Size(121, 21);
            this.comboBoxLieux.TabIndex = 49;
            this.comboBoxLieux.Text = "Lieu Existant";
            this.comboBoxLieux.SelectedIndexChanged += new System.EventHandler(this.comboBoxLieux_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 48;
            this.label2.Text = "Lieu:";
            // 
            // comboBoxHD_M
            // 
            this.comboBoxHD_M.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxHD_M.FormattingEnabled = true;
            this.comboBoxHD_M.Location = new System.Drawing.Point(198, 169);
            this.comboBoxHD_M.Name = "comboBoxHD_M";
            this.comboBoxHD_M.Size = new System.Drawing.Size(50, 21);
            this.comboBoxHD_M.TabIndex = 47;
            // 
            // comboBoxHF_M
            // 
            this.comboBoxHF_M.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxHF_M.FormattingEnabled = true;
            this.comboBoxHF_M.Location = new System.Drawing.Point(383, 169);
            this.comboBoxHF_M.Name = "comboBoxHF_M";
            this.comboBoxHF_M.Size = new System.Drawing.Size(50, 21);
            this.comboBoxHF_M.TabIndex = 46;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(56, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 45;
            this.label6.Text = "HeureDebut";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(256, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 44;
            this.label5.Text = "HeureFin";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(269, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 43;
            this.label4.Text = "Libelle";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 42;
            this.label3.Text = "Categorie";
            // 
            // buttonAnnuler
            // 
            this.buttonAnnuler.Location = new System.Drawing.Point(301, 489);
            this.buttonAnnuler.Name = "buttonAnnuler";
            this.buttonAnnuler.Size = new System.Drawing.Size(121, 45);
            this.buttonAnnuler.TabIndex = 41;
            this.buttonAnnuler.Text = "Annuler";
            this.buttonAnnuler.UseVisualStyleBackColor = true;
            this.buttonAnnuler.Click += new System.EventHandler(this.buttonAnnuler_Click);
            // 
            // buttonValider
            // 
            this.buttonValider.Location = new System.Drawing.Point(127, 489);
            this.buttonValider.Name = "buttonValider";
            this.buttonValider.Size = new System.Drawing.Size(121, 45);
            this.buttonValider.TabIndex = 40;
            this.buttonValider.Text = "Valider";
            this.buttonValider.UseVisualStyleBackColor = true;
            this.buttonValider.Click += new System.EventHandler(this.buttonValider_Click);
            // 
            // checkedListBoxAstronaute
            // 
            this.checkedListBoxAstronaute.FormattingEnabled = true;
            this.checkedListBoxAstronaute.Location = new System.Drawing.Point(125, 364);
            this.checkedListBoxAstronaute.Name = "checkedListBoxAstronaute";
            this.checkedListBoxAstronaute.Size = new System.Drawing.Size(297, 109);
            this.checkedListBoxAstronaute.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(119, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 31);
            this.label1.TabIndex = 38;
            this.label1.Text = "Ajouter une Activité";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Mission_Control.Properties.Resources.nanedi_valles;
            this.pictureBox1.Location = new System.Drawing.Point(641, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(311, 589);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_DoubleClick);
            // 
            // comboBoxHF_H
            // 
            this.comboBoxHF_H.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxHF_H.FormattingEnabled = true;
            this.comboBoxHF_H.Location = new System.Drawing.Point(312, 169);
            this.comboBoxHF_H.Name = "comboBoxHF_H";
            this.comboBoxHF_H.Size = new System.Drawing.Size(47, 21);
            this.comboBoxHF_H.TabIndex = 36;
            this.comboBoxHF_H.SelectedIndexChanged += new System.EventHandler(this.afterHours_Select_F);
            // 
            // comboBoxHD_H
            // 
            this.comboBoxHD_H.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxHD_H.FormattingEnabled = true;
            this.comboBoxHD_H.Location = new System.Drawing.Point(127, 169);
            this.comboBoxHD_H.Name = "comboBoxHD_H";
            this.comboBoxHD_H.Size = new System.Drawing.Size(50, 21);
            this.comboBoxHD_H.TabIndex = 35;
            this.comboBoxHD_H.SelectedIndexChanged += new System.EventHandler(this.afterHours_Select_D);
            // 
            // comboBoxLibelle
            // 
            this.comboBoxLibelle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLibelle.FormattingEnabled = true;
            this.comboBoxLibelle.Location = new System.Drawing.Point(312, 142);
            this.comboBoxLibelle.Name = "comboBoxLibelle";
            this.comboBoxLibelle.Size = new System.Drawing.Size(121, 21);
            this.comboBoxLibelle.TabIndex = 34;
            // 
            // comboBoxCategorie
            // 
            this.comboBoxCategorie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCategorie.FormattingEnabled = true;
            this.comboBoxCategorie.Location = new System.Drawing.Point(127, 142);
            this.comboBoxCategorie.Name = "comboBoxCategorie";
            this.comboBoxCategorie.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCategorie.TabIndex = 33;
            this.comboBoxCategorie.SelectedIndexChanged += new System.EventHandler(this.comboBoxCategorie_SelectionChangeCommitted);
            this.comboBoxCategorie.SelectionChangeCommitted += new System.EventHandler(this.comboBoxCategorie_SelectionChangeCommitted);
            // 
            // FormAjoutActivite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 682);
            this.Controls.Add(this.numericUpDownY);
            this.Controls.Add(this.numericUpDownX);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.maskedTextBoxY1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.maskedTextBoxX1);
            this.Controls.Add(this.btn_ajout_lieu);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBoxLieux);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxHD_M);
            this.Controls.Add(this.comboBoxHF_M);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonAnnuler);
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
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDownY;
        private System.Windows.Forms.NumericUpDown numericUpDownX;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxY1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxX1;
        private System.Windows.Forms.Button btn_ajout_lieu;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxLieux;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxHD_M;
        private System.Windows.Forms.ComboBox comboBoxHF_M;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonAnnuler;
        private System.Windows.Forms.Button buttonValider;
        private System.Windows.Forms.CheckedListBox checkedListBoxAstronaute;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBoxHF_H;
        private System.Windows.Forms.ComboBox comboBoxHD_H;
        private System.Windows.Forms.ComboBox comboBoxLibelle;
        private System.Windows.Forms.ComboBox comboBoxCategorie;

    }
}