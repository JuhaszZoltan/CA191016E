using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace CA191016E
{
    class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            //ajánlott "irodalom": http://info.nytta.hu/temak/prog/Programozasi_tetelek.pdf

            #region másolás tétele
            ////IN: sorozat
            ////OUT: (ua.) sorozat

            //bool[] bajt = { false, true, true, false, false, false, false, true };
            //bool[] masolat = new bool[bajt.Length];

            //for (int i = 0; i < bajt.Length; i++)
            //{
            //    masolat[i] = bajt[i];
            //}

            ////ez már nem másolás, csak IT fétis
            //int dec = 0;
            //for (int i = 0; i < masolat.Length; i++)
            //{
            //    if (masolat[i])
            //    {
            //        dec += (int)Math.Pow(2, 7 - i);
            //    }
            //}
            //Console.WriteLine((char)dec);

            #endregion
            #region sorozatszámítás télele(i)
            ////IN: sorozat
            ////OUT: sorozathoz rendelt érték

            ////összegzés
            //int[] t = { 11, 13, 25, 32, 42 };
            //int sum = 0;
            //for (int i = 0; i < t.Length; i++)
            //{
            //    sum += t[i];
            //}
            //Console.WriteLine($"elemek összege: {sum}");

            ////átlagszámítás (gyakori, de NEM tétel):
            //Console.WriteLine($"elemek átlaga: {sum / (float)t.Length}");

            ////összefűzés
            //string[] t2 = { "hétfőn", " ", "a", " ", "fű", " ", "se", " ", "nő" };
            //string mondat = "";
            //for (int i = 0; i < t2.Length; i++)
            //{
            //    mondat += t2[i];
            //}
            //Console.WriteLine(mondat);

            ////szorzatképzés
            //double[] t3 = { 1.5, 1.03, 1.2 };
            //double tet = 240;
            //for (int i = 0; i < t3.Length; i++)
            //{
            //    tet *= t3[i];
            //}
            //Console.WriteLine($"nyeremény: {tet}");
            #endregion
            #region megszámlálás tétele
            ////IN: sorozat
            ////OUT: szám

            //char[] betuk = { 'a', 'x', 'g', 'e', 'h', 'e', 't', 'h' };
            //string validator = "aeiuo";
            //int db = 0;

            //for (int i = 0; i < betuk.Length; i++)
            //{
            //    if (validator.Contains(betuk[i]))
            //    {
            //        db++;
            //    }
            //}
            //Console.WriteLine($"magánhangzók száma: {db}");

            //int[] t = { 11, 13, 25, 32, 42 };
            //int db2 = 0;
            //for (int i = 0; i < t.Length; i++)
            //{
            //    if (t[i] % 2 == 0) db2++;
            //}
            //Console.WriteLine($"páros elemek száma: {db2}");
            #endregion
            #region szélsőérték tételek
            ////min és max value, min és max index;
            ////IN: sorozat
            ////OUT: sorozat egy eleme VAGY egy indexe

            //float[] t = { 12.4F, 132.54F, 0.02F, 100F, 5.54F, 11.111F, 69.654F };

            ////max:

            //int maxi = 0;
            ////nem 0-ánál indul, hanem 1-nél!!
            //for (int i = 1; i < t.Length; i++)
            //{
            //    if (t[i] > t[maxi]) maxi = i;
            //}
            //Console.WriteLine($"maximum index: {maxi}");
            //Console.WriteLine($"maximum hely: {maxi + 1}");
            //Console.WriteLine($"maximum value: {t[maxi]}");

            //int mini = 0;
            //for (int i = 1; i < t.Length; i++)
            //{
            //    if (t[i] < t[mini]) mini = i;
            //}
            //Console.WriteLine($"minimum index: {mini}");
            //Console.WriteLine($"minimum hely: {mini + 1}");
            //Console.WriteLine($"minimum value: {t[mini]}");


            ////max value 'tétel': nem ezt célszerű megtanulni
            //float max = t[0];
            //for (int i = 1; i < t.Length; i++)
            //{
            //    if (max < t[i]) max = t[i];
            //}
            //Console.WriteLine($"MAXIMUM bénán: {max}");
            ////az algoritmus "jó", de a helyet ebből már nem tudod kinyerni utólag

            #endregion
            #region kiválogatás tétele
            //IN: egy sorozat
            //OUT: egy másik sorozat

            string[] nevek = { "Ildikó", "Andris", "Béla", "Abigél", "András", "József" };
            string[] aBetusNevek = new string[nevek.Length];

            for (int i = 0; i < aBetusNevek.Length; i++)
            {
                //aBetusNevek[i] = "papucs";
            }

            
            int si = 0;
            for (int i = 0; i < nevek.Length; i++)
            {
                if(nevek[i].StartsWith("A")) //nevek[i][0] == 'A'
                {
                    aBetusNevek[si] = nevek[i];
                    si++;
                }
            }

            for (int i = 0; i < si; i++)
            {
                Console.Write($"{aBetusNevek[i]} ");
            }

            Console.WriteLine("\n---------------");

            Array.Resize(ref aBetusNevek, si);

            for (int i = 0; i < aBetusNevek.Length; i++)
            {
                Console.Write(aBetusNevek[i] + " ");
            }

            #endregion
            Console.ReadKey();
        }
    }
}
