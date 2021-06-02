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

namespace Dora.AddWindows
{
    /// <summary>
    /// Interaction logic for addClanarina.xaml
    /// </summary>
    public partial class addClanarina : Window
    {
        private DBAccess.Create cr ;
        public addClanarina()
        {
            InitializeComponent();
            cr = new DBAccess.Create();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            cr.AddClanarina(short.Parse(tb1.Text), Int32.Parse(tb2.Text));
        }
    }
}
