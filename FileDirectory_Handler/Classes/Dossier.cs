using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace FileDirectory_Handler.Classes
{//A
    [Serializable()]
    class Dossier : IComparable<Dossier>
    {
//1
        private string _nom;
        public string Nom
        {
            get { return _nom; }
            set { _nom = value; }
        }
        private DateTime _dateCreation;
        public DateTime DateCreation
        {
            get { return _dateCreation; }
            set { _dateCreation = value; }
        }
        private Image _icone;
        public Image Icone
        {
            get { return _icone; }
            set { _icone = value; }
        }
        private Dossier _parent;
        public Dossier Parent
        {
            get { return _parent; }
            set { _parent = value; }
        }
//2
        private static Image _iconeParDefaut = Image.FromFile("icone_init.jpg");

//3
        public static Image IconeParDefaut
        {
            get { return _iconeParDefaut; }
            set { _iconeParDefaut = value; }
        }
//4
        public Dossier()
        {
            _nom = "nouveau dossier";
            _dateCreation = DateTime.Now;
        }
//5
        public Dossier(string nom, Image icone, Dossier parent)
        {
            Nom = nom;
            Icone = icone;
            Parent = parent;
        }
//6
        public override string ToString()
        {
            return _nom;
        }
//7
        public int CompareTo(Dossier other)
        {
            if (other == null) return 1;
            return _dateCreation.CompareTo(other._dateCreation);
        }
//8
        public virtual string Chemin()
        {
            if (_parent == null)  return _nom+"\\";
            return _parent.Chemin() + _nom + "\\";
        }
//9
        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            if (!(obj is Dossier)) return false;
            Dossier d = (Dossier)obj;
            return this.Chemin().CompareTo(d.Chemin()) == 0;
        }

        public long Taille()
        {
            if (_parent == null)
            {
                if (this is Fichier)
                    return ((Fichier)this).Taille;
                else
                    return 0;
            }
            else
                return  Taille() + _parent.Taille();
        }

        private int size;
    }
}
