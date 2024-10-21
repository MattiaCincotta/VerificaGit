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
            libro = new Libro(txtAuthor.Text, txtTitle.Text, txtEditor.Text,int.Parse(txtYear.Text), int.Parse(txtPageNumber.Text));
            List<Libro> libri = new List<Libro>();
            biblioteca = new Biblioteca(txtNome.Text, txtIndirizzo.Text, int.Parse(txtApertura.Text), int.Parse(txtChiusura.Text), libri);
        }

        private void btnAddBook_Click(object sender, RoutedEventArgs e)
        {
            biblioteca.addBook(libro);
        }

        private void btnSearchByTitle_Click(object sender, RoutedEventArgs e)
        {
            biblioteca.searchBookByTitle(txtSearchByTitle.Text);
        }

        private void btnSearchByAuthor_Click(object sender, RoutedEventArgs e)
        {
            biblioteca.searchBookByAuthor(txtSearchByAuthor.Text);
        }

        private void btnBookNumber_Click(object sender, RoutedEventArgs e)
        {
            int bookNumber = biblioteca.bookNumber();
            txtBookNumber.Text = bookNumber.ToString();
        }

        private void btnReadingTime_Click(object sender, RoutedEventArgs e)
        {
            libro.ReadingTime();
        }

        private void btnToString_Click(object sender, RoutedEventArgs e)
        {
            string Stringa = libro.ToString();
            txtToString.Text = Stringa;
        }

    }
}