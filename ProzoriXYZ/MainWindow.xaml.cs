using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        private ObservableCollection<Osoba> osobe = new();
        private bool dodavanje = true;
        
        public MainWindow()
        {
            InitializeComponent();
 
            DataContext = new Osoba();

            dg.ItemsSource = osobe;
        }

		private void DodajOsobu(object sender, RoutedEventArgs e)
		{
            if (dodavanje)
                osobe.Add(DataContext as Osoba);
            else
			{
                dodavanje = true;
                dugmence.Content = "Dodaj";
			}
            DataContext = new Osoba();
		}

		private void dg_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
            if (e.AddedItems.Count > 0)
            {
                dodavanje = false;
                dugmence.Content = "OK";
                DataContext = e.AddedItems[0];
            } else
			{
                dodavanje = true;
                dugmence.Content = "Dodaj";
			}
		}
	}
}
