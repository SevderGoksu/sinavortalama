using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VizeFinalOrt
{
    class Program
    {
        static void Main(string[] args)
        {
            int exam1;
            int exam2;
            float result;            
            Console.WriteLine("Vize notunuzu giriniz");
            exam1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Final notunuzu giriniz");
            exam2 = Convert.ToInt32(Console.ReadLine());
            result = Convert.ToInt32((exam1 * 0.4f) + (exam2 * 0.6f));            
            Console.WriteLine("Sınav sonucu: {0}",Sonuc(result));
            Console.Read();           
        }
        public static string Sonuc(float result)
        {
            if (result<=50)
            {
                return "Kaldın";
            }
            return "Geçtin";

        }
    }
}
