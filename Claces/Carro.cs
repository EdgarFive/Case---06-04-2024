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
        private int Encendido = 1;
        private int velocidad_actual = 0;
        public int MAXVELOCIDAD = 200;
        
        // =====================================================
        public bool Freno_mano = true;
        public int palanca_cambios = 0;

        public Carro(string m, int modelo, string col, string ow)
        {
            Marca = m;
            Modelo = modelo;
            Color = col;
            owner = ow;
        }




        //Area de encendido y apagado ====================================================
        public int Encender_Apagar()
        {
            if (Encendido == 1)
            {
                Encendido = 0;
                return Encendido;
            }
            else
            {
                Encendido = 1;
                return Encendido;
            }
        }


        public bool Freno_de_mano(int eevari)
        {
            
            if (eevari == 0)
            {
                Freno_mano = true;
            }
            else if (eevari == 1 )
            {
                Freno_mano = false;
            }
            return Freno_mano; 
        }

        public int Palanca_de_los_cambios(int eevari)
        {
            switch (eevari)
            {
                case 0:
                    palanca_cambios = 0;
                    break;
                case 1:
                    palanca_cambios = 1;

                    break;
                case 2:
                    palanca_cambios = 2;

                    break;
                case 3:
                    palanca_cambios = 3;

                    break;
                case 4:
                    palanca_cambios = 4;

                    break;
                case 5:
                    palanca_cambios = 5;

                    break;
                case 6:
                    palanca_cambios = 6;
                    break;
            }
            return palanca_cambios;
        }

        public int Cambio_de_velociadad_automatico()
        {
            int eevariableint = 0;
            if(velocidad_actual >= 160)
            {
                eevariableint = 5;
                return eevariableint;

            }
            else if (velocidad_actual>=120)
            {
                eevariableint = 4;
                return eevariableint;


            }
            else if(velocidad_actual>= 80)
            {
                eevariableint = 3;
                return eevariableint;

            }
            else if (velocidad_actual >= 40)
            {
                eevariableint = 2;
                return eevariableint;

            }
            return eevariableint;
        }

        public int Acelerar()
        {
            //Console.WriteLine($"Hola, Soy Batman 1");
            //Console.ReadKey();
            if (Encendido == 0 && palanca_cambios >= 1 && Freno_mano == false)
            {
                // Console.WriteLine($"Hola, Soy Batman 2");
                //Console.ReadKey();
                if (velocidad_actual < MAXVELOCIDAD)
                {
                    //Console.WriteLine($"Hola, Soy Batman 3");
                    //Console.ReadKey();
                    velocidad_actual += 10;
                }
                return velocidad_actual;
            }
            else
            {
                return 0;

            }
        }

    }
}
