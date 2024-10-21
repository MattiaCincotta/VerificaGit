using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace VerificaGitHub
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Libro libro;
        Biblioteca biblioteca;
        public MainWindow()
        {
            InitializeComponent();
            libro = new Libro();
            List<Libro> libri = new List<Libro>();
            biblioteca = new Biblioteca();
        }

        private void btnAddBook_Click(object sender, RoutedEventArgs e)
        {
            biblioteca.AddBook(libro);
        }

        private void btnSearchByTitle_Click(object sender, RoutedEventArgs e)
        {
            biblioteca.SearchBookByTitle(txtSearchByTitle.Text);
        }

        private void btnSearchByAuthor_Click(object sender, RoutedEventArgs e)
        {
            biblioteca.SearchBookByAuthor(txtSearchByAuthor.Text);
        }

        private void btnBookNumber_Click(object sender, RoutedEventArgs e)
        {
            int bookNumber = biblioteca.BookNumber(libro);
            txtBookNumber.Text = bookNumber.ToString();
        }

        private void btnReadingTime_Click(object sender, RoutedEventArgs e)
        {
            libro.ReadingTime();
        }

        private void btnToString_Click(object sender, RoutedEventArgs e)
        {
            string Stringa = libro.ToString();
            txtBookNumber.Text = Stringa;
        }
    }
}