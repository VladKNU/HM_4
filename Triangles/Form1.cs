using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Triangles
{
    public partial class Form1 : Form
    {
        private TriangleClass A;
        private EquilTriangle B;


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            A = null;
            B = null;
            try
            {
                double a = Convert.ToDouble(textBox1.Text);
                double b = Convert.ToDouble(textBox2.Text);
                double c = Convert.ToDouble(textBox3.Text);

                if (a == b && b == c)
                {
                    B = new EquilTriangle(a, b, c);
                    MessageBox.Show("Рівносторонній трикутник створено");
                }
                else
                {
                    A = new TriangleClass(a, b, c);
                    MessageBox.Show("Трикутник створено");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не вдалось створити трикутник");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (A != null)
                MessageBox.Show(A.GetPerimetr().ToString());
            else if (B != null)
                MessageBox.Show(B.GetPerimetr().ToString());
            else
                MessageBox.Show("Створіть трикутник!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (A != null)
                MessageBox.Show(A.GetAlpha().ToString());
            else if (B != null)
                MessageBox.Show(B.GetAlpha().ToString());
            else
                MessageBox.Show("Створіть трикутник!");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (A != null)
                MessageBox.Show(A.GetBetta().ToString());
            else if (B != null)
                MessageBox.Show(B.GetBetta().ToString());
            else
                MessageBox.Show("Створіть трикутник!");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (A != null)
                MessageBox.Show(A.GetGamma().ToString());
            else if (B != null)
                MessageBox.Show(B.GetGamma().ToString());
            else
                MessageBox.Show("Створіть трикутник!");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (B != null)
                MessageBox.Show(B.GetArea().ToString());
            else
                MessageBox.Show("Трикутник не рівносторонній!");
        }
    }
}
