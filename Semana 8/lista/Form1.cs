using lista.clase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lista
{
    public partial class Form1 : Form
    {
        private string[] ArregloNotas;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonarreglo_Click(object sender, EventArgs e)
        {
            int[] arreglo = new int[5];
            arreglo[0] = 10;
            arreglo[1] = 30;
            arreglo[2] = 20;
            arreglo[3] = 40;
            arreglo[4] = 1;

            ClsArreglos ObjetoArreglo = new ClsArreglos(arreglo);
            int[] resultado = ObjetoArreglo.MetodoBurbuja();

            foreach (int r in resultado)
            {
                listBox1.Items.Add(r);
            }
        }

        private void buttonCargararchivo_Click(object sender, EventArgs e)
        {
            ClsArchivo ar = new ClsArchivo();
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Title = "Seleccione su archivo";
            ofd.InitialDirectory = @"C:\Users\charly\Desktop\Archivo";
            ofd.Filter = "Archivo plano (*.csv)|*.csv";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                var archivo = ofd.FileName;
                String resultado = ar.LeerTodoArchivo(archivo);
                ArregloNotas = ar.LeerArchivo(archivo);               
            }
        }

        private void buttonnombres_Click(object sender, EventArgs e)
        {

            foreach (string linea in ArregloNotas)
            {
                string[] datosU = linea.Split(';');
                listBoxresultado.Items.Add($"{datosU[0]} {datosU[1]}");                             
            }
        }

        private void buttonpromedio_Click(object sender, EventArgs e)
        {
            double par1, par2, par3, total;
           
            foreach (string r in ArregloNotas)
            {
                string[] prom = r.Split(';');

                par1 = Convert.ToDouble(prom[2]);
                par2 = Convert.ToDouble(prom[3]);
                par3 = Convert.ToDouble(prom[4]);               
                total = (par1 + par2 + par3)/3;

                listBoxresultado2.Items.Add($"{total}"); 
            }
        }

        private void buttonPromedioG_Click(object sender, EventArgs e)
        {
            double par1, par2, par3;
            double total1 = 0, total2 = 0, total3 = 0;
            double prom1 = 0, prom2 = 0, prom3 = 0;

            foreach (string r in ArregloNotas)
            {
                string[] prom = r.Split(';');              

                par1 = Convert.ToDouble(prom[2]);
                par2 = Convert.ToDouble(prom[3]);
                par3 = Convert.ToDouble(prom[4]);

                total1 += par1;
                total2 += par2;
                total3 += par3;
            }
            prom1 = total1 / 60;
            prom2 = total2 / 60;
            prom3 = total3 / 60;

            listBoxresultado3.Items.Add($"Primer parcial =  {prom1}");
            listBoxresultado3.Items.Add($"Segundo parcial = {prom2}");
            listBoxresultado3.Items.Add($"Tercer parcial =  {prom3}");
        }

        private void buttonND_Click(object sender, EventArgs e)
        {
            int par1, par2, par3;
            int mejor, peor;
            int total;

            foreach (string r in ArregloNotas)
            {
                string[] prom = r.Split(';');

                par1 = Convert.ToInt32(prom[2]);
                par2 = Convert.ToInt32(prom[3]);
                par3 = Convert.ToInt32(prom[4]);
                total = (par1 + par2 + par3) / 3;
               
                if (total >21)
                {
                    mejor = total;
                    listBoxresultado4.Items.Add($"{prom[1]} {mejor}");
                }

                if (total <3)
                {
                    peor = total;
                    listBoxresultado5.Items.Add($"{prom[1]} {peor}");
                }                                                                                                   
            }
        }
    } 
}
