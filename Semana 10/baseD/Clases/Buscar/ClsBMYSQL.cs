using baseD.Clases.BaseDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace baseD.Clases.Buscar
{
    public class ClsBMYSQL
    {
        public DataTable CargarDatosDB(string condicion = "1=1")
        {
            ClsConexionMYSQL cn = new ClsConexionMYSQL();
            DataTable dt = new DataTable();
            string sentencia = $"select * from tb_alumnos where {condicion}";
            dt = cn.consultaTablaDirecta(sentencia);
            return dt;
        }
    }
}