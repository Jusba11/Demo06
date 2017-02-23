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

namespace ikkunaLaskuri
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

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            double ikkunanleveys = int.Parse(leveysBox.Text);

            double ikkunankorkeus = int.Parse(korkeusBox.Text);

            double karminleveys = int.Parse(karmiBox.Text);

            double lasinleveys = ikkunanleveys - (2 * karminleveys);
            
            double lasinkorkeus = ikkunankorkeus - (2 * karminleveys);


            double lasinPA = lasinleveys * lasinkorkeus;
            lasinPAbox.Text = lasinPA.ToString();

            double ikkunanPA = ikkunanleveys * ikkunankorkeus;
            ikkunanPAbox.Text = ikkunanPA.ToString();

            double karminpiiri = (ikkunankorkeus * 2) + (lasinleveys * 2);
            karminpiiriBox.Text = karminpiiri.ToString();

        }
    }
}
