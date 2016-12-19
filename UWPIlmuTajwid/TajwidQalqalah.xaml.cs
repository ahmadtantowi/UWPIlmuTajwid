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
    public sealed partial class TajwidQalqalah : Page
    {
        public TajwidQalqalah()
        {
            this.InitializeComponent();
            LoadContent();
        }

        string penjelasanQalqalah = "Qalqalah secara bahasa artinya gerak, getaran suara, memantul. Sedangkan secara istilah qalqalah adalah membunyikan dengan suara yang berlebih dari makhraj hurufnya" + Environment.NewLine +
            "Qalqalah berlaku bila huruf qalqalah itu mati, atau mati karena waqaf. Qalqalah ketika dibaca bunyinya tidak langsung menghilang, melainkan masih terdengar pantulan suara dari huruf qalqalah itu sendiri";
        string hurufQalqalah = "ق ط ب ج د";

        string pengertianQalqalahSugra = "Sugra menurut bahasa artinya kecil. Qalqalah sugra terjadi apabila huruf qalqalah itu mati pada kata asalnya (pada umumnya terletak di tengah-tengah kata)";
        string caraBacaQalqalahSugra = "Yaitu dengan pantulan tidak terlalu kuat";

        string pengertianQalqalahKubra = "Kubra menurut bahasa artinya besar. Qalqalah sugra terjadi apabila huruf qalqalah yang mati bukan pada asalnya. Huruf tersebut mati karena diberhentikan/diwaqafkan dan berada pada akhir kata";
        string caraBacaQalqalahKubra = "Yaitu harus lebih mantap dengan memantulkan suara dengan pantulan yang kuat";

        void LoadContent()
        {
            PenjelasanQalqalah.Text = penjelasanQalqalah;
            HurufQalqalah.Text = hurufQalqalah;

            PengertianSugra.Text = pengertianQalqalahSugra;
            PengertianKubra.Text = pengertianQalqalahKubra;
            CaraBacaSugra.Text = caraBacaQalqalahSugra;
            CaraBacaKubra.Text = caraBacaQalqalahKubra;
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

        private void CthQalqSugra1_Click(object sender, RoutedEventArgs e)
        {
            CthQalqSugra1ME.Play();
        }

        private void CthQalqSugra2_Click(object sender, RoutedEventArgs e)
        {
            CthQalqSugra2ME.Play();
        }

        private void CthQalqKubra1_Click(object sender, RoutedEventArgs e)
        {
            CthQalqKubra1ME.Play();
        }

        private void CthQalqKubra2_Click(object sender, RoutedEventArgs e)
        {
            CthQalqKubra2ME.Play();
        }
    }
}
