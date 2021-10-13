using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW_4._1
{
    public partial class Form1 : Form
    {

        private Triangle A;

        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double a = Convert.ToDouble(textBox1.Text);
                double b = Convert.ToDouble(textBox2.Text);
                double c = Convert.ToDouble(textBox3.Text);

                A = new Triangle(a, b, c);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Не удалось создать триугольник");
            }            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (A != null)
                MessageBox.Show(A.GetPerimetr().ToString());
            else
                MessageBox.Show("Створіть трикутник!");
        }
    }
}
