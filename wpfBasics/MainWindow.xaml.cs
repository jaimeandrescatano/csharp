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

namespace wpfBasics
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            List<string> mylist1 = new List<string>(new string[] { "element1", "element2", "element3" });
            List<string> mylist2 = new List<string>(new string[] { "perro", "gato", "pollo" });

            myListBox1.ItemsSource = mylist1;
            myListBox2.ItemsSource = mylist2;
        }
    }
}
