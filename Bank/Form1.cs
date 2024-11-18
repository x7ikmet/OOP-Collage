using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank
{
    public partial class Form1 : Form
    {

        private Random random = new Random();
        private Button[] buttons;
        public Form1()
        {
            InitializeComponent();
            buttons = new Button[] { 
                button2, button3, button4, 
                button7, button6,button5, 
                button10, button9,button8
            };

            foreach(Button button in buttons)
            {
                button.Click += NumberButton_Click;
            }
            RandomizeNumbers();
        }

        private void RandomizeNumbers()
        {
            List<int> numbers = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                numbers.Add(i);
            }


            foreach (Button button in buttons)
            {

                int index = random.Next(numbers.Count);
                button.Text = numbers[index].ToString();
                numbers.RemoveAt(index);

            }
        }

        private void NumberButton_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox1.Text += btn.Text;
            RandomizeNumbers();
        }

    }
}
