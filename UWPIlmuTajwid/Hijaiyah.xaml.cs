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
        string asysyafatain = "Yaitu tempat keluarnya huruf hijaiyah yang terletak pada kedua bibir. Yang termasuk huruf-huruf syafatain ialah Wau (و), Fa (ف), Mim (م) dan ba’ (ب) dengan perincian sebagai berikut:";
        string alkhaisyum = "Yaitu tempat keluarnya huruf hijaiyah yang terletak pada janur hidung. Dan jika kita menutup hidung ketika membunyikan huruf tersebut, maka tidak dapat terdengar. Adapun huruf-hurufnya yaitu huruf-huruf ghunnah mim dan nun dengan ketentuan sebagai berikut:";

        string _allisanu1 = "1. Pangkal lidah dan langit-langit mulut bagian belakang, yaitu huruf Qaf(ق). Maksudnya bunyi huruf qof ini keluar dari pangkal lidah dekat dengan kerongkongan yang dihimpitkan ke langit-langit mulut bagian belakang";
        string _allisanu2 = "2. Pangkal lidah bagian tengah dan langit-langit mulut bagian tengah, yaitu huruf Kaf (ك). Maksudnya bunyi huruf kaf ini keluar dari pangkal lidah di depan makhraj huruf qof, yang dihimpitkan ke langit-langit bagian mulut bagian tengah";
        string _allisanu3 = "3. Tengah-tengah lidah, yaitu huruf Jim (ج), Syin (ش) dan Ya (ي). Maksudnya bunyi huruf-huruf tersebut keluar dari tengah-tengah lidah tepat, serta menepati langit-langit mulut yang tepat di atasnya";
        string _allisanu4 = "4. Pangkat tepi lidah, yaitu huruf Dhad (ض). Maksudnya bunyi huruf Dhad (ض) keluar dari tepi lidah (boleh tepi lidah kanan atau kiri) hingga sambung dengan makhrojnya huruf lam, serta menepati graham";
        string _allisanu5 = "5. Ujung tepi lidah, yaitu huruf Lam (ل). Maksudnya bunyi huruf Lam (ل) keluar dari tepi lidah (sebelah kiri/kanan) hingga penghabisan ujung lidah, serta menepati dengan langit-langit mulut atas";
        string _allisanu6 = "6. Ujung lidah, yaitu huruf Nun (ن). Maksudnya bunyi huruf Nun (ن) keluar dari ujung lidah (setelah makhrojnya Lam (ل), lebih masuk sedikit ke dasar lidah dari pada Lam (ل)), serta menepati dengan langit-langit mulut atas";
        string _allisanu7 = "7. Ujung lidah tepat, yaitu huruf Ra (ر). Maksudnya bunyi huruf Ra (ر) keluar dari ujung lidah tepat (setelah makhrojnya Nun dan lebih masuk ke dasar lidah dari pda Nun), serta menepati dengan langit-langit mulut atas";
        string _allisanu8 = "8. Kulit gusi atas, yaitu Dal (د), Ta (ت) dan Tha (ط). Maksudnya bunyi huruf-huruf tersebut keluar dari ujung lidah, serta menepat i dengan pangkal dua gigi seri yang atas";
        string _allisanu9 = "9. Runcing lidah, yaitu huruf Shod (ص), Sin (س) dan Zai (ز). Maksudnya bunyi huruf-huruf tersebut keluar dari ujung lidah, serta menepati ujung dua gigi seri yang bawah";
        string _allisanu10 = "10. Gusi, yaitu huruf Zha (ظ), Tsa (ث) dan Dzal (ذ). Maksudnya huruf-huruf tersebut keluar dari ujung lidah, serta menepati dengan ujung dua gigi seri yang atas";

        string _syafatain1 = "1. Fa (ف) keluar dari dalamnya bibir yang bawah, serta menepati dengan ujung dua gigi seri yang atas";
        string _syafatain2 = "2. Wau, Ba, Mim (و , ب , م) keluar dari antara dua bibir (antara bibir atas dan bawah). Hanya saja untuk Wawu bibir membuka, sedangkan untuk Ba dan Mim bibir membungkam";

        void LoadContent()
        {
            Aljauf.Text = aljauf;
            Alhalqu.Text = alhalqu;
            Allisanu.Text = allisanu;
            Asysyafatain.Text = asysyafatain;
            Alkhaisyum.Text = alkhaisyum;

            allisanu1.Text = _allisanu1;
            allisanu2.Text = _allisanu2;
            allisanu3.Text = _allisanu3;
            allisanu4.Text = _allisanu4;
            allisanu5.Text = _allisanu5;
            allisanu6.Text = _allisanu6;
            allisanu7.Text = _allisanu7;
            allisanu8.Text = _allisanu8;
            allisanu9.Text = _allisanu9;
            allisanu10.Text = _allisanu10;

            syafatain1.Text = _syafatain1;
            syafatain2.Text = _syafatain2;
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
