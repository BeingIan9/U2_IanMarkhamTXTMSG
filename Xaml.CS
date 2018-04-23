/*Ian Markham
 * March 29, 2018
 * Translates shortform text into full words
 * U2IanMarkhamTXTMSG
 */
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
    public static class Globals
    {
        public static string replacedText;
        public static string[] splitText = new string[50];
        public static int lines;
        public static int looptimes = 2;
    }
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btntranslate_Click(object sender, RoutedEventArgs e)
        {
            Globals.replacedText = txtinput.Text.Replace("\r", "");
            Globals.splitText = Globals.replacedText.Split('\n');
            Globals.lines = Globals.splitText.Length;
            Console.WriteLine(Globals.lines);
            Globals.looptimes = Globals.lines;
            for (int i = 0; i < Globals.looptimes; i++)
            {

                //Seperates output text, acts as "enter" key.
               

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
}
