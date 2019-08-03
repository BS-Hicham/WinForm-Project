namespace PEOO_EFM_2018
{
    partial class Frm_gestOrd
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmb_nserie = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.ckb_graveur = new System.Windows.Forms.CheckBox();
            this.dtp_garantie = new System.Windows.Forms.DateTimePicker();
            this.txt_modele = new System.Windows.Forms.TextBox();
            this.txt_marque = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pb_photo = new System.Windows.Forms.PictureBox();
            this.btn_parcourir = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cmb_eType = new System.Windows.Forms.ComboBox();
            this.txt_eTaille = new System.Windows.Forms.TextBox();
            this.txt_eMarque = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cklb_se = new System.Windows.Forms.CheckedListBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.rb_tLabtop = new System.Windows.Forms.RadioButton();
            this.rb_tDesktop = new System.Windows.Forms.RadioButton();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btn_fermer = new System.Windows.Forms.Button();
            this.btn_exporter = new System.Windows.Forms.Button();
            this.btn_lister = new System.Windows.Forms.Button();
            this.btn_supprimer = new System.Windows.Forms.Button();
            this.btn_modifier = new System.Windows.Forms.Button();
            this.btn_ajouter = new System.Windows.Forms.Button();
            this.btn_nouveau = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.p_desktop = new System.Windows.Forms.Panel();
            this.txt_souris = new System.Windows.Forms.TextBox();
            this.txt_clavier = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_couleur = new System.Windows.Forms.Button();
            this.p_laptop = new System.Windows.Forms.Panel();
            this.txt_autonomie = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.p1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.cdiag = new System.Windows.Forms.ColorDialog();
            this.ofdiag = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_photo)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.p_desktop.SuspendLayout();
            this.p_laptop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.p1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmb_nserie);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.ckb_graveur);
            this.groupBox1.Controls.Add(this.dtp_garantie);
            this.groupBox1.Controls.Add(this.txt_modele);
            this.groupBox1.Controls.Add(this.txt_marque);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(261, 153);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Caractéristiques";
            // 
            // cmb_nserie
            // 
            this.cmb_nserie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_nserie.FormattingEnabled = true;
            this.cmb_nserie.Location = new System.Drawing.Point(73, 23);
            this.cmb_nserie.Name = "cmb_nserie";
            this.cmb_nserie.Size = new System.Drawing.Size(162, 21);
            this.cmb_nserie.TabIndex = 10;
            this.cmb_nserie.SelectedIndexChanged += new System.EventHandler(this.cmb_nserie_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(14, 26);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 13);
            this.label11.TabIndex = 9;
            this.label11.Text = "N°serie :";
            // 
            // ckb_graveur
            // 
            this.ckb_graveur.AutoSize = true;
            this.ckb_graveur.Location = new System.Drawing.Point(73, 102);
            this.ckb_graveur.Name = "ckb_graveur";
            this.ckb_graveur.Size = new System.Drawing.Size(40, 17);
            this.ckb_graveur.TabIndex = 8;
            this.ckb_graveur.Text = "oui";
            this.ckb_graveur.UseVisualStyleBackColor = true;
            // 
            // dtp_garantie
            // 
            this.dtp_garantie.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_garantie.Location = new System.Drawing.Point(73, 125);
            this.dtp_garantie.Name = "dtp_garantie";
            this.dtp_garantie.Size = new System.Drawing.Size(162, 20);
            this.dtp_garantie.TabIndex = 7;
            // 
            // txt_modele
            // 
            this.txt_modele.Location = new System.Drawing.Point(73, 76);
            this.txt_modele.Name = "txt_modele";
            this.txt_modele.Size = new System.Drawing.Size(162, 20);
            this.txt_modele.TabIndex = 5;
            // 
            // txt_marque
            // 
            this.txt_marque.Location = new System.Drawing.Point(73, 50);
            this.txt_marque.Name = "txt_marque";
            this.txt_marque.Size = new System.Drawing.Size(162, 20);
            this.txt_marque.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Garantie :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Graveur :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Modèle :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Marque :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pb_photo);
            this.groupBox2.Controls.Add(this.btn_parcourir);
            this.groupBox2.Location = new System.Drawing.Point(279, 33);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(261, 231);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Photo";
            // 
            // pb_photo
            // 
            this.pb_photo.Location = new System.Drawing.Point(19, 20);
            this.pb_photo.Name = "pb_photo";
            this.pb_photo.Size = new System.Drawing.Size(223, 167);
            this.pb_photo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_photo.TabIndex = 1;
            this.pb_photo.TabStop = false;
            // 
            // btn_parcourir
            // 
            this.btn_parcourir.Location = new System.Drawing.Point(19, 193);
            this.btn_parcourir.Name = "btn_parcourir";
            this.btn_parcourir.Size = new System.Drawing.Size(223, 23);
            this.btn_parcourir.TabIndex = 0;
            this.btn_parcourir.Text = "Parcourir...";
            this.btn_parcourir.UseVisualStyleBackColor = true;
            this.btn_parcourir.Click += new System.EventHandler(this.btn_parcourir_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.cmb_eType);
            this.groupBox3.Controls.Add(this.txt_eTaille);
            this.groupBox3.Controls.Add(this.txt_eMarque);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(12, 192);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(261, 116);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ecran";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(173, 53);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(36, 13);
            this.label12.TabIndex = 13;
            this.label12.Text = "puces";
            // 
            // cmb_eType
            // 
            this.cmb_eType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_eType.FormattingEnabled = true;
            this.cmb_eType.Location = new System.Drawing.Point(73, 78);
            this.cmb_eType.Name = "cmb_eType";
            this.cmb_eType.Size = new System.Drawing.Size(162, 21);
            this.cmb_eType.TabIndex = 12;
            // 
            // txt_eTaille
            // 
            this.txt_eTaille.Location = new System.Drawing.Point(73, 50);
            this.txt_eTaille.Name = "txt_eTaille";
            this.txt_eTaille.Size = new System.Drawing.Size(90, 20);
            this.txt_eTaille.TabIndex = 11;
            // 
            // txt_eMarque
            // 
            this.txt_eMarque.Location = new System.Drawing.Point(73, 22);
            this.txt_eMarque.Name = "txt_eMarque";
            this.txt_eMarque.Size = new System.Drawing.Size(162, 20);
            this.txt_eMarque.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Type :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Taille :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Marque :";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cklb_se);
            this.groupBox4.Location = new System.Drawing.Point(279, 270);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(261, 166);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Systèmes d\'exploitation";
            // 
            // cklb_se
            // 
            this.cklb_se.FormattingEnabled = true;
            this.cklb_se.Location = new System.Drawing.Point(19, 19);
            this.cklb_se.Name = "cklb_se";
            this.cklb_se.Size = new System.Drawing.Size(223, 139);
            this.cklb_se.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.p_laptop);
            this.groupBox5.Controls.Add(this.p_desktop);
            this.groupBox5.Controls.Add(this.rb_tLabtop);
            this.groupBox5.Controls.Add(this.rb_tDesktop);
            this.groupBox5.Location = new System.Drawing.Point(12, 314);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(261, 122);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Type";
            // 
            // rb_tLabtop
            // 
            this.rb_tLabtop.AutoSize = true;
            this.rb_tLabtop.Location = new System.Drawing.Point(140, 20);
            this.rb_tLabtop.Name = "rb_tLabtop";
            this.rb_tLabtop.Size = new System.Drawing.Size(58, 17);
            this.rb_tLabtop.TabIndex = 1;
            this.rb_tLabtop.Text = "Laptop";
            this.rb_tLabtop.UseVisualStyleBackColor = true;
            this.rb_tLabtop.CheckedChanged += new System.EventHandler(this.rb_type_CheckedChanged);
            // 
            // rb_tDesktop
            // 
            this.rb_tDesktop.AutoSize = true;
            this.rb_tDesktop.Checked = true;
            this.rb_tDesktop.Location = new System.Drawing.Point(25, 20);
            this.rb_tDesktop.Name = "rb_tDesktop";
            this.rb_tDesktop.Size = new System.Drawing.Size(65, 17);
            this.rb_tDesktop.TabIndex = 0;
            this.rb_tDesktop.TabStop = true;
            this.rb_tDesktop.Text = "Desktop";
            this.rb_tDesktop.UseVisualStyleBackColor = true;
            this.rb_tDesktop.CheckedChanged += new System.EventHandler(this.rb_type_CheckedChanged);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btn_fermer);
            this.groupBox6.Controls.Add(this.btn_exporter);
            this.groupBox6.Controls.Add(this.btn_lister);
            this.groupBox6.Controls.Add(this.btn_supprimer);
            this.groupBox6.Controls.Add(this.btn_modifier);
            this.groupBox6.Controls.Add(this.btn_ajouter);
            this.groupBox6.Controls.Add(this.btn_nouveau);
            this.groupBox6.Location = new System.Drawing.Point(546, 33);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(127, 403);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Boîte à outils";
            // 
            // btn_fermer
            // 
            this.btn_fermer.Location = new System.Drawing.Point(19, 345);
            this.btn_fermer.Name = "btn_fermer";
            this.btn_fermer.Size = new System.Drawing.Size(89, 45);
            this.btn_fermer.TabIndex = 6;
            this.btn_fermer.Text = "Fermer";
            this.btn_fermer.UseVisualStyleBackColor = true;
            // 
            // btn_exporter
            // 
            this.btn_exporter.Location = new System.Drawing.Point(19, 291);
            this.btn_exporter.Name = "btn_exporter";
            this.btn_exporter.Size = new System.Drawing.Size(89, 45);
            this.btn_exporter.TabIndex = 5;
            this.btn_exporter.Text = "Exporter";
            this.btn_exporter.UseVisualStyleBackColor = true;
            // 
            // btn_lister
            // 
            this.btn_lister.Location = new System.Drawing.Point(19, 237);
            this.btn_lister.Name = "btn_lister";
            this.btn_lister.Size = new System.Drawing.Size(89, 45);
            this.btn_lister.TabIndex = 4;
            this.btn_lister.Text = "Lister...";
            this.btn_lister.UseVisualStyleBackColor = true;
            // 
            // btn_supprimer
            // 
            this.btn_supprimer.Location = new System.Drawing.Point(19, 183);
            this.btn_supprimer.Name = "btn_supprimer";
            this.btn_supprimer.Size = new System.Drawing.Size(89, 45);
            this.btn_supprimer.TabIndex = 3;
            this.btn_supprimer.Text = "Supprimer";
            this.btn_supprimer.UseVisualStyleBackColor = true;
            // 
            // btn_modifier
            // 
            this.btn_modifier.Location = new System.Drawing.Point(19, 129);
            this.btn_modifier.Name = "btn_modifier";
            this.btn_modifier.Size = new System.Drawing.Size(89, 45);
            this.btn_modifier.TabIndex = 2;
            this.btn_modifier.Text = "Modifier";
            this.btn_modifier.UseVisualStyleBackColor = true;
            // 
            // btn_ajouter
            // 
            this.btn_ajouter.Location = new System.Drawing.Point(19, 75);
            this.btn_ajouter.Name = "btn_ajouter";
            this.btn_ajouter.Size = new System.Drawing.Size(89, 45);
            this.btn_ajouter.TabIndex = 1;
            this.btn_ajouter.Text = "Ajouter";
            this.btn_ajouter.UseVisualStyleBackColor = true;
            // 
            // btn_nouveau
            // 
            this.btn_nouveau.Location = new System.Drawing.Point(19, 21);
            this.btn_nouveau.Name = "btn_nouveau";
            this.btn_nouveau.Size = new System.Drawing.Size(89, 45);
            this.btn_nouveau.TabIndex = 0;
            this.btn_nouveau.Text = "Nouveau";
            this.btn_nouveau.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(221, 10);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(242, 20);
            this.label10.TabIndex = 6;
            this.label10.Text = "Gestion du parc informatique";
            // 
            // p_desktop
            // 
            this.p_desktop.Controls.Add(this.txt_souris);
            this.p_desktop.Controls.Add(this.txt_clavier);
            this.p_desktop.Controls.Add(this.label8);
            this.p_desktop.Controls.Add(this.label9);
            this.p_desktop.Location = new System.Drawing.Point(8, 41);
            this.p_desktop.Name = "p_desktop";
            this.p_desktop.Size = new System.Drawing.Size(246, 70);
            this.p_desktop.TabIndex = 2;
            // 
            // txt_souris
            // 
            this.txt_souris.Location = new System.Drawing.Point(72, 40);
            this.txt_souris.Name = "txt_souris";
            this.txt_souris.Size = new System.Drawing.Size(162, 20);
            this.txt_souris.TabIndex = 14;
            // 
            // txt_clavier
            // 
            this.txt_clavier.Location = new System.Drawing.Point(72, 11);
            this.txt_clavier.Name = "txt_clavier";
            this.txt_clavier.Size = new System.Drawing.Size(162, 20);
            this.txt_clavier.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 43);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Souris :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Clavier :";
            // 
            // btn_couleur
            // 
            this.btn_couleur.BackColor = System.Drawing.Color.Red;
            this.btn_couleur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_couleur.Location = new System.Drawing.Point(72, 39);
            this.btn_couleur.Name = "btn_couleur";
            this.btn_couleur.Size = new System.Drawing.Size(162, 22);
            this.btn_couleur.TabIndex = 15;
            this.btn_couleur.Text = "Choisir...";
            this.btn_couleur.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_couleur.UseVisualStyleBackColor = false;
            this.btn_couleur.Click += new System.EventHandler(this.btn_couleur_Click);
            // 
            // p_laptop
            // 
            this.p_laptop.Controls.Add(this.btn_couleur);
            this.p_laptop.Controls.Add(this.txt_autonomie);
            this.p_laptop.Controls.Add(this.label13);
            this.p_laptop.Controls.Add(this.label14);
            this.p_laptop.Location = new System.Drawing.Point(6, 41);
            this.p_laptop.Name = "p_laptop";
            this.p_laptop.Size = new System.Drawing.Size(246, 70);
            this.p_laptop.TabIndex = 7;
            // 
            // txt_autonomie
            // 
            this.txt_autonomie.Location = new System.Drawing.Point(72, 11);
            this.txt_autonomie.Name = "txt_autonomie";
            this.txt_autonomie.Size = new System.Drawing.Size(162, 20);
            this.txt_autonomie.TabIndex = 13;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(8, 43);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(49, 13);
            this.label13.TabIndex = 12;
            this.label13.Text = "Couleur :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(8, 14);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(63, 13);
            this.label14.TabIndex = 11;
            this.label14.Text = "Autonomie :";
            // 
            // p1
            // 
            this.p1.ContainerControl = this;
            // 
            // ofdiag
            // 
            this.ofdiag.Filter = "Images JPEG | *.jpg";
            // 
            // Frm_gestOrd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 446);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Frm_gestOrd";
            this.Text = "Parc informatique";
            this.Load += new System.EventHandler(this.Frm_gestOrd_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_photo)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.p_desktop.ResumeLayout(false);
            this.p_desktop.PerformLayout();
            this.p_laptop.ResumeLayout(false);
            this.p_laptop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.p1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton rb_tLabtop;
        private System.Windows.Forms.RadioButton rb_tDesktop;
        private System.Windows.Forms.DateTimePicker dtp_garantie;
        private System.Windows.Forms.TextBox txt_modele;
        private System.Windows.Forms.TextBox txt_marque;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pb_photo;
        private System.Windows.Forms.Button btn_parcourir;
        private System.Windows.Forms.ComboBox cmb_eType;
        private System.Windows.Forms.TextBox txt_eTaille;
        private System.Windows.Forms.TextBox txt_eMarque;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.CheckedListBox cklb_se;
        private System.Windows.Forms.Button btn_fermer;
        private System.Windows.Forms.Button btn_exporter;
        private System.Windows.Forms.Button btn_lister;
        private System.Windows.Forms.Button btn_supprimer;
        private System.Windows.Forms.Button btn_modifier;
        private System.Windows.Forms.Button btn_ajouter;
        private System.Windows.Forms.Button btn_nouveau;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox ckb_graveur;
        private System.Windows.Forms.ComboBox cmb_nserie;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel p_laptop;
        private System.Windows.Forms.Button btn_couleur;
        private System.Windows.Forms.TextBox txt_autonomie;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel p_desktop;
        private System.Windows.Forms.TextBox txt_souris;
        private System.Windows.Forms.TextBox txt_clavier;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ErrorProvider p1;
        private System.Windows.Forms.ColorDialog cdiag;
        private System.Windows.Forms.OpenFileDialog ofdiag;
    }
}