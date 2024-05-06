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
        }

    }