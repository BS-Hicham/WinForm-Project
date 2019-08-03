using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace FileDirectory_Handler.Classes
{
    //B
    //1
    [Serializable()]
    class Fichier : Dossier
    {
        private string _ext;
        public string Ext
        {
            get { return _ext; }
            set { _ext = value; }
        }
        private long _taille;
        public long Taille
        {
            get { return _taille; }
            set { _taille = value; }
        }
        //2
        public Fichier(string nom, Image icone, Dossier parent, string ext, long taille)
            : base(nom, icone, parent)
        {
            Ext = ext;
            Taille = taille;
        }
        //3
        public override string ToString()
        {
            return base.ToString() + "." + Ext;
        }
        //4
        public override string Chemin()
        {
            return base.Chemin() + ToString();
        }

    }

}
