using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello {
    class Program {

        private static List<string> list = new List<string>();
        private static List<Person> people = new List<Person>();

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
            BetterMath();
            Console.ReadLine();
            insertStrings();

            foreach (var v in list) {
                Console.WriteLine(v);
            }
            Math();

            foreach (Person p in people) {
                string s = p.name;
            }

        }

        private static void insertStrings() {
            list.Add("Casper was here");
        }

        private static void Math()
        {
            Console.WriteLine("12345678");
            Console.ReadLine();
        }


        private static void BetterMath()
        {
            Console.WriteLine("i'm better lol");
            Console.ReadLine();
        }
    }
}
