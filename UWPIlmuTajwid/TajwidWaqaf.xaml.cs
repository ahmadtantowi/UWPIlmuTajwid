using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

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

        string pengertianWaqaf = "Waqaf secara bahasa memiliki arti berhenti." + Environment.NewLine + 
            "Sedangkan secara istilah, waqaf yaitu menghentikan bacaan sejenak pada akhir kalimat ataupun pada pertengahan kalimat";
        string jenisWaqaf = "1. Waqaf sempurna (taam)" + Environment.NewLine +
            "yaitu waqaf pada suatu kalimat yang dibaca secara sempurna tanpa melakuakan pemotongan di tengah-tengah bacaan, serta tidak mempengaruhi arti karena tidak berhubungan dengan bacaan sebelumnya ataupun selanjutnya" + Environment.NewLine + 
            "2. Waqaf memadai (kaaf)" + Environment.NewLine + 
            "yaitu waqaf pada suatu kalimat yang dibaca secara sempurna tanpa melakukan pemotongan kalimat di tengah-tengah, namun masih berhubungan arti dengan kalimat sebelum atau sesudahnya" + Environment.NewLine +
            "3. Waqaf baik (hasan)" + Environment.NewLine +
            "yaitu mewaqafkan kalimat yang tidak mempengaruhi arti, namun kalimat tersebut masih berhubungan dengan kalimat sesudahnya" + Environment.NewLine +
            "4. Waqaf buruk (qabiih)" +Environment.NewLine +
            "yaitu mewaqafkan ditengah kalimat dengan membaca tidak sepurna sehingga mempengaruhi makna yang berkaitan dengan kalimat yang lainnya, waqaf ini harus dihindari";

        string Lazim        = "Dilambangkan dengan huruf mim (م), diharuskan untuk berhenti. Biasanya terletak di akhir kalimat";
        string Mutlak       = "Dilambangkan dengan huruf tha (ط), diutamakan untuk berhenti pada waqaf tersebut";
        string Jaiz         = "Dilambangkan dengan huruf jim (ج), boleh berhenti atau diteruskan";
        string WasluUla     = "Dilambangkan dengan huruf shad-lam-ya (صلى), boleh berhenti atau lebih baik diteruskan";
        string LaWashal     = "Dilambangkan dengan huruf lam-alif (لا), dilarang berhenti kecuali pada akhir ayat";
        string WaqfuUla     = "Dilambangkan dengan huruf qaf-alif-lam (قال), lebih baik berhenti";
        string Muanaqah     = "Dilambangkan dengan tiga-titik berbentuk segitiga sebanyak dua buah, diutamakan berhenti pada salah satu tanda waqaf tersebut";
        string Murakhas     = "Dilambangkan dengan huruf shad (ص), boleh berhenti karena ayatnya panjang, diutamakan untuk diteruskan";
        string Qabih        = "Dilambangkan dengan huruf qaf (ق), diutamakan untuk diteruskan";
        string Saktah       = "Dilambangkan dengan sin-alif-kaf-ta-hha (ساكته), diharuskan untuk berhenti dan diam sejenak tanpa mengambil nafas";

        void LoadContent()
        {
            PengertianWaqaf.Text = pengertianWaqaf;
            JenisWaqaf.Text = jenisWaqaf;

            PenjelasanLazim.Text = Lazim;
            PenjelasanMutlak.Text = Mutlak;
            PenjelasanJaiz.Text = Jaiz;
            PenjelasanWasluUla.Text = WasluUla;
            PenjelasanLaWashal.Text = LaWashal;
            PenjelasanWaqfuUla.Text = WaqfuUla;
            PenjelasanMuanaqah.Text = Muanaqah;
            PenjelasanMurakhas.Text = Murakhas;
            PenjelasanQabih.Text = Qabih;
            PenjelasanSaktah.Text = Saktah;
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
