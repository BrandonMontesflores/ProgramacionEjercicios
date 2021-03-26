using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carro.Car
{
    class ClsCar
    {
        public string sistema { get; }
        public int vm { get; }
        public string color { get; set; }
        public string modelo { get; set; }
        public int anio { get; set; }
        public int va = 0;
        public bool encendido { get; set; } = false;

        public ClsCar(string sistemac, int vmax)
        {
            this.vm = vmax;
            this.sistema = sistemac;
        }

        public ClsCar(string sistemac, int vmax, int anioc, string colorc, string modeloc)
        {
            this.vm = vmax;
            this.sistema = sistemac;
            this.color = colorc;
            this.anio = anioc;
            this.modelo = modeloc;
        }              
                  
        public string encender()
        {
            string resultado = "";
            if (encendido)
            {

                encendido = false;
                resultado = "El carro está apagado";
            }
            else
            {

                encendido = true;
                resultado = "Puedes continuar";
            }
            va = 0;
            return resultado;

        }

        public string frenar()
        {
            if (!encendido)
            {
                return "Debes encender el carro";
            }
            va = 0;
            return "El carro se frenó";
        }

        public string acelerar()
        {
            if (!encendido)
            {
                return "Debes encender el carro";
            }
            if (va >= vm)
            {
                va = vm;
                return $"Llegaste al límite {vm} K/H";
            }
            else
            {
                va = va + 10;
                return $"Vas a {va} K/H";
            }
        }

        public string cambio()
        {
            if (va==10)
            {
                return "Debes cambiar a segunda";
            }
            if (va==20)
            {
                return "Debes cambiar a tercera";
            }
            else
            {
                va = va + 30;
                return "Debes cambiar a cuarta y quinta";
            }           
                       
        }
    }
}
