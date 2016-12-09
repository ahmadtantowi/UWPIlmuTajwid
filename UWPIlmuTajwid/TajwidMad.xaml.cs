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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace UWPIlmuTajwid
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class TajwidMad : Page
    {
        public TajwidMad()
        {
            this.InitializeComponent();
            LoadContent();
        }

        public string pengertianMadThabii = "Apabila ada huruf 'alif' terletak setelah fathah, atau huruf 'ya' sukun setelah kasrah, atau huruf 'wau' setelah dhammah, maka kalimat tersebut dihukumi mad thabii";
        public string caraBacaMadThabii = "Yaitu dengan memanjangkan huruf sepanjang dua harakat";
        public string huruf2MadThabii = "ا و ي";

        void LoadContent()
        {
            PengertianMadThabii.Text = pengertianMadThabii;
            CaraBacaMadThabii.Text = caraBacaMadThabii;
            HurufMadThabii.Text = huruf2MadThabii;
        }

        private void HamburgerButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationPane.IsPaneOpen = !NavigationPane.IsPaneOpen;
        }

        private void panelAlifLam_Checked(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(TajwidAlifLam));
        }

        private void panelNunMati_Checked(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(TajwidNunMati));
        }

        private void panelMimMati_Checked(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(TajwidMimMati));
        }

        private void panelMad_Checked(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(TajwidMad));
        }

        private void panelQalqalah_Checked(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(TajwidQalqalah));
        }

        private void panelWaqaf_Checked(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(TajwidWaqaf));
        }
    }
}
