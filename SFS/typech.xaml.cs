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

namespace SFS
{
    /// <summary>
    /// Interaction logic for typech.xaml
    /// </summary>
    public partial class typech : Window
    {
        public typech()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            mainqueryform mq = new mainqueryform();
            mq.Show();
            this.Close();

        }
    }
}
