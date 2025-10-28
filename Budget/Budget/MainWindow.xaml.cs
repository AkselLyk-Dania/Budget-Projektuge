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

            ListBoxIndtaegter.ItemsSource = indtægter.liste;
            ListBoxUdgifter.ItemsSource = udgifter.liste;
        }

        class Item
        {
            public int kroner;
            public string navn;

            public string Newtask { get; set; }
            public bool IsCompleted { get; set; }

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

            ListBoxIndtaegter.ItemsSource = null;
            ListBoxIndtaegter.ItemsSource = indtægter.liste;

            InputNavn.Clear();
            InputKroner.Clear();
        }

        private void TilføjTilUdgifter(object sender, RoutedEventArgs e)
        {
            string stringInputNavn = InputNavn.GetLineText(0);
            string stringInputKroner = InputKroner.GetLineText(0);

            int integerInputKroner = Convert.ToInt32(stringInputKroner);
            Item hej = new Item(stringInputNavn, integerInputKroner);
            udgifter.liste.Add(hej);

            InputNavn.Clear();
            InputKroner.Clear();
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


        private void SelectionChanged_Indtaegter(object sender, SelectionChangedEventArgs e)
        {

        }

        private void SelectionChanged_Udgifter(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
