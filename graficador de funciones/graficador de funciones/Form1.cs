using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace graficador_de_funciones
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int esc = 10, escEsp;
        Bitmap GRAFICADOR = new Bitmap(graficador_de_funciones.Properties.Resources._342);

        private void escala()
        {
            if (escalaTXT.Text == null || escalaTXT.Text == "")
            {
                esc = 10;
                escalaTXT.Text = "1";
            }
            else
            {
                esc = (int)Convert.ToInt32(escalaTXT.Text);
                if (esc < 1) esc = 1;
                escalaTXT.Text = esc.ToString();
                esc = esc * 10;
            }
        }

        private void graficar(double x, double y)
        {
            int x0 = grafica.Width / 2;
            int y0 = grafica.Height / 2;

            x = x0 + (x * esc);
            y = y0 - (y * esc);
            if (x < grafica.Width && y < grafica.Height && x > 0 && y > 0)
            {
                GRAFICADOR.SetPixel((int)x, (int)y, Color.Red);
            }
            grafica.Image = GRAFICADOR;
        }//grafica en un punto espesifico de la recta

        private void GenerarEjeCordenadas()
        {
            escala();
                escEsp = esc;
                int x0 = grafica.Width / 2;
                int y0 = grafica.Height / 2;
                GRAFICADOR = new Bitmap(graficador_de_funciones.Properties.Resources._342);//elminar grafico anterior

                for (int i = 0; i < grafica.Width; i++) //graficar eje x
                {
                    GRAFICADOR.SetPixel(i, y0, Color.Black);
                }

                for (int i = 0; i < grafica.Height; i++) //graficar eje y
                {
                    GRAFICADOR.SetPixel(x0, i, Color.Black);
                }

                for (int i = x0; i < grafica.Width; i = i + esc) //graficar en x
                {
                    for (int y = 0; y < 3; y = y + 1)
                    {
                        GRAFICADOR.SetPixel(i, y0 + y, Color.Black);
                        GRAFICADOR.SetPixel(i, y0 - y, Color.Black);
                    }
                }

                for (int i = x0; i > 0; i = i - esc) //graficar escala en x
                {
                    for (int y = 0; y < 3; y = y + 1)
                    {
                        GRAFICADOR.SetPixel(i, y0 + y, Color.Black);
                        GRAFICADOR.SetPixel(i, y0 - y, Color.Black);
                    }
                }
                for (int i = y0; i < grafica.Height; i = i + esc) //graficar escala en y
                {
                    for (int y = 0; y < 3; y = y + 1)
                    {
                        GRAFICADOR.SetPixel(x0 + y, i, Color.Black);
                        GRAFICADOR.SetPixel(x0 - y, i, Color.Black);
                    }
                }

                for (int i = y0; i > 0; i = i - esc) //graficar escala en y
                {
                    for (int y = 0; y < 3; y = y + 1)
                    {
                        GRAFICADOR.SetPixel(x0 + y, i, Color.Black);
                        GRAFICADOR.SetPixel(x0 - y, i, Color.Black);
                    }
                }
                grafica.Image = GRAFICADOR;
        }//crea un eje de coordenadas

        private void Form1_Load(object sender, EventArgs e)
        {
            GenerarEjeCordenadas();
        }
        
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Title = "save grafic";
            saveFileDialog1.Filter = "img(*.jpeg)|*.jpeg";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                GRAFICADOR.Save(saveFileDialog1.FileName, ImageFormat.Jpeg);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GenerarEjeCordenadas();
            funcionTomada.Refresh();

            interpretador sep = new interpretador();
            calculador cal = new calculador();

            sep.interpretar(funcion.Text);
            funcionTomada.Text = interpretador.function; 

            for (double i = -27; i < 27; i+= 0.005)
            {
                cal.calcular(i); //calcular Y
                graficar(i , cal.resultado);
            }
            /*cal.calcular(1);
            funcionTomada.Text = cal.resultado.ToString();*/
        }
    }
}