using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

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

        string pengertianMadThabii = "Apabila ada huruf 'alif' terletak setelah fathah, atau huruf 'ya' sukun setelah kasrah, atau huruf 'wau' setelah dhammah, maka kalimat tersebut dihukumi mad thabii";
        string caraBacaMadThabii = "Yaitu dengan memanjangkan huruf sepanjang dua harakat";
        string huruf2MadThabii = "ا و ي";

        string pengertianMadWajibMuttasil = "Apabila ada mad thabii bertemu dengan 'hamzah' dalam satu kalimat, maka wajib dibaca sepanjang lima harakat";
        string pengertianMadJaizMunfashil = "Apabila ada mad thabii bertemu dengan 'hamzah' tetapi hamzah tersebut di lain kalimat, cara membacanya boleh terpisah atau seperti mad thabii"; 

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

        private void panelHome_Checked(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage));
        }

        private void CthMadTbiA_Click(object sender, RoutedEventArgs e)
        {
            CthMadTbiAME.Play();
        }

        private void CthMadTbiW_Click(object sender, RoutedEventArgs e)
        {
            CthMadTbiWME.Play();
        }

        private void CthMadTbiY_Click(object sender, RoutedEventArgs e)
        {
            CthMadTbiYME.Play();
        }
    }
}
