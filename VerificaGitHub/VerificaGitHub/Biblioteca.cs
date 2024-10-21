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


        public void addBook(Libro libro)
        {
            libri.Add(libro);
        }

        public Libro searchBookByTitle(string title)
        {
            for (int i = 0; i < libri.Count; i++) 
            {
                if (libri[i].Title == title) return libri[i];

            }
            throw new Exception("book doesn't exist");
        }

        public List<Libro> searchBookByAuthor(string author)
        {
            List<Libro> newList = new List<Libro>();
            foreach (Libro libro in libri) 
            {
                if (libro.Author == author) newList.Add(libro);
            }
            return newList;
        }

        public int bookNumber()
        {
            return libri.Count;
        }

    }
}
