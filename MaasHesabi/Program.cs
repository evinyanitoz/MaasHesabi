using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaasHesabi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("MAAŞ GÜNÜNÜZ NEDİR?");
           int gun=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("MAAŞIN YATACAĞI AY NEDİR?");
            int ay = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("MAAŞIN YATACAĞI yıl NEDİR?");
            int yil = Convert.ToInt32(Console.ReadLine());

            DateTime olusanTarih = new DateTime(yil, ay, gun);

            if (olusanTarih.DayOfWeek == DayOfWeek.Sunday)
            {
                var pazar = olusanTarih.Day - 2;
                DateTime Dtpazar = new DateTime(yil, ay, pazar);
            }

            else if (olusanTarih.DayOfWeek == DayOfWeek.Saturday)
            {
                var cumartesi = olusanTarih.Day - 1;
                DateTime Dtcumartesi = new DateTime(yil, ay, cumartesi);
                Console.WriteLine($"MAAŞININ YATACAĞI TARİH {Dtcumartesi}");
            }
            else Console.WriteLine($"MAAŞININ YATACAĞI TARİH {olusanTarih}");
            Console.ReadLine();
        }
            

           
        }
    }

