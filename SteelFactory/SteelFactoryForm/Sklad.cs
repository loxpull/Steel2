using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SteelFactoryForm
{
    public partial class Sklad : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Admin\\source\\repos\\SteelFactory\\SteelFactoryForm\\Database1.mdf;Integrated Security=True");
        


        public Sklad()
        {
            InitializeComponent();
        }
        public double Ore { get; set; }
        public double Nikel { get; set; }
        public double Chrome { get; set; }
        public double Marganec { get; set; }
        public double TimeFurnace { get; set; }
        public double TimeConverter { get; set; }
        public double TimeRollingMachine { get; set; }

        TextBox[] tbs;
        private void Form1_Load(object sender, EventArgs e)
        {
            tbs = new TextBox[] { textBox1, textBox2, textBox3, textBox4, textBox5, textBox6, textBox7 };
            textBox1.Text = Convert.ToString(Ore); 
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Ore = double.Parse(textBox1.Text);
            Nikel = double.Parse(textBox2.Text);
            string text3 = textBox3.Text;
            string text4 = textBox4.Text;
            string text5 = textBox5.Text;
            string text6 = textBox6.Text;
            string text7 = textBox7.Text;

            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string path = Path.Combine(desktopPath, "111.txt");
            try
            {
                using (StreamWriter writer = new StreamWriter(path))
                {
                    writer.WriteLine("Руда: " + Ore);
                    writer.WriteLine("Никель: " + Nikel);
                    writer.WriteLine("Хром: " + text3);
                    writer.WriteLine("Марганец: " + text4);
                    writer.WriteLine("Время работы доменной печи (часы):: " + text5);
                    writer.WriteLine("Время работы конвертера (часы): " + text6);
                    writer.WriteLine("Время работы прокатного стана (часы): " + text7);

                }
                MessageBox.Show("Данные сохранены успешно!"); 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при сохранении данных: " + ex.Message);
            }
            int count = 0;
            for (int i = 0; i < 7; i++)
            {
                if (tbs[i].Text != "")
                {
                    count++;
                }
            }
            if (count < 7)
            {
                MessageBox.Show("Не все поля заполненные");
            }
            else
            {
                Ore = double.Parse(textBox1.Text);
                Nikel = double.Parse(textBox2.Text);
                Chrome = double.Parse(textBox3.Text);
                Marganec = double.Parse(textBox4.Text);
                TimeFurnace = double.Parse(textBox5.Text);
                TimeConverter = double.Parse(textBox6.Text);
                TimeRollingMachine = double.Parse(textBox7.Text);
                this.Close();
            }
        }
}
}
