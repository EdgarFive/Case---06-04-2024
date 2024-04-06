using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Case___06_04_2024.Claces
{
    internal class Carro
    {
        public string Marca {get;}
        public int Modelo {get;}
        public string Color {get; set;}
        public string owner {get; set;}

        private int Encendido = 0;
        private int velocidad_actual = 0;
       
        public int MAXVELOCIDAD {get; set;}

        public Carro(string m, int modelo, string col)
        {
            Marca = m;
            Modelo = modelo;
            Color = col;
        }

        public int Encender()
        {
            if (Encendido == 0)
            {
                Encendido = 1;
                return Encendido;
            }
            else
            {
                Encendido = 0;
                return Encendido;
            }
        }

        public int Acelerar()
        {
            if (Encendido == 0)
            {
                return 0;
            }
            else
            {
                velocidad_actual += 10;
                return velocidad_actual;
            }
        }



    }

}
