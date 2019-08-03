namespace PEOO_EFM_2017_2
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
            this.lb_dossiers = new System.Windows.Forms.ListBox();
            this.txt_taille = new System.Windows.Forms.TextBox();
            this.lv_contenu = new System.Windows.Forms.ListView();
            this.grb_affichage = new System.Windows.Forms.GroupBox();
            this.rd_pt_icone = new System.Windows.Forms.RadioButton();
            this.rd_gd_icone = new System.Windows.Forms.RadioButton();
            this.rd_detail = new System.Windows.Forms.RadioButton();
            this.rd_liste = new System.Windows.Forms.RadioButton();
            this.btn_icone = new System.Windows.Forms.Button();
            this.btn_charger = new System.Windows.Forms.Button();
            this.Cb_fichier = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_sauvgarder = new System.Windows.Forms.Button();
            this.btn_afficher = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.Pb_icone = new System.Windows.Forms.PictureBox();
            this.btn_ajouter = new System.Windows.Forms.Button();
            this.lbl_espase = new System.Windows.Forms.Label();
            this.grb_fichier = new System.Windows.Forms.GroupBox();
            this.txt_extension = new System.Windows.Forms.TextBox();
            this.txt_nom = new System.Windows.Forms.TextBox();
            this.txt_disque = new System.Windows.Forms.TextBox();
            this.Dtp_creer = new System.Windows.Forms.DateTimePicker();
            this.cmb_dossiers = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Ofdiag_icone = new System.Windows.Forms.OpenFileDialog();
            this.Img_la = new System.Windows.Forms.ImageList(this.components);
            this.Img_sm = new System.Windows.Forms.ImageList(this.components);
            this.sfDiag = new System.Windows.Forms.SaveFileDialog();
            this.ofdiag = new System.Windows.Forms.OpenFileDialog();
            this.grb_affichage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_icone)).BeginInit();
            this.grb_fichier.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_dossiers
            // 
            this.lb_dossiers.FormattingEnabled = true;
            this.lb_dossiers.Location = new System.Drawing.Point(34, 249);
            this.lb_dossiers.Name = "lb_dossiers";
            this.lb_dossiers.Size = new System.Drawing.Size(169, 173);
            this.lb_dossiers.TabIndex = 62;
            this.lb_dossiers.SelectedIndexChanged += new System.EventHandler(this.lb_dossiers_SelectedIndexChanged);
            // 
            // txt_taille
            // 
            this.txt_taille.Location = new System.Drawing.Point(91, 52);
            this.txt_taille.Name = "txt_taille";
            this.txt_taille.Size = new System.Drawing.Size(100, 20);
            this.txt_taille.TabIndex = 4;
            // 
            // lv_contenu
            // 
            this.lv_contenu.Location = new System.Drawing.Point(209, 249);
            this.lv_contenu.Name = "lv_contenu";
            this.lv_contenu.Size = new System.Drawing.Size(510, 169);
            this.lv_contenu.TabIndex = 61;
            this.lv_contenu.UseCompatibleStateImageBehavior = false;
            // 
            // grb_affichage
            // 
            this.grb_affichage.Controls.Add(this.rd_pt_icone);
            this.grb_affichage.Controls.Add(this.rd_gd_icone);
            this.grb_affichage.Controls.Add(this.rd_detail);
            this.grb_affichage.Controls.Add(this.rd_liste);
            this.grb_affichage.Location = new System.Drawing.Point(358, 153);
            this.grb_affichage.Name = "grb_affichage";
            this.grb_affichage.Size = new System.Drawing.Size(348, 91);
            this.grb_affichage.TabIndex = 60;
            this.grb_affichage.TabStop = false;
            this.grb_affichage.Text = "Affichage";
            // 
            // rd_pt_icone
            // 
            this.rd_pt_icone.AutoSize = true;
            this.rd_pt_icone.Location = new System.Drawing.Point(193, 53);
            this.rd_pt_icone.Name = "rd_pt_icone";
            this.rd_pt_icone.Size = new System.Drawing.Size(91, 17);
            this.rd_pt_icone.TabIndex = 3;
            this.rd_pt_icone.TabStop = true;
            this.rd_pt_icone.Text = "Petites icones";
            this.rd_pt_icone.UseVisualStyleBackColor = true;
            // 
            // rd_gd_icone
            // 
            this.rd_gd_icone.AutoSize = true;
            this.rd_gd_icone.Location = new System.Drawing.Point(193, 30);
            this.rd_gd_icone.Name = "rd_gd_icone";
            this.rd_gd_icone.Size = new System.Drawing.Size(99, 17);
            this.rd_gd_icone.TabIndex = 2;
            this.rd_gd_icone.TabStop = true;
            this.rd_gd_icone.Text = "Grandes icones";
            this.rd_gd_icone.UseVisualStyleBackColor = true;
            // 
            // rd_detail
            // 
            this.rd_detail.AutoSize = true;
            this.rd_detail.Location = new System.Drawing.Point(39, 53);
            this.rd_detail.Name = "rd_detail";
            this.rd_detail.Size = new System.Drawing.Size(57, 17);
            this.rd_detail.TabIndex = 1;
            this.rd_detail.TabStop = true;
            this.rd_detail.Text = "Details";
            this.rd_detail.UseVisualStyleBackColor = true;
            // 
            // rd_liste
            // 
            this.rd_liste.AutoSize = true;
            this.rd_liste.Location = new System.Drawing.Point(39, 30);
            this.rd_liste.Name = "rd_liste";
            this.rd_liste.Size = new System.Drawing.Size(47, 17);
            this.rd_liste.TabIndex = 0;
            this.rd_liste.TabStop = true;
            this.rd_liste.Text = "Liste";
            this.rd_liste.UseVisualStyleBackColor = true;
            // 
            // btn_icone
            // 
            this.btn_icone.Location = new System.Drawing.Point(470, 22);
            this.btn_icone.Name = "btn_icone";
            this.btn_icone.Size = new System.Drawing.Size(60, 116);
            this.btn_icone.TabIndex = 59;
            this.btn_icone.Text = "Icone...";
            this.btn_icone.UseVisualStyleBackColor = true;
            this.btn_icone.Click += new System.EventHandler(this.btn_icone_Click);
            // 
            // btn_charger
            // 
            this.btn_charger.Location = new System.Drawing.Point(551, 115);
            this.btn_charger.Name = "btn_charger";
            this.btn_charger.Size = new System.Drawing.Size(155, 23);
            this.btn_charger.TabIndex = 58;
            this.btn_charger.Text = "Charger";
            this.btn_charger.UseVisualStyleBackColor = true;
            this.btn_charger.Click += new System.EventHandler(this.btn_charger_Click);
            // 
            // Cb_fichier
            // 
            this.Cb_fichier.AutoSize = true;
            this.Cb_fichier.Location = new System.Drawing.Point(9, -1);
            this.Cb_fichier.Name = "Cb_fichier";
            this.Cb_fichier.Size = new System.Drawing.Size(57, 17);
            this.Cb_fichier.TabIndex = 2;
            this.Cb_fichier.Text = "Fichier";
            this.Cb_fichier.UseVisualStyleBackColor = true;
            this.Cb_fichier.CheckedChanged += new System.EventHandler(this.Cb_fichier_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(34, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Taille";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Extention";
            // 
            // btn_sauvgarder
            // 
            this.btn_sauvgarder.Location = new System.Drawing.Point(551, 83);
            this.btn_sauvgarder.Name = "btn_sauvgarder";
            this.btn_sauvgarder.Size = new System.Drawing.Size(155, 23);
            this.btn_sauvgarder.TabIndex = 57;
            this.btn_sauvgarder.Text = "Sauvgarder";
            this.btn_sauvgarder.UseVisualStyleBackColor = true;
            this.btn_sauvgarder.Click += new System.EventHandler(this.btn_sauvgarder_Click);
            // 
            // btn_afficher
            // 
            this.btn_afficher.Location = new System.Drawing.Point(551, 51);
            this.btn_afficher.Name = "btn_afficher";
            this.btn_afficher.Size = new System.Drawing.Size(155, 23);
            this.btn_afficher.TabIndex = 56;
            this.btn_afficher.Text = "Afficher";
            this.btn_afficher.UseVisualStyleBackColor = true;
            this.btn_afficher.Click += new System.EventHandler(this.btn_afficher_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(365, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 13);
            this.label8.TabIndex = 55;
            this.label8.Text = "Image";
            // 
            // Pb_icone
            // 
            this.Pb_icone.Location = new System.Drawing.Point(358, 50);
            this.Pb_icone.Name = "Pb_icone";
            this.Pb_icone.Size = new System.Drawing.Size(100, 82);
            this.Pb_icone.TabIndex = 53;
            this.Pb_icone.TabStop = false;
            // 
            // btn_ajouter
            // 
            this.btn_ajouter.Location = new System.Drawing.Point(551, 22);
            this.btn_ajouter.Name = "btn_ajouter";
            this.btn_ajouter.Size = new System.Drawing.Size(155, 23);
            this.btn_ajouter.TabIndex = 54;
            this.btn_ajouter.Text = "Ajouter";
            this.btn_ajouter.UseVisualStyleBackColor = true;
            this.btn_ajouter.Click += new System.EventHandler(this.btn_ajouter_Click);
            // 
            // lbl_espase
            // 
            this.lbl_espase.AutoSize = true;
            this.lbl_espase.Location = new System.Drawing.Point(172, 22);
            this.lbl_espase.Name = "lbl_espase";
            this.lbl_espase.Size = new System.Drawing.Size(57, 13);
            this.lbl_espase.TabIndex = 52;
            this.lbl_espase.Text = "lbl_espase";
            // 
            // grb_fichier
            // 
            this.grb_fichier.Controls.Add(this.txt_taille);
            this.grb_fichier.Controls.Add(this.txt_extension);
            this.grb_fichier.Controls.Add(this.Cb_fichier);
            this.grb_fichier.Controls.Add(this.label7);
            this.grb_fichier.Controls.Add(this.label6);
            this.grb_fichier.Location = new System.Drawing.Point(118, 143);
            this.grb_fichier.Name = "grb_fichier";
            this.grb_fichier.Size = new System.Drawing.Size(200, 100);
            this.grb_fichier.TabIndex = 51;
            this.grb_fichier.TabStop = false;
            // 
            // txt_extension
            // 
            this.txt_extension.Location = new System.Drawing.Point(91, 22);
            this.txt_extension.Name = "txt_extension";
            this.txt_extension.Size = new System.Drawing.Size(100, 20);
            this.txt_extension.TabIndex = 3;
            // 
            // txt_nom
            // 
            this.txt_nom.Location = new System.Drawing.Point(118, 112);
            this.txt_nom.Name = "txt_nom";
            this.txt_nom.Size = new System.Drawing.Size(200, 20);
            this.txt_nom.TabIndex = 50;
            // 
            // txt_disque
            // 
            this.txt_disque.Enabled = false;
            this.txt_disque.Location = new System.Drawing.Point(97, 19);
            this.txt_disque.Name = "txt_disque";
            this.txt_disque.Size = new System.Drawing.Size(57, 20);
            this.txt_disque.TabIndex = 49;
            // 
            // Dtp_creer
            // 
            this.Dtp_creer.Enabled = false;
            this.Dtp_creer.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Dtp_creer.Location = new System.Drawing.Point(118, 50);
            this.Dtp_creer.Name = "Dtp_creer";
            this.Dtp_creer.Size = new System.Drawing.Size(200, 20);
            this.Dtp_creer.TabIndex = 48;
            // 
            // cmb_dossiers
            // 
            this.cmb_dossiers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_dossiers.FormattingEnabled = true;
            this.cmb_dossiers.Location = new System.Drawing.Point(118, 80);
            this.cmb_dossiers.Name = "cmb_dossiers";
            this.cmb_dossiers.Size = new System.Drawing.Size(200, 21);
            this.cmb_dossiers.TabIndex = 47;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 46;
            this.label5.Text = "Details fichier";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 45;
            this.label4.Text = "Nom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 44;
            this.label3.Text = "Dossier parent";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 43;
            this.label2.Text = "Date de creation";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 42;
            this.label1.Text = "Disque local";
            // 
            // Ofdiag_icone
            // 
            this.Ofdiag_icone.FileName = "openFileDialog1";
            // 
            // Img_la
            // 
            this.Img_la.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.Img_la.ImageSize = new System.Drawing.Size(16, 16);
            this.Img_la.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // Img_sm
            // 
            this.Img_sm.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.Img_sm.ImageSize = new System.Drawing.Size(16, 16);
            this.Img_sm.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // ofdiag
            // 
            this.ofdiag.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 424);
            this.Controls.Add(this.lb_dossiers);
            this.Controls.Add(this.lv_contenu);
            this.Controls.Add(this.grb_affichage);
            this.Controls.Add(this.btn_icone);
            this.Controls.Add(this.btn_charger);
            this.Controls.Add(this.btn_sauvgarder);
            this.Controls.Add(this.btn_afficher);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Pb_icone);
            this.Controls.Add(this.btn_ajouter);
            this.Controls.Add(this.lbl_espase);
            this.Controls.Add(this.grb_fichier);
            this.Controls.Add(this.txt_nom);
            this.Controls.Add(this.txt_disque);
            this.Controls.Add(this.Dtp_creer);
            this.Controls.Add(this.cmb_dossiers);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grb_affichage.ResumeLayout(false);
            this.grb_affichage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_icone)).EndInit();
            this.grb_fichier.ResumeLayout(false);
            this.grb_fichier.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lb_dossiers;
        private System.Windows.Forms.TextBox txt_taille;
        private System.Windows.Forms.ListView lv_contenu;
        private System.Windows.Forms.GroupBox grb_affichage;
        private System.Windows.Forms.RadioButton rd_pt_icone;
        private System.Windows.Forms.RadioButton rd_gd_icone;
        private System.Windows.Forms.RadioButton rd_detail;
        private System.Windows.Forms.RadioButton rd_liste;
        private System.Windows.Forms.Button btn_icone;
        private System.Windows.Forms.Button btn_charger;
        private System.Windows.Forms.CheckBox Cb_fichier;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_sauvgarder;
        private System.Windows.Forms.Button btn_afficher;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox Pb_icone;
        private System.Windows.Forms.Button btn_ajouter;
        private System.Windows.Forms.Label lbl_espase;
        private System.Windows.Forms.GroupBox grb_fichier;
        private System.Windows.Forms.TextBox txt_extension;
        private System.Windows.Forms.TextBox txt_nom;
        private System.Windows.Forms.TextBox txt_disque;
        private System.Windows.Forms.DateTimePicker Dtp_creer;
        private System.Windows.Forms.ComboBox cmb_dossiers;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog Ofdiag_icone;
        private System.Windows.Forms.ImageList Img_la;
        private System.Windows.Forms.ImageList Img_sm;
        private System.Windows.Forms.SaveFileDialog sfDiag;
        private System.Windows.Forms.OpenFileDialog ofdiag;
    }
}

