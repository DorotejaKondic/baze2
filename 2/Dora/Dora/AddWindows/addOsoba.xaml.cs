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
    /// Interaction logic for addOsoba.xaml
    /// </summary>
    public partial class addOsoba : Window
    {
        private DBAccess.Create cr;
        public addOsoba()
        {
            InitializeComponent();
            cr = new DBAccess.Create();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            cr.AddOsoba(Int32.Parse(tb1.Text), tb2.Text, tb3.Text, tb4.Text, tb5.Text);
        }
    }
}
