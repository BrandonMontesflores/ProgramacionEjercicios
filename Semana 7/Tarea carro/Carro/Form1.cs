using Carro.Car;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Carro
{
    public partial class Form1 : Form
    {
        ClsCar carro;
        public Form1()
        {
            InitializeComponent();
            axWindowsMediaPlayer1.Visible = false;
        }

        private void buttonCA_Click(object sender, EventArgs e)
        {
            carro = new ClsCar("automático", 200, 2010, "rojo", "Toyota Yaris");                
            MessageBox.Show($"El carro {carro.sistema} es color {carro.color} y modelo {carro.modelo} {carro.anio}");
            labelcam.Text = "";
            labelest.Text = "";
            labelvel.Text = "";
            buttoncambio.Visible = false;
            axWindowsMediaPlayer1.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            labelest.Text = carro.encender();
            axWindowsMediaPlayer1.Visible = true;
        }

        private void buttonacelerar_Click(object sender, EventArgs e)
        {          
                if (carro == null)
                {
                    MessageBox.Show("Debes crear el carro");
                }
                else
                {
                    labelvel.Text = carro.acelerar();
                }          
        }

        private void buttonfrenar_Click(object sender, EventArgs e)
        {
            labelvel.Text = carro.frenar();
        }

        private void buttonCM_Click(object sender, EventArgs e)
        {
            carro = new ClsCar("mecánico", 250, 2015, "gris", "Toyota Hilux");
            MessageBox.Show($"El carro {carro.sistema} es color {carro.color} y modelo {carro.modelo} {carro.anio}");
            labelcam.Text = "";
            labelest.Text = "";
            labelvel.Text = "";
            buttoncambio.Visible = true;
            axWindowsMediaPlayer1.Visible = false;
        }

        private void buttoncambio_Click(object sender, EventArgs e)
        {
            labelcam.Text = carro.cambio();          
        }
         
        
    }
}
