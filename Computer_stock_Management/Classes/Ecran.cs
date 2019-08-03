using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PEOO_EFM_2018.Classes
{
    [Serializable()]
    class Ecran
    {
        private string _marque;
        private int _taille;
        private TypeEcran _tEcran;
        public string Marque
        {
            get { return _marque; }
            set { _marque = value; }
        }
        public int Taille
        {
            get { return _taille; }
            set { _taille = value; }
        }
        public TypeEcran TEcran
        {
            get { return _tEcran; }
            set { _tEcran = value; }
        }
        public Ecran() { }
        public Ecran(string marque, int taille, TypeEcran te)
        {
            Marque = marque;
            Taille = taille;
            TEcran = te;
        }
        public Ecran(Ecran e)
        {
            _marque = e._marque;
            _taille = e._taille;
            _tEcran = e._tEcran;
        }
        public override string ToString()
        {
            return _marque + " " + _taille.ToString() + "pouces " + _tEcran.ToString();
        }
    }
}
