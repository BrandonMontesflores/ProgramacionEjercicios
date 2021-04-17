using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parcial2.clases
{
    class ClsProm : InterfacePromedios
    {
        
        public string[,] Clasificar_Alumnos(string[,] matriz, string seccion)
        {
            throw new NotImplementedException();
        }
    
        public string[,] nombre_nota_mayor(string[,] matriz)
        {
            throw new NotImplementedException();
        }

        public string[,] nombre_nota_mayor(string[,] matriz, string seccion)
        {
            throw new NotImplementedException();
        }

        public int nombre_nota_mayor(string[,] matriz, string[] seccion)
        {
            throw new NotImplementedException();
        }

        public int nota_mayor(string[,] matriz, string[] seccion)
        {
            int acumulador = 0;
            int total = 0;
            int promedio = 0;
            int mejor = 0;
            int total1 = 0;
            int[] PromMej = new int[seccion.Length];
            int TotalFilas = matriz.GetLength(0);
 
            for (int i = 1; i < TotalFilas; i++)
            {

                total = Convert.ToInt32(matriz[i,2]) 
                    + Convert.ToInt32(matriz[i,3]) 
                    + Convert.ToInt32(matriz[i,4]);
                promedio = total / 3;
                if (acumulador != 0)
                {
                    PromMej[acumulador] = promedio;
                    if (PromMej[acumulador] >total1)
                    {
                        mejor = PromMej[acumulador];
                        total1 = PromMej[acumulador];
                    }
                }
                acumulador++;
            }
            return mejor;
        }

        public int promedios_general_seccion(string[,] matriz, string seccion)
        {
            int acumulador = 0;
            int total = 0;
            int total2 = 0;
            int promedio;
            int totalFilas = matriz.GetLength(0);           

            for (int i = 1; i < totalFilas; i++)
            {
                if (matriz[i, enumColumnas.Seccion] == seccion)
                {
                    total = Convert.ToInt32(matriz[i,2])
                         + Convert.ToInt32(matriz[i,3])
                         + Convert.ToInt32(matriz[i,4]);
                    total2 = total + total2;
                    acumulador++;
                }              
            }
            promedio = total2 / acumulador;
            return promedio;
        }

        public int promedios_por_parcial(string[,] matriz, int columnaparcial)
        {
            int acumulador = 0;
            int promedio;
            int totalFilas = matriz.GetLength(0);           
            for (int i = 1; i < totalFilas; i++)
            {
                acumulador = acumulador + Convert.ToInt32(matriz[i, columnaparcial]);
            }
            promedio = acumulador / (totalFilas - 1);
            return promedio;
        }

        public int promedios_por_seccion(string[,] matriz, int columnaparcial, string seccion)
        {
            throw new NotImplementedException();
        }
    }
}

