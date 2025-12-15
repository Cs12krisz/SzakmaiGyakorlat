using negyszogCLI;
using System.Collections.ObjectModel;
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
        static ObservableCollection<Negyszog> lista = new ObservableCollection<Negyszog>();
        public MainWindow()
        {
            InitializeComponent();
            Beolvas("negyszogek.csv");
            dtg_Data.ItemsSource = lista;
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int a = int.Parse(tbx_Aoldal.Text);
            int b = int.Parse(tbx_Boldal.Text);
            int c = int.Parse(tbx_Coldal.Text);
            int d = int.Parse(tbx_Doldal.Text);

            if (a <= b && b <= c && c <= d)
            {
                Negyszog ujnegyszog = new Negyszog(
                a,
                b,
                c,
                d
                );
                lista.Add(ujnegyszog);
                if (!ujnegyszog.SzerkeszthetoE())
                {
                    MessageBox.Show("Nem lehetséges 4 szakaszból négyszöget szerkeszteni.");
                }
            }
            else
            {
                MessageBox.Show("hibás sorrend");
                tbx_Aoldal.Clear();
                tbx_Boldal.Clear();
                tbx_Coldal.Clear();
                tbx_Doldal.Clear();
                tbx_Aoldal.Focus();
            }
            
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (dtg_Data.SelectedIndex > -1)
            {
                lista.RemoveAt(dtg_Data.SelectedIndex);
            }

            else
            {
                MessageBox.Show("Nincs kijelölt elem");
            }

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (dtg_Data.SelectedIndex > -1)
            {
                if(lista[dtg_Data.SelectedIndex].Modify(
                    int.Parse(tbx_Aoldal.Text),
                    int.Parse(tbx_Boldal.Text),
                    int.Parse(tbx_Coldal.Text),
                    int.Parse(tbx_Doldal.Text)

                ))
                {
                    MessageBox.Show("Sikeres módosítás");
                    dtg_Data.Items.Refresh();
                }
                else
                {
                    MessageBox.Show("Nincs jogosultsága a módosításhoz");
                }
            }

            else
            {
                MessageBox.Show("Nincs kijelölt elem");
            }
        }
    }
}