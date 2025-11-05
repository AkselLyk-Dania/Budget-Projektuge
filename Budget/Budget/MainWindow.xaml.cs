using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
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
using static System.Net.Mime.MediaTypeNames;

namespace Budget
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ItemCollection udgifter = new ItemCollection();
        ItemCollection indtaegter = new ItemCollection();

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

        private void TilføjTilIndtaegter(object sender, RoutedEventArgs e)
        {
            string stringInputNavn = InputNavn.GetLineText(0);
            string stringInputKroner = InputKroner.GetLineText(0);

            int integerInputKroner;
            bool kronerErTal = int.TryParse(stringInputKroner, out integerInputKroner);

            if (!string.IsNullOrEmpty(stringInputKroner) && !string.IsNullOrEmpty(stringInputNavn) && kronerErTal)
            {
                Item item = new Item(stringInputNavn, integerInputKroner);
                indtaegter.liste.Add(item);
                ListBoxIndtaegter.Items.Add(stringInputNavn + ":   +" + stringInputKroner + " kr");

                InputNavn.Clear();
                InputKroner.Clear();
            }
        }

        private void TilføjTilUdgifter(object sender, RoutedEventArgs e)
        {
            string stringInputNavn = InputNavn.GetLineText(0);
            string stringInputKroner = InputKroner.GetLineText(0);

            int integerInputKroner;
            bool kronerErTal = int.TryParse(stringInputKroner, out integerInputKroner);

            if (!string.IsNullOrEmpty(stringInputKroner) && !string.IsNullOrEmpty(stringInputNavn) && kronerErTal)
            {
                Item item = new Item(stringInputNavn, integerInputKroner);
                udgifter.liste.Add(item);
                ListBoxUdgifter.Items.Add(stringInputNavn + ":   -" + stringInputKroner + " kr");

                InputNavn.Clear();
                InputKroner.Clear();
            }
        }

        private void Udregn(object sender, RoutedEventArgs e)
        {
            int indtaegterSum = indtaegter.liste.Sum(Item => Item.kroner);
            int udgifterSum = udgifter.liste.Sum(Item => Item.kroner);

            int sumAfBegge = indtaegterSum - udgifterSum;
            string sumText = Convert.ToString(sumAfBegge);

            SumBox.Clear();

            SumBox.Text = sumText + " kr";
        }

        private void ButtonReset_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Er du sikker på at du vil slette alt?", "Reset", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                ListBoxIndtaegter.Items.Clear();
                ListBoxUdgifter.Items.Clear();
                SumBox.Clear();

                indtaegter.liste.Clear();
                udgifter.liste.Clear();
            }
        }

        private void ButtonUndoIndtaegter_Click(object sender, RoutedEventArgs e)
        {
            if (indtaegter.liste.Count > 0)
            {
                indtaegter.liste.RemoveAt(indtaegter.liste.Count - 1);
                ListBoxIndtaegter.Items.RemoveAt(ListBoxIndtaegter.Items.Count - 1);
            }
        }

        private void ButtonUndoUdgifter_Click(object sender, RoutedEventArgs e)
        {
            if (udgifter.liste.Count > 0)
            {
                udgifter.liste.RemoveAt(udgifter.liste.Count - 1);
                ListBoxUdgifter.Items.RemoveAt(ListBoxUdgifter.Items.Count - 1);
            }
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

        private void SumBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}