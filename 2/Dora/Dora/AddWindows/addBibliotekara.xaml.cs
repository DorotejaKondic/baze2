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
    /// Interaction logic for addBibliotekara.xaml
    /// </summary>
    public partial class addBibliotekara : Window
    {
        private Create cr;
        public addBibliotekara()
        {
            InitializeComponent();
            cr = new Create();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            cr.AddBibiliotekar(Int16.Parse(tb1.Text), tb2.Text, tb3.Text, Int16.Parse(tb4.Text));

        }
    }
}
