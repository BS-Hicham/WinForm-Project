using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PEOO_EFM_2018.Classes;
using System.IO;

namespace PEOO_EFM_2018
{
    public partial class Frm_gestOrd : Form
    {
        public Frm_gestOrd()
        {
            InitializeComponent();
        }

        private void Frm_gestOrd_Load(object sender, EventArgs e)
        {
            cmb_nserie.Items.Clear();
            foreach (Ordinateur item in Program.parc)
            {
                cmb_nserie.Items.Add(item.NSerie.ToString());
            }
            cmb_eType.Items.Clear();
            foreach (string s in Enum.GetNames(typeof(TypeEcran)))
            {
                cmb_eType.Items.Add(s);
            }
            cklb_se.Items.Clear();
            foreach (SystemeExploitation se in Program.systemes)
            {
                cklb_se.Items.Add(se.ToString());
            }
            rb_tLabtop.Checked = true;
        }

        private void cmb_nserie_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_nserie.SelectedIndex != -1)
            {
                Ordinateur ordi = Program.RechercherParNserie(long.Parse(cmb_nserie.Text));
                if (ordi != null)
                {
                    txt_marque.Text = ordi.Marque;
                    txt_modele.Text = ordi.Modele;
                    ckb_graveur.Checked = ordi.Graveur;
                    dtp_garantie.Value = ordi.DateDebutGarantie;
                    txt_eMarque.Text = ordi.EcranOrdi.Marque;
                    txt_eTaille.Text = ordi.EcranOrdi.Taille.ToString();
                    cmb_eType.Text = ordi.EcranOrdi.TEcran.ToString();
                    pb_photo.Image = ordi.Photo;
                    for (int i = 0; i < cklb_se.Items.Count; i++)
                    {
                        cklb_se.SetItemChecked(i,ordi.isSEinstalled(cklb_se.Items[i].ToString()));
                    }
                    if (ordi is DesktopPC)
                    {
                        DesktopPC dpc = (DesktopPC)ordi;
                        txt_souris.Text = dpc.Souris;
                        txt_clavier.Text = dpc.Clavier;
                        rb_tDesktop.Checked = true;
                    }
                    else
                    {
                        LaptopPC lpc = (LaptopPC)ordi;
                        txt_autonomie.Text = lpc.Autonomie.ToString();
                        btn_couleur.BackColor = lpc.Couleur;
                        rb_tLabtop.Checked = true;

                    }
                }
                else
                    MessageBox.Show("N° de serie introuvable");
            }
        }

        private void rb_type_CheckedChanged(object sender, EventArgs e)
        {
            p_desktop.Visible = rb_tDesktop.Checked;
            p_laptop.Visible = rb_tLabtop.Checked;
        }

        private void btn_parcourir_Click(object sender, EventArgs e)
        {
            if (ofdiag.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                pb_photo.Image = Image.FromFile(ofdiag.FileName);
            }

        }

        private void btn_couleur_Click(object sender, EventArgs e)
        {
            if (cdiag.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                btn_couleur.BackColor = cdiag.Color;
            }
        }

        
    }
}
