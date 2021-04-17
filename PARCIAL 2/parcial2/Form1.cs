using parcial2.clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace parcial2
{
    public partial class Form1 : Form
    {
        private string[] ArregloNotas;      

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCargar_Click(object sender, EventArgs e)
        {
            ClsArchivo ar = new ClsArchivo();   
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Title = "Seleccione su archivo";
            ofd.InitialDirectory = @"C:\Users\charly\Desktop\Archivo";
            ofd.Filter = "Archivo plano (*.csv)|*.csv";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                var archivo = ofd.FileName;
                string resultado = ar.LeerTodoArchivo(archivo);
                ArregloNotas = ar.LeerArchivo(archivo);
            }
        }      

        private void buttonNombres_Click(object sender, EventArgs e)
        {
            string[,] ArregloDosDimensiones = new string[ArregloNotas.Length,6];
            int NumeroLinea = 0;

            foreach (string linea in ArregloNotas)
            {
                string[] datosU = linea.Split(';');
                ArregloDosDimensiones[NumeroLinea, enumColumnas.Correlativo] = datosU[0];
                ArregloDosDimensiones[NumeroLinea, enumColumnas.Nombre] = datosU[1];
                ArregloDosDimensiones[NumeroLinea, enumColumnas.Parcial1] = datosU[2];
                ArregloDosDimensiones[NumeroLinea, enumColumnas.Parcial2] = datosU[3];
                ArregloDosDimensiones[NumeroLinea, enumColumnas.Parcial3] = datosU[4];
                ArregloDosDimensiones[NumeroLinea, enumColumnas.Seccion] = datosU[5];
                NumeroLinea++;
                listBox1.Items.Add($"{datosU[enumColumnas.Correlativo]} {datosU[enumColumnas.Nombre]}");
            }
            
        }

        private void buttonPromedioG_Click(object sender, EventArgs e)
        {
            ClsProm prom = new ClsProm();
            string[,] ArregloDosDimensiones = new string[ArregloNotas.Length, 6];
            int NumeroLinea = 0;

            foreach (string linea in ArregloNotas)
            {
                string[] datosU = linea.Split(';');
                ArregloDosDimensiones[NumeroLinea, enumColumnas.Correlativo] = datosU[0];
                ArregloDosDimensiones[NumeroLinea, enumColumnas.Nombre] = datosU[1];
                ArregloDosDimensiones[NumeroLinea, enumColumnas.Parcial1] = datosU[2];
                ArregloDosDimensiones[NumeroLinea, enumColumnas.Parcial2] = datosU[3];
                ArregloDosDimensiones[NumeroLinea, enumColumnas.Parcial3] = datosU[4];
                ArregloDosDimensiones[NumeroLinea, enumColumnas.Seccion] = datosU[5];
                NumeroLinea++;                
            }
            int promedio = prom.promedios_por_parcial(ArregloDosDimensiones, enumColumnas.Parcial1);
            listBox2.Items.Add($"Primer parcial {promedio}");
            int promedio2 = prom.promedios_por_parcial(ArregloDosDimensiones, enumColumnas.Parcial2);
            listBox2.Items.Add($"Segundo parcial {promedio2}");
            int promedio3 = prom.promedios_por_parcial(ArregloDosDimensiones, enumColumnas.Parcial3);
            listBox2.Items.Add($"Tercer parcial {promedio3}");
        }
                       
        private void buttonPromedioA_Click(object sender, EventArgs e)
        {
            string[,] ArregloDosDimensiones = new string[ArregloNotas.Length, 6];
            int NumeroLinea = 0;
            int par1, par2, par3, total;

            foreach (string linea in ArregloNotas)
            {
                string[] datosU = linea.Split(';');
                ArregloDosDimensiones[NumeroLinea, enumColumnas.Correlativo] = datosU[0];
                ArregloDosDimensiones[NumeroLinea, enumColumnas.Nombre] = datosU[1];
                ArregloDosDimensiones[NumeroLinea, enumColumnas.Parcial1] = datosU[2];
                ArregloDosDimensiones[NumeroLinea, enumColumnas.Parcial2] = datosU[3];
                ArregloDosDimensiones[NumeroLinea, enumColumnas.Parcial3] = datosU[4];
                ArregloDosDimensiones[NumeroLinea, enumColumnas.Seccion] = datosU[5];
                NumeroLinea++;
                par1 = Convert.ToInt32(datosU[2]);
                par2 = Convert.ToInt32(datosU[3]);
                par3 = Convert.ToInt32(datosU[4]);
                total = (par1 + par2 + par3) / 3;

                listBox3.Items.Add($"{total}");
            }
        }

        private void buttonPromGS_Click(object sender, EventArgs e)
        {
            ClsProm prom = new ClsProm();
            string[,] ArregloDosDimensiones = new string[ArregloNotas.Length, 6];
            int NumeroLinea = 0;

            foreach (string linea in ArregloNotas)
            {
                string[] datosU = linea.Split(';');
                ArregloDosDimensiones[NumeroLinea, enumColumnas.Correlativo] = datosU[0];
                ArregloDosDimensiones[NumeroLinea, enumColumnas.Nombre] = datosU[1];
                ArregloDosDimensiones[NumeroLinea, enumColumnas.Parcial1] = datosU[2];
                ArregloDosDimensiones[NumeroLinea, enumColumnas.Parcial2] = datosU[3];
                ArregloDosDimensiones[NumeroLinea, enumColumnas.Parcial3] = datosU[4];
                ArregloDosDimensiones[NumeroLinea, enumColumnas.Seccion] = datosU[5];
                NumeroLinea++;
            }

                int promedio = prom.promedios_general_seccion(ArregloDosDimensiones,"A");
                listBox4.Items.Add($"General A {promedio}");
                int promedio2 = prom.promedios_general_seccion(ArregloDosDimensiones,"B");
                listBox4.Items.Add($"General B {promedio2}");
                int promedio3 = prom.promedios_general_seccion(ArregloDosDimensiones,"C");
                listBox4.Items.Add($"General C {promedio3}");
                int promedio4 = prom.promedios_general_seccion(ArregloDosDimensiones,"D");
                listBox4.Items.Add($"General D {promedio4}");            
        }

        private void buttonNotasD_Click(object sender, EventArgs e)
        {
            ClsProm prom = new ClsProm();
            string[,] ArregloDosDimensiones = new string[ArregloNotas.Length, 6];
            int NumeroLinea = 0;

            foreach (string linea in ArregloNotas)
            {
                string[] datosU = linea.Split(';');
                ArregloDosDimensiones[NumeroLinea, enumColumnas.Correlativo] = datosU[0];
                ArregloDosDimensiones[NumeroLinea, enumColumnas.Nombre] = datosU[1];
                ArregloDosDimensiones[NumeroLinea, enumColumnas.Parcial1] = datosU[2];
                ArregloDosDimensiones[NumeroLinea, enumColumnas.Parcial2] = datosU[3];
                ArregloDosDimensiones[NumeroLinea, enumColumnas.Parcial3] = datosU[4];
                ArregloDosDimensiones[NumeroLinea, enumColumnas.Seccion] = datosU[5];
                NumeroLinea++;
            }
            int mejor = prom.nota_mayor(ArregloDosDimensiones, ArregloNotas);
            listBox5.Items.Add($"La mejor nota es {mejor}");
        }
    }
}   
