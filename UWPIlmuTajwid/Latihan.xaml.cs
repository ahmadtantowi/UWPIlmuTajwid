﻿using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

using SQLite.Net.Attributes;
using System.Diagnostics;
using System.IO;
using System;
using System.Collections;

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

        int jumlahPertanyaan = 0;   // maksimal 9
        int jawabanBenar;
        string jawaban;

        public Latihan()
        {
            this.InitializeComponent();
            ConnectSQLite();
            kalkulasiPertanyaan();
        }

        private void ConnectSQLite()
        {
            //path = Path.Combine(Windows.Storage.ApplicationData.Current.LocalFolder.Path, "db.sqlite");
            path = Path.Combine(Windows.ApplicationModel.Package.Current.InstalledLocation.Path, "Database", "db.sqlite");
            // menampilkan path folder data aplikasi
            Debug.WriteLine(path);

            try
            {
                conn = new SQLite.Net.SQLiteConnection(new SQLite.Net.Platform.WinRT.SQLitePlatformWinRT(), path);
                conn.CreateTable<tb_Pertanyaan>();
                Debug.WriteLine("Connection success!");
            }
            catch(SQLite.Net.SQLiteException e)
            {
                Debug.WriteLine("Connection failed!");
            }
        }

        private void kalkulasiPertanyaan()
        {
            if (jumlahPertanyaan < 10)
                getPertanyaan();
            else
            {
                boxPertanyaan.Text = "SELAMAT!" + Environment.NewLine +
                    "Anda berhasil menjawab pertanyaan sebanyak " + jawabanBenar + " buah" +
                    Environment.NewLine + "silahkan tekan tombol [ <- ] kembali";
                boxPertanyaan.FontSize = 18;
            }
        }

        private void kalkulasiJawaban(bool status)
        {
            if (status)
                jawabanBenar += 1;
        }

        private int getIdPertanyaan()
        {
            ArrayList list = new ArrayList();
            Random rnd = new Random();
            int id = rnd.Next(1, 40);

            foreach (int value in list)
            {
                Debug.WriteLine(value + ", ");
                if (value == id)
                    getIdPertanyaan();
            }

            list.Add(id);
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

            foreach (var message in query)
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

            boxPertanyaan.Text = pertanyaan + Environment.NewLine + kalimah;
            textPertanyaan.Text = "Pertanyaan " + (jumlahPertanyaan + 1) + "/10";

            _a.Content = "A. " + pilA;
            _b.Content = "B. " + pilB;
            _c.Content = "C. " + pilC;
            _d.Content = "D. " + pilD;

            _a.IsEnabled = true;
            _b.IsEnabled = true;
            _c.IsEnabled = true;
            _d.IsEnabled = true;

            // kalkulasi jumlah pertanyaan
            jumlahPertanyaan += 1;
        }

        private void getResult(string _jawaban)
        {
            if (_jawaban == this.jawaban)
            {
                statusJawabanBenar.IsEnabled = true;
                kalkulasiJawaban(true);
            }
            else
                statusJawabanSalah.IsEnabled = true;

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
            //boxKalimah.Text = "";
            statusJawabanBenar.IsEnabled = false;
            statusJawabanSalah.IsEnabled = false;

            btnNext.IsEnabled = false;
            kalkulasiPertanyaan();
        }
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
