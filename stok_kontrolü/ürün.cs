using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stok_kontrolü
{
    public class ürün
    {
        private int stok;
        public int ürün1 
        {
            get
            {
                return stok;
            }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("stok miktarınınız");
                }
                else
                {
                    stok = value;
                }
            }
        }
    }
}
