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

namespace U2IanMarkhamTXTMSG
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btntranslate_Click(object sender, RoutedEventArgs e)
        {
            string input = txtinput.Text;
            if (input == "CU")
            {
                MessageBox.Show("see You");
            }
            else if (input == ":-)")
            {
                MessageBox.Show("I'm happy");
            }
            else if (input == ":-(")
            {
                MessageBox.Show("I'm unhappy");
            }
            else if (input == ";-)")
            {
                MessageBox.Show("wink");
            }
            else if (input == ":-P")
            {
                MessageBox.Show("stick out my tongue");
            }
            else if (input == "(˜.˜)")
            {
                MessageBox.Show("sleepy");
            }
            else if (input == "TA")
            {
                MessageBox.Show("totally awesome");
            }
            else if (input == "CCC")
            {
                MessageBox.Show("Canadian Computing Competition");
            }
            else if (input == "CUZ")
            {
                MessageBox.Show("because");
            }
            else if (input == "TY")
            {
                MessageBox.Show("thank-you");
            }
            else if (input == "YW")
            {
                MessageBox.Show("you're welcome");
            }
            else if (input == "TTYL")
            {
                MessageBox.Show("talk to you later");
            }
            
        }
    }
}
