using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace PEOO_EFM_2018.Classes
{
    [Serializable()]
    class LaptopPC:Ordinateur
    {
        private double _autonomie;
        private Color _couleur;
        public double Autonomie
        {
            get { return _autonomie; }
            set { _autonomie = value; }
        }
        public Color Couleur
        {
            get { return _couleur; }
            set { _couleur = value; }
        }
        public LaptopPC() : base() { }
        public LaptopPC(string marque, string modele, DateTime ddGarantie, bool graveur, Image photo, Ecran ecran, double autonomie, Color c)
            : base(marque, modele, ddGarantie, graveur,photo ,ecran)
        {
            Autonomie = autonomie;
            Couleur = c;
        }
        public LaptopPC(LaptopPC lpc)
            : base(lpc)
        {
            _autonomie = lpc._autonomie;
            _couleur = lpc._couleur;
        }
        public override DateTime DateFinGarantie
        {
            get { return _dateDebutGarantie.AddYears(2); }
        }
        public override Ecran EcranOrdi
        {
            get
            {
                return base.EcranOrdi;
            }
            set
            {
                if (value.Marque.CompareTo(this.Marque) != 0)
                    throw new Exception("la marque de l'écran doit être identique à la marque du Laptop");
                else
                    _ecranOrdi = value;
            }
        }
    }
}
