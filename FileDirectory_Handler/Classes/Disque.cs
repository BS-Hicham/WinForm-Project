using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PEOO_EFM_2017_2.Classes
{
//C
//1
    [Serializable()]
    class Disque
    {
        private char _lettre;
        public char Lettre
        {
            get { return _lettre; }
            set { _lettre = value; }
        }
        private long _capacite;
        public long Capacite
        {
            get { return _capacite; }
            set { _capacite = value; }
        }
        private List<Dossier> _dossiers = new List<Dossier>();
        public List<Dossier> Dossiers
        {
            get { return _dossiers; }
        }

//2
        public Disque(char lettre, long capacite)
        {
            Lettre = lettre;
            Capacite = capacite;
        }
//3
        public long EspaceUtilise()
        {
            long som = 0;
            foreach (Dossier d in _dossiers)
            {
                som += d.Taille();
            }
            return som;
        }
//4
        public void AjouterDossier(Dossier d)
        {
            if (d is Fichier)
            {
                if ((_capacite - EspaceUtilise()) > ((Fichier)d).Taille)
                {
                    _dossiers.Add(d);
                }
                else
                    throw new Exception("Espace insuffisant");

            }
            else
                _dossiers.Add(d);
        }
//5
        public List<Dossier> Contenu(string chemin)
        {
            List<Dossier> lst = new List<Dossier>();
            foreach (Dossier d in _dossiers)
            {
                if (chemin == d.Parent.Chemin())
                {
                    lst.Add(d);
                }
            }
            lst.Sort();
            return lst;
        }

        public Dossier DossierParChemin(string chemin)
        {
            foreach (Dossier d in _dossiers)
            {
                if (chemin == d.Chemin()) return d;
            }
            return null;
        }

    }
}
