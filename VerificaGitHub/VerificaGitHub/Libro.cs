using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerificaGitHub
{
    internal class Libro
    {
        private string author, title, editor;
        private int year, pageNumber;

        public Libro(string author, string title, string editor, int year, int pageNumber)
        {
            this.author = author;
            this.title = title;
            this.editor = editor;
            this.year = year;
            this.pageNumber = pageNumber;
        }

        public string Author { get { return author; } set { author = value; } }
        public string Title { get { return title; } set { title = value; } }

        public string Editor { get { return editor; } set { editor = value; } }
        public int Year { get { return year; } set { year = value; } }
        public int PageNumber { get { return pageNumber; } set { pageNumber = value; } }

        public override string ToString()
        {
            string stringa = $"{Author}, {Title},{Editor}, {Year}, {PageNumber}";
            return stringa;
        }

        public string ReadingTime()
        {
            if (pageNumber < 100)
            {
                return $"con {pageNumber} pagine ci vorrà almeno 1 ora";
            }
            else if (pageNumber > 100 && pageNumber < 200)
            {
                return $"con {pageNumber} pagine ci vorranno almeno 2 ora";

            }
            else
            {
                return $"con {pageNumber} pagine ci vorranno più di 2 ore";

            }

        }
    }
}
