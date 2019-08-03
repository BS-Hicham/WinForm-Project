using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PEOO_EFM_2017_2.Classes;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace PEOO_EFM_2017_2
{
    public partial class Form1 : Form
    {
//A
        Disque disq_c = new Disque('C', 755277);

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
//B-1
            txt_disque.Text = disq_c.Lettre.ToString();
            lbl_espase.Text = disq_c.Capacite.ToString();
            Pb_icone.Image = Dossier.IconeParDefaut;
            cmb_dossiers.Items.Add(@"C:\");
            cmb_dossiers.SelectedIndex = 0;
            grb_fichier.Enabled = false;
            lv_contenu.View = View.Details;
            lv_contenu.Columns.Add("Nom");
            lv_contenu.Columns.Add("Créer le");
            lv_contenu.Columns.Add("Type");
            lv_contenu.Columns.Add("Taille");



        }

        private void Cb_fichier_CheckedChanged(object sender, EventArgs e)
        {
//B-2
            grb_fichier.Enabled = Cb_fichier.Checked;
        }

        private void btn_icone_Click(object sender, EventArgs e)
        {
//B-3
            
            Ofdiag_icone.Filter = "Images|*.ico";
            if (Ofdiag_icone.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Pb_icone.Image = Image.FromFile(Ofdiag_icone.FileName);
                //ou
                //Pb_icone.ImageLocation = Ofdiag_icone.FileName;
            }
        }

        private void btn_ajouter_Click(object sender, EventArgs e)
        {
//B-4
            //	Créer un dossier (ou fichier) et ajouter le à la collections des dossiers du disq_c.
            //	Afficher le message d’exception au cas d’un espace insuffisant sur le disque.
            //	Ajouter le chemin du dossier (seulement les dossiers) au ComboBox cmb_dossiers

            Dossier d;
            if (Cb_fichier.Checked)
            {
                d = new Fichier(txt_nom.Text, Pb_icone.Image, disq_c.DossierParChemin(cmb_dossiers.Text), txt_extension.Text, long.Parse(txt_taille.Text));
            }
            else
            {
                d = new Dossier(txt_nom.Text, Pb_icone.Image, disq_c.DossierParChemin(cmb_dossiers.Text));
                cmb_dossiers.Items.Add(d.Chemin());
            }
            try
            {
                disq_c.AjouterDossier(d);
                ////
                ////
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); 
            }

        }

        private void btn_afficher_Click(object sender, EventArgs e)
        {
//B-5
            foreach (Dossier d in disq_c.Dossiers)
            {
                if (!(d is Fichier))
                {
                    lb_dossiers.Items.Add(d.Chemin());
                }
            }
        }

        private void lb_dossiers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lb_dossiers.SelectedIndex != -1)
            {
                ImageList imgL=new ImageList();
                ImageList imgS=new ImageList();
                imgL.ImageSize=new Size(64,64);
                imgS.ImageSize=new Size(16,16);
                lv_contenu.SmallImageList=imgS;
                lv_contenu.LargeImageList=imgL;
                int c=0;

                lv_contenu.Groups.Add("Dossiers","Groupe de Dossiers");
                lv_contenu.Groups.Add("Fichiers","Groupe de Fichier");

                foreach (Dossier d in disq_c.Contenu(lb_dossiers.Text))
                {
                    imgL.Images.Add(d.Icone);
                    imgS.Images.Add(d.Icone);

                    ListViewItem item;
                    if (d is Fichier)
                    {
                        item = new ListViewItem(d.Nom, c, lv_contenu.Groups[1]);
                        item.SubItems.Add(d.DateCreation.ToShortDateString());
                        item.SubItems.Add("Fichier de type" + ((Fichier)d).Ext);
                        item.SubItems.Add(((Fichier)d).Taille.ToString() + " Ko");
                    }
                    else
                    {
                        item = new ListViewItem(d.Nom, c, lv_contenu.Groups[0]);
                        item.SubItems.Add(d.DateCreation.ToShortDateString());
                        item.SubItems.Add("Dossier de fichiers");
                        item.SubItems.Add("");
                    }
                    lv_contenu.Items.Add(item);
                    c++;
                }
            }
        }

        private void btn_sauvgarder_Click(object sender, EventArgs e)
        {
//B-7
            if (sfDiag.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                FileStream fs = new FileStream(sfDiag.FileName, FileMode.Create, FileAccess.Write);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, disq_c);
                fs.Close();

            }
            
        }

        private void btn_charger_Click(object sender, EventArgs e)
        {
            if (ofdiag.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                FileStream fs = new FileStream(ofdiag.FileName, FileMode.Open, FileAccess.Read);
                BinaryFormatter bf = new BinaryFormatter();
                disq_c=(Disque) bf.Deserialize(fs);
                fs.Close();
            }
        }
    }
}
