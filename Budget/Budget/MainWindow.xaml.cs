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

namespace Budget
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ItemCollection udgifter = new ItemCollection();
        ItemCollection indtægter = new ItemCollection();

        public MainWindow()
        {
            InitializeComponent();
            
        }

        class Item
        {
            public int kroner;
            public string navn;

            public Item(string navn, int kroner)
            {
                this.navn = navn;
                this.kroner = kroner;
            }
        }

        class ItemCollection
        {
            public List<Item> liste = new List<Item>();
        }


        private void TilføjTilIndtægter(object sender, RoutedEventArgs e)
        {
            string stringInputNavn = InputNavn.GetLineText(0);
            string stringInputKroner = InputKroner.GetLineText(0);

            int integerInputKroner = Convert.ToInt32(stringInputKroner);
            Item hej = new Item(stringInputNavn, integerInputKroner);
            indtægter.liste.Add(hej);

            InputNavn.Clear();
        }

        private void TilføjTilUdgifter(object sender, RoutedEventArgs e)
        {

        }

        private void Udregn(object sender, RoutedEventArgs e)
        {

        }

        public void KronerInput(object sender, TextCompositionEventArgs e)
        {

        }

        public void NavnInput(object sender, TextCompositionEventArgs e)
        {

        }

        private void ListBoxIndtægter(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ListBoxUdgifter(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
