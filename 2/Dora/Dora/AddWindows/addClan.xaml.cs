﻿using System;
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
    /// Interaction logic for addClan.xaml
    /// </summary>
    public partial class addClan : Window
    {
        private Create cr;
        public addClan()
        {
            InitializeComponent();
            cr = new Create();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            cr.AddClan(Int32.Parse(tb1.Text), Int32.Parse(tb2.Text));
        }
    }
}