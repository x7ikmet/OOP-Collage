using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank
{
    public partial class Form2 : Form
    {
        private List<Button> buttons = new List<Button>();

        public Form2()
        {
            InitializeComponent();
        }

        private void setUp()
        {
            foreach(Control control in this.Controls)
            {
                if (control is Button btn && btn.Text == "0")
                {
                    buttons.Add(btn);

                }
            }
        }
    }
}
