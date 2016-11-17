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
    public sealed partial class Pengaturan : Page
    { 
        public Pengaturan()
        {
            this.InitializeComponent();

            var settings = Windows.Storage.ApplicationData.Current.RoamingSettings;

            if (settings.Values["currentTheme"] as string == "dark")
                SwitchTheme_Toggle.IsOn = true;
            else
                SwitchTheme_Toggle.IsOn = false;
        }

        private void SwitchTheme_Toggled(object sender, RoutedEventArgs e)
        {
            string currentTheme = null;
            var settings = Windows.Storage.ApplicationData.Current.RoamingSettings;
            if (settings.Values.ContainsKey("currentTheme"))
            {
                currentTheme = (string)settings.Values["currentTheme"];
                settings.Values.Remove("currentTheme");
            }

            settings.Values.Add("currentTheme", currentTheme == "light" ? "dark" : "light");
            if (settings.Values["currentTheme"] as string == "dark")
                SwitchTheme_Toggle.IsOn = true;
            else
                SwitchTheme_Toggle.IsOn = false;

            NotifSwitchTheme.Text = "Mengubah tema membutuhkan memulai ulang aplikasi";
            ValueSwitchTheme.Text = settings.Values["currentTheme"] as string;
        }

        private void SwitchThemeLight_Click(object sender, RoutedEventArgs e)
        {
            var settings = Windows.Storage.ApplicationData.Current.RoamingSettings;

            string currentTheme = null;
            if (settings.Values.ContainsKey("currentTheme"))
            {
                currentTheme = settings.Values["currentTheme"] as string;
                settings.Values.Remove("currentTheme");
            }

            settings.Values.Add("currentTheme", currentTheme == "light");

            //NotifSwitchTheme.Text = "Mengubah tema membutuhkan memulai ulang aplikasi";
            ValueSwitchTheme.Text = settings.Values["currentTheme"] as string;
        }

        private void SwitchThemeDark_Click(object sender, RoutedEventArgs e)
        {
            var settings = Windows.Storage.ApplicationData.Current.RoamingSettings;

            string currentTheme = null;
            if (settings.Values.ContainsKey("currentTheme"))
            {
                currentTheme = settings.Values["currentTheme"] as string;
                settings.Values.Remove("currentTheme");
            }

            settings.Values.Add("currentTheme", currentTheme == "dark");

            //NotifSwitchTheme.Text = "Mengubah tema membutuhkan memulai ulang aplikasi";
            ValueSwitchTheme.Text = settings.Values["currentTheme"] as string;
        }
    }
}
