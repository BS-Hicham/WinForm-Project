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
using System.Runtime.Serialization.Formatters.Binary;

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
                        cklb_se.SetItemChecked(i, ordi.isSEinstalled(cklb_se.Items[i].ToString()));
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

        private void btn_nouveau_Click(object sender, EventArgs e)
        {
            txt_autonomie.Clear();
            txt_clavier.Clear();
            txt_eMarque.Clear();
            txt_eTaille.Clear();
            txt_marque.Clear();
            txt_modele.Clear();
            txt_souris.Clear();
            pb_photo.Image = null;
        }

        private void btn_ajouter_Click(object sender, EventArgs e)
        {
            Ordinateur ordi = null;
            if (txt_marque.Text != "" && txt_modele.Text != "" && txt_eMarque.Text != "")
            {
                Ecran ec = new Ecran(txt_eMarque.Text, int.Parse(txt_eTaille.Text), (TypeEcran)Enum.Parse(typeof(TypeEcran), cmb_eType.Text));

                if (rb_tDesktop.Checked)
                {
                    if (txt_souris.Text != "" && txt_clavier.Text != "")
                    {
                        ordi = new DesktopPC(txt_marque.Text, txt_modele.Text, dtp_garantie.Value, ckb_graveur.Checked, pb_photo.Image, ec, txt_clavier.Text, txt_souris.Text);
                    }
                    else
                    {
                        MessageBox.Show("veuillez remplir tous les champs");
                    }
                }
                else
                {
                    if (txt_autonomie.Text != "")
                    {
                        ordi = new LaptopPC(txt_marque.Text, txt_modele.Text, dtp_garantie.Value, ckb_graveur.Checked, pb_photo.Image, ec, double.Parse(txt_autonomie.Text), btn_couleur.BackColor);
                    }
                    else
                    {
                        MessageBox.Show("veuillez remplir tous les champs");
                    }
                }

                SystemeExploitation se;
                for (int i = 0; i < cklb_se.CheckedItems.Count; i++)
                {
                    se = Program.RechercheSEparStr(cklb_se.CheckedItems[i].ToString());
                    ordi.AjouterSE(se);
                }
                Program.parc.Add(ordi);
                cmb_nserie.Items.Add(ordi.NSerie.ToString());
            }
            else
                MessageBox.Show("veuillez remplir tous les champs");
        }

        private void btn_modifier_Click(object sender, EventArgs e)
        {
            if (cmb_nserie.SelectedIndex != -1)
            {
                Ordinateur ordi = Program.RechercherParNserie(long.Parse(cmb_nserie.Text));
                if (ordi != null)
                {
                    if (txt_marque.Text != "" && txt_modele.Text != "" && txt_eMarque.Text != "" && txt_eTaille.Text != "")
                    {
                        ordi.Marque = txt_marque.Text;
                        ordi.Modele = txt_modele.Text;
                        ordi.Graveur = ckb_graveur.Checked;
                        ordi.DateDebutGarantie = dtp_garantie.Value;
                        ordi.EcranOrdi.Marque = txt_eMarque.Text;
                        ordi.EcranOrdi.Taille = int.Parse(txt_eTaille.Text);
                        ordi.EcranOrdi.TEcran = (TypeEcran)Enum.Parse(typeof(TypeEcran), cmb_eType.Text);
                        ordi.Photo = pb_photo.Image;

                        if (rb_tDesktop.Checked)
                        {
                            if (txt_souris.Text != "" && txt_clavier.Text != "")
                            {
                                ((DesktopPC)ordi).Souris = txt_souris.Text;
                                ((DesktopPC)ordi).Clavier = txt_clavier.Text;
                            }
                            else
                            {
                                MessageBox.Show("veuillez remplir tous les champs");
                            }
                        }
                        else
                        {
                            if (txt_autonomie.Text != "")
                            {
                                ((LaptopPC)ordi).Autonomie = int.Parse(txt_autonomie.Text);
                                ((LaptopPC)ordi).Couleur = btn_couleur.BackColor;
                            }
                            else
                            {
                                MessageBox.Show("veuillez remplir tous les champs");
                            }
                        }

                        SystemeExploitation se;
                        ordi.SE.Clear();
                        for (int i = 0; i < cklb_se.CheckedItems.Count; i++)
                        {
                            se = Program.RechercheSEparStr(cklb_se.CheckedItems[i].ToString());
                            ordi.AjouterSE(se);
                        }
                    }
                    else
                    {
                        MessageBox.Show("veuillez remplir tous les champs");
                    }
                }
                else
                    MessageBox.Show("Ordinateur introuvable");
            }
        }

        private void btn_supprimer_Click(object sender, EventArgs e)
        {
            if (cmb_nserie.SelectedIndex != -1)
            {
                Ordinateur ordi = Program.RechercherParNserie(long.Parse(cmb_nserie.Text));
                if (ordi != null)
                {
                    Program.parc.Remove(ordi);
                }
                else
                {
                    MessageBox.Show("Ordinateur introuvable");
                }
            }
        }

        private void btn_lister_Click(object sender, EventArgs e)
        {
            Frm_ListeOrd f = new Frm_ListeOrd();
            f.Show();
        }

        private void btn_exporter_Click(object sender, EventArgs e)
        {
            if (sfdiag.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Program.chemin = sfdiag.FileName;
                FileStream fs =new FileStream(sfdiag.FileName,FileMode.Create);
                BinaryFormatter formatter = new BinaryFormatter();
                try
                {
                    formatter.Serialize(fs, Program.parc);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    fs.Close();
                }
            }
        }

        private void btn_importer_Click(object sender, EventArgs e)
        {
            if (Program.chemin != "")
                ofdiag2.FileName = Program.chemin;
            if (ofdiag2.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                
                FileStream fs = new FileStream(ofdiag2.FileName, FileMode.Open);
                BinaryFormatter formatter = new BinaryFormatter();
                try
                {
                    List<Ordinateur> lst = null;
                    lst = (List<Ordinateur>)formatter.Deserialize(fs);
                    if (Program.parc.Count > 0)
                        if (MessageBox.Show("voulez vous effacer les données existants", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Yes)
                            Program.parc.Clear();
                    Program.parc.AddRange(lst);
                    Frm_gestOrd_Load(this, null);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    fs.Close();
                }
            }
        }
    }
}
