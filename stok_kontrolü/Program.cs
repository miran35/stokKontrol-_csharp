using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stok_kontrolü
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ürün stok1 = new ürün();
            int stok = 100;

            while (true)
            {
                Console.WriteLine("Ürün ile ilgli öğrenmek istediğiniz konuyu seçin");
                Console.WriteLine("1- Ürün stok miktarı");
                Console.WriteLine("2-Ürünü sat");
                Console.WriteLine("3-Ürün ekle");
                Console.WriteLine("4-çıkış ");
                Console.WriteLine("Bir seçim yapınız");
                int secim = Convert.ToInt32(Console.ReadLine());
            
                switch (secim)
                {
                    case 1:
                        Console.WriteLine("Ürün stoğu : " + stok);
                        break;
                    case 2:
                        Console.Write("Satmak istediğini ürün adedini giriniz : ");
                        int sat = Convert.ToInt32(Console.ReadLine());
                        if (sat < stok)
                        {
                            stok -= sat;
                            Console.WriteLine("Ürün satıldı ");
                        }
                        else
                        {
                            Console.Write("Stok adedinden fazla ürün satamazsınız");
                        }

                            break;
                    case 3:
                        Console.WriteLine("Eklemek istediğiniz ürün adedini giriniz : ");
                        int ekle = int.Parse(Console.ReadLine());
                        stok += ekle;
                        break;
                    case 4:
                        Console.WriteLine("Çıkış yapıldı :");
                        break;


                }
            }

        }
    }
}
