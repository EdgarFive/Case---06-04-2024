



using Case___06_04_2024.Claces;
using System.ComponentModel;


/*
 try
{

}
catch (Exception eerror)
{
    Console.WriteLine($"Ah ocurrido un error en el ingreso de datos; Error: \"{eerror}\"");
}
 */
//=======================================================================================
//AREA DE FUNCIONES =====================================================================
//=======================================================================================


//Función || Imprimir el listado de acciones ====
static void ffimprimir_string_vector_enumerado(string[] eeacciones)
{
    for (int ii =0; ii < eeacciones.Length; ii++)
    {
        Console.WriteLine($"{ii+1}. {eeacciones[ii]}.");
    }
}

//Función || Freno de mano =======
static int fffreno_mano(bool eebool)
{
    int eefreno;
    if (eebool)
    {
        for (int kk = 0; kk != -1;)
        {
            try
            {
                Console.Clear();
                Console.WriteLine($"Freno de mano - Estado:");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Puesto");
                Console.ResetColor();
                Console.WriteLine($"Siguiente acción:\n1. Dejarlo puesto.\n2. Quitarlo.");
                eefreno = int.Parse(Console.ReadLine()) - 1;
                if (eefreno == 0)
                {
                    Console.Clear();
                    Console.WriteLine($"Has puesto el freno de mano.");
                    Console.ReadKey();
                    return eefreno;
                }
                else if (eefreno == 1)
                {
                    Console.Clear();
                    Console.WriteLine($"Has quitado el freno de mano.");
                    Console.ReadKey();
                    return eefreno;

                }
                else
                {
                    Console.Clear();
                    Console.WriteLine($"Los parámetros ingresados no son validos; Inténtelo de nuevo.");
                    Console.ReadKey();

                }

            }
            catch (Exception eerror)
            {
                Console.WriteLine($"Ah ocurrido un error en el ingreso de datos; Error: \"{eerror}\"");
            }
        }

    }
    else
    {
        for (int kk = 0; kk != -1;)
        {
            try
            {
                Console.Clear();
                Console.WriteLine($"Freno de mano - Estado:");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"No Puesto");
                Console.ResetColor();
                Console.WriteLine($"Siguiente acción:\n1. Ponerlo.\n2. Quitarlo.");
                eefreno = int.Parse(Console.ReadLine()) - 1;
                if (eefreno == 0)
                {
                    Console.Clear();
                    Console.WriteLine($"Has puesto el freno de mano.");
                    Console.ReadKey();
                    return eefreno;
                }
                else if (eefreno == 1)
                {
                    Console.Clear();
                    Console.WriteLine($"Has quitado el freno de mano.");
                    Console.ReadKey();
                    return eefreno;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine($"Los parámetros ingresados no son validos; Inténtelo de nuevo.");
                    Console.ReadKey();
                }

            }
            catch (Exception eerror)
            {
                Console.WriteLine($"Ah ocurrido un error en el ingreso de datos; Error: \"{eerror}\"");
            }
        }
    }
    return eefreno = 0;
}

//Función || Imprimir velocidad de palanca =====================
static void ffnumero_de_velocidad(int eevariint)
{
    if (eevariint == 0)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"N");
        Console.ResetColor();
        //Console.ReadKey();
    }
    else if (eevariint == 6)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"R");
        Console.ResetColor();

        //Console.ReadKey();
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine(eevariint);
        Console.ResetColor();

        //Console.ReadKey();
    }
}

//Función || Verificar si se puede acelerar ====================
static bool ffverificar_si_se_puede_acelerar(int eepalanca, bool eefrenomano)
{
    bool eeresul = false;
    if (eepalanca >= 1 && eepalanca <= 5 && eefrenomano == false)
    {
        eeresul = true;
        return eeresul;
    }
    else
    {
        Console.Clear();
        Console.WriteLine($"Lo siento, no puedes acelerar. Verifica que estés en una velocidad de avance y no tengas el freno de mano puesto.");
        Console.ReadKey();
    }
    return eeresul;
}





//=======================================================================================
//AREA DE DEFINICIONES ==================================================================
//=======================================================================================

int eefreno = 0;
int eepalanca = 0;
int eevelocidad = 0;

int eevariable;

string[] eeacciones = { "Apagar/Encender carro", "Freno de mano", "Palanca de Cambios", "Acelerar", "Desacelerar", "Frenar", "Luces", "Radio" };



//=======================================================================================
//INICIO DEL PROGRAMA ===================================================================
//=======================================================================================






Carro ccarrito = new Carro("Toyota", 2024, "Blanco", "Edgar");

for (int ii = 0; ii != -1;)
{
    try
    {
        Console.Clear();
        Console.WriteLine($"Estás dentro del Carro {ccarrito.owner}. Siguiente Acción:\n1. Encender el carro.\n-1. Salir del carro.");
        int eemenu = int.Parse(Console.ReadLine());
        switch (eemenu)
        {
            case 1:
                for (int jj = 0; jj != -1;)
                {
                    try
                    {
                        Console.Clear();

                        ccarrito.Encender_Apagar();
                        Console.WriteLine($"Estado del carro:");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"Encendido");
                        Console.ResetColor();
                        Console.WriteLine($"Siguiente acción");
                        ffimprimir_string_vector_enumerado(eeacciones);
                        eemenu = int.Parse(Console.ReadLine());
                        //string[] eeacciones = { "Apagar/Encender carro", "Freno de mano", "Palanca de Cambios", "Acelerar", "Desacelerar", "Frenar", "Luces", "Radio" };

                        switch (eemenu)
                        {
                            case 1:
                                Console.Clear();
                                Console.WriteLine($"Has apagado el Carro.");
                                ccarrito.Encender_Apagar();
                                jj = -1;
                                Console.ReadKey();
                                break;
                            case 2:
                                eefreno = fffreno_mano(ccarrito.Freno_de_mano(eefreno));
                                ccarrito.Freno_de_mano(eefreno);

                                break;
                            case 3:
                                for(int kk = 0; kk != -1;)
                                {
                                    try
                                    {
                                        Console.Clear();
                                        Console.WriteLine($"Palanca de cambios - Estado:");
                                        Console.WriteLine($"La velocidad esta en la posición:");
                                        ffnumero_de_velocidad(ccarrito.Palanca_de_los_cambios(eepalanca));

                                        Console.WriteLine($"Siguiente acción: \n0. Neutro.\n1. Primera.\n2. Segunda.\n3. Tercera.\n4. Cuarta.\n5. Quinta.\n6. Reversa.");
                                        eepalanca = int.Parse(Console.ReadLine());
                                        ccarrito.Palanca_de_los_cambios(eepalanca);

                                        Console.WriteLine($"La velocidad esta en la posición:");
                                        ffnumero_de_velocidad(ccarrito.Palanca_de_los_cambios(eepalanca));
                                        Console.ReadKey();
                                        kk = -1;
                                    }
                                    catch (Exception eerror)
                                    {
                                        Console.Clear();
                                        Console.WriteLine($"Ah ocurrido un error en el ingreso de datos; Error: \"{eerror}\"");
                                        Console.ReadKey();
                                    }
                                }
                                break;
                            case 4:
                                bool eebool2 = ffverificar_si_se_puede_acelerar(ccarrito.Palanca_de_los_cambios(eepalanca), ccarrito.Freno_de_mano(eefreno)) ;
                               
                                if (eebool2)
                                {
                                    for (int kk = 0; kk != -1;)
                                    {
                                        eevelocidad = ccarrito.Acelerar();
                                        Console.WriteLine($"{eevelocidad}Km/h");


                                        //Console.WriteLine($"Hola, Soy Batman 1");
                                        //Console.ReadKey();
                                        if (eevelocidad == 40)
                                        {
                                            Console.WriteLine($"Subimos a la velocidad {ccarrito.Cambio_de_velociadad_automatico()}");
                                        }
                                        else if (eevelocidad == 80)
                                        {
                                            Console.WriteLine($"Subimos a la velocidad {ccarrito.Cambio_de_velociadad_automatico()}");

                                        }
                                        else if (eevelocidad == 120)
                                        {
                                            Console.WriteLine($"Subimos a la velocidad {ccarrito.Cambio_de_velociadad_automatico()}");

                                        }
                                        else if (eevelocidad == 160)
                                        {
                                            Console.WriteLine($"Subimos a la velocidad {ccarrito.Cambio_de_velociadad_automatico()}");

                                        }else if (eevelocidad >= 200)
                                        {
                                            Console.WriteLine($"MAXIMA VELOCIDAD ALCANZADA!!!");
                                            Console.ReadKey();

                                        }
                                    }
                                }
                                break;
                            case 5:
                                break;
                            case 6:
                                break;
                            case 7:
                                break;
                            default:
                                break;

                        }




                        Console.ReadKey();
                    }
                    catch (Exception eerror)
                    {
                        Console.WriteLine($"Ah ocurrido un error en el ingreso de datos; Error: \"{eerror}\"");
                    }
                }
                break;
            case 2:
                eefreno = fffreno_mano(ccarrito.Freno_de_mano(eefreno));              
                ccarrito.Freno_de_mano(eefreno);

                break;
            case -1:
                Console.Clear();
                Console.WriteLine($"Has salido del carro.");
                Console.ReadKey();

                ii = -1;
                break;
            default:
                Console.Clear();
                Console.WriteLine($"El valor ingresado no es valido; Inténtelo nuevamente.");
                Console.ReadKey();
                break;
        }
    }
    catch (Exception eerror)
    {
        Console.WriteLine($"Ah ocurrido un error en el ingreso de datos; Error: \"{eerror}\"");
    }

}



/*

cccarrito.Encender();


if (cccarrito.Acelerar() == 0)
{
    Console.WriteLine($"El carro está apagado");
} else
{
    Console.WriteLine(cccarrito.Acelerar() + " km/h");
    Console.WriteLine(cccarrito.Acelerar() + " km/h");
    Console.WriteLine(cccarrito.Acelerar() + " km/h");
}

cccarrito.Encender();
Console.WriteLine(cccarrito.Acelerar() + " km/h");

*/





















/*
//cccarrito.Marca = "Toyota";
//cccarrito.Modelo = 2021;
cccarrito.Color = "Rojo";
cccarrito.owner = "Juan";
cccarrito.MAXVELOCIDAD = 200;

Console.WriteLine($"El carro es un {cccarrito.Marca}");

Console.WriteLine($"Mi segundo carro es un {cccarrito2.Marca}");

Console.ReadKey();


//cccarrito.Marca = "Nissan";
//Console.WriteLine($"El carro es un {cccarrito.Marca}");
//Console.ReadKey();
*/