using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PEOO_EFM_2018.Classes;
using System.Data.SqlClient;

namespace PEOO_EFM_2018
{
    public partial class Frm_ListeOrd : Form
    {
        public Frm_ListeOrd()
        {
            InitializeComponent();
        }

        private void Frm_ListeOrd_Load(object sender, EventArgs e)
        {
            cmb_fMarque.Items.Clear();
            cmb_fMarque.Items.Add("[tous]");
            foreach (Ordinateur ordi in Program.parc)
            {
                if(!cmb_fMarque.Items.Contains(ordi.Marque))
                    cmb_fMarque.Items.Add(ordi.Marque);
            }
            listView1.Columns.Clear();
            listView1.Columns.Add("Ordinateur");
            listView1.Columns.Add("Graveur?");
            listView1.Columns.Add("Date fin garantie");
            listView1.Columns.Add("Ecran");
        }
        
        private void Charger()
        {
            List<Ordinateur> lst = new List<Ordinateur>();
            if (rb_tTous.Checked)
            {
                lst.AddRange(Program.parc);
            }
            else if (rb_tDesktop.Checked)
            {
                foreach (Ordinateur ordi in Program.parc)
                    if (ordi is DesktopPC)
                        lst.Add(ordi);
            }
            else
            {
                foreach (Ordinateur ordi in Program.parc)
                    if (ordi is LaptopPC)
                        lst.Add(ordi);
            }
            if (cmb_fMarque.SelectedIndex > 0)
            {
                for (int i = 0; i < lst.Count; i++)
                {
                    if (lst[i].Marque != cmb_fMarque.Text)
                    {
                        lst.RemoveAt(i);
                        i--;
                    }
                }
            }
            dgv.DataSource = null;
            dgv.DataSource = lst;
            int c = 0;
            listView1.Items.Clear();
            ImageList imgS = new ImageList();
            ImageList imgL = new ImageList();
            imgL.ColorDepth = ColorDepth.Depth32Bit;
            imgS.ColorDepth = ColorDepth.Depth32Bit;
            imgL.ImageSize = new Size(128, 128);
            imgS.ImageSize = new Size(64, 64);
            listView1.LargeImageList = imgL;
            listView1.SmallImageList = imgS;

            foreach (Ordinateur ordi in lst)
            {
                imgL.Images.Add(ordi.Photo);
                imgS.Images.Add(ordi.Photo);
                ListViewItem item = new ListViewItem(ordi.Marque + " " + ordi.Modele, c);
                item.SubItems.Add(ordi.Graveur ? "Oui" : "Non");
                item.SubItems.Add(ordi.DateFinGarantie.ToShortDateString());
                item.SubItems.Add(ordi.EcranOrdi.ToString());
                listView1.Items.Add(item);
                c++;
            }
        }

        private void rb_type_CheckedChanged(object sender, EventArgs e)
        {
            Charger();
        }

        private void btn_Valider_Click(object sender, EventArgs e)
        {
            Charger();
        }

        private void rb_affichage_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_aDetails.Checked)
                listView1.View = View.Details;
            else if (rb_aLargeIcone.Checked)
                listView1.View = View.LargeIcon;
            else if (rb_aList.Checked)
                listView1.View = View.List;
            else if (rb_aSmallIcone.Checked)
                listView1.View = View.SmallIcon;
            else
                listView1.View = View.Tile;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlConnection cnx= new SqlConnection("Data Source=.;Initial Catalog=efm_asp_2018;Integrated Security=True");
            SqlDataAdapter da = new SqlDataAdapter("select * from article",cnx);
            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            da.Fill(dt);
            foreach (Ordinateur o in Program.parc)
            {
                DataRow dr = dt.NewRow();
                dr["libelle"] = o.Marque + " " + o.Modele;
                dt.Rows.Add(dr);
            }
            da.Update(dt);
        }
    }
}
