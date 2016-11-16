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
    public sealed partial class Tajwid : Page
    {
        public Tajwid()
        {
            this.InitializeComponent();
        }

        public string huruf2 = "Huruf-hurufnya sebagai berikut:";

        public string kontenAssamsiyah = "Alif lam samsiyah merupakan alim lam yang cara membacanya tidak diucapkan";
        public string huruf2Assamsiyah = "ت ث د ذ ر ز س ش ص ض ط ظ ل ن";

        public string kontenAlqamariyah = "Alif lam qamariah merupakan alim lam yang cara membacanya membunyikan huruf 'al'";
        public string huruf2Alqamariyah = "ا ب ج ح خ ع غ ف ق ك م ه و ي";

        private void assamsiyah_Click(object sender, RoutedEventArgs e)
        {
            jenisAlifLam.Text = "Alif Lam Samsiyah";
            kontenAlifLam.Text = kontenAssamsiyah.ToString();
            huruf2Tajwid.Text = huruf2.ToString();
            huruf2AlifLam.Text = huruf2Assamsiyah.ToString();
        }

        private void alqamariyah_Click(object sender, RoutedEventArgs e)
        {
            jenisAlifLam.Text = "Alif Lam Qamariyah";
            kontenAlifLam.Text = kontenAlqamariyah.ToString();
            huruf2Tajwid.Text = huruf2.ToString();
            huruf2AlifLam.Text = huruf2Alqamariyah.ToString();
        }
    }
}
