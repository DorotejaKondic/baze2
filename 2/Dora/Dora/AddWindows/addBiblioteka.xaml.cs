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
using System.Windows.Shapes;
using Dora.DBAccess;

namespace Dora.AddWindows
{
    /// <summary>
    /// Interaction logic for addBiblioteka.xaml
    /// </summary>
    public partial class addBiblioteka : Window
    {
        private Create cr;
        public addBiblioteka()
        {
            InitializeComponent();
            cr = new Create();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            

            if (tb1.Text != ""  && tb2.Text != "" && tb3.Text != "") {
                cr.AddBibilioteka(Int16.Parse(tb1.Text), tb2.Text, tb3.Text);
                MainWindow mw = new MainWindow();
                mw.Show();
                
            }
            else
                MessageBox.Show("unesi sva polja");

        }
    }
}
