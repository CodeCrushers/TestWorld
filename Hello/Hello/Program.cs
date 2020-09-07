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
            Console.WriteLine("Hej, Casper was here");
            Console.WriteLine("LOL DUDE Same");
            Console.WriteLine("Gustav er en dejlig drengn");
            Console.WriteLine("1337 haX0r");
            Console.WriteLine("Gustav er en dejlig dreng");

            insertStrings();

            foreach (var v in list) {
                Console.WriteLine(v);
            }

            foreach (Person p in people) {
                string s = p.name;
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


        public void BetterMath()
        {
            Console.WriteLine("i'm better lol");
        }
    }
}
