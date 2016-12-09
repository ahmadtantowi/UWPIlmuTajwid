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
    public sealed partial class TajwidWaqaf : Page
    {
        public TajwidWaqaf()
        {
            this.InitializeComponent();
            LoadContent();
        }

        string pengertianWaqaf = "Waqaf secara bahasa memiliki arti berhenti. &#10;Sedangkan secara istilah, waqaf yaitu menghentikan bacaan sejenak pada akhir kalimat ataupun pada pertengahan kalimat";
        string jenisWaqaf = "1. Waqaf sempurna (taam) &#10;yaitu waqaf pada suatu kalimat yang dibaca secara sempurna tanpa melakuakan pemotongan di tengah-tengah bacaan, serta tidak mempengaruhi arti karena tidak berhubungan dengan bacaan sebelumnya ataupun selanjutnya &#10;" + 
            "2. Waqaf memadai (kkaf) &#10;yaitu waqaf pada suatu kalimat yang dibaca secara sempurna tanpa melakukan pemotongan kalimat di tengah-tengah, namun masih berhubungan arti dengan kalimat sebelum atau sesudahnya &#10;" + 
            "3. Waqaf baik (hasan) &#10;yaitu mewaqafkan kalimat yang tidak mempengaruhi arti, namun kalimat tersebut masih berhubungan dengan kalimat sesudahnya &#10;" +
            "4. Waqaf buruk (qabiih) &#10;yaitu mewaqafkan ditengah kalimat dengan membaca tidak sepurna sehingga mempengaruhi makna yang berkaitan dengan kalimat yang lainnya, waqaf ini harus dihindari";

        void LoadContent()
        {
            PengertianWaqaf.Text = pengertianWaqaf;
            JenisWaqaf.Text = jenisWaqaf;
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
