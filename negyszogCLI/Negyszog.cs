using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace negyszogCLI
{
    public class Negyszog
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

        public bool SzerkeszthetoE()
        {
            int[] oldalak = {A, B, C, D};
            int legnagyobb = oldalak[0];
            for (int i = 1; i < oldalak.Length; i++)
            {
                if (oldalak[i] > legnagyobb)
                {
                    legnagyobb = oldalak[i];
                }
            }

            int osszeg = oldalak.Sum() - legnagyobb;
            if (legnagyobb < osszeg)
            {
                return true;
            }

            return false;
        }

        public bool Modify(int ujA, int ujB, int ujC, int ujD)
        {
            if(Environment.UserName == "CsKrisz")
            {
                A = ujA;
                B = ujB;
                C = ujC;
                D = ujD;
                return true;
            }

            return false;
        }

        public override string? ToString()
        {
            return $"\ta: {A} b: {B} c: {C} d: {D}";
        }
    }
}
