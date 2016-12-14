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
