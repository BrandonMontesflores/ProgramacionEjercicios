﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaBot.Conexion
{
    class ClsSQL
    {
        public SqlConnection conexion;
        private String _conexion { get; }

        public ClsSQL()
        {

            _conexion = "Data Source =UMG-VM\\SQLEXPRESS;Initial Catalog=dbprogra1a;Integrated Security=True";

        }

        public void cerrarConexionBD()
        {
            conexion.Close();
        }

        public void abrirConexion()
        {
            conexion = new SqlConnection(_conexion);
            conexion.Open();
        }

        public DataTable consultaTablaDirecta(String sqll)
        {
            abrirConexion();
            SqlDataReader dr;
            SqlCommand comm = new SqlCommand(sqll, conexion);
            dr = comm.ExecuteReader();

            var dataTable = new DataTable();
            dataTable.Load(dr);
            cerrarConexionBD();
            return dataTable;
        }

        public void EjecutaSQLDirecto(String sqll)
        {
            abrirConexion();
            try
            {

                SqlCommand comm = new SqlCommand(sqll, conexion);
                comm.ExecuteReader();
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
            }
            finally
            {
                cerrarConexionBD();
            }
        }

        public void EjecutaSQLManual(String sqll)
        {
            SqlCommand comm = new SqlCommand(sqll, conexion);
            comm.ExecuteReader();
        }
    }
}
