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
    public sealed partial class TajwidNunMati : Page
    {
        public TajwidNunMati()
        {
            this.InitializeComponent();
            LoadContent();
        }

        public string pengertianIdzhar = "Apabila ada nun mati/tanwin bertemu dengan salah satu huruf idzhar, maka harus dibaca dengan jelas";
        public string huruf2Idzhar = "ا ح ع ه غ خ";

        public string pengertianIdghamBigunnah = "Menurut bahasa idgham artinya meleburkan, gunnah artinya mendengung. Apabila ada nun mati/tanwin bertemu dengan salah satu huruf idhgham bigunnah, maka huruf nun mati/tanwin dileburkan dengan dengung";
        public string huruf2IdghamBigunnah = "ي ن م و";

        public string pengertianIdghamBilagunnah = "Menurut bahasa idgham artinya meleburkan, gunnah artinya tanpa mendengaung. Apabila ada nun mati/tanwin bertemu dengan salah satu huruf idgham bilagunnah, maka huruf nun mati/tanwin dileburkan tanpa dengung";
        public string huruf2IdghamBilagunnah = "ل ر";

        public string pengertianIqlab = "Menurut bahasa iqlab artinya merubah/mengganti. Apabila ada nun mati/tanwin bertemu dengan huruf iqlab, maka hiruf nun mati/tanwin dibaca dengan huruf mim";
        public string huruf2Iqlab = "ب";

        public string pengertianIkhfa = "Menurut bahasa ikhfa artinya samar-samar. Apabila nun mati/tanwin bertemu dengan salah satu huruf ikhfa, maka huruf nun mati/tanwin dibaca dengan samar-samar";
        public string huruf2Ikhfa = "ت ث ج د ذ ز س ش ص ض ط ظ ف ق ك";

        void LoadContent()
        {
            PengertianIdzhar.Text = pengertianIdzhar;
            PengertianIdghamBigunnah.Text = pengertianIdghamBigunnah;
            PengertianIdghamBilagunnah.Text = pengertianIdghamBilagunnah;
            PengertianIqlab.Text = pengertianIqlab;
            PengertianIkhfa.Text = pengertianIkhfa;
            HurufIdzhar.Text = huruf2Idzhar;
            HurufIdghamBigunnah.Text = huruf2IdghamBigunnah;
            HurufIdghamBilagunnah.Text = huruf2IdghamBilagunnah;
            HurufIqlab.Text = huruf2Iqlab;
            HurufIkhfa.Text = huruf2Ikhfa;
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
    }
}
