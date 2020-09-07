using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello {
    class Program {

        private static List<string> list = new List<string>();

        static void Main(string[] args) {
            Console.WriteLine("Hej, Casper was here");
            Console.WriteLine("LOL DUDE Same");
<<<<<<< Updated upstream
            Console.WriteLine("Gustav er en dejlig drengn");
            Console.WriteLine("1337 haX0r");
=======
            Console.WriteLine("Gustav er en dejlig dreng");
            
            foreach(var v in list) {
                Console.WriteLine(v);
            }

        }

        private void insertStrings() {
            list.Add("Casper was here");
>>>>>>> Stashed changes
        }
    }
}
