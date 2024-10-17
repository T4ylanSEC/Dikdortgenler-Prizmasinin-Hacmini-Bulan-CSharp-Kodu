using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dikdortgenler_Prizmasinin_Hacmini_Bulan_CSharp_Kodu
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Dikdörtgenler prizmasının kenarlarını Uzun Kenar, Kısa Kenar, Yükseklik diyelim.
            //Konsolda sayıları direkt yanına yazmasını istediğim için WriteLine yerine Write yazdım.
            //Kenarları tam sayı olarak düşündüğüm için double yerine int değişkenini kullandım.

            Console.Write("Uzun Kenarı Girin: ");
            int UzunKenar = Convert.ToInt32(Console.ReadLine());

            Console.Write("Kısa Kenarı Girin: ");
            int KısaKenar = Convert.ToInt32(Console.ReadLine());

            Console.Write("Yüksekliği Girin: ");
            int Yükseklik = Convert.ToInt32(Console.ReadLine());

            int Hacim = UzunKenar * KısaKenar * Yükseklik;

            Console.WriteLine("Dikdörtgenler Prizmasının Hacmi: " + Hacim);

            Console.ReadKey();

        }
    }
}