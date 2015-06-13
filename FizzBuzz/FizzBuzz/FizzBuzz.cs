using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FizzBuzz
{
    public partial class FizzBuzz : Form
    {
        public FizzBuzz()
        {
            InitializeComponent();
            count();
        }

        private async void count()
        {
            for (int i = 1; i < 101; i++)
            {
                if (i % 3 == 0 && i % 5 == 0) 
                {
                    richTextBox1.AppendText(i + ": FizzBuzz\r\n");
                    await Task.Delay(1000);
                }
                else if (i % 3 == 0)
                {
                    richTextBox1.AppendText(i +": Fizz\r\n");
                    await Task.Delay(1000);
                }
                else if (i % 5 == 0)
                {
                    richTextBox1.AppendText(i + ": Buzz\r\n");
                    await Task.Delay(1000);
                }
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
