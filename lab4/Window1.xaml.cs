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

namespace lab4
{
    public partial class Window1 : Window
    {
        private MainWindow _mainWindow;
        public Window1(MainWindow mainWindow)
        {
            InitializeComponent();
            _mainWindow = mainWindow; 
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double x = Convert.ToDouble(TB_X.Text);
                double y = Convert.ToDouble(TB_Y.Text);
                _mainWindow.DefineQuarter(x, y);  
                _mainWindow.DrawCircle(ref x, ref y);  
                this.Close();
            }
            catch (FormatException)
            {
                MessageBox.Show("Помилка: введіть число");
            }
        }
    }
}