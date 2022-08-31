using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uzaktan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] gunler = { "Neden kaçtın neden?",
          "Mesut olurduk belki",
          "Korkuttum mu seni?",
          "Benden ne zarar gelir ki?",
          "",
          "Seni seyretmem, gezmem lazımdı",
          "Bu yolun sonunu bulmam lazımdı",
          "Seni tanımam, bilmem lazımdı",
          "Bu hikâyeye bir son lazımdı",
          "",
          "Öyle uzaktan uzaktan hiç konuşmadan nasıl da bağladın beni?",
          "Hani bi' geldin bi' kayboldun, esrarlı mağrurdun, aklıma sardım seni",
          "Öyle uzaktan uzaktan hiç konuşmadan nasıl da bağladın beni?",
          "Hani bi' geldin bi' kayboldun, esrarlı mağrurdun, aklıma sardım seni",
          "",
          "Nedir sırrın ne senin?",
          "Çekip bıraktım, sen kimsin?",
          "Toz ol, derdim bitsin",
          "Aklım aşkını yensin",
          "",
          "Seni seyretmem, gezmem lazımdı",
          "Bu yolun sonunu bulmam lazımdı",
          "Seni tanımam, bilmem lazımdı",
          "Dudaklarıma bir veda lazımdı",
          "",
          "Öyle uzaktan uzaktan hiç konuşmadan nasıl da bağladın beni?",
          "Hani bi' geldin bi' kayboldun, esrarlı mağrurdun, aklıma sardım seni",
          "Öyle uzaktan uzaktan hiç konuşmadan nasıl da bağladın beni?",
          "Hani bi' geldin bi' kayboldun, esrarlı mağrurdun, aklıma sardım seni",
          "",
          "Aklıma sardım seni, aklıma sardım seni" };
            for (int i = 0; i < gunler.Length; i++)
            {
                Console.WriteLine(gunler[i]);
                System.Threading.Thread.Sleep(1000);

            }         
            Console.ReadKey();
        }
    }
}
