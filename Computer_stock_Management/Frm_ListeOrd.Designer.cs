namespace PEOO_EFM_2018
{
    partial class Frm_ListeOrd
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
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.rb_tTous = new System.Windows.Forms.RadioButton();
            this.rb_tLabtop = new System.Windows.Forms.RadioButton();
            this.rb_tDesktop = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb_aTile = new System.Windows.Forms.RadioButton();
            this.rb_aDetails = new System.Windows.Forms.RadioButton();
            this.rb_aSmallIcone = new System.Windows.Forms.RadioButton();
            this.rb_aLargeIcone = new System.Windows.Forms.RadioButton();
            this.rb_aList = new System.Windows.Forms.RadioButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.listView1 = new System.Windows.Forms.ListView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_Valider = new System.Windows.Forms.Button();
            this.cmb_fMarque = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.rb_tTous);
            this.groupBox5.Controls.Add(this.rb_tLabtop);
            this.groupBox5.Controls.Add(this.rb_tDesktop);
            this.groupBox5.Location = new System.Drawing.Point(12, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(117, 95);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Type";
            // 
            // rb_tTous
            // 
            this.rb_tTous.AutoSize = true;
            this.rb_tTous.Location = new System.Drawing.Point(25, 68);
            this.rb_tTous.Name = "rb_tTous";
            this.rb_tTous.Size = new System.Drawing.Size(45, 17);
            this.rb_tTous.TabIndex = 2;
            this.rb_tTous.Text = "tous";
            this.rb_tTous.UseVisualStyleBackColor = true;
            this.rb_tTous.CheckedChanged += new System.EventHandler(this.rb_type_CheckedChanged);
            // 
            // rb_tLabtop
            // 
            this.rb_tLabtop.AutoSize = true;
            this.rb_tLabtop.Location = new System.Drawing.Point(25, 43);
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
            this.rb_tDesktop.Location = new System.Drawing.Point(25, 18);
            this.rb_tDesktop.Name = "rb_tDesktop";
            this.rb_tDesktop.Size = new System.Drawing.Size(65, 17);
            this.rb_tDesktop.TabIndex = 0;
            this.rb_tDesktop.TabStop = true;
            this.rb_tDesktop.Text = "Desktop";
            this.rb_tDesktop.UseVisualStyleBackColor = true;
            this.rb_tDesktop.CheckedChanged += new System.EventHandler(this.rb_type_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_aTile);
            this.groupBox1.Controls.Add(this.rb_aDetails);
            this.groupBox1.Controls.Add(this.rb_aSmallIcone);
            this.groupBox1.Controls.Add(this.rb_aLargeIcone);
            this.groupBox1.Controls.Add(this.rb_aList);
            this.groupBox1.Location = new System.Drawing.Point(145, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(218, 95);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Affichage";
            // 
            // rb_aTile
            // 
            this.rb_aTile.AutoSize = true;
            this.rb_aTile.Location = new System.Drawing.Point(127, 43);
            this.rb_aTile.Name = "rb_aTile";
            this.rb_aTile.Size = new System.Drawing.Size(78, 17);
            this.rb_aTile.TabIndex = 4;
            this.rb_aTile.Text = "Mosaïques";
            this.rb_aTile.UseVisualStyleBackColor = true;
            this.rb_aTile.CheckedChanged += new System.EventHandler(this.rb_affichage_CheckedChanged);
            // 
            // rb_aDetails
            // 
            this.rb_aDetails.AutoSize = true;
            this.rb_aDetails.Location = new System.Drawing.Point(127, 18);
            this.rb_aDetails.Name = "rb_aDetails";
            this.rb_aDetails.Size = new System.Drawing.Size(57, 17);
            this.rb_aDetails.TabIndex = 3;
            this.rb_aDetails.Text = "Détails";
            this.rb_aDetails.UseVisualStyleBackColor = true;
            this.rb_aDetails.CheckedChanged += new System.EventHandler(this.rb_affichage_CheckedChanged);
            // 
            // rb_aSmallIcone
            // 
            this.rb_aSmallIcone.AutoSize = true;
            this.rb_aSmallIcone.Location = new System.Drawing.Point(11, 68);
            this.rb_aSmallIcone.Name = "rb_aSmallIcone";
            this.rb_aSmallIcone.Size = new System.Drawing.Size(91, 17);
            this.rb_aSmallIcone.TabIndex = 2;
            this.rb_aSmallIcone.Text = "Petites icônes";
            this.rb_aSmallIcone.UseVisualStyleBackColor = true;
            this.rb_aSmallIcone.CheckedChanged += new System.EventHandler(this.rb_affichage_CheckedChanged);
            // 
            // rb_aLargeIcone
            // 
            this.rb_aLargeIcone.AutoSize = true;
            this.rb_aLargeIcone.Location = new System.Drawing.Point(11, 44);
            this.rb_aLargeIcone.Name = "rb_aLargeIcone";
            this.rb_aLargeIcone.Size = new System.Drawing.Size(99, 17);
            this.rb_aLargeIcone.TabIndex = 1;
            this.rb_aLargeIcone.Text = "Grandes icônes";
            this.rb_aLargeIcone.UseVisualStyleBackColor = true;
            this.rb_aLargeIcone.CheckedChanged += new System.EventHandler(this.rb_affichage_CheckedChanged);
            // 
            // rb_aList
            // 
            this.rb_aList.AutoSize = true;
            this.rb_aList.Checked = true;
            this.rb_aList.Location = new System.Drawing.Point(11, 20);
            this.rb_aList.Name = "rb_aList";
            this.rb_aList.Size = new System.Drawing.Size(47, 17);
            this.rb_aList.TabIndex = 0;
            this.rb_aList.TabStop = true;
            this.rb_aList.Text = "Liste";
            this.rb_aList.UseVisualStyleBackColor = true;
            this.rb_aList.CheckedChanged += new System.EventHandler(this.rb_affichage_CheckedChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 113);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(601, 302);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgv);
            this.tabPage1.Location = new System.Drawing.Point(4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(593, 276);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "GridView";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.Location = new System.Drawing.Point(3, 3);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.Size = new System.Drawing.Size(587, 270);
            this.dgv.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.listView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(593, 276);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "ListView";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Location = new System.Drawing.Point(3, 3);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(587, 270);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_Valider);
            this.groupBox2.Controls.Add(this.cmb_fMarque);
            this.groupBox2.Location = new System.Drawing.Point(381, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(228, 95);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filtrer par marque";
            // 
            // btn_Valider
            // 
            this.btn_Valider.Location = new System.Drawing.Point(30, 62);
            this.btn_Valider.Name = "btn_Valider";
            this.btn_Valider.Size = new System.Drawing.Size(178, 23);
            this.btn_Valider.TabIndex = 1;
            this.btn_Valider.Text = "Valider";
            this.btn_Valider.UseVisualStyleBackColor = true;
            this.btn_Valider.Click += new System.EventHandler(this.btn_Valider_Click);
            // 
            // cmb_fMarque
            // 
            this.cmb_fMarque.Location = new System.Drawing.Point(30, 25);
            this.cmb_fMarque.Name = "cmb_fMarque";
            this.cmb_fMarque.Size = new System.Drawing.Size(178, 21);
            this.cmb_fMarque.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(274, -7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Frm_ListeOrd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 423);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox5);
            this.Name = "Frm_ListeOrd";
            this.Text = "Frm_ListeOrd";
            this.Load += new System.EventHandler(this.Frm_ListeOrd_Load);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton rb_tTous;
        private System.Windows.Forms.RadioButton rb_tLabtop;
        private System.Windows.Forms.RadioButton rb_tDesktop;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb_aTile;
        private System.Windows.Forms.RadioButton rb_aDetails;
        private System.Windows.Forms.RadioButton rb_aSmallIcone;
        private System.Windows.Forms.RadioButton rb_aLargeIcone;
        private System.Windows.Forms.RadioButton rb_aList;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_Valider;
        private System.Windows.Forms.ComboBox cmb_fMarque;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button button1;
    }

    partial class Copy2OfFrm_ListeOrd
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
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.rb_tTous = new System.Windows.Forms.RadioButton();
            this.rb_tLabtop = new System.Windows.Forms.RadioButton();
            this.rb_tDesktop = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb_aTile = new System.Windows.Forms.RadioButton();
            this.rb_aDetails = new System.Windows.Forms.RadioButton();
            this.rb_aSmallIcone = new System.Windows.Forms.RadioButton();
            this.rb_aLargeIcone = new System.Windows.Forms.RadioButton();
            this.rb_aList = new System.Windows.Forms.RadioButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.listView1 = new System.Windows.Forms.ListView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_Valider = new System.Windows.Forms.Button();
            this.cmb_fMarque = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.rb_tTous);
            this.groupBox5.Controls.Add(this.rb_tLabtop);
            this.groupBox5.Controls.Add(this.rb_tDesktop);
            this.groupBox5.Location = new System.Drawing.Point(12, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(117, 95);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Type";
            // 
            // rb_tTous
            // 
            this.rb_tTous.AutoSize = true;
            this.rb_tTous.Location = new System.Drawing.Point(25, 68);
            this.rb_tTous.Name = "rb_tTous";
            this.rb_tTous.Size = new System.Drawing.Size(45, 17);
            this.rb_tTous.TabIndex = 2;
            this.rb_tTous.Text = "tous";
            this.rb_tTous.UseVisualStyleBackColor = true;
            this.rb_tTous.CheckedChanged += new System.EventHandler(this.rb_type_CheckedChanged);
            // 
            // rb_tLabtop
            // 
            this.rb_tLabtop.AutoSize = true;
            this.rb_tLabtop.Location = new System.Drawing.Point(25, 43);
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
            this.rb_tDesktop.Location = new System.Drawing.Point(25, 18);
            this.rb_tDesktop.Name = "rb_tDesktop";
            this.rb_tDesktop.Size = new System.Drawing.Size(65, 17);
            this.rb_tDesktop.TabIndex = 0;
            this.rb_tDesktop.TabStop = true;
            this.rb_tDesktop.Text = "Desktop";
            this.rb_tDesktop.UseVisualStyleBackColor = true;
            this.rb_tDesktop.CheckedChanged += new System.EventHandler(this.rb_type_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_aTile);
            this.groupBox1.Controls.Add(this.rb_aDetails);
            this.groupBox1.Controls.Add(this.rb_aSmallIcone);
            this.groupBox1.Controls.Add(this.rb_aLargeIcone);
            this.groupBox1.Controls.Add(this.rb_aList);
            this.groupBox1.Location = new System.Drawing.Point(145, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(218, 95);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Affichage";
            // 
            // rb_aTile
            // 
            this.rb_aTile.AutoSize = true;
            this.rb_aTile.Location = new System.Drawing.Point(127, 43);
            this.rb_aTile.Name = "rb_aTile";
            this.rb_aTile.Size = new System.Drawing.Size(78, 17);
            this.rb_aTile.TabIndex = 4;
            this.rb_aTile.Text = "Mosaïques";
            this.rb_aTile.UseVisualStyleBackColor = true;
            this.rb_aTile.CheckedChanged += new System.EventHandler(this.rb_affichage_CheckedChanged);
            // 
            // rb_aDetails
            // 
            this.rb_aDetails.AutoSize = true;
            this.rb_aDetails.Location = new System.Drawing.Point(127, 18);
            this.rb_aDetails.Name = "rb_aDetails";
            this.rb_aDetails.Size = new System.Drawing.Size(57, 17);
            this.rb_aDetails.TabIndex = 3;
            this.rb_aDetails.Text = "Détails";
            this.rb_aDetails.UseVisualStyleBackColor = true;
            this.rb_aDetails.CheckedChanged += new System.EventHandler(this.rb_affichage_CheckedChanged);
            // 
            // rb_aSmallIcone
            // 
            this.rb_aSmallIcone.AutoSize = true;
            this.rb_aSmallIcone.Location = new System.Drawing.Point(11, 68);
            this.rb_aSmallIcone.Name = "rb_aSmallIcone";
            this.rb_aSmallIcone.Size = new System.Drawing.Size(91, 17);
            this.rb_aSmallIcone.TabIndex = 2;
            this.rb_aSmallIcone.Text = "Petites icônes";
            this.rb_aSmallIcone.UseVisualStyleBackColor = true;
            this.rb_aSmallIcone.CheckedChanged += new System.EventHandler(this.rb_affichage_CheckedChanged);
            // 
            // rb_aLargeIcone
            // 
            this.rb_aLargeIcone.AutoSize = true;
            this.rb_aLargeIcone.Location = new System.Drawing.Point(11, 44);
            this.rb_aLargeIcone.Name = "rb_aLargeIcone";
            this.rb_aLargeIcone.Size = new System.Drawing.Size(99, 17);
            this.rb_aLargeIcone.TabIndex = 1;
            this.rb_aLargeIcone.Text = "Grandes icônes";
            this.rb_aLargeIcone.UseVisualStyleBackColor = true;
            this.rb_aLargeIcone.CheckedChanged += new System.EventHandler(this.rb_affichage_CheckedChanged);
            // 
            // rb_aList
            // 
            this.rb_aList.AutoSize = true;
            this.rb_aList.Checked = true;
            this.rb_aList.Location = new System.Drawing.Point(11, 20);
            this.rb_aList.Name = "rb_aList";
            this.rb_aList.Size = new System.Drawing.Size(47, 17);
            this.rb_aList.TabIndex = 0;
            this.rb_aList.TabStop = true;
            this.rb_aList.Text = "Liste";
            this.rb_aList.UseVisualStyleBackColor = true;
            this.rb_aList.CheckedChanged += new System.EventHandler(this.rb_affichage_CheckedChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 113);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(601, 302);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgv);
            this.tabPage1.Location = new System.Drawing.Point(4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(593, 276);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "GridView";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.Location = new System.Drawing.Point(3, 3);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.Size = new System.Drawing.Size(587, 270);
            this.dgv.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.listView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(593, 276);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "ListView";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Location = new System.Drawing.Point(3, 3);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(587, 270);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_Valider);
            this.groupBox2.Controls.Add(this.cmb_fMarque);
            this.groupBox2.Location = new System.Drawing.Point(381, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(228, 95);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filtrer par marque";
            // 
            // btn_Valider
            // 
            this.btn_Valider.Location = new System.Drawing.Point(30, 62);
            this.btn_Valider.Name = "btn_Valider";
            this.btn_Valider.Size = new System.Drawing.Size(178, 23);
            this.btn_Valider.TabIndex = 1;
            this.btn_Valider.Text = "Valider";
            this.btn_Valider.UseVisualStyleBackColor = true;
            this.btn_Valider.Click += new System.EventHandler(this.btn_Valider_Click);
            // 
            // cmb_fMarque
            // 
            this.cmb_fMarque.Location = new System.Drawing.Point(30, 25);
            this.cmb_fMarque.Name = "cmb_fMarque";
            this.cmb_fMarque.Size = new System.Drawing.Size(178, 21);
            this.cmb_fMarque.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(274, -7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Copy2OfFrm_ListeOrd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 423);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox5);
            this.Name = "Copy2OfFrm_ListeOrd";
            this.Text = "Copy2OfFrm_ListeOrd";
            this.Load += new System.EventHandler(this.Frm_ListeOrd_Load);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton rb_tTous;
        private System.Windows.Forms.RadioButton rb_tLabtop;
        private System.Windows.Forms.RadioButton rb_tDesktop;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb_aTile;
        private System.Windows.Forms.RadioButton rb_aDetails;
        private System.Windows.Forms.RadioButton rb_aSmallIcone;
        private System.Windows.Forms.RadioButton rb_aLargeIcone;
        private System.Windows.Forms.RadioButton rb_aList;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_Valider;
        private System.Windows.Forms.ComboBox cmb_fMarque;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button button1;
    }

    partial class Copy1OfFrm_ListeOrd
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
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.rb_tTous = new System.Windows.Forms.RadioButton();
            this.rb_tLabtop = new System.Windows.Forms.RadioButton();
            this.rb_tDesktop = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb_aTile = new System.Windows.Forms.RadioButton();
            this.rb_aDetails = new System.Windows.Forms.RadioButton();
            this.rb_aSmallIcone = new System.Windows.Forms.RadioButton();
            this.rb_aLargeIcone = new System.Windows.Forms.RadioButton();
            this.rb_aList = new System.Windows.Forms.RadioButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.listView1 = new System.Windows.Forms.ListView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_Valider = new System.Windows.Forms.Button();
            this.cmb_fMarque = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.rb_tTous);
            this.groupBox5.Controls.Add(this.rb_tLabtop);
            this.groupBox5.Controls.Add(this.rb_tDesktop);
            this.groupBox5.Location = new System.Drawing.Point(12, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(117, 95);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Type";
            // 
            // rb_tTous
            // 
            this.rb_tTous.AutoSize = true;
            this.rb_tTous.Location = new System.Drawing.Point(25, 68);
            this.rb_tTous.Name = "rb_tTous";
            this.rb_tTous.Size = new System.Drawing.Size(45, 17);
            this.rb_tTous.TabIndex = 2;
            this.rb_tTous.Text = "tous";
            this.rb_tTous.UseVisualStyleBackColor = true;
            this.rb_tTous.CheckedChanged += new System.EventHandler(this.rb_type_CheckedChanged);
            // 
            // rb_tLabtop
            // 
            this.rb_tLabtop.AutoSize = true;
            this.rb_tLabtop.Location = new System.Drawing.Point(25, 43);
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
            this.rb_tDesktop.Location = new System.Drawing.Point(25, 18);
            this.rb_tDesktop.Name = "rb_tDesktop";
            this.rb_tDesktop.Size = new System.Drawing.Size(65, 17);
            this.rb_tDesktop.TabIndex = 0;
            this.rb_tDesktop.TabStop = true;
            this.rb_tDesktop.Text = "Desktop";
            this.rb_tDesktop.UseVisualStyleBackColor = true;
            this.rb_tDesktop.CheckedChanged += new System.EventHandler(this.rb_type_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_aTile);
            this.groupBox1.Controls.Add(this.rb_aDetails);
            this.groupBox1.Controls.Add(this.rb_aSmallIcone);
            this.groupBox1.Controls.Add(this.rb_aLargeIcone);
            this.groupBox1.Controls.Add(this.rb_aList);
            this.groupBox1.Location = new System.Drawing.Point(145, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(218, 95);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Affichage";
            // 
            // rb_aTile
            // 
            this.rb_aTile.AutoSize = true;
            this.rb_aTile.Location = new System.Drawing.Point(127, 43);
            this.rb_aTile.Name = "rb_aTile";
            this.rb_aTile.Size = new System.Drawing.Size(78, 17);
            this.rb_aTile.TabIndex = 4;
            this.rb_aTile.Text = "Mosaïques";
            this.rb_aTile.UseVisualStyleBackColor = true;
            this.rb_aTile.CheckedChanged += new System.EventHandler(this.rb_affichage_CheckedChanged);
            // 
            // rb_aDetails
            // 
            this.rb_aDetails.AutoSize = true;
            this.rb_aDetails.Location = new System.Drawing.Point(127, 18);
            this.rb_aDetails.Name = "rb_aDetails";
            this.rb_aDetails.Size = new System.Drawing.Size(57, 17);
            this.rb_aDetails.TabIndex = 3;
            this.rb_aDetails.Text = "Détails";
            this.rb_aDetails.UseVisualStyleBackColor = true;
            this.rb_aDetails.CheckedChanged += new System.EventHandler(this.rb_affichage_CheckedChanged);
            // 
            // rb_aSmallIcone
            // 
            this.rb_aSmallIcone.AutoSize = true;
            this.rb_aSmallIcone.Location = new System.Drawing.Point(11, 68);
            this.rb_aSmallIcone.Name = "rb_aSmallIcone";
            this.rb_aSmallIcone.Size = new System.Drawing.Size(91, 17);
            this.rb_aSmallIcone.TabIndex = 2;
            this.rb_aSmallIcone.Text = "Petites icônes";
            this.rb_aSmallIcone.UseVisualStyleBackColor = true;
            this.rb_aSmallIcone.CheckedChanged += new System.EventHandler(this.rb_affichage_CheckedChanged);
            // 
            // rb_aLargeIcone
            // 
            this.rb_aLargeIcone.AutoSize = true;
            this.rb_aLargeIcone.Location = new System.Drawing.Point(11, 44);
            this.rb_aLargeIcone.Name = "rb_aLargeIcone";
            this.rb_aLargeIcone.Size = new System.Drawing.Size(99, 17);
            this.rb_aLargeIcone.TabIndex = 1;
            this.rb_aLargeIcone.Text = "Grandes icônes";
            this.rb_aLargeIcone.UseVisualStyleBackColor = true;
            this.rb_aLargeIcone.CheckedChanged += new System.EventHandler(this.rb_affichage_CheckedChanged);
            // 
            // rb_aList
            // 
            this.rb_aList.AutoSize = true;
            this.rb_aList.Checked = true;
            this.rb_aList.Location = new System.Drawing.Point(11, 20);
            this.rb_aList.Name = "rb_aList";
            this.rb_aList.Size = new System.Drawing.Size(47, 17);
            this.rb_aList.TabIndex = 0;
            this.rb_aList.TabStop = true;
            this.rb_aList.Text = "Liste";
            this.rb_aList.UseVisualStyleBackColor = true;
            this.rb_aList.CheckedChanged += new System.EventHandler(this.rb_affichage_CheckedChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 113);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(601, 302);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgv);
            this.tabPage1.Location = new System.Drawing.Point(4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(593, 276);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "GridView";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.Location = new System.Drawing.Point(3, 3);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.Size = new System.Drawing.Size(587, 270);
            this.dgv.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.listView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(593, 276);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "ListView";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Location = new System.Drawing.Point(3, 3);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(587, 270);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_Valider);
            this.groupBox2.Controls.Add(this.cmb_fMarque);
            this.groupBox2.Location = new System.Drawing.Point(381, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(228, 95);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filtrer par marque";
            // 
            // btn_Valider
            // 
            this.btn_Valider.Location = new System.Drawing.Point(30, 62);
            this.btn_Valider.Name = "btn_Valider";
            this.btn_Valider.Size = new System.Drawing.Size(178, 23);
            this.btn_Valider.TabIndex = 1;
            this.btn_Valider.Text = "Valider";
            this.btn_Valider.UseVisualStyleBackColor = true;
            this.btn_Valider.Click += new System.EventHandler(this.btn_Valider_Click);
            // 
            // cmb_fMarque
            // 
            this.cmb_fMarque.Location = new System.Drawing.Point(30, 25);
            this.cmb_fMarque.Name = "cmb_fMarque";
            this.cmb_fMarque.Size = new System.Drawing.Size(178, 21);
            this.cmb_fMarque.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(274, -7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Copy1OfFrm_ListeOrd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 423);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox5);
            this.Name = "Copy1OfFrm_ListeOrd";
            this.Text = "Copy1OfFrm_ListeOrd";
            this.Load += new System.EventHandler(this.Frm_ListeOrd_Load);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton rb_tTous;
        private System.Windows.Forms.RadioButton rb_tLabtop;
        private System.Windows.Forms.RadioButton rb_tDesktop;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb_aTile;
        private System.Windows.Forms.RadioButton rb_aDetails;
        private System.Windows.Forms.RadioButton rb_aSmallIcone;
        private System.Windows.Forms.RadioButton rb_aLargeIcone;
        private System.Windows.Forms.RadioButton rb_aList;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_Valider;
        private System.Windows.Forms.ComboBox cmb_fMarque;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button button1;
    }

    partial class CopyOfFrm_ListeOrd
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
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.rb_tTous = new System.Windows.Forms.RadioButton();
            this.rb_tLabtop = new System.Windows.Forms.RadioButton();
            this.rb_tDesktop = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb_aTile = new System.Windows.Forms.RadioButton();
            this.rb_aDetails = new System.Windows.Forms.RadioButton();
            this.rb_aSmallIcone = new System.Windows.Forms.RadioButton();
            this.rb_aLargeIcone = new System.Windows.Forms.RadioButton();
            this.rb_aList = new System.Windows.Forms.RadioButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.listView1 = new System.Windows.Forms.ListView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_Valider = new System.Windows.Forms.Button();
            this.cmb_fMarque = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.rb_tTous);
            this.groupBox5.Controls.Add(this.rb_tLabtop);
            this.groupBox5.Controls.Add(this.rb_tDesktop);
            this.groupBox5.Location = new System.Drawing.Point(12, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(117, 95);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Type";
            // 
            // rb_tTous
            // 
            this.rb_tTous.AutoSize = true;
            this.rb_tTous.Location = new System.Drawing.Point(25, 68);
            this.rb_tTous.Name = "rb_tTous";
            this.rb_tTous.Size = new System.Drawing.Size(45, 17);
            this.rb_tTous.TabIndex = 2;
            this.rb_tTous.Text = "tous";
            this.rb_tTous.UseVisualStyleBackColor = true;
            this.rb_tTous.CheckedChanged += new System.EventHandler(this.rb_type_CheckedChanged);
            // 
            // rb_tLabtop
            // 
            this.rb_tLabtop.AutoSize = true;
            this.rb_tLabtop.Location = new System.Drawing.Point(25, 43);
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
            this.rb_tDesktop.Location = new System.Drawing.Point(25, 18);
            this.rb_tDesktop.Name = "rb_tDesktop";
            this.rb_tDesktop.Size = new System.Drawing.Size(65, 17);
            this.rb_tDesktop.TabIndex = 0;
            this.rb_tDesktop.TabStop = true;
            this.rb_tDesktop.Text = "Desktop";
            this.rb_tDesktop.UseVisualStyleBackColor = true;
            this.rb_tDesktop.CheckedChanged += new System.EventHandler(this.rb_type_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_aTile);
            this.groupBox1.Controls.Add(this.rb_aDetails);
            this.groupBox1.Controls.Add(this.rb_aSmallIcone);
            this.groupBox1.Controls.Add(this.rb_aLargeIcone);
            this.groupBox1.Controls.Add(this.rb_aList);
            this.groupBox1.Location = new System.Drawing.Point(145, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(218, 95);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Affichage";
            // 
            // rb_aTile
            // 
            this.rb_aTile.AutoSize = true;
            this.rb_aTile.Location = new System.Drawing.Point(127, 43);
            this.rb_aTile.Name = "rb_aTile";
            this.rb_aTile.Size = new System.Drawing.Size(78, 17);
            this.rb_aTile.TabIndex = 4;
            this.rb_aTile.Text = "Mosaïques";
            this.rb_aTile.UseVisualStyleBackColor = true;
            this.rb_aTile.CheckedChanged += new System.EventHandler(this.rb_affichage_CheckedChanged);
            // 
            // rb_aDetails
            // 
            this.rb_aDetails.AutoSize = true;
            this.rb_aDetails.Location = new System.Drawing.Point(127, 18);
            this.rb_aDetails.Name = "rb_aDetails";
            this.rb_aDetails.Size = new System.Drawing.Size(57, 17);
            this.rb_aDetails.TabIndex = 3;
            this.rb_aDetails.Text = "Détails";
            this.rb_aDetails.UseVisualStyleBackColor = true;
            this.rb_aDetails.CheckedChanged += new System.EventHandler(this.rb_affichage_CheckedChanged);
            // 
            // rb_aSmallIcone
            // 
            this.rb_aSmallIcone.AutoSize = true;
            this.rb_aSmallIcone.Location = new System.Drawing.Point(11, 68);
            this.rb_aSmallIcone.Name = "rb_aSmallIcone";
            this.rb_aSmallIcone.Size = new System.Drawing.Size(91, 17);
            this.rb_aSmallIcone.TabIndex = 2;
            this.rb_aSmallIcone.Text = "Petites icônes";
            this.rb_aSmallIcone.UseVisualStyleBackColor = true;
            this.rb_aSmallIcone.CheckedChanged += new System.EventHandler(this.rb_affichage_CheckedChanged);
            // 
            // rb_aLargeIcone
            // 
            this.rb_aLargeIcone.AutoSize = true;
            this.rb_aLargeIcone.Location = new System.Drawing.Point(11, 44);
            this.rb_aLargeIcone.Name = "rb_aLargeIcone";
            this.rb_aLargeIcone.Size = new System.Drawing.Size(99, 17);
            this.rb_aLargeIcone.TabIndex = 1;
            this.rb_aLargeIcone.Text = "Grandes icônes";
            this.rb_aLargeIcone.UseVisualStyleBackColor = true;
            this.rb_aLargeIcone.CheckedChanged += new System.EventHandler(this.rb_affichage_CheckedChanged);
            // 
            // rb_aList
            // 
            this.rb_aList.AutoSize = true;
            this.rb_aList.Checked = true;
            this.rb_aList.Location = new System.Drawing.Point(11, 20);
            this.rb_aList.Name = "rb_aList";
            this.rb_aList.Size = new System.Drawing.Size(47, 17);
            this.rb_aList.TabIndex = 0;
            this.rb_aList.TabStop = true;
            this.rb_aList.Text = "Liste";
            this.rb_aList.UseVisualStyleBackColor = true;
            this.rb_aList.CheckedChanged += new System.EventHandler(this.rb_affichage_CheckedChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 113);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(601, 302);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgv);
            this.tabPage1.Location = new System.Drawing.Point(4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(593, 276);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "GridView";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.Location = new System.Drawing.Point(3, 3);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.Size = new System.Drawing.Size(587, 270);
            this.dgv.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.listView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(593, 276);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "ListView";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Location = new System.Drawing.Point(3, 3);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(587, 270);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_Valider);
            this.groupBox2.Controls.Add(this.cmb_fMarque);
            this.groupBox2.Location = new System.Drawing.Point(381, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(228, 95);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filtrer par marque";
            // 
            // btn_Valider
            // 
            this.btn_Valider.Location = new System.Drawing.Point(30, 62);
            this.btn_Valider.Name = "btn_Valider";
            this.btn_Valider.Size = new System.Drawing.Size(178, 23);
            this.btn_Valider.TabIndex = 1;
            this.btn_Valider.Text = "Valider";
            this.btn_Valider.UseVisualStyleBackColor = true;
            this.btn_Valider.Click += new System.EventHandler(this.btn_Valider_Click);
            // 
            // cmb_fMarque
            // 
            this.cmb_fMarque.Location = new System.Drawing.Point(30, 25);
            this.cmb_fMarque.Name = "cmb_fMarque";
            this.cmb_fMarque.Size = new System.Drawing.Size(178, 21);
            this.cmb_fMarque.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(274, -7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CopyOfFrm_ListeOrd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 423);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox5);
            this.Name = "CopyOfFrm_ListeOrd";
            this.Text = "CopyOfFrm_ListeOrd";
            this.Load += new System.EventHandler(this.Frm_ListeOrd_Load);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton rb_tTous;
        private System.Windows.Forms.RadioButton rb_tLabtop;
        private System.Windows.Forms.RadioButton rb_tDesktop;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb_aTile;
        private System.Windows.Forms.RadioButton rb_aDetails;
        private System.Windows.Forms.RadioButton rb_aSmallIcone;
        private System.Windows.Forms.RadioButton rb_aLargeIcone;
        private System.Windows.Forms.RadioButton rb_aList;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_Valider;
        private System.Windows.Forms.ComboBox cmb_fMarque;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button button1;
    }
}