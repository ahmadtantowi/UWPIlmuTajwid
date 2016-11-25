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

using SQLite.Net.Attributes;
using System.Diagnostics;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace UWPIlmuTajwid
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Latihan : Page
    {
        string path;
        SQLite.Net.SQLiteConnection conn;

        public Latihan()
        {
            this.InitializeComponent();

            path = Path.Combine(Windows.Storage.ApplicationData.Current.LocalFolder.Path, "db.sqlite");

            conn = new SQLite.Net.SQLiteConnection(new SQLite.Net.Platform.WinRT.SQLitePlatformWinRT(), path);
            conn.CreateTable<Pertanyaan>();

            // menampilkan path folder data aplikasi
            Debug.WriteLine(Windows.Storage.ApplicationData.Current.LocalFolder.Path);
        }

        public void View_Database(object sender, RoutedEventArgs e)
        {
            var query = conn.Table<Pertanyaan>();
            string id = "";
            string name = "";
            string age = "";

            foreach (var message in query)
            {
                id = id + " " + message.Id;
                name = name + " " + message.Name;
                age = age + " " + message.Age;
            }

            view_table.Text = id + ", " + name + ", " + age;
        }

        private void ok_button_Click(object sender, RoutedEventArgs e)
        {
            var add = conn.Insert(new Pertanyaan() {
                Name = nama_field.Text,
                Age = umur_field.Text
            });
        }

        private void View_Database_Click(object sender, RoutedEventArgs e)
        {
            var query = conn.Table<Pertanyaan>();
            string id = "";
            string name = "";
            string age = "";

            foreach (var message in query)
            {
                id = id + " " + message.Id;
                name = name + " " + message.Name;
                age = age + " " + message.Age;
            }

            view_table.Text = id + ", " + name + ", " + age;
        }
    }

    public class Pertanyaan
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Age { get; set; }
    }
}
