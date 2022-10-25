using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            >| 48 / 6 / 4
            >| 24 / 3 * 2
            >| 2^2 + 5 - 1 + 4
            >| (7+4) * 2 - 1 + 8 / 2
            >| (5-1) * 2 - 1 + 7^2 / 2
            */

            Console.WriteLine(48 / 6 / 4);                              // 2
            Console.WriteLine(24 / 3 * 2);                              // 16
            Console.WriteLine(Math.Pow(2,2) + 5 - 1 + 4);               // 12
            Console.WriteLine((7 + 4) * 2 - 1 + 8 / 2);                 // 25
            Console.WriteLine((5 - 1) * 2 - 1 + (Math.Pow(7,2)) / 2);   // 31.5

            Console.WriteLine("----------------------------------------------------------------------");

            /*
            x = 20 , y = 13, z = 42
            >| 23 == 55 && 76 > 45 && 5 < 12
            >| 23 >= 23 && 45 != 18
            >| x > y && z == y && z < x
            >| z > x && y < x
            >| x != z || y <= z
            */

            int x = 20, y = 13, z = 42;

            if (23 == 55 && 76 > 45 && 5 < 12)
            {
                Console.WriteLine("TRUE");
            }
            else
            {
                Console.WriteLine("FALSE");
            }

            if (23 >= 23 && 45 != 18)
            {
                Console.WriteLine("TRUE");
            }
            else
            {
                Console.WriteLine("FALSE");
            }

            if (x > y && z == y && z < x)
            {
                Console.WriteLine("TRUE");
            }
            else
            {
                Console.WriteLine("FALSE");
            }

            if (z > x && y < x)
            {
                Console.WriteLine("TRUE");
            }
            else
            {
                Console.WriteLine("FALSE");
            }

            if (x != z || y <= z)
            {
                Console.WriteLine("TRUE");
            }
            else
            {
                Console.WriteLine("FALSE");
            }

            Console.WriteLine("----------------------------------------------------------------------");

            Console.Write("Birinci sayıyı giriniz : ");
            int birinciSayi = Convert.ToInt32(Console.ReadLine());

            Console.Write("İkinci sayıyı giriniz : ");
            int ikinciSayi = Convert.ToInt32(Console.ReadLine());

            if (birinciSayi % ikinciSayi == 0)
            {
                Console.WriteLine("Birinci sayı ikinci sayıya tam bölünüyor.");
            }
            else
            {
                Console.WriteLine("Birinci sayı ikinci sayıya tam bölünmüyor.");
            }

            Console.WriteLine("----------------------------------------------------------------------");

            /*
             gg.aa.yyyy değerlerini girip aa yı ay olarak yazdırınız.
            */

            Console.Write("Gün, ay, yıl formatında bir değer giriniz(28.05.2017) : ");
            String tarih = Convert.ToString(Console.ReadLine());

            int veri = Convert.ToInt32(tarih.Substring(3, 2));

            while (true) {
                if (veri <= 12)
                {
                    if (veri == 01)
                    {
                        Console.WriteLine("OCAK");

                        break;
                    }
                    else if (veri == 02)
                    {
                        Console.WriteLine("ŞUBAT");

                        break;
                    }
                    else if (veri == 03)
                    {
                        Console.WriteLine("MART");

                        break;
                    }
                    else if (veri == 04)
                    {
                        Console.WriteLine("NİSAN");

                        break;
                    }
                    else if (veri == 05)
                    {
                        Console.WriteLine("MAYIS");

                        break;
                    }
                    else if (veri == 06)
                    {
                        Console.WriteLine("HAZİRAN");

                        break;
                    }
                    else if (veri == 07)
                    {
                        Console.WriteLine("TEMMUZ");

                        break;
                    }
                    else if (veri == 08)
                    {
                        Console.WriteLine("AĞUSTOS");

                        break;
                    }
                    else if (veri == 09)
                    {
                        Console.WriteLine("EYLÜL");

                        break;
                    }
                    else if (veri == 10)
                    {
                        Console.WriteLine("EKİM");

                        break;
                    }
                    else if (veri == 11)
                    {
                        Console.WriteLine("KASIM");

                        break;
                    }
                    else if (veri == 12)
                    {
                        Console.WriteLine("ARALIK");

                        break;
                    }
                    else
                    {
                        Console.WriteLine("Girdiğiniz değer herhangi bir ayı temsil etmiyor.");
                    }
                }

            
            }

            Console.WriteLine("----------------------------------------------------------------------");

            /*
            İkinci dereceden denklem köklerini bulan program.
            */

            // x2 + 2x + 2
            // a2x + bx + c
            // delta = b2 - 4 . a . c
            // kök = -b - kök delta / 2a ve -b + kök delta / 2a

            Console.WriteLine("DENKLEM FORMATI : ax2 + bx + c şeklindedir.");
            Console.WriteLine("********************************************");

            Console.Write("Lütfen 'a' değerini giriniz : ");
            float a = Convert.ToSingle(Console.ReadLine());

            Console.Write("Lütfen 'b' değerini giriniz : ");
            float b = Convert.ToSingle(Console.ReadLine());

            Console.Write("Lütfen 'c' değerini giriniz : ");
            float c = Convert.ToSingle(Console.ReadLine());

            float delta = (float)Math.Pow(b,2) - (4 * a * c);

            float birinciKok = ((-b) - (float)Math.Sqrt(delta)) / (2 * a);

            float ikinciKok = ((-b) + (float)Math.Sqrt(delta)) / (2 * a);

            if (delta < 0)
            {
                Console.WriteLine("Kökler reel sayı değildir.");
                // Delta sıfırdan küçük ve kökler reel değil

            }
            else if (delta == 0)
            {
                Console.WriteLine("Kökler eşit : {0}" , birinciKok);
                // Delta sıfıra eşit iki kök reel

            }
            else
            {
                Console.WriteLine("Birinci Kök : " + birinciKok);

                Console.WriteLine("İkinci Kök : " + ikinciKok);

                // Delta sıfırdan büyük, x1 ve x2 olmak üzere iki kök var

            }

            Console.WriteLine("----------------------------------------------------------------------");

            // Bir radyan = 57,2958 derece.

            int d, r, g;
            double pi = 3.14;

            Console.Write("Açıyı giriniz = ");
            d = Convert.ToInt32(Console.ReadLine());

            r = Convert.ToInt32(d * pi / 180);
            g = d * 200 / 180;

            Console.WriteLine("Radyan = " + r);
            Console.WriteLine("Grad = " + g);
            Console.ReadKey();
        }
    }
}
