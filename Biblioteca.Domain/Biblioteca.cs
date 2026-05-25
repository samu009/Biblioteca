using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Domain
{
    public class Biblioteca
    {
        public string Nome { get; set; }
        public string Indirizzo { get; set; }
        public string OrarioApertura { get; set; } 
        public string OrarioChiusura { get; set; }  

        private List<Libro> _elencoLibri;


        public Biblioteca(string nome, string indirizzo, string orarioApertura, string orarioChiusura)
        {
            Nome = nome;
            Indirizzo = indirizzo;
            OrarioApertura = orarioApertura;
            OrarioChiusura = orarioChiusura;
            _elencoLibri = new List<Libro>(); 
        }


        public void AggiungiLibro(Libro libro)
        {
            if (libro != null)
            {
                _elencoLibri.Add(libro);
            }
        }


        public bool RimuoviLibro(Libro libro)
        {
            return _elencoLibri.Remove(libro);
        }


        public int GetNumeroLibri()
        {
            return _elencoLibri.Count;
        }

        public override string ToString()
        {
            string info = $"Biblioteca: {Nome}\n" +
                          $"Indirizzo: {Indirizzo}\n" +
                          $"Orario: {OrarioApertura} - {OrarioChiusura}\n" +
                          $"--- Elenco Libri ({GetNumeroLibri()}) ---\n";

            if (_elencoLibri.Count == 0)
            {
                info += "Nessun libro disponibile al momento.";
            }
            else
            {
                foreach (Libro l in _elencoLibri)
                {
                    info += $"- {l.ToString()}\n";
                }
            }

            return info;
        }
    }
}
