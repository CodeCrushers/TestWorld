using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello {
    class Program {
        static void Main(string[] args) {
            int tal = 10;
            int[] flereTal = new int[10];
            while (tal > 0)
            {
                tal--;
                flereTal[tal] = tal;
                Console.WriteLine(tal);
            }
        }
    }
}
