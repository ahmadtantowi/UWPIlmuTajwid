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
    public sealed partial class TajwidAlifLam : Page
    {
        public TajwidAlifLam()
        {
            this.InitializeComponent();
            LoadContent();
        }

        public string pengertianAssyamsiyah = "Alif lam syamsiyah merupakan alim-lam yang dirangkai dengan kata benda (isim) yang diawali dengan salah satu dari huruf-huruf syamsiyah. Secara bahasa, syamsiah adalah matahari. Alif lam syamsiyah ditandai dengan tasydid";
        public string caraBacaAssyamsiyah = "Yaitu dengan memasukkan alim-lam sukun ke huruf-huruf syamsiyah, sehingga bacaan lam sukunnya hilang dan lebur ke dalam huruf syamsiyah yang mengikutinya";
        public string huruf2Assyamsiyah = "ت ث د ذ ر ز س ش ص ض ط ظ ل ن";

        public string pengertianAlqamariyah = "Alif lam qamariah merupakan alim-lam yang dirangkai dengan kata benda (isim) yang diwawali dengan salah satu huruf qamariyah. Secara bahasa, qamariyah adalah bulan. Alif lam qamariyah ditandai dengan sukun/mati;";
        public string caraBacaAlqamariyah = "Yakni dengan tetap dibaca lam sukunnya";
        public string huruf2Alqamariyah = "ا ب ج ح خ ع غ ف ق ك م ه و ي";

        void LoadContent()
        {
            PengertianSyamsiyah.Text = pengertianAssyamsiyah;
            PengertianQamariyah.Text = pengertianAlqamariyah;
            CaraBacaSyamsiyah.Text = caraBacaAssyamsiyah;
            CaraBacaQamariyah.Text = caraBacaAlqamariyah;
            HurufSyamisyah.Text = huruf2Assyamsiyah;
            HurufQamariyah.Text = huruf2Alqamariyah;
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
