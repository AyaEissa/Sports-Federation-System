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
    /// Interaction logic for EmployeesDepartmentQuery.xaml
    /// </summary>
    public partial class EmployeesDepartmentQuery : Window
    {
        public EmployeesDepartmentQuery()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            EmployeesDepartmentDataG edg = new EmployeesDepartmentDataG();
            edg.Show();
            this.Close();
        }
    }
}
