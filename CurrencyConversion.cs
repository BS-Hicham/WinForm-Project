using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PE_TP_04.Classes.Ex03;

namespace PE_TP_04
{
    public partial class Ex_03 : Form
    {
        public Ex_03()
        {
            InitializeComponent();
        }
        const int y0 = 20;
        const int DELTA_X = 15, DELTA_Y = 5,TXT_L=75,LBL_L=30,H_MIN=185,H_MAX=425;

        private void Ex_03_Load(object sender, EventArgs e)
        {
            this.Height = H_MIN;
            cmb_iDev.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_iDev.Items.Clear();
            foreach (string dev in Enum.GetNames(typeof(Devise)))
            {
                cmb_iDev.Items.Add(dev);
            }
        }

        private void btn_convertir_Click(object sender, EventArgs e)
        {
            if (cmb_iDev.Text != "")
            {
                int x = 60;
                foreach (Devise dev in Enum.GetValues(typeof(Devise)))
                {
                    if (dev != (Devise)Enum.Parse(typeof(Devise), cmb_iDev.Text))
                    {
                        Label lbl = new Label();
                        lbl.Text = dev.ToString();
                        lbl.Width = LBL_L;
                        lbl.Location = new Point(x, y0);
                        TextBox txt = new TextBox();
                        txt.Width = TXT_L;
                        txt.Enabled = false;
                        txt.Text = Convertisseur.Convertir(double.Parse(txt_iVal.Text), (Devise)Enum.Parse(typeof(Devise), cmb_iDev.Text), dev).ToString();
                        txt.Location = new Point(x - (txt.Width - lbl.Width) / 2, y0 + lbl.Height + DELTA_Y);
                        grb1.Controls.Add(lbl);
                        grb1.Controls.Add(txt);
                        x += TXT_L + DELTA_X;
                    }
                }
                cmb_iDev.Enabled = false;
                txt_iVal.Enabled = false;
                this.Height = H_MAX;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            grb1.Controls.Clear();
            this.Height = H_MIN;
            txt_iVal.Enabled = true;
            txt_iVal.Select();
            cmb_iDev.Enabled = true;
        }
    }
}
