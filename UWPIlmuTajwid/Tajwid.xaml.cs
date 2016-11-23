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
using Windows.Data.Json;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace UWPIlmuTajwid
{
    /// <summary>                               
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Tajwid : Page
    {
        public Tajwid()
        {
            this.InitializeComponent();
        }

        public string huruf2    = "Huruf-hurufnya sebagai berikut:";
        public string caraBaca  = "Cara membacanya:";

        // Alif Lam
        public string pengertianAssyamsiyah = "Alif lam syamsiyah merupakan alim-lam yang dirangkai dengan kata benda (isim) yang diawali dengan salah satu dari huruf-huruf syamsiyah. Secara bahasa, syamsiah adalah matahari. Alif lam syamsiyah ditandai dengan tasydid";
        public string caraBacaAssyamsiyah   = "Yaitu dengan memasukkan alim-lam sukun ke huruf-huruf syamsiyah, sehingga bacaan lam sukunnya hilang dan lebur ke dalam huruf syamsiyah yang mengikutinya";
        public string huruf2Assyamsiyah     = "ت ث د ذ ر ز س ش ص ض ط ظ ل ن";

        public string pengertianAlqamariyah = "Alif lam qamariah merupakan alim-lam yang dirangkai dengan kata benda (isim) yang diwawali dengan salah satu huruf qamariyah. Secara bahasa, qamariyah adalah bulan. Alif lam qamariyah ditandai dengan sukun/mati;";
        public string caraBacaAlqamariyah   = "Yakni dengan tetap dibaca lam sukunnya";
        public string huruf2Alqamariyah     = "ا ب ج ح خ ع غ ف ق ك م ه و ي";

        // Nun mati/tanwin
        public string pengertianIdzhar      = "";
        public string caraBacaIdzhar        = "";
        public string huruf2Idzhar          = "";

        public string pengertianIdgham      = "";
        public string caraBacaIdgham        = "";
        public string huruf2Idgham          = "";

        public string pengertianIqlab       = "";
        public string caraBacaIqlab         = "";
        public string huruf2Iqlab           = "";

        public string pengertianIkhfa       = "";
        public string caraBacaIkhfa         = "";
        public string huruf2Ikhfa           = "";

        // Mim mati
        public string pengertianIdzharSafawi        = "";
        public string caraBacaIdzharSafawi          = "";
        public string huruf2IdzharSafawi            = "";

        public string pengertianIdghamMutamatsilain = "";
        public string caraBacaIdghamMutamasilain    = "";
        public string huruf2IdghamMutamasilain      = "";

        public string pengertianIkhfaSafawi         = "";
        public string caraBacaIkhfaSafawi           = "";
        public string huruf2IkhfaSafawi             = "";

        // Mad
        // Waqaf
        // Washal

        private void assamsiyah_Click(object sender, RoutedEventArgs e)
        {
            jenisAlifLam.Text           = "Alif Lam Samsiyah";
            pengertianAlifLam.Text      = pengertianAssyamsiyah.ToString();
            caraBacaAlifLam_Text.Text   = caraBaca;
            caraBacaAlifLam.Text        = caraBacaAssyamsiyah;
            huruf2AlifLam_Text.Text     = huruf2.ToString();
            huruf2AlifLam.Text          = huruf2Assyamsiyah.ToString();
        }

        private void alqamariyah_Click(object sender, RoutedEventArgs e)
        {
            jenisAlifLam.Text           = "Alif Lam Qamariyah";
            pengertianAlifLam.Text      = pengertianAlqamariyah.ToString();
            caraBacaAlifLam_Text.Text   = caraBaca;
            caraBacaAlifLam.Text        = caraBacaAlqamariyah;
            huruf2AlifLam_Text.Text     = huruf2.ToString();
            huruf2AlifLam.Text          = huruf2Alqamariyah.ToString();
        }

        private void idzhar_Click(object sender, RoutedEventArgs e)
        {
            jenisNunMati.Text           = "Idzhar";
        }

        private void idgham_Click(object sender, RoutedEventArgs e)
        {

        }

        private void iqlab_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ikhfa_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
