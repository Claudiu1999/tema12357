using System;
using System.Collections.Generic;
using System.Text;

namespace Bilblioteca
{
    enum Categorie { Nuvela, Poezie, Roman, Comedie };
    class Carte
    {
        string nume;
        string autor;
        string editura;
        int nrexemplare;
        public Categorie categorie;
        public string Nume { get; set; }
        public string Autor { get; set; }
        public string Editura { get; set; }

        public int NrExemplare { get; set; }


        public Carte()
        {
            nume = string.Empty;
            autor = string.Empty;
            editura = string.Empty;
            nrexemplare = 0;
        }

        public Carte(string _nume, string _autor, string _editura, int _nrexemplare)
        {
            nume = _nume;
            autor = _autor;
            editura = _editura;
            nrexemplare = _nrexemplare;
            
        }

        public Carte(string _nume, string _autor, string _editura, int _nrexemplare, Categorie _categorie)
        {
            nume = _nume;
            autor = _autor;
            editura = _editura;
            nrexemplare = _nrexemplare;
            categorie = _categorie;

        }

        public Carte(String nume1)
        {
            string[] buff= nume.Split(',');
            nume = buff[0];
            autor = buff[1];
            editura = buff[2];
            nrexemplare = Convert.ToInt32( buff[3] );

        }

        public string ComparaExemplare(Carte c1,Carte c2)
        {
            if (c1.nrexemplare > c2.nrexemplare)
                return string.Format("Cartea {0} are mai multe exemplare", c1.nume);
            else
                if (c1.nrexemplare == c2.nrexemplare)
                    return "Ambele carti au acelasi numar de exemplare";
                else
                    return string.Format("Cartea {0} are mai multe exemplare", c2.nume);
        }

        public string Info()
        {
            return string.Format(" Cartea se numeste {0}, scrisa de autorul {1}, de la editura {2}, fiind {3} exemplare, si face parte din categorie {4}", nume, autor, editura,nrexemplare,categorie);
        }

        public string ConversieLaSir()
        {
            string sir;
            sir = string.Format(" Cartea se numeste {0}, scrisa de autorul {1}, de la editura {2}, fiind {3} exemplare", nume, autor, editura, nrexemplare);
            return sir;
        }
    }
}
