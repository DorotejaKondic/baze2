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
using Dora.AddWindows;
using Dora.DBAccess;

namespace Dora
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Read read;
        public MainWindow mw;
        private Delete del;
        public MainWindow()
        {
            InitializeComponent();
            read = new Read();
            del = new Delete();
            bibliotekeGR.ItemsSource = read.GetBiblioteke();
            bibliotekariGR.ItemsSource = read.GetBibliotekare();
            clanGR.ItemsSource = read.GetClanove();
            clanarinaGR.ItemsSource = read.GetClanarine();
            izdanjeGR.ItemsSource = read.GetIzdanja();
            izdavacGR.ItemsSource = read.GetIzdavaci();
            knjigaGR.ItemsSource = read.GetKnjige();
            osobaGR.ItemsSource = read.GetOsobe();
            primerakGR.ItemsSource = read.GetPrimerci();
            za_iznajmljivanjeGR.ItemsSource = read.GetIznajmljivanja();
            za_prodajuGR.ItemsSource = read.GetProdaje();
        }

        private void bibliotekeBTN_Click(object sender, RoutedEventArgs e)
        {
            bibliotekeGR.Visibility = Visibility.Visible;
            bibliotekariGR.Visibility = Visibility.Hidden;
            clanGR.Visibility = Visibility.Hidden; 
            clanarinaGR.Visibility = Visibility.Hidden;
            izdanjeGR.Visibility = Visibility.Hidden;
            izdavacGR.Visibility = Visibility.Hidden;
            knjigaGR.Visibility = Visibility.Hidden;
            osobaGR.Visibility = Visibility.Hidden;
            primerakGR.Visibility = Visibility.Hidden;
            za_iznajmljivanjeGR.Visibility = Visibility.Hidden;
            za_prodajuGR.Visibility = Visibility.Hidden;

        }

        private void bibliotekariBTN_Click(object sender, RoutedEventArgs e)
        {
            bibliotekeGR.Visibility = Visibility.Hidden;
            bibliotekariGR.Visibility = Visibility.Visible;
            clanGR.Visibility = Visibility.Hidden;
            clanarinaGR.Visibility = Visibility.Hidden;
            izdanjeGR.Visibility = Visibility.Hidden;
            izdavacGR.Visibility = Visibility.Hidden;
            knjigaGR.Visibility = Visibility.Hidden;
            osobaGR.Visibility = Visibility.Hidden;
            primerakGR.Visibility = Visibility.Hidden;
            za_iznajmljivanjeGR.Visibility = Visibility.Hidden;
            za_prodajuGR.Visibility = Visibility.Hidden;
        }

        private void clanBTN_Click(object sender, RoutedEventArgs e)
        {
            bibliotekeGR.Visibility = Visibility.Hidden;
            bibliotekariGR.Visibility = Visibility.Hidden;
            clanGR.Visibility = Visibility.Visible;
            clanarinaGR.Visibility = Visibility.Hidden;
            izdanjeGR.Visibility = Visibility.Hidden;
            izdavacGR.Visibility = Visibility.Hidden;
            knjigaGR.Visibility = Visibility.Hidden;
            osobaGR.Visibility = Visibility.Hidden;
            primerakGR.Visibility = Visibility.Hidden;
            za_iznajmljivanjeGR.Visibility = Visibility.Hidden;
            za_prodajuGR.Visibility = Visibility.Hidden;
        }

        private void clanarinaBTN_Click(object sender, RoutedEventArgs e)
        {
            bibliotekeGR.Visibility = Visibility.Hidden;
            bibliotekariGR.Visibility = Visibility.Hidden;
            clanGR.Visibility = Visibility.Hidden;
            clanarinaGR.Visibility = Visibility.Visible;
            izdanjeGR.Visibility = Visibility.Hidden;
            izdavacGR.Visibility = Visibility.Hidden;
            knjigaGR.Visibility = Visibility.Hidden;
            osobaGR.Visibility = Visibility.Hidden;
            primerakGR.Visibility = Visibility.Hidden;
            za_iznajmljivanjeGR.Visibility = Visibility.Hidden;
            za_prodajuGR.Visibility = Visibility.Hidden;
        }

        private void izdanjeBTN_Click(object sender, RoutedEventArgs e)
        {
            bibliotekeGR.Visibility = Visibility.Hidden;
            bibliotekariGR.Visibility = Visibility.Hidden;
            clanGR.Visibility = Visibility.Hidden;
            clanarinaGR.Visibility = Visibility.Hidden;
            izdanjeGR.Visibility = Visibility.Visible;
            izdavacGR.Visibility = Visibility.Hidden;
            knjigaGR.Visibility = Visibility.Hidden;
            osobaGR.Visibility = Visibility.Hidden;
            primerakGR.Visibility = Visibility.Hidden;
            za_iznajmljivanjeGR.Visibility = Visibility.Hidden;
            za_prodajuGR.Visibility = Visibility.Hidden;
        }

        private void izdavacBTN_Click(object sender, RoutedEventArgs e)
        {
            bibliotekeGR.Visibility = Visibility.Hidden;
            bibliotekariGR.Visibility = Visibility.Hidden;
            clanGR.Visibility = Visibility.Hidden;
            clanarinaGR.Visibility = Visibility.Hidden;
            izdanjeGR.Visibility = Visibility.Hidden;
            izdavacGR.Visibility = Visibility.Visible;
            knjigaGR.Visibility = Visibility.Hidden;
            osobaGR.Visibility = Visibility.Hidden;
            primerakGR.Visibility = Visibility.Hidden;
            za_iznajmljivanjeGR.Visibility = Visibility.Hidden;
            za_prodajuGR.Visibility = Visibility.Hidden;
        }

        private void knjigaBTN_Click(object sender, RoutedEventArgs e)
        {
            bibliotekeGR.Visibility = Visibility.Hidden;
            bibliotekariGR.Visibility = Visibility.Hidden;
            clanGR.Visibility = Visibility.Hidden;
            clanarinaGR.Visibility = Visibility.Hidden;
            izdanjeGR.Visibility = Visibility.Hidden;
            izdavacGR.Visibility = Visibility.Hidden;
            knjigaGR.Visibility = Visibility.Visible;
            osobaGR.Visibility = Visibility.Hidden;
            primerakGR.Visibility = Visibility.Hidden;
            za_iznajmljivanjeGR.Visibility = Visibility.Hidden;
            za_prodajuGR.Visibility = Visibility.Hidden;
        }

        private void osobaBTN_Click(object sender, RoutedEventArgs e)
        {
            bibliotekeGR.Visibility = Visibility.Hidden;
            bibliotekariGR.Visibility = Visibility.Hidden;
            clanGR.Visibility = Visibility.Hidden;
            clanarinaGR.Visibility = Visibility.Hidden;
            izdanjeGR.Visibility = Visibility.Hidden;
            izdavacGR.Visibility = Visibility.Hidden;
            knjigaGR.Visibility = Visibility.Hidden;
            osobaGR.Visibility = Visibility.Visible;
            primerakGR.Visibility = Visibility.Hidden;
            za_iznajmljivanjeGR.Visibility = Visibility.Hidden;
            za_prodajuGR.Visibility = Visibility.Hidden;
        }

        private void primerakBTN_Click(object sender, RoutedEventArgs e)
        {
            bibliotekeGR.Visibility = Visibility.Hidden;
            bibliotekariGR.Visibility = Visibility.Hidden;
            clanGR.Visibility = Visibility.Hidden;
            clanarinaGR.Visibility = Visibility.Hidden;
            izdanjeGR.Visibility = Visibility.Hidden;
            izdavacGR.Visibility = Visibility.Hidden;
            knjigaGR.Visibility = Visibility.Hidden;
            osobaGR.Visibility = Visibility.Hidden;
            primerakGR.Visibility = Visibility.Visible;
            za_iznajmljivanjeGR.Visibility = Visibility.Hidden;
            za_prodajuGR.Visibility = Visibility.Hidden;
        }

        private void za_iznajmljivanjeBTN_Click(object sender, RoutedEventArgs e)
        {
            bibliotekeGR.Visibility = Visibility.Hidden;
            bibliotekariGR.Visibility = Visibility.Hidden;
            clanGR.Visibility = Visibility.Hidden;
            clanarinaGR.Visibility = Visibility.Hidden;
            izdanjeGR.Visibility = Visibility.Hidden;
            izdavacGR.Visibility = Visibility.Hidden;
            knjigaGR.Visibility = Visibility.Hidden;
            osobaGR.Visibility = Visibility.Hidden;
            primerakGR.Visibility = Visibility.Hidden;
            za_iznajmljivanjeGR.Visibility = Visibility.Visible;
            za_prodajuGR.Visibility = Visibility.Hidden;
        }

        private void za_prodaju_Click(object sender, RoutedEventArgs e)
        {
            bibliotekeGR.Visibility = Visibility.Hidden;
            bibliotekariGR.Visibility = Visibility.Hidden;
            clanGR.Visibility = Visibility.Hidden;
            clanarinaGR.Visibility = Visibility.Hidden;
            izdanjeGR.Visibility = Visibility.Hidden;
            izdavacGR.Visibility = Visibility.Hidden;
            knjigaGR.Visibility = Visibility.Hidden;
            osobaGR.Visibility = Visibility.Hidden;
            primerakGR.Visibility = Visibility.Hidden;
            za_iznajmljivanjeGR.Visibility = Visibility.Hidden;
            za_prodajuGR.Visibility = Visibility.Visible;
        }

        private void dodajBTN_Click(object sender, RoutedEventArgs e)
        {
            if(bibliotekeGR.Visibility == Visibility.Visible) { 
            addBiblioteka ab = new addBiblioteka();
            ab.Show();
            }else if (bibliotekariGR.Visibility == Visibility.Visible)
            {
                addBibliotekara ab = new addBibliotekara();
                ab.Show();
            }else if (clanGR.Visibility == Visibility.Visible)
            {
                addClan ac = new addClan();
                ac.Show();
            }else if (clanarinaGR.Visibility == Visibility.Visible)
            {
                addClanarina ac = new addClanarina();
                ac.Show();
            }else if (osobaGR.Visibility == Visibility.Visible)
            {
                addOsoba ao = new addOsoba();
                ao.Show();
            }
        }

        private void obrisiBTN_Click(object sender, RoutedEventArgs e)
        {
            if(bibliotekeGR.Visibility == Visibility.Visible)
            {
                del.DeleteBiblioteka((Biblioteka)bibliotekeGR.SelectedItem);
            }else if (bibliotekariGR.Visibility == Visibility.Visible)
            {
                Bibliotekar b = (Bibliotekar)bibliotekariGR.SelectedItem;
                del.DeleteBibliotekar(read.GetBibliotekar(b.ID_Bibliotekara));
            }
        }
    }
}
