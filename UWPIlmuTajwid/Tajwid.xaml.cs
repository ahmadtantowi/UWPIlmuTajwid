using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

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

        //public string huruf2    = "Huruf-hurufnya sebagai berikut:";
        //public string caraBaca  = "Cara membacanya:";

        //// Alif Lam
        //public string pengertianAssyamsiyah = "Alif lam syamsiyah merupakan alim-lam yang dirangkai dengan kata benda (isim) yang diawali dengan salah satu dari huruf-huruf syamsiyah. Secara bahasa, syamsiah adalah matahari. Alif lam syamsiyah ditandai dengan tasydid";
        //public string caraBacaAssyamsiyah   = "Yaitu dengan memasukkan alim-lam sukun ke huruf-huruf syamsiyah, sehingga bacaan lam sukunnya hilang dan lebur ke dalam huruf syamsiyah yang mengikutinya";
        //public string huruf2Assyamsiyah     = "ت ث د ذ ر ز س ش ص ض ط ظ ل ن";

        //public string pengertianAlqamariyah = "Alif lam qamariah merupakan alim-lam yang dirangkai dengan kata benda (isim) yang diwawali dengan salah satu huruf qamariyah. Secara bahasa, qamariyah adalah bulan. Alif lam qamariyah ditandai dengan sukun/mati;";
        //public string caraBacaAlqamariyah   = "Yakni dengan tetap dibaca lam sukunnya";
        //public string huruf2Alqamariyah     = "ا ب ج ح خ ع غ ف ق ك م ه و ي";

        //// Nun mati/tanwin
        //public string pengertianIdzhar      = "Apabila ada nun mati/tanwin bertemu dengan salah satu huruf idzhar, maka harus dibaca dengan jelas";
        //public string huruf2Idzhar          = "ا ح ع ه غ خ";

        //public string pengertianIdghamBigunnah      = "Menurut bahasa idgham artinya meleburkan, gunnah artinya mendengung. Apabila ada nun mati/tanwin bertemu dengan salah satu huruf idhgham bigunnah, maka huruf nun mati/tanwin dileburkan dengan dengung";
        //public string huruf2IdghamBigunnah          = "ي ن م و";

        //public string pengertianIdghamBilagunnah    = "Menurut bahasa idgham artinya meleburkan, gunnah artinya tanpa mendengaung. Apabila ada nun mati/tanwin bertemu dengan salah satu huruf idgham bilagunnah, maka huruf nun mati/tanwin dileburkan tanpa dengung";
        //public string huruf2IdghamBilagunnah        = "ل ر";

        //public string pengertianIqlab               = "Menurut bahasa iqlab artinya merubah/mengganti. Apabila ada nun mati/tanwin bertemu dengan huruf iqlab, maka hiruf nun mati/tanwin dibaca dengan huruf mim";
        //public string huruf2Iqlab                   = "ب";

        //public string pengertianIkhfa               = "Menurut bahasa ikhfa artinya samar-samar. Apabila nun mati/tanwin bertemu dengan salah satu huruf ikhfa, maka huruf nun mati/tanwin dibaca dengan samar-samar";
        //public string huruf2Ikhfa                   = "ت ث ج د ذ ز س ش ص ض ط ظ ف ق ك";

        //// Mim mati
        //public string pengertianIdzharSafawi        = "Apabila mim mati bertemu dengan huruf 'ba', maka mim mati harus dibaca samar antara 'mim' dan 'ba' ditahan kira-kira dua ketukan dan seraya mengeluarkan suara gunnah (dengung dari pangkal hidung)";
        //public string caraBacaIdzharSafawi          = "Suara mim mati disamarkan, disertai dengan mendengaung, dan ada tekanan selama 2 harakat";
        //public string huruf2IdzharSafawi            = "م";

        //public string pengertianIdghamMimi          = "Merupakan huruf mim mati yang bertemu dengan 'mim'";
        //public string caraBacaIdghamMimi            = "Suara mim sukun dimasukkan kepada huruf berikutnya dan disertai dengan gunnah (dengung dari pangkal hidung";
        //public string huruf2IdghamMimi              = "ب";

        //public string pengertianIkhfaSafawi         = "Merupakan pertemuan antara mim mati dengan huruf hijaiyah selain huruf 'mim' dan 'ba'";
        //public string caraBacaIkhfaSafawi           = "Suara mim mati dibaca jelas, tidak mendengung, dan tidak ada tekanan";
        //public string huruf2IkhfaSafawi             = "ا ت ث ج ح خ د ذ ر ز س ش ص ض ط ظ ع غ ف ق ك ل ن و ه ى";

        //// Mad
        //public string pengertianMadThabii           = "Apabila ada huruf 'alif' terletak setelah fathah, atau huruf 'ya' sukun setelah kasrah, atau huruf 'wau' setelah dhammah, maka kalimat tersebut dihukumi mad thabii";
        //public string caraBacaMadThabii             = "Yaitu dengan memanjangkan huruf sepanjang dua harakat";
        //public string huruf2MadThabii               = "ا و ي";

        //// Qalqalah
        //public string pengertianQalqalahSugra = "Sugra menurut bahasa artinya kecil. Qalqalah sugra terjadi apabila huruf qalqalah itu mati pada kata asalnya (pada umumnya terletak di tengah-tengah kata)";
        //public string caraBacaQalqalahSugra = "Yaitu dengan pantulan tidak terlalu kuat";

        //public string pengertianQalqalahKubra = "Kubra menurut bahasa artinya besar. Qalqalah sugra terjadi apabila huruf qalqalah yang mati bukan pada asalnya. Huruf tersebut mati karena diberhentikan/diwaqafkan dan berada pada akhir kata";
        //public string caraBacaQalqalahKubra = "Yaitu harus lebih mantap dengan memantulkan suara dengan pantulan yang kuat";

        // Waqaf
        // Washal

        //private void assamsiyah_Click(object sender, RoutedEventArgs e)
        //{
        //    jenisAlifLam.Text           = "Alif Lam Samsiyah";
        //    pengertianAlifLam.Text      = pengertianAssyamsiyah.ToString();
        //    caraBacaAlifLam_Text.Text   = caraBaca;
        //    caraBacaAlifLam.Text        = caraBacaAssyamsiyah;
        //    huruf2AlifLam_Text.Text     = huruf2.ToString();
        //    huruf2AlifLam.Text          = huruf2Assyamsiyah.ToString();
        //}

        //private void alqamariyah_Click(object sender, RoutedEventArgs e)
        //{
        //    jenisAlifLam.Text           = "Alif Lam Qamariyah";
        //    pengertianAlifLam.Text      = pengertianAlqamariyah.ToString();
        //    caraBacaAlifLam_Text.Text   = caraBaca;
        //    caraBacaAlifLam.Text        = caraBacaAlqamariyah;
        //    huruf2AlifLam_Text.Text     = huruf2.ToString();
        //    huruf2AlifLam.Text          = huruf2Alqamariyah.ToString();
        //}

        //private void idzhar_Click(object sender, RoutedEventArgs e)
        //{
        //    jenisNunMati.Text           = "Idzhar";
        //    pengertianNunMati.Text      = pengertianIdzhar.ToString();
        //    huruf2NunMati_Text.Text     = huruf2.ToString();
        //    huruf2NunMati.Text          = huruf2Idzhar.ToString();
        //}

        //private void idghamBigunnah_Click(object sender, RoutedEventArgs e)
        //{
        //    jenisNunMati.Text           = "Idgham Bigunnah";
        //    pengertianNunMati.Text      = pengertianIdghamBigunnah.ToString();
        //    huruf2NunMati_Text.Text     = huruf2.ToString();
        //    huruf2NunMati.Text          = huruf2IdghamBigunnah.ToString();
        //}

        //private void idghamBilagunnah_Click(object sender, RoutedEventArgs e)
        //{
        //    jenisNunMati.Text           = "Idgham Bilagunnah";
        //    pengertianNunMati.Text      = pengertianIdghamBilagunnah.ToString();
        //    huruf2NunMati_Text.Text     = huruf2.ToString();
        //    huruf2NunMati.Text          = huruf2IdghamBilagunnah.ToString();
        //}

        //private void iqlab_Click(object sender, RoutedEventArgs e)
        //{
        //    jenisNunMati.Text           = "Iqlab";
        //    pengertianNunMati.Text      = pengertianIqlab.ToString();
        //    huruf2NunMati_Text.Text     = huruf2.ToString();
        //    huruf2NunMati.Text          = huruf2Iqlab.ToString();
        //}

        //private void ikhfa_Click(object sender, RoutedEventArgs e)
        //{
        //    jenisNunMati.Text           = "Ikhfa";
        //    pengertianNunMati.Text      = pengertianIkhfa.ToString();
        //    huruf2NunMati_Text.Text     = huruf2.ToString();
        //    huruf2NunMati.Text          = huruf2Ikhfa.ToString();
        //}

        //private void idzharSafawi_Click(object sender, RoutedEventArgs e)
        //{
        //    jenisMimMati.Text           = "Idzhar Safawi";
        //    pengertianMimMati.Text      = pengertianIdzharSafawi.ToString();
        //    caraBacaMimMati_Text.Text   = caraBaca;
        //    caraBacaMimMati.Text        = caraBacaIdzharSafawi;
        //    huruf2MimMati_Text.Text     = huruf2.ToString();
        //    huruf2MimMati.Text          = huruf2IdzharSafawi.ToString();
        //}

        //private void idghamMimi_Click(object sender, RoutedEventArgs e)
        //{
        //    jenisMimMati.Text           = "Idgham Mimi";
        //    pengertianMimMati.Text      = pengertianIdghamMimi.ToString();
        //    caraBacaMimMati_Text.Text   = caraBaca;
        //    caraBacaMimMati.Text        = caraBacaIdghamMimi;
        //    huruf2MimMati_Text.Text     = huruf2.ToString();
        //    huruf2MimMati.Text          = huruf2IdghamMimi.ToString();
        //}

        //private void ikhfaSafawi_Click(object sender, RoutedEventArgs e)
        //{
        //    jenisMimMati.Text           = "Ikhfa Safawi";
        //    pengertianMimMati.Text      = pengertianIkhfaSafawi.ToString();
        //    caraBacaMimMati_Text.Text   = caraBaca;
        //    caraBacaMimMati.Text        = caraBacaIkhfaSafawi;
        //    huruf2MimMati_Text.Text     = huruf2.ToString();
        //    huruf2MimMati.Text          = huruf2IkhfaSafawi.ToString();
        //}

        //private void madThabii_Click(object sender, RoutedEventArgs e)
        //{
        //    jenisMad.Text               = "Mad Thabii";
        //    pengertianMad.Text          = pengertianMadThabii.ToString();
        //    caraBacaMad_Text.Text       = caraBaca;
        //    caraBacaMad.Text            = caraBacaMadThabii.ToString();
        //    huruf2Mad_Text.Text         = huruf2.ToString();
        //    huruf2Mad.Text              = huruf2MadThabii.ToString();
        //}

        //private void qalqalahSugra_Click(object sender, RoutedEventArgs e)
        //{
        //    jenisQalqalah.Text = "Qalqalah Sugra";
        //    pengertianQalqalah.Text = pengertianQalqalahSugra.ToString();
        //    caraBacaQalqalah_Text.Text = caraBaca.ToString();
        //    caraBacaQalqalah.Text = caraBacaQalqalahSugra.ToString();
        //}

        //private void qalqalahKubra_Click(object sender, RoutedEventArgs e)
        //{
        //    jenisQalqalah.Text = "Qalqalah Kubra";
        //    pengertianQalqalah.Text = pengertianQalqalahKubra.ToString();
        //    caraBacaQalqalah_Text.Text = caraBaca.ToString();
        //    caraBacaQalqalah.Text = caraBacaQalqalahKubra.ToString();
        //}

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
