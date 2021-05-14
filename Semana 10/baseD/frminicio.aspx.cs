using baseD.Clases.Archivos;
using baseD.Clases.BaseDatos;
using baseD.Clases.Buscar;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace baseD
{
    public partial class frminicio : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private void CargarArchivoExterno()
        {
            string fuente = @"C:\Users\alumno\Desktop\Archivo\1_4949951634001101227.csv";
            ClsArchivo ar = new ClsArchivo();
            ClsConexionSQL cnSQL = new ClsConexionSQL();
            ClsConexionMYSQL cnMYSQL = new ClsConexionMYSQL();
            string[] ArregloNotas = ar.LeerArchivo(fuente);
            string sentencia = "";
            int NumeroLinea = 0;

            //Iteramos sobre el Arreglo, linea por linea,para convertir en datos individuales.
            foreach (string Linea in ArregloNotas)
            {
                string[] datos = Linea.Split(';');
                if (NumeroLinea > 0)
                {
                    sentencia += $"insert into tb_alumnos values({datos[0]},'{datos[1]}',{datos[2]},{datos[3]},{datos[4]},{datos[5]},'{datos[6]}');\n";
                }
                NumeroLinea++;
            }
            NumeroLinea = 0;
            cnSQL.EjecutaSQLDirecto(sentencia);
            cnMYSQL.EjecutaMYSQLDirecto(sentencia);
        }

        protected void ButtonCargaDatos_Click(object sender, EventArgs e)
        {
            CargarArchivoExterno();
        }
                                

        protected void ButtonBuscarid_Click(object sender, EventArgs e)
        {
            ClsBSQL buscar = new ClsBSQL();
            string id = TextBox1.Text.Trim();
            string condicion = $"correlativo = {id}";
            DataTable dt = buscar.CargarDatosDB(condicion);
            
            if (dt.Rows.Count > 0)
            {
                string nombre = dt.Rows[0].Field<String>("nombre");
                TextBox3.Text = nombre;
            }
            else
            {
                TextBox3.Text = "No hay informacion";
            }
        }

        protected void ButtonBuscarnombre_Click(object sender, EventArgs e)
        {
            ClsBSQL buscar = new ClsBSQL();
            string nombre = TextBox2.Text.Trim();
            string condicion = $"nombre like ('%{nombre}%')";
            DataTable dt = buscar.CargarDatosDB(condicion); 
            
            if (dt.Rows.Count > 0)
            {
                int id = dt.Rows[0].Field<int>("correlativo");
                TextBox4.Text = id+"";
            }
            else
            {
                TextBox4.Text = "No hay informacion";
            }
        }

        protected void ButtonBuscarid2_Click(object sender, EventArgs e)
        {
            ClsBMYSQL buscar = new ClsBMYSQL();
            string id = TextBox5.Text.Trim();
            string condicion = $"correlativo = {id}";
            DataTable dt = buscar.CargarDatosDB(condicion);

            if (dt.Rows.Count > 0)
            {
                string nombre = dt.Rows[0].Field<String>("nombre");
                TextBox6.Text = nombre;
            }
            else
            {
                TextBox6.Text = "No hay informacion";
            }
        }

        protected void ButtonBuscarnombre2_Click(object sender, EventArgs e)
        {
            ClsBMYSQL buscar = new ClsBMYSQL();
            string nombre = TextBox7.Text.Trim();
            string condicion = $"nombre like ('%{nombre}%')";
            DataTable dt = buscar.CargarDatosDB(condicion);

            if (dt.Rows.Count > 0)
            {
                int id = dt.Rows[0].Field<int>("correlativo");
                TextBox8.Text = id + "";
            }
            else
            {
                TextBox8.Text = "No hay informacion";
            }
        }
    }
}