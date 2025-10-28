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
            BudgetListe Udgifter = new List<BudgetListe>();
            InitializeComponent();
        }

        private void Vælg_Indtægt_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Vælg_udgift_Click(object sender, RoutedEventArgs e)
        {

        }
    }

    public class BudgetListe //ItemCollection
    {
        //public string Task { get; set; }
        List<Item> Udgifter;
        List<Item> Indtægter;

    }

    public class Item
    {
        public int pris;
        public string titel;
    }
}
