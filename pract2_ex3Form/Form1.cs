using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pract2_ex3Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double goods = Convert.ToDouble(textBox1.Text);
                int i = 10;
                while (i <= 100)
                {
                    textBox2.AppendText("Стоимость " + i + "шт: " + goods * i);
                    textBox2.AppendText(Environment.NewLine);
                    i += 10;
                }
            }
            catch (FormatException)
            {
                textBox2.AppendText("Неверный формат ввода данных");
            }
        }
    }
}
