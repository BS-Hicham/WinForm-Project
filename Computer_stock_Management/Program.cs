using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using PEOO_EFM_2018.Classes;
using System.Drawing;

namespace PEOO_EFM_2018
{
    static class Program
    {
        public static List<Ordinateur> parc = new List<Ordinateur>();
        public static List<SystemeExploitation> systemes = new List<SystemeExploitation>();
        public static string chemin = "";
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //init parc
            parc.Add(new DesktopPC("HP", "600G1", new DateTime(2017, 6, 15), true,new Bitmap(@"Images\hpd1.jpg"), new Ecran("LG 500F", 17, TypeEcran.LED), "Logitec 104 touches", "Logitec 3b"));
            parc.Add(new DesktopPC("Acer", "Extensa M26", new DateTime(2018, 6, 1), true, new Bitmap(@"Images\Acer.jpg"), new Ecran("HP 22es", 21, TypeEcran.LCD), "Jedel 104 touches", "Jedel 2.4GHz"));
            parc.Add(new LaptopPC("HP", "ENVY touchsmart", new DateTime(2018, 6, 15), false, new Bitmap(@"Images\hpd1.jpg"), new Ecran("HP", 17, TypeEcran.LED), 3, Color.Red));
            parc.Add(new LaptopPC("Dell", "inspiron 3552", new DateTime(2019, 5, 5), false, new Bitmap(@"Images\dell.jpg"), new Ecran("Dell", 15, TypeEcran.LED), 3, Color.Yellow));
            parc.Add(new LaptopPC("ASUS", "GL702VS", new DateTime(2018, 8, 1), false, new Bitmap(@"Images\asus.jpg"), new Ecran("ASUS", 15, TypeEcran.LED), 3, Color.Red));
            parc.Add(new DesktopPC("Dell", "T3610 station", new DateTime(2017, 12, 21), true, new Bitmap(@"Images\delld.jpg"), new Ecran("LG 500F", 17, TypeEcran.LED), "HP multi 104 touches", "Logitec 3b"));
            parc.Add(new DesktopPC("Apple", "iMac", new DateTime(2017, 6, 10), true, new Bitmap(@"Images\appeld.jpg"), new Ecran("Apple", 21, TypeEcran.OLED), "Compaq 104 touches", "Compaq 3b"));
            parc.Add(new LaptopPC("Lenovo", "Thinkpad x270", new DateTime(2017, 10, 5), true, new Bitmap(@"Images\Lenovo.jpg"), new Ecran("Lenovo", 21, TypeEcran.OLED), 3, Color.Blue));
            parc.Add(new LaptopPC("ASUS", "X541UA", new DateTime(2017, 3, 10), false, new Bitmap(@"Images\asus2.jpg"), new Ecran("ASUS", 17, TypeEcran.LED), 3, Color.Black));
            //init se
            systemes.Add(new SystemeExploitation("Linux 3.0", new DateTime(2011, 1, 1), 32));
            systemes.Add(new SystemeExploitation("Mac OS X 10.7", new DateTime(2011, 1, 1), 64));
            systemes.Add(new SystemeExploitation("OS X 10.8 Mountain", new DateTime(2012, 1, 1), 32));
            systemes.Add(new SystemeExploitation("Windows 8", new DateTime(2012, 10, 26), 64));
            systemes.Add(new SystemeExploitation("AmigaOS 4.1 Final Edition", new DateTime(2014, 1, 1), 32));
            systemes.Add(new SystemeExploitation("RedHat 7", new DateTime(2014, 1, 1), 32));
            systemes.Add(new SystemeExploitation("Windows 10", new DateTime(2015, 7, 9), 64));
            systemes.Add(new SystemeExploitation("MacOS Sierra 10.12", new DateTime(2016, 1, 1), 32));
            systemes.Add(new SystemeExploitation("Windows Server 2016", new DateTime(2016, 1, 1), 32));

            parc[0].AjouterSE(systemes[1]);
            parc[0].AjouterSE(systemes[3]);
            parc[1].AjouterSE(systemes[2]);
            parc[1].AjouterSE(systemes[3]);
            parc[2].AjouterSE(systemes[1]);
            parc[2].AjouterSE(systemes[4]);
            parc[2].AjouterSE(systemes[5]);
            parc[3].AjouterSE(systemes[6]);
            parc[4].AjouterSE(systemes[1]);
            parc[4].AjouterSE(systemes[2]);
            parc[4].AjouterSE(systemes[3]);
            parc[8].AjouterSE(systemes[6]);
            parc[5].AjouterSE(systemes[7]);
            parc[5].AjouterSE(systemes[4]);
            parc[6].AjouterSE(systemes[5]);
            parc[6].AjouterSE(systemes[6]);
            parc[7].AjouterSE(systemes[7]);
            parc[8].AjouterSE(systemes[4]);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Frm_gestOrd());
        }
        public static Ordinateur RechercherParNserie(long nSerie)
        {
            foreach (Ordinateur ordi in parc)
            {
                if (ordi.NSerie == nSerie) return ordi;
            }
            return null;
        }
        public static SystemeExploitation RechercheSEparStr(string str_se)
        {
            foreach (SystemeExploitation se in systemes)
            {
                if (se.ToString().CompareTo(str_se) == 0) return se;
            }
            return null;
        }
    }
}
