﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using CowboyCafe.Data;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for OrderControl.xaml
    /// </summary>
    public partial class OrderControl : UserControl
    {
        public OrderControl()
        {
            InitializeComponent();
            DataContext = new Order();
            Order.OrderNumber++;
        }

        private void ItemSelectionButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void CancelOrderButton_Click(object sender, RoutedEventArgs e)
        {
            DataContext = new Order();
            Order.OrderNumber++;
        }

        private void CompleteOrderButton_Click(object sender, RoutedEventArgs e)
        {
            DataContext = new Order();
            Order.OrderNumber++;
        }
    }
}
