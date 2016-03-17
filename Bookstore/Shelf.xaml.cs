using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Bookstore
{
    /// <summary>
    /// Interaction logic for Shelf.xaml
    /// </summary>
    public partial class Shelf : Page
    {
        public Shelf()
        {
            InitializeComponent();
        }



        private void button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow win = new MainWindow();
            win.Show();

        }

        private void Book1_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Window win = new Window();
            ShowBook theBook = new ShowBook();

            theBook.Sense.Visibility = Visibility.Hidden;
            theBook.PP.Visibility = Visibility.Hidden;
            theBook.quixote.Visibility = Visibility.Hidden;
            theBook.dorrit.Visibility = Visibility.Hidden;
            theBook.white.Visibility = Visibility.Hidden;
            theBook.wuthering.Visibility = Visibility.Hidden;
            theBook.North.Visibility = Visibility.Hidden;
            theBook.Eyre.Visibility = Visibility.Visible;
            win.Content = theBook;
            win.Show();
        }

        private void Book2_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Window win = new Window();
            ShowBook theBook = new ShowBook();

            theBook.PP.Visibility = Visibility.Visible;
            theBook.Sense.Visibility = Visibility.Hidden;
            theBook.Eyre.Visibility = Visibility.Hidden;
            theBook.quixote.Visibility = Visibility.Hidden;
            theBook.dorrit.Visibility = Visibility.Hidden;
            theBook.white.Visibility = Visibility.Hidden;
            theBook.wuthering.Visibility = Visibility.Hidden;
            theBook.North.Visibility = Visibility.Hidden;
            win.Content = theBook;
            win.Show();
        }

        private void Wuthering_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Window win = new Window();
            ShowBook theBook = new ShowBook();

            theBook.PP.Visibility = Visibility.Hidden;
            theBook.Sense.Visibility = Visibility.Hidden;
            theBook.Eyre.Visibility = Visibility.Hidden;
            theBook.quixote.Visibility = Visibility.Hidden;
            theBook.dorrit.Visibility = Visibility.Hidden;
            theBook.white.Visibility = Visibility.Hidden;
            theBook.wuthering.Visibility = Visibility.Visible;
            theBook.North.Visibility = Visibility.Hidden;
            win.Content = theBook;
            win.Show();
        }

        private void WomanWhite_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Window win = new Window();
            ShowBook theBook = new ShowBook();

            theBook.PP.Visibility = Visibility.Hidden;
            theBook.Sense.Visibility = Visibility.Hidden;
            theBook.Eyre.Visibility = Visibility.Hidden;
            theBook.quixote.Visibility = Visibility.Hidden;
            theBook.dorrit.Visibility = Visibility.Hidden;
            theBook.white.Visibility = Visibility.Visible;
            theBook.wuthering.Visibility = Visibility.Hidden;
            theBook.North.Visibility = Visibility.Hidden;
            win.Content = theBook;
            win.Show();
        }

        private void Dorrit_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Window win = new Window();
            ShowBook theBook = new ShowBook();

            theBook.PP.Visibility = Visibility.Hidden;
            theBook.Sense.Visibility = Visibility.Hidden;
            theBook.Eyre.Visibility = Visibility.Hidden;
            theBook.quixote.Visibility = Visibility.Hidden;
            theBook.dorrit.Visibility = Visibility.Visible;
            theBook.white.Visibility = Visibility.Hidden;
            theBook.wuthering.Visibility = Visibility.Hidden;
            theBook.North.Visibility = Visibility.Hidden;
            win.Content = theBook;
            win.Show();
        }

        private void NorthSouth_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Window win = new Window();
            ShowBook theBook = new ShowBook();

            theBook.PP.Visibility = Visibility.Hidden;
            theBook.Sense.Visibility = Visibility.Hidden;
            theBook.Eyre.Visibility = Visibility.Hidden;
            theBook.quixote.Visibility = Visibility.Hidden;
            theBook.dorrit.Visibility = Visibility.Hidden;
            theBook.white.Visibility = Visibility.Hidden;
            theBook.wuthering.Visibility = Visibility.Hidden;
            theBook.North.Visibility = Visibility.Visible;
            win.Content = theBook;
            win.Show();
        }

        private void Sense_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Window win = new Window();
            ShowBook theBook = new ShowBook();

            theBook.PP.Visibility = Visibility.Hidden;
            theBook.Sense.Visibility = Visibility.Visible;
            theBook.Eyre.Visibility = Visibility.Hidden;
            theBook.quixote.Visibility = Visibility.Hidden;
            theBook.dorrit.Visibility = Visibility.Hidden;
            theBook.white.Visibility = Visibility.Hidden;
            theBook.wuthering.Visibility = Visibility.Hidden;
            theBook.North.Visibility = Visibility.Hidden;
            win.Content = theBook;
            win.Show();
        }

        private void Quixote_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Window win = new Window();
            ShowBook theBook = new ShowBook();

            theBook.PP.Visibility = Visibility.Hidden;
            theBook.Sense.Visibility = Visibility.Hidden;
            theBook.Eyre.Visibility = Visibility.Hidden;
            theBook.quixote.Visibility = Visibility.Visible;
            theBook.dorrit.Visibility = Visibility.Hidden;
            theBook.white.Visibility = Visibility.Hidden;
            theBook.wuthering.Visibility = Visibility.Hidden;
            theBook.North.Visibility = Visibility.Hidden;
            win.Content = theBook;
            win.Show();
        }

        private void Janeausten_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            this.Book2_MouseDoubleClick(sender, e);
        }

        private void Emily_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            this.Wuthering_MouseDoubleClick(sender, e);
        }

        private void Wilkie_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            this.WomanWhite_MouseDoubleClick(sender, e);
        }

        private void Dickens_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            this.WomanWhite_MouseDoubleClick(sender, e);
        }

        private void Gaskell_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            this.NorthSouth_MouseDoubleClick(sender, e);
        }

        private void Austen_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            this.Sense_MouseDoubleClick(sender, e);
        }

        private void Cervantes_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            this.Quixote_MouseDoubleClick(sender, e);
        }
    }
}
