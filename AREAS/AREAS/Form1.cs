using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AREAS
{
    public partial class Form1 : Form
    {
        int bandera = 0;
        public Form1()
        {
            InitializeComponent();
            
            txtA.Enabled = false;
            txtL1.Enabled = false;
            txtL2.Enabled = false;
            txtH.Enabled = false;
            txtR.Enabled = false;
            txtA.Text = "";
            txtL1.Text = "";
            txtL2.Text = "";
            txtH.Text = "";
            txtR.Text = "";

        }
        public void inicializacion()
        {
            txtA.Enabled = false;
            txtL1.Enabled = false;
            txtL2.Enabled = false;
            txtH.Enabled = false;
            txtR.Enabled = false;
            txtA.Text = "";
            txtL1.Text = "";
            txtL2.Text = "";
            txtH.Text = "";
            txtR.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            txtL1.Text = "hola";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            inicializacion();
            txtL1.Enabled = true;
            btnCuadrado.Enabled = true;
            btnRec.Enabled = true;
            bandera = 1;

            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            inicializacion();

            txtL1.Enabled = true;
            btnCuadrado.Enabled = true;
            btnRec.Enabled = true;
            bandera = 2;

           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            inicializacion();
            txtL1.Enabled = true;
            txtL2.Enabled = true;
            btnTrap.Enabled = true;
            btnTri.Enabled = true;
            bandera = 3;
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            inicializacion();
            txtR.Enabled = true;
            btnCir.Enabled = true;

            bandera = 4;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            inicializacion();

            txtL1.Enabled = true;
            txtL2.Enabled = true;
            btnTrap.Enabled = true;
            btnTri.Enabled = true;
            bandera = 5;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            inicializacion();

            txtL1.Enabled = true;
            txtA.Enabled = true;
            btnRom.Enabled = true;
            bandera = 6;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtL1.Enabled = true;
            txtH.Enabled = true;
            btnPen.Enabled = true;
            btnHex.Enabled = true;
            bandera = 7;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            inicializacion();

            txtL1.Enabled = true;
            txtH.Enabled = true;
            btnPen.Enabled = true;
            btnHex.Enabled = true;
            bandera = 8;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            if (bandera==1)
            {
                double a = double.Parse(txtL1.Text);
                double resultado = Mate.Cuadrado(a);
                Area.Text = Convert.ToString(resultado);
            }
            else if (bandera == 2)
            {
                double a = double.Parse(txtL1.Text);
                double resultado = Mate.Rectangulo(a);
                Area.Text = Convert.ToString(resultado);
            }
            else if (bandera == 3)
            {
                
                double a = double.Parse(txtL1.Text);
                double b = double.Parse(txtL2.Text);
                double resultado = Mate.Triangulo(a, b);
                Area.Text = Convert.ToString(resultado);
            }
           else if (bandera == 4)
            {
                double a = double.Parse(txtR.Text);
                double resultado = Mate.Circulo(a);
                Area.Text = Convert.ToString(resultado);
            }
           else if (bandera == 5)
            {
                double a = double.Parse(txtL1.Text);
                double b = double.Parse(txtL2.Text);
                double c = double.Parse(ljlk.Text);
                double resultado = Mate.Trapecio(a, b, c);
                Area.Text = Convert.ToString(resultado);
            }
           else if (bandera == 6)
            {
                double a = double.Parse(txtL1.Text);
                double b = double.Parse(txtA.Text);
                double resultado = Mate.Romboide(a, b);
                Area.Text = Convert.ToString(resultado);
            }
           else if (bandera == 7)
            {
                double a = double.Parse(txtL1.Text);
                double b = double.Parse(txtH.Text);
                double resultado = Mate.Pentagono(a, b);
                Area.Text = Convert.ToString(resultado);
            }
           else if (bandera == 8)
            {
                double a = double.Parse(txtL1.Text);
                double b = double.Parse(txtH.Text);
                double resultado = Mate.Hexagono(a, b);
                Area.Text = Convert.ToString(resultado);
            }
            inicializacion();



        }
    }
}
