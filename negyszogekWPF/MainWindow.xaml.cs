using negyszogCLI;
using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace negyszogekWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static List<Negyszog> lista = new List<Negyszog>();
        public MainWindow()
        {
            InitializeComponent();
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
                    lista.Add(negyszog);
                }

            }
        }
    }
}