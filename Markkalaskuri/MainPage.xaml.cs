using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Markkalaskuri
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void laske(object sender, RoutedEventArgs e)
        {
            double eurot = int.Parse(EuroField.Text);
            double markat = int.Parse(MarkkaField.Text);

            // 1 euro = 5.945markkaa

            double markkamaara = eurot * 5.945;
            string value1 = markkamaara.ToString("0.00");
            markkamaaraText.Text = value1;

            double euromaara = markat / 5.945;
            string value2 = euromaara.ToString("0.00");
            euromaaraText.Text = value2;

        }

        private void EuroField_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Markat_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void textBlock2_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }

        private void textBlock_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }

        private void textBlock3_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }

        private void textBlock1_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }
    }
}
