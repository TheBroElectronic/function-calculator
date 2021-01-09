using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        Bitmap GRAFICADOR = new Bitmap(graficador_de_funciones.Properties.Resources._342);
        interpretador sep = new interpretador();
        int esc;

        void GenerarEjeCordenadas()
        {
            esc = (int)Convert.ToInt32(escalaTXT.Text);
            if (esc < 1) esc = 1;
            escalaTXT.Text = esc.ToString();
            esc = esc * 10;

            int x0 = grafica.Width / 2;
            int y0 = grafica.Height / 2;

            for (int i = 0; i < grafica.Width; i= i+1) //elminar grafico anterior
            {
                for (int y = 0; y < grafica.Height; y=y+1)
                {
                    GRAFICADOR.SetPixel(i, y, Color.White);
                }
            }

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
                for (int y = 0; y < 3; y = y+1)
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

        public void graficar(double x, double y)
        {
            int x0 = grafica.Width / 2;
            int y0 = grafica.Height / 2;

            x = x0 + (x*esc);
            y = y0 - (y*esc);

            if(x < grafica.Width && y < grafica.Height && x > 0 && y > 0)
            {
                GRAFICADOR.SetPixel((int)x, (int)y, Color.Black);
            }
            grafica.Image = GRAFICADOR;
        }//grafica en un punto espesifico de la recta

        private void Form1_Load(object sender, EventArgs e)
        {
            GenerarEjeCordenadas();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GenerarEjeCordenadas();
            funcionTomada.Refresh();
            funcionTomada.Text = sep.interpretar(funcion.Text).ToString();

            for (double i = -grafica.Width / 2; i < grafica.Width; i+= 0.05)
            {
                graficar(i , i);
            }
        }
    }
}