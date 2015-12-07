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
            this.comboBoxHD = new System.Windows.Forms.ComboBox();
            this.comboBoxHF = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxCategorie
            // 
            this.comboBoxCategorie.FormattingEnabled = true;
            this.comboBoxCategorie.Location = new System.Drawing.Point(70, 124);
            this.comboBoxCategorie.Name = "comboBoxCategorie";
            this.comboBoxCategorie.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCategorie.TabIndex = 0;
            this.comboBoxCategorie.Text = "categorie";
            // 
            // comboBoxLibelle
            // 
            this.comboBoxLibelle.FormattingEnabled = true;
            this.comboBoxLibelle.Location = new System.Drawing.Point(244, 123);
            this.comboBoxLibelle.Name = "comboBoxLibelle";
            this.comboBoxLibelle.Size = new System.Drawing.Size(121, 21);
            this.comboBoxLibelle.TabIndex = 1;
            this.comboBoxLibelle.Text = "libelle";
            // 
            // comboBoxHD
            // 
            this.comboBoxHD.FormattingEnabled = true;
            this.comboBoxHD.Location = new System.Drawing.Point(70, 151);
            this.comboBoxHD.Name = "comboBoxHD";
            this.comboBoxHD.Size = new System.Drawing.Size(121, 21);
            this.comboBoxHD.TabIndex = 2;
            this.comboBoxHD.Text = "heure début";
            // 
            // comboBoxHF
            // 
            this.comboBoxHF.FormattingEnabled = true;
            this.comboBoxHF.Location = new System.Drawing.Point(244, 151);
            this.comboBoxHF.Name = "comboBoxHF";
            this.comboBoxHF.Size = new System.Drawing.Size(121, 21);
            this.comboBoxHF.TabIndex = 3;
            this.comboBoxHF.Text = "heure fin";
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
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // comboBox5
            // 
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(70, 97);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(121, 21);
            this.comboBox5.TabIndex = 6;
            this.comboBox5.Text = "Jour";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(68, 226);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(297, 229);
            this.checkedListBox1.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(70, 471);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 45);
            this.button1.TabIndex = 8;
            this.button1.Text = "Valider";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // FormAjoutActivite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 682);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.comboBox5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.comboBoxHF);
            this.Controls.Add(this.comboBoxHD);
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
        private System.Windows.Forms.ComboBox comboBoxHD;
        private System.Windows.Forms.ComboBox comboBoxHF;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
    }
}