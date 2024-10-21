using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerificaGitHub
{
    internal class Biblioteca
    {
        private string nome, indirizzo;
        private int apertura, chiusura;
        private List<Libro> libri;

        public Biblioteca(string nome, string indirizzo, int apertura, int chiusura, List<Libro> libri)
        {
            this.nome = nome;
            this.indirizzo = indirizzo;
            this.apertura = apertura;
            this.chiusura = chiusura;
            this.libri = libri;
        }
        public string Nome { get { return nome; } set { nome = value; } }
        public string Indirizzo { get { return indirizzo; } set { indirizzo = value; } }
        public int Apertura { get { return apertura; } set { apertura = value; } }
        public int Chiusura { get { return chiusura; } set { chiusura = value; } }



    }
}
