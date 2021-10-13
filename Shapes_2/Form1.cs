using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shapes_2
{
    public partial class Form1 : Form
    {
        private Square S;
        private Rectangle R;
        private Rhomb RH;
        private Triangle T;
        private Circle C;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            S = null;
            R = null;
            RH = null;
            T = null;
            C = null;
            try
            {
                double a = Convert.ToDouble(textBox1.Text);

                S = new Square(a);
                MessageBox.Show("Квадрат створено");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не вдалось створити квадрат");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            S = null;
            R = null;
            RH = null;
            T = null;
            C = null;
            try
            {
                double a = Convert.ToDouble(textBox2.Text);
                double b = Convert.ToDouble(textBox3.Text);

                R = new Rectangle(a, b);
                MessageBox.Show("Прямокутник створено");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не вдалось створити прямокутник");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            S = null;
            R = null;
            RH = null;
            T = null;
            C = null;
            try
            {
                double a = Convert.ToDouble(textBox4.Text);
                double b = Convert.ToDouble(textBox5.Text);
                double c = Convert.ToDouble(textBox6.Text);

                T = new Triangle(a, b, c);
                MessageBox.Show("Трикутник створено");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не вдалось створити трикутник");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            S = null;
            R = null;
            RH = null;
            T = null;
            C = null;
            try
            {
                double a = Convert.ToDouble(textBox7.Text);
                double alpha = Convert.ToDouble(textBox9.Text);

                RH = new Rhomb(a, alpha);
                MessageBox.Show("Ромб створено");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не вдалось створити ромб");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            S = null;
            R = null;
            RH = null;
            T = null;
            C = null;
            try
            {
                double r = Convert.ToDouble(textBox10.Text);

                C = new Circle(r);
                MessageBox.Show("Круг створено");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не вдалось створити круг");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if(S != null)
                MessageBox.Show(S.GetPerimetr().ToString());
            else if(R != null)
                MessageBox.Show(R.GetPerimetr().ToString());
            else if(RH != null)
                MessageBox.Show(RH.GetPerimetr().ToString());
            else if(T != null)
                MessageBox.Show(T.GetPerimetr().ToString());
            else if (C != null)
                MessageBox.Show(C.GetPerimetr().ToString());
            else
                MessageBox.Show("Спочатку створіть фігуру!");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (S != null)
                MessageBox.Show(S.GetArea().ToString());
            else if (R != null)
                MessageBox.Show(R.GetArea().ToString());
            else if (RH != null)
                MessageBox.Show(RH.GetArea().ToString());
            else if (T != null)
                MessageBox.Show(T.GetArea().ToString());
            else if (C != null)
                MessageBox.Show(C.GetArea().ToString());
            else
                MessageBox.Show("Спочатку створіть фігуру!");
        }
    }
}
