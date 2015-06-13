using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReverseString
{
    public partial class Form1 : Form
    {
        private String inputText;
        private String outputText;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            inputText = inputTextBox.Text;

            if (inputText != "")
            {
                outputText = reverseString(inputText);
                outputTextBox.Text = outputText;

                if (inputText.ToLower() == outputText.ToLower())
                {
                    palyndromeCheck.Text = "Yes";
                }
                else
                {
                    palyndromeCheck.Text = "No";
                }
            }
            else
            {
                outputTextBox.Text = "Please enter a valid text";
            }         
        }

        private String reverseString(String input)
        {
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        private void inputTextBox_keyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(sender, e);
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
