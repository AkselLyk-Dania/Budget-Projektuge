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
        public MainWindow()
        {
            InitializeComponent();
            ItemCollection udgifter = new ItemCollection();
            ItemCollection indtægter = new ItemCollection();
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
            public List<Item> liste;
        }

        private void T(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_2(object sender, TextChangedEventArgs e)
        {

        }

        private void TilføjTilIndtægter(object sender, RoutedEventArgs e)
        {

        }

        private void TilføjTilUdgifter(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

        }
    }
}
