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
    public sealed partial class Hijaiyah : Page
    {
        public Hijaiyah()
        {
            this.InitializeComponent();
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
