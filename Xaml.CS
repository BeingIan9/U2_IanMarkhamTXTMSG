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
    //Holds values that are later called.
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

        //Triggers when user clicks the run button
        public void Click_Run(Object sender, RoutedEventArgs e)
        {
            Globals.replacedText = txtinput.Text.Replace("\r", "");
            Globals.splitText = Globals.replacedText.Split('\n');
            Globals.lines = Globals.splitText.Length;
            Console.WriteLine(Globals.lines);
            Globals.looptimes = Globals.lines;
            txtoutput.Text = "";

            //Reads through all lines of text entered and matches it to the shortforms.
            for (int i = 0; i < Globals.looptimes; i++)
            {

                //Seperates output text, acts as "enter" key.
                if (txtinput.Text == "")
                {
                }
                else
                {
                    txtoutput.Text = txtoutput.Text + "\n";
                }


                //Checks user input and whether or not it matches stated shortforms.
                if (Globals.splitText[i] == "LOL")
                {
                    //Replaces the shortform with the normal form, then sets it to the output text.
                    txtoutput.Text = txtoutput.Text + Globals.splitText[i].Replace("LOL", "Laugh out loud.");
                }
                else if (Globals.splitText[i] == "CU")
                {
                    txtoutput.Text = txtoutput.Text + Globals.splitText[i].Replace("CU", "See you.");
                }
                else if (Globals.splitText[i] == ":-)")
                {
                    txtoutput.Text = txtoutput.Text + Globals.splitText[i].Replace(":-)", "I'm happy.");
                }
                else if (Globals.splitText[i] == ":-(")
                {
                    txtoutput.Text = txtoutput.Text + Globals.splitText[i].Replace(":-(", "I'm sad.");
                }
                else if (Globals.splitText[i] == ";-)")
                {
                    txtoutput.Text = txtoutput.Text + Globals.splitText[i].Replace(";-)", "Wink.");
                }
                else if (Globals.splitText[i] == ":-P")
                {
                    txtoutput.Text = txtoutput.Text + Globals.splitText[i].Replace(":-P", "Stick out tongue.");
                }
                else if (Globals.splitText[i] == "(~.~)")
                {
                    txtoutput.Text = txtoutput.Text + Globals.splitText[i].Replace("(~.~)", "I'm sleepy.");
                }
                else if (Globals.splitText[i] == "TA")
                {
                    txtoutput.Text = txtoutput.Text + Globals.splitText[i].Replace("TA", "Totally awesome.");
                }
                else if (Globals.splitText[i] == "CCC")
                {
                    txtoutput.Text = txtoutput.Text + Globals.splitText[i].Replace("CCC", "Canadian Computing Competition.");
                }
                else if (Globals.splitText[i] == "CUZ")
                {
                    txtoutput.Text = txtoutput.Text + Globals.splitText[i].Replace("CUZ", "Because.");
                }
                else if (Globals.splitText[i] == "TY")
                {
                    txtoutput.Text = txtoutput.Text + Globals.splitText[i].Replace("TY", "Thank-you.");
                }
                else if (Globals.splitText[i] == "YW")
                {
                    txtoutput.Text = txtoutput.Text + Globals.splitText[i].Replace("YW", "You're welcome.");
                }
                else if (Globals.splitText[i] == "TTYL")
                {
                    txtoutput.Text = txtoutput.Text + Globals.splitText[i].Replace("TTYL", "Talk to you later.");
                    //Tells that program is closing.
                    MessageBox.Show("Program closing.");
                    //Program is closed
                    Environment.Exit(0);
                }
                else
                {
                    txtoutput.Text = txtoutput.Text + Globals.splitText[i];
                }
            }
        }
    }
}
