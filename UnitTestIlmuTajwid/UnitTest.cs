using UWPIlmuTajwid;
using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;
using Microsoft.VisualStudio.TestPlatform.UnitTestFramework.AppContainer;

namespace UnitTestIlmuTajwid
{
    [TestClass]
    public class UnitTest1
    {
        [UITestMethod]
        public void TestIdSamaDenganNol()
        {
            var latihan = new Latihan();

            // ambil id sebanyak 10 kali dari class Latihan.xaml.cs
            for (int i = 0; i < 10; i++)
                latihan.getIdPertanyaan3(40);

            // cek apakah id sama dengan nol
            for(int i=0; i<10; i++)
                Microsoft.VisualStudio.TestPlatform.UnitTestFramework.Assert.AreNotEqual(0, latihan.list[i]);
        }

        [UITestMethod]
        public void TestIdPernahTerambil()
        {
            var latihan = new Latihan();

            // ambil id sebanyak 10 kali dari class Latihan.xaml.cs
            for (int i = 0; i < 10; i++)
                latihan.getIdPertanyaan3(40);

            for(int i=0; i<10; i++)
            {
                for(int j=0; j<10; j++)
                {
                    // cek apakah ada id yang sama
                    if (i != j)
                        Microsoft.VisualStudio.TestPlatform.UnitTestFramework.Assert.AreNotEqual(latihan.list[i], latihan.list[j], "i=" + i + ", j=" + j);
                }
            }
        }
    }
}
