using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace PEOO_EFM_2018.Classes
{
    [Serializable()]
    class DesktopPC:Ordinateur
    {
        private string _clavier;
        private string _souris;
        public string Clavier
        {
            get { return _clavier; }
            set { _clavier = value; }
        }
        public string Souris
        {
            get { return _souris; }
            set { _souris = value; }
        }
        public override DateTime DateFinGarantie
        {
            get { return DateDebutGarantie.AddMonths(6); }
        }
        public DesktopPC() : base() { }
        public DesktopPC(string marque, string modele, DateTime ddGarantie, bool graveur,Image photo, Ecran ecran, string clavier,string souris)
            : base(marque, modele, ddGarantie, graveur, photo,ecran)
        {
            Clavier = clavier;
            Souris = souris;
        }

    }
}
