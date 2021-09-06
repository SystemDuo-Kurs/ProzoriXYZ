using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ProzoriXYZ
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Osoba o = new();
            DataContext = o;

            List<Osoba> osobe = new();
            osobe.Add(new Osoba { Ime = "Pera", Prezime = "Peric" });
            osobe.Add(new Osoba { Ime = "Neko", Prezime = "Nekic" });
            osobe.Add(new Osoba { Ime = "Asd", Prezime = "Zklj" });
            dg.ItemsSource = osobe;

            string neki = "asd";
            string asd = null;
            int br = 45;
            int? brrr = null;
        }
    }
}
