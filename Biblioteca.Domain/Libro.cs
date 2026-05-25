namespace Biblioteca.Domain
{
    public class Libro
    {
        private string autore;
        private string titolo;
        private int annoPubblicazione;
        private string _editore;
        private int numeroPagine;

        public string Autore
        {
            get { return autore; }
            set { autore = value; }
        }

        public string Titolo
        {
            get { return titolo; }
            set { titolo = value; }
        }

        public int AnnoPubblicazione
        {
            get { return annoPubblicazione; }
            set { annoPubblicazione = value; }
        }

        public string Editore
        {
            get { return _editore; }
            set { _editore = value; }
        }

        public int NumeroPagine
        {
            get { return numeroPagine; }
            set
            {
                if (value >= 0) numeroPagine = value;
                else throw new ArgumentException("Il numero di pagine non può essere negativo.");
            }
        }

        public Libro(string autore, string titolo, int annoPubblicazione, string editore, int numeroPagine)
        {
            Autore = autore;
            Titolo = titolo;
            AnnoPubblicazione = annoPubblicazione;
            Editore = editore;
            NumeroPagine = numeroPagine;
        }

        public override string ToString()
        {
            return $"Titolo: {Titolo}, Autore: {Autore}, Editore: {Editore}, Anno: {AnnoPubblicazione}, Pagine: {NumeroPagine}";
        }

        public string ReadingTime()
        {
            if (NumeroPagine < 100)
            {
                return "1h";
            }
            else if (NumeroPagine >= 100 && NumeroPagine <= 200)
            {
                return "2h";
            }
            else // NumeroPagine > 200
            {
                return "Superiore alle 2h";
            }
        }
    }
}