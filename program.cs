using System;
using System.Reflection.Metadata.Ecma335;
using System.Reflection.PortableExecutable;
using System.Runtime.InteropServices;
internal class Program
    {
        static void Main(string[] args)
        {
            

            const string
                PREGUNTAR_OPCION_MENU = "Ingrese un numero según lo que quiera realizar: 1. CargarDatosSuperheroe1, 2. CargarDatosSuperheroe2, 3. Competir, 4. Cambiar Atributos, 5. Salir";
            const double
                AMPLIA_DIFERENCIA = 30,
                PAREJO = 10,
                NO_LE_SOBRO_NADA = 0;
            const int
                CARGAR_DATOS_SUPERHEROE_1 = 1,
                CARGAR_DATOS_SUPERHEROE_2 = 2,
                COMPETIR = 3,
                CAMBIAR_ATRIBUTOS = 4,
                SALIR = 5;
            const char
                SI = 's',
                NO = 'n';
            string nombreSuper;
            int opcionMenu;
            Superheroe superheroe1 = null;
            Superheroe superheroe2 = null;
            double skillSuperheroe1, skillSuperheroe2, diferenciaSkills;
            char respuesta;

             opcionMenu = IngresarOpcionMenu(PREGUNTAR_OPCION_MENU, CARGAR_DATOS_SUPERHEROE_1, CARGAR_DATOS_SUPERHEROE_2, COMPETIR,CAMBIAR_ATRIBUTOS, SALIR);
            while(opcionMenu != SALIR)
            {
                switch(opcionMenu)
                {
                    case CARGAR_DATOS_SUPERHEROE_1:
                    superheroe1 = ObtenerSuperheroe();
                    Console.WriteLine("Se ha creado el superhéroe " + superheroe1.Nombre);
                    break;

                    case CARGAR_DATOS_SUPERHEROE_2:
                    superheroe2 = ObtenerSuperheroe();
                    Console.WriteLine("Se ha creado el superhéroe " + superheroe2.Nombre);
                    break;

                    case COMPETIR:

                    break;

                    case CAMBIAR_ATRIBUTOS:

                    break;

                    case SALIR:

                    break;

                }
        }

        
        static int IngresarOpcionMenu(string mensaje, int opcion1, int opcion2, int opcion3, int opcion4, int opcion5)
        {
            Console.WriteLine(mensaje);
            int respuesta = int.Parse(Console.ReadLine());
            while(respuesta != opcion1 && respuesta != opcion2 && respuesta != opcion3 && respuesta != opcion4 && respuesta != opcion5)
            {
                Console.WriteLine("Hubo un error en el ingreso. " + mensaje);
                respuesta = int.Parse(Console.ReadLine());
            }

            return respuesta;
        }
        static double IngresarAtributoSuperheroe(string mensaje)
        {
            Console.Write(mensaje);
            double atributo = int.Parse(Console.ReadLine());
            while (atributo < 0 && atributo > 100 )
            {
                Console.Write("Hubo un error en el ingreso. Recordá que el atributo tiene que estar entre los valores 1 y 100. " + mensaje);
                atributo = int.Parse(Console.ReadLine());
            }

            return atributo;
        }

        static double IngresarNumeroPositivo(string mensaje)
        {
            Console.Write(mensaje);
            double num = double.Parse(Console.ReadLine());
            while(num < 0)
            {
                Console.Write("Hubo un error en el ingreso. Recordá que el numero tiene que ser mayor a cero. " + mensaje);
                num = double.Parse(Console.ReadLine());
            }

            return num;
        }

        static string IngresarString(string mensaje)
        {
            Console.Write(mensaje);
            mensaje = Console.ReadLine();
            return mensaje;
        }

         static Superheroe ObtenerSuperheroe()
        {
            Console.WriteLine("Se está creando un superheroe:");
            string nombre = IngresarString("Ingrese el nombre: ");
            string ciudad = IngresarString("Ingrese la ciudad: ");
            double peso = IngresarNumeroPositivo("Ingrese el peso: ");
            double fuerza = IngresarAtributoSuperheroe("Ingrese la fuerza: ");
            double velocidad = IngresarAtributoSuperheroe("Ingrese la velocidad: ");
            double inteligencia = IngresarAtributoSuperheroe("Ingrese la inteligencia: ");

            Superheroe superheroe = new Superheroe(nombre, ciudad, peso, fuerza, velocidad, inteligencia);
            return superheroe;
        }

        static void MostrarGanador(double diferenciaSkills, Superheroe superheroe1, Superheroe superheroe2, double AMPLIA_DIFERENCIA, double PAREJO, double NO_LE_SOBRO_NADA)
        {
            if(diferenciaSkills >= AMPLIA_DIFERENCIA)
                        {
                            Console.WriteLine($"Ganó {superheroe1.Nombre} por amplia diferencia.");
                        }

                        else if(diferenciaSkills >= PAREJO)
                        {
                            Console.WriteLine($"Ganó {superheroe1.Nombre}. ¡Fue muy parejo!");
                        }

                        else if(diferenciaSkills > NO_LE_SOBRO_NADA)
                        {
                            Console.WriteLine($"Ganó {superheroe1.Nombre}. ¡No le sobró nada!");
                        }

                        else if(diferenciaSkills <= -AMPLIA_DIFERENCIA)
                        {
                            Console.WriteLine($"Ganó {superheroe2.Nombre} por amplia diferencia.");
                        }

                        else if(diferenciaSkills <= -PAREJO)
                        {
                            Console.WriteLine($"Ganó {superheroe2.Nombre}. ¡Fue muy parejo!");
                        }

                        else if(diferenciaSkills < NO_LE_SOBRO_NADA)
                        {
                            Console.WriteLine($"Ganó {superheroe1.Nombre}. ¡No le sobró nada!");
                        }

                        else
                        {
                            Console.WriteLine("¡Empataron!");
                        }
        }

        static string IngresarNombreSuperheroe(string mensaje, Superheroe superheroe1, Superheroe superheroe2)
        {
            Console.WriteLine(mensaje);
            string nombreSuper = Console.ReadLine();
            while(nombreSuper != superheroe1.Nombre && nombreSuper != superheroe2.Nombre)
            {
                Console.WriteLine($"Hubo un error en el ingreso. Recordá que el nombre de los superheroes son: {superheroe1.Nombre} y {superheroe2.Nombre}. {mensaje}");
                nombreSuper = Console.ReadLine();
            }

            return nombreSuper;
        }

        static char ResponderSiOno(string mensaje, char SI, char NO)
        {
            Console.WriteLine(mensaje);
            char respuesta = char.Parse(Console.ReadLine());
            while(respuesta != SI && respuesta != NO)
            {
                Console.WriteLine("Hubo un error en el ingreso. " + mensaje);
            }

            return respuesta;
        }

    }