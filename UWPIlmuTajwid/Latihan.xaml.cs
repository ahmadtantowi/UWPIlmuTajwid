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

        string jawaban;

        public Latihan()
        {
            this.InitializeComponent();

            path = Path.Combine(Windows.Storage.ApplicationData.Current.LocalFolder.Path, "db.sqlite");

            conn = new SQLite.Net.SQLiteConnection(new SQLite.Net.Platform.WinRT.SQLitePlatformWinRT(), path);
            conn.CreateTable<tb_Pertanyaan>();

            // menampilkan path folder data aplikasi
            Debug.WriteLine(Windows.Storage.ApplicationData.Current.LocalFolder.Path);

            getPertanyaan();
        }

        private int getIdPertanyaan()
        {
            //var query = conn.Query<tb_Pertanyaan>("select IdPertanyaan from tb_Pertanyaan where);
            Random rnd = new Random();
            int id = rnd.Next(1, 4);

            return id;
        }

        private void getPertanyaan()
        {
            string pertanyaan = "";
            string kalimah = "";
            string jawaban = "";
            string pilA = "";
            string pilB = "";
            string pilC = "";
            string pilD = "";

            var query = conn.Query<tb_Pertanyaan>("select * from tb_Pertanyaan where IdPertanyaan = " + getIdPertanyaan());

            foreach(var message in query)
            {
                pertanyaan = message.Pertanyaan;
                kalimah = message.Kalimah;
                jawaban = message.Jawaban;
                pilA = message.PilA;
                pilB = message.PilB;
                pilC = message.PilC;
                pilD = message.PilD;
            }
            this.jawaban = jawaban;

            if (pertanyaan != null)
                boxPertanyaan.Text = pertanyaan;
            else
                boxPertanyaan.Text = " ";

            if (kalimah != null)
                boxKalimah.Text = kalimah;
            else
                boxKalimah.Text = " ";

            _a.Content = "A. " + pilA;
            _b.Content = "B. " + pilB;
            _c.Content = "C. " + pilC;
            _d.Content = "D. " + pilD;

            btnNext.IsEnabled = false;
            _a.IsEnabled = true;
            _b.IsEnabled = true;
            _c.IsEnabled = true;
            _d.IsEnabled = true;
        }

        private void getResult(string _jawaban)
        {
            if(_jawaban == this.jawaban)
            {
                statusJawaban.Text = "Benar!";
            }
            else
            {
                statusJawaban.Text = "Salah!";
            }

            btnNext.IsEnabled = true;
            _a.IsEnabled = false;
            _b.IsEnabled = false;
            _c.IsEnabled = false;
            _d.IsEnabled = false;
        }

        private void _a_Click(object sender, RoutedEventArgs e)
        {
            getResult("a");
        }

        private void _b_Click(object sender, RoutedEventArgs e)
        {
            getResult("b");
        }

        private void _c_Click(object sender, RoutedEventArgs e)
        {
            getResult("c");
        }

        private void _d_Click(object sender, RoutedEventArgs e)
        {
            getResult("d");
        }

        private void btnNext_Click(object sender, RoutedEventArgs e)
        {
            boxPertanyaan.Text = "";
            boxKalimah.Text = "";
            statusJawaban.Text = "";

            getPertanyaan();
        }

        /*
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
        */
    }

    public class tb_Pertanyaan
    {
        [PrimaryKey, AutoIncrement]
        public int IdPertanyaan { get; set; }
        public string Pertanyaan { get; set; }
        public string Kalimah { get; set; }
        public string Jawaban { get; set; }
        public string PilA { get; set; }
        public string PilB { get; set; }
        public string PilC { get; set; }
        public string PilD { get; set; }
    }
}
