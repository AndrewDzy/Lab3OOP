using System.Security.Policy;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double side1 = double.Parse(txtSide1.Text);
            double side2 = double.Parse(txtSide2.Text);
            double angle = double.Parse(txtAngle.Text);

            Triangle triangle;
            if (rbRightTriangle.Checked)
                triangle = new RightTriangle(side1, side2, angle);
            else if (rbIsoscelesTriangle.Checked)
                triangle = new IsoscelesTriangle(side1, side2, angle);
            else if (rbEquilateralTriangle.Checked)
                triangle = new EquilateralTriangle(side1, angle);
            else
            {
                MessageBox.Show("Please select a triangle type.");
                return;
            }

            double area = triangle.CalculateArea();
            double perimeter = triangle.CalculatePerimeter();

            MessageBox.Show($"Area: {area}\nPerimeter: {perimeter}");

            if (string.IsNullOrWhiteSpace(txtSide1.Text) ||
                string.IsNullOrWhiteSpace(txtSide2.Text) ||
                string.IsNullOrWhiteSpace(txtAngle.Text))
            {
                MessageBox.Show("Введіть число");
                return;
            }
        }
        abstract class Triangle
        {
            protected double side1;
            protected double side2;
            protected double angle;

            // Конструктор
            public Triangle(double s1, double s2, double a)
            {
                side1 = s1;
                side2 = s2;
                angle = a;
            }

            // Віртуальна функція для обчислення площі
            public virtual double CalculateArea()
            {
                // Реалізація може бути залишена пустою, оскільки цей метод буде перевизначено у класах-спадкоємцях
                return 0;
            }

            // Віртуальна функція для обчислення периметра
            public virtual double CalculatePerimeter()
            {
                // Реалізація може бути залишена пустою, оскільки цей метод буде перевизначено у класах-спадкоємцях
                return 0;
            }
        }

        // Клас прямокутного трикутника
        class RightTriangle : Triangle
        {
            public RightTriangle(double s1, double s2, double a) : base(s1, s2, a)
            {
            }

            // Реалізація обчислення площі
            public override double CalculateArea()
            {
                return 0.5 * side1 * side2;
            }

            // Реалізація обчислення периметра
            public override double CalculatePerimeter()
            {
                double side3 = Math.Sqrt(side1 * side1 + side2 * side2);
                return side1 + side2 + side3;
            }
        }

        // Клас рівнобедреного трикутника
        class IsoscelesTriangle : Triangle
        {
            public IsoscelesTriangle(double s1, double s2, double a) : base(s1, s2, a)
            {
            }

            // Реалізація обчислення площі
            public override double CalculateArea()
            {
                double height = side1 * Math.Sin(angle);
                return 0.5 * side2 * height;
            }

            // Реалізація обчислення периметра
            public override double CalculatePerimeter()
            {
                double side3 = Math.Sqrt(side2 * side2 + 2 * side1 * side2 * Math.Cos(angle));
                return 2 * side1 + side3;
            }
        }

        // Клас рівностороннього трикутника
        class EquilateralTriangle : Triangle
        {
            public EquilateralTriangle(double s, double a) : base(s, s, a)
            {
            }

            // Реалізація обчислення площі
            public override double CalculateArea()
            {
                return (Math.Sqrt(3) / 4) * side1 * side1;
            }

            // Реалізація обчислення периметра
            public override double CalculatePerimeter()
            {
                return 3 * side1;
            }
        }
        private void txtSide1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Delete)
            {
                e.Handled = true;
            }
        }

        private void txtSide2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Delete)
            {
                e.Handled = true; 
            }
        }

        private void txtAngle_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Delete)
            {
                e.Handled = true;
            }
        }
    }
}

