namespace negyszogCLI
{
    public class Program
    {
        static List<Negyszog> negyszogek = new List<Negyszog>();
        public static void Main(string[] args)
        {
            Beolvas("negyszogek.csv");
            foreach (var negyszog in negyszogek)
            {
                Console.WriteLine(negyszog);
            }

            Szerkeszthetok();

            Console.WriteLine("Paralelorammák:");
            var paralelok = negyszogek.Where(n => ParalelogrammaE(n));
            foreach (var paralelo in paralelok)
            {
                Console.WriteLine(paralelo);
            }

            Console.WriteLine("Rombuszok:");
            var rombuszok = negyszogek.Where(n => RombuszE(n));
            foreach (var rombusz in rombuszok)
            {
                Console.WriteLine(rombusz);
            }
        }

        static void Beolvas(string fajl) 
        {
            using (StreamReader sr = new StreamReader(fajl))
            {
                while (!sr.EndOfStream)
                {
                    string sor = sr.ReadLine();
                    Negyszog negyszog = new Negyszog(sor);
                    negyszogek.Add(negyszog);
                }
                
            }
        }

        public static bool ParalelogrammaE(Negyszog negyszog)
        {
            if (negyszog.A == negyszog.C && negyszog.B == negyszog.D)
            {
                return true;
            }

            return false;
        }

        public static bool RombuszE(Negyszog negyszog)
        {
            if (negyszog.A == negyszog.B && negyszog.A == negyszog.C && negyszog.A == negyszog.D)
            {
                return true;
            }

            return false;
        }

        public static void Szerkeszthetok()
        {
            var szerkeszthetoek = negyszogek.Where(n => n.SzerkeszthetoE());
            Console.WriteLine();
            Console.WriteLine("Szerkeszthető négyszögek:");
            foreach (var negyszog in szerkeszthetoek)
            {
                Console.WriteLine(negyszog);
            }
        }

    }
}
