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

namespace LibraryWPF
{
    /// <summary>
    /// Interaction logic for DeleteDialog.xaml
    /// </summary>
    public partial class DeleteDialog : Window
    {
        private bool res = false;
        private string title;
        public DeleteDialog(string title)
        {
            InitializeComponent();
            this.title = title;
            titletxt.Text = $"Are you sure you want to delete {title} ?";
        }

        private void yes_Click(object sender, RoutedEventArgs e)
        {
            res = true;
            this.Close();
        }

        private void no_Click(object sender, RoutedEventArgs e)
        {
            res = false;
            this.Close();
        }

        public bool getres()
        {
            return res;
        }
    }
}
