using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace PhoneApp3
{
    public partial class Page1 : PhoneApplicationPage
    {
        Math_Stuff calc = new Math_Stuff();

        public Page1()
        {
            InitializeComponent();
        }

        private void zero_Click(object sender, RoutedEventArgs e)
        {
            tbox.Text += "0";
        }

        private void one_Click(object sender, RoutedEventArgs e)
        {
            tbox.Text += "1";
        }

        private void two_Click(object sender, RoutedEventArgs e)
        {
            tbox.Text += "2";
        }

        private void three_Click(object sender, RoutedEventArgs e)
        {
            tbox.Text += "3";
        }

        private void four_Click(object sender, RoutedEventArgs e)
        {
            tbox.Text += "4";
        }

        private void five_Click(object sender, RoutedEventArgs e)
        {
            tbox.Text += "5";
        }

        private void six_Click(object sender, RoutedEventArgs e)
        {
            tbox.Text += "6";
        }

        private void seven_Click(object sender, RoutedEventArgs e)
        {
            tbox.Text += "7";
        }

        private void eight_Click(object sender, RoutedEventArgs e)
        {
            tbox.Text += "8";
        }

        private void nine_Click(object sender, RoutedEventArgs e)
        {
            tbox.Text += "9";
        }

        private void plus_Click(object sender, RoutedEventArgs e)
        {
            tbox.Text += "+";
        }

        private void sub_Click(object sender, RoutedEventArgs e)
        {
            tbox.Text += "-";
        }

        private void mult_Click(object sender, RoutedEventArgs e)
        {
            tbox.Text += "*";
        }

        private void devide_Click(object sender, RoutedEventArgs e)
        {
            tbox.Text += "/";
        }

        private void clear_Click(object sender, RoutedEventArgs e)
        {
            tbox.Text = "0";
        }

        private void equal_Click(object sender, RoutedEventArgs e)
        {
          tbox.Text = calc.calculate(tbox.Text);
        }


    }
}