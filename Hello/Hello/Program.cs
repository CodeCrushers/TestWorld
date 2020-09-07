using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello {
    class Program {

        private static List<string> list = new List<string>();

        static void Main(string[] args) {
            int tal = 10;
            int[] flereTal = new int[10];
            while (tal > 0)
            {
                tal--;
                flereTal[tal] = tal;
                Console.WriteLine(tal);
            }
            Console.WriteLine("Hej, Casper was here");
            Console.WriteLine("LOL DUDE Same");
            Console.WriteLine("Gustav er en dejlig drengn");
            Console.WriteLine("1337 haX0r");
            Console.WriteLine("Gustav er en dejlig dreng");

            insertStrings();

            foreach (var v in list) {
                Console.WriteLine(v);
            }

        }

        private static void insertStrings() {
            list.Add("Casper was here");
        }

        private void Math()
        {
            Console.WriteLine("12345678");
            Console.ReadLine();
        }
    }
}
