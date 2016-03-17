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
   
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent(); 

        }

       
        private void SeeShelf_Click(object sender, RoutedEventArgs e)
        {
            MainWindow shelfWin = new MainWindow();
            Page shelf = new Shelf();
            shelfWin.Content = shelf;
            this.Close();
            shelfWin.Show();
            
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            MainWindow addWin = new MainWindow();
            AddBook add = new AddBook();
            addWin.Content = add;
            addWin.Show();

        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            MainWindow addWin = new MainWindow();
            Shelf theShelf = new Shelf();
            addWin.Content = theShelf;
            addWin.Show();
            addWin.SizeToContent = SizeToContent.Width;
            addWin.SizeToContent = SizeToContent.Height;

        }
    }
}
