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
    public sealed partial class TajwidMimMati : Page
    {
        public TajwidMimMati()
        {
            this.InitializeComponent();
            LoadContent();
        }

        public string pengertianIdzharSyafawi = "Apabila mim mati bertemu dengan huruf 'ba', maka mim mati harus dibaca samar antara 'mim' dan 'ba' ditahan kira-kira dua ketukan dan seraya mengeluarkan suara gunnah (dengung dari pangkal hidung)";
        public string caraBacaIdzharSyafawi = "Suara mim mati disamarkan, disertai dengan mendengaung, dan ada tekanan selama 2 harakat";
        public string huruf2IdzharSyafawi = "م";

        public string pengertianIdghamMimi = "Merupakan huruf mim mati yang bertemu dengan 'mim'";
        public string caraBacaIdghamMimi = "Suara mim sukun dimasukkan kepada huruf berikutnya dan disertai dengan gunnah (dengung dari pangkal hidung";
        public string huruf2IdghamMimi = "ب";

        public string pengertianIkhfaSyafawi = "Merupakan pertemuan antara mim mati dengan huruf hijaiyah selain huruf 'mim' dan 'ba'";
        public string caraBacaIkhfaSyafawi = "Suara mim mati dibaca jelas, tidak mendengung, dan tidak ada tekanan";
        public string huruf2IkhfaSyafawi = "ا ت ث ج ح خ د ذ ر ز س ش ص ض ط ظ ع غ ف ق ك ل ن و ه ى";

        void LoadContent()
        {
            PengertianIdzharSyafawi.Text = pengertianIdzharSyafawi;
            PengertianIdghamMimi.Text = pengertianIdghamMimi;
            PengertianIkhfaSyafawi.Text = pengertianIkhfaSyafawi;
            CaraBacaIdzharSyafawi.Text = caraBacaIdzharSyafawi;
            CaraBacaIdghamMimi.Text = caraBacaIdghamMimi;
            CaraBacaIkhfaSyafawi.Text = caraBacaIkhfaSyafawi;
            HurufIdzharSyafawi.Text = huruf2IdzharSyafawi;
            HurufIdghamMimi.Text = huruf2IdghamMimi;
            HurufIkhfaSyafawi.Text = huruf2IkhfaSyafawi;
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

        private void panelHome_Checked(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage));
        }

        private void CthIdzharSyafawi1_Click(object sender, RoutedEventArgs e)
        {
            CthIkhfaSyafawi1ME.Play();
        }

        private void CthIdzharSyafawi2_Click(object sender, RoutedEventArgs e)
        {
            CthIdzharSyafawi2ME.Play();
        }

        private void CthIdghamMimi1_Click(object sender, RoutedEventArgs e)
        {
            CthIdghamMimi1ME.Play();
        }
    }
}
