using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.IO;

namespace PEOO_EFM_2018.Classes
{
    [Serializable()]
    abstract class Ordinateur:IComparable<Ordinateur>
    {
        protected long _nSerie;
        protected string _marque;
        protected string _modele;
        protected DateTime _dateDebutGarantie;
        protected bool _graveur;
        protected Image _photo;        
        protected Ecran _ecranOrdi;
        private static long _cpt=0;
        List<SystemeExploitation> _se = new List<SystemeExploitation>();

        public long NSerie { get { return _nSerie; } }
        public string Marque { get { return _marque; } set { _marque = value; } }
        public string Modele { get { return _modele; } set { _modele = value; } }
        public DateTime DateDebutGarantie { get { return _dateDebutGarantie; } set { _dateDebutGarantie = value; } }
        public bool Graveur { get { return _graveur; } set { _graveur = value; } }
        public Image Photo { get { return _photo; } set { _photo = value; } }
        public List<SystemeExploitation> SE { get { return _se; } }
        public virtual Ecran EcranOrdi { get { return _ecranOrdi; } set { _ecranOrdi = value; } }
        public abstract DateTime DateFinGarantie{get;}

        public Ordinateur() {_nSerie = ++_cpt; }
        public Ordinateur(string marque, string modele, DateTime ddGarantie, bool graveur,Image photo ,Ecran ecran):this()
        {
            Marque = marque;
            Modele = modele;
            DateDebutGarantie = ddGarantie;
            Graveur = graveur;
            Photo = photo;
            EcranOrdi = ecran;            
        }
        public Ordinateur(Ordinateur ordi)
        {
            _marque = ordi._marque;
            _modele = ordi._modele;
            _dateDebutGarantie = ordi._dateDebutGarantie;
            _graveur = ordi._graveur;
            _photo = ordi._photo;
            _ecranOrdi = ordi._ecranOrdi;
        }
        public void setPhoto(string chemin)
        {
            if (File.Exists(chemin))
                _photo = Image.FromFile(chemin);
            else
                throw new Exception("photo introuvable");
        }

        public bool AjouterSE(SystemeExploitation se)
        {
            foreach (SystemeExploitation item in _se)
                if(item.Equals(se)) return false;
            _se.Add(se);
            return true;
        }
        public bool isSEinstalled(string str_se)
        {
            foreach (SystemeExploitation s in _se)
            {
                if (s.ToString().CompareTo(str_se) == 0) return true;
            }
            return false;
        }
        public int CompareTo(Ordinateur other)
        {
            return (_marque + " " + _modele).CompareTo(other._marque + " " + other._modele);
        }
    }

    [Serializable()]
    abstract class Copy2OfOrdinateur : IComparable<Copy2OfOrdinateur>
    {
        protected long _nSerie;
        protected string _marque;
        protected string _modele;
        protected DateTime _dateDebutGarantie;
        protected bool _graveur;
        protected Image _photo;
        protected Ecran _ecranOrdi;
        private static long _cpt = 0;
        List<SystemeExploitation> _se = new List<SystemeExploitation>();

        public long NSerie { get { return _nSerie; } }
        public string Marque { get { return _marque; } set { _marque = value; } }
        public string Modele { get { return _modele; } set { _modele = value; } }
        public DateTime DateDebutGarantie { get { return _dateDebutGarantie; } set { _dateDebutGarantie = value; } }
        public bool Graveur { get { return _graveur; } set { _graveur = value; } }
        public Image Photo { get { return _photo; } set { _photo = value; } }
        public List<SystemeExploitation> SE { get { return _se; } }
        public virtual Ecran EcranOrdi { get { return _ecranOrdi; } set { _ecranOrdi = value; } }
        public abstract DateTime DateFinGarantie { get; }

        public Copy2OfOrdinateur() { _nSerie = ++_cpt; }
        public Copy2OfOrdinateur(string marque, string modele, DateTime ddGarantie, bool graveur, Image photo, Ecran ecran)
            : this()
        {
            Marque = marque;
            Modele = modele;
            DateDebutGarantie = ddGarantie;
            Graveur = graveur;
            Photo = photo;
            EcranOrdi = ecran;
        }
        public Copy2OfOrdinateur(Copy2OfOrdinateur ordi)
        {
            _marque = ordi._marque;
            _modele = ordi._modele;
            _dateDebutGarantie = ordi._dateDebutGarantie;
            _graveur = ordi._graveur;
            _photo = ordi._photo;
            _ecranOrdi = ordi._ecranOrdi;
        }
        public void setPhoto(string chemin)
        {
            if (File.Exists(chemin))
                _photo = Image.FromFile(chemin);
            else
                throw new Exception("photo introuvable");
        }

        public bool AjouterSE(SystemeExploitation se)
        {
            foreach (SystemeExploitation item in _se)
                if (item.Equals(se)) return false;
            _se.Add(se);
            return true;
        }
        public bool isSEinstalled(string str_se)
        {
            foreach (SystemeExploitation s in _se)
            {
                if (s.ToString().CompareTo(str_se) == 0) return true;
            }
            return false;
        }
        public int CompareTo(Copy2OfOrdinateur other)
        {
            return (_marque + " " + _modele).CompareTo(other._marque + " " + other._modele);
        }
    }

    [Serializable()]
    abstract class Copy1OfOrdinateur : IComparable<Copy1OfOrdinateur>
    {
        protected long _nSerie;
        protected string _marque;
        protected string _modele;
        protected DateTime _dateDebutGarantie;
        protected bool _graveur;
        protected Image _photo;
        protected Ecran _ecranOrdi;
        private static long _cpt = 0;
        List<SystemeExploitation> _se = new List<SystemeExploitation>();

        public long NSerie { get { return _nSerie; } }
        public string Marque { get { return _marque; } set { _marque = value; } }
        public string Modele { get { return _modele; } set { _modele = value; } }
        public DateTime DateDebutGarantie { get { return _dateDebutGarantie; } set { _dateDebutGarantie = value; } }
        public bool Graveur { get { return _graveur; } set { _graveur = value; } }
        public Image Photo { get { return _photo; } set { _photo = value; } }
        public List<SystemeExploitation> SE { get { return _se; } }
        public virtual Ecran EcranOrdi { get { return _ecranOrdi; } set { _ecranOrdi = value; } }
        public abstract DateTime DateFinGarantie { get; }

        public Copy1OfOrdinateur() { _nSerie = ++_cpt; }
        public Copy1OfOrdinateur(string marque, string modele, DateTime ddGarantie, bool graveur, Image photo, Ecran ecran)
            : this()
        {
            Marque = marque;
            Modele = modele;
            DateDebutGarantie = ddGarantie;
            Graveur = graveur;
            Photo = photo;
            EcranOrdi = ecran;
        }
        public Copy1OfOrdinateur(Copy1OfOrdinateur ordi)
        {
            _marque = ordi._marque;
            _modele = ordi._modele;
            _dateDebutGarantie = ordi._dateDebutGarantie;
            _graveur = ordi._graveur;
            _photo = ordi._photo;
            _ecranOrdi = ordi._ecranOrdi;
        }
        public void setPhoto(string chemin)
        {
            if (File.Exists(chemin))
                _photo = Image.FromFile(chemin);
            else
                throw new Exception("photo introuvable");
        }

        public bool AjouterSE(SystemeExploitation se)
        {
            foreach (SystemeExploitation item in _se)
                if (item.Equals(se)) return false;
            _se.Add(se);
            return true;
        }
        public bool isSEinstalled(string str_se)
        {
            foreach (SystemeExploitation s in _se)
            {
                if (s.ToString().CompareTo(str_se) == 0) return true;
            }
            return false;
        }
        public int CompareTo(Copy1OfOrdinateur other)
        {
            return (_marque + " " + _modele).CompareTo(other._marque + " " + other._modele);
        }
    }

    [Serializable()]
    abstract class CopyOfOrdinateur : IComparable<CopyOfOrdinateur>
    {
        protected long _nSerie;
        protected string _marque;
        protected string _modele;
        protected DateTime _dateDebutGarantie;
        protected bool _graveur;
        protected Image _photo;
        protected Ecran _ecranOrdi;
        private static long _cpt = 0;
        List<SystemeExploitation> _se = new List<SystemeExploitation>();

        public long NSerie { get { return _nSerie; } }
        public string Marque { get { return _marque; } set { _marque = value; } }
        public string Modele { get { return _modele; } set { _modele = value; } }
        public DateTime DateDebutGarantie { get { return _dateDebutGarantie; } set { _dateDebutGarantie = value; } }
        public bool Graveur { get { return _graveur; } set { _graveur = value; } }
        public Image Photo { get { return _photo; } set { _photo = value; } }
        public List<SystemeExploitation> SE { get { return _se; } }
        public virtual Ecran EcranOrdi { get { return _ecranOrdi; } set { _ecranOrdi = value; } }
        public abstract DateTime DateFinGarantie { get; }

        public CopyOfOrdinateur() { _nSerie = ++_cpt; }
        public CopyOfOrdinateur(string marque, string modele, DateTime ddGarantie, bool graveur, Image photo, Ecran ecran)
            : this()
        {
            Marque = marque;
            Modele = modele;
            DateDebutGarantie = ddGarantie;
            Graveur = graveur;
            Photo = photo;
            EcranOrdi = ecran;
        }
        public CopyOfOrdinateur(CopyOfOrdinateur ordi)
        {
            _marque = ordi._marque;
            _modele = ordi._modele;
            _dateDebutGarantie = ordi._dateDebutGarantie;
            _graveur = ordi._graveur;
            _photo = ordi._photo;
            _ecranOrdi = ordi._ecranOrdi;
        }
        public void setPhoto(string chemin)
        {
            if (File.Exists(chemin))
                _photo = Image.FromFile(chemin);
            else
                throw new Exception("photo introuvable");
        }

        public bool AjouterSE(SystemeExploitation se)
        {
            foreach (SystemeExploitation item in _se)
                if (item.Equals(se)) return false;
            _se.Add(se);
            return true;
        }
        public bool isSEinstalled(string str_se)
        {
            foreach (SystemeExploitation s in _se)
            {
                if (s.ToString().CompareTo(str_se) == 0) return true;
            }
            return false;
        }
        public int CompareTo(CopyOfOrdinateur other)
        {
            return (_marque + " " + _modele).CompareTo(other._marque + " " + other._modele);
        }
    }
}
