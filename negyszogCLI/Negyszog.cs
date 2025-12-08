using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace negyszogCLI
{
    internal class Negyszog
    {
        public Negyszog(int a, int b, int c, int d)
        {
            A = a;
            B = b;
            C = c;
            D = d;
        }

        public Negyszog(string sor)
        {
            string[] temp = sor.Split(' ');
            A = int.Parse(temp[0]);
            B = int.Parse(temp[1]);
            C = int.Parse(temp[2]);
            D = int.Parse(temp[3]);
        }

        public int A { get; private set; }
        public int B { get; private set; }
        public int C { get; private set; }
        public int D { get; private set; }
    }
}
