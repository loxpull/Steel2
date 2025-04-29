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
    public partial class SteelFactory : Form
    {
        public SteelFactory()
        {
            InitializeComponent();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            CreateOrder createOrder = new CreateOrder();
            createOrder.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Sklad sklad = new Sklad();
            sklad.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            QueueOrder queueOrder = new QueueOrder();
            queueOrder.Show();
        }

        private void SteelFactory_Load(object sender, EventArgs e)
        {

        }
    }
}
