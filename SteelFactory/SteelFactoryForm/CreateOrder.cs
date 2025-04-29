using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SteelFactoryForm
{
    public partial class CreateOrder : Form
    {
        TextBox[] tbs;
        public CreateOrder()
        {
            InitializeComponent();
        }

        private void Form_Load(object sender, EventArgs e)
        {
            tbs = new TextBox[] { textBox1, textBox2 };
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int count = 0;
            for (int i = 0; i < 2; i++)
            {
                if (tbs[i].Text != "")
                {
                    count++;
                }
            }
            if (count < 2)
            {
                MessageBox.Show("Не все поля заполненные");
            }
            else
            {
            }
        }
    }
}

