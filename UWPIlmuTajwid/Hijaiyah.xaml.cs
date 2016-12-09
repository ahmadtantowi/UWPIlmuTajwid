using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace UWPIlmuTajwid
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Hijaiyah : Page
    {
        public Hijaiyah()
        {
            this.InitializeComponent();
            LoadContent();
        }

        string aljauf = "Yaitu tempat keluarnya huruf hijaiyah yang terletak pada rongga mulut dan rongga tenggorokan. Bunyi huruf yang keluar dari rongga mulut dan rongga tenggorokan ada tiga macam, yaitu; alif (ا), wawu mati (وْ) dan ya mati (يْ) dengan penjelasan sebagai berikut:";
        string alhalqu = "Yaitu tempat keluar bunyi huruf hijaiyah yang terletak pada kerongkongan / tenggorokan. Dan berdasarkan perbedaan teknis pelafalannya, huruf-huruf halqiyah (huruf-huruf yang keluar dari tenggorokan) dibagi menjadi tiga bagian yaitu:";
        string allisanu = "Bunyi huruf hijaiyah dengan tempat keluarnya dari lidah ada 18 huruf, yaitu: Berdasarkan delapan belas huruf itu dapat dikelompokkan menjadi 10 makhraj, yaitu sebagai berikut:";
        string asysyafatain = "Yaitu tempat keluarnya huruf hijaiyah yang terletak pada kedua bibir. Yang termasuk huruf-huruf syafatain ialah wawu (و), fa’ (ف), mim (م) dan ba’ (ب) dengan perincian sebagai berikut:";
        string alkhaisyum = "Yaitu tempat keluarnya huruf hijaiyah yang terletak pada janur hidung. Dan jika kita menutup hidung ketika membunyikan huruf tersebut, maka tidak dapat terdengar. Adapun huruf-hurufnya yaitu huruf-huruf ghunnah mim dan nun dengan ketentuan sebagai berikut:";

        void LoadContent()
        {
            Aljauf.Text = aljauf;
            Alhalqu.Text = alhalqu;
            Allisanu.Text = allisanu;
            Asysayafatain.Text = asysyafatain;
            Alkhaisyum.Text = alkhaisyum;
        }

        private void alif_Click(object sender, RoutedEventArgs e)
        {
            AlifMediaElement.Play();
        }
        private void ba_Click(object sender, RoutedEventArgs e)
        {
            BaMediaElement.Play();
        }
        private void ta_Click(object sender, RoutedEventArgs e)
        {
            TaMediaElement.Play();
        }
        private void tsa_Click(object sender, RoutedEventArgs e)
        {
            TsafMediaElement.Play();
        }
        private void jim_Click(object sender, RoutedEventArgs e)
        {
            JimMediaElement.Play();
        }
        private void ha_Click(object sender, RoutedEventArgs e)
        {
            HaMediaElement.Play();
        }
        private void kha_Click(object sender, RoutedEventArgs e)
        {
            KhaMediaElement.Play();
        }
        private void dal_Click(object sender, RoutedEventArgs e)
        {
            DalMediaElement.Play();
        }
        private void dzal_Click(object sender, RoutedEventArgs e)
        {
            DzalMediaElement.Play();
        }
        private void ra_Click(object sender, RoutedEventArgs e)
        {
            RaMediaElement.Play();
        }
        private void zai_Click(object sender, RoutedEventArgs e)
        {
            ZaiMediaElement.Play();
        }
        private void sin_Click(object sender, RoutedEventArgs e)
        {
            SinMediaElement.Play();
        }
        private void syin_Click(object sender, RoutedEventArgs e)
        {
            SyinMediaElement.Play();
        }
        private void shad_Click(object sender, RoutedEventArgs e)
        {
            ShadMediaElement.Play();
        }
        private void dhad_Click(object sender, RoutedEventArgs e)
        {
            DhadMediaElement.Play();
        }
        private void tha_Click(object sender, RoutedEventArgs e)
        {
            ThaMediaElement.Play();
        }
        private void zha_Click(object sender, RoutedEventArgs e)
        {
            ZhaMediaElement.Play();
        }
        private void ain_Click(object sender, RoutedEventArgs e)
        {
            AinMediaElement.Play();
        }
        private void ghain_Click(object sender, RoutedEventArgs e)
        {
            GhainMediaElement.Play();
        }
        private void fa_Click(object sender, RoutedEventArgs e)
        {
            FaMediaElement.Play();
        }
        private void qaf_Click(object sender, RoutedEventArgs e)
        {
            QafMediaElement.Play();
        }
        private void kaf_Click(object sender, RoutedEventArgs e)
        {
            KafMediaElement.Play();
        }
        private void lam_Click(object sender, RoutedEventArgs e)
        {
            LamMediaElement.Play();
        }
        private void mim_Click(object sender, RoutedEventArgs e)
        {
            MimMediaElement.Play();
        }
        private void nun_Click(object sender, RoutedEventArgs e)
        {
            NunMediaElement.Play();
        }
        private void wau_Click(object sender, RoutedEventArgs e)
        {
            WauMediaElement.Play();
        }
        private void hha_Click(object sender, RoutedEventArgs e)
        {
            HhaMediaElement.Play();
        }
        private void hamzah_Click(object sender, RoutedEventArgs e)
        {
            AlifMediaElement.Play();
        }
        private void ya_Click(object sender, RoutedEventArgs e)
        {
            YaMediaElement.Play();
        }
    }
}
