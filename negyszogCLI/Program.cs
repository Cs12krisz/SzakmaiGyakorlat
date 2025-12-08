namespace negyszogCLI
{
    internal class Program
    {
        static List<Negyszog> negyszogek = new List<Negyszog>();
        static void Main(string[] args)
        {
            Beolvas("negyszogek.csv");
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
    }
}
