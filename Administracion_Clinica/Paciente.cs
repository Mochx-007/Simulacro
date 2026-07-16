using System;
using System.Collections.Generic;

namespace Administracion_Clinica
{
    public class Paciente
    {
        static string expediente = "";
        static string nombre = "";
        static int edad = 0;
        static string sexo = "";
        static string tipoSangre = "";
        static string telefono = "";

        public static void MenuPacientes()
        {
            string opcion;
            do
            {
                Console.Clear();
                Console.WriteLine(" Módulo de Pacientes ");
                Console.WriteLine("1. Registrar paciente");
                Console.WriteLine("2. Consultar paciente");
                Console.WriteLine("3. Mostrar información registrada");
                Console.WriteLine("4. Regresar");
                Console.Write("Seleccione una opción: ");
                opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1": Registrar(); break;
                    case "2": Consultar(); break;
                    case "3": Mostrar(); break;
                    case "4": break;
                    default: Console.WriteLine("Opción inválida."); Console.ReadKey(); break;
                }
            } while (opcion != "4");
        }

        static void Registrar()
        {
            Console.Clear();
            Console.Write("Número de expediente: ");
            expediente = Console.ReadLine();
            Console.Write("Nombre completo: ");
            nombre = Console.ReadLine();
            Console.Write("Edad: ");
            edad = int.Parse(Console.ReadLine());
            Console.Write("Sexo: ");
            sexo = Console.ReadLine();
            Console.Write("Tipo de sangre: ");
            tipoSangre = Console.ReadLine();
            Console.Write("Número de teléfono: ");
            telefono = Console.ReadLine();
            Console.WriteLine("\nPaciente registrado con éxito. Presione una tecla...");
            Console.ReadKey();
        }

        static void Consultar()
        {
            Console.Clear();
            Console.Write("Ingrese el número de expediente: ");
            string exp = Console.ReadLine();
            if (exp == expediente && expediente != "")
            {
                Mostrar();
            }
            else
            {
                Console.WriteLine("Paciente no encontrado. ");
                Console.ReadKey();
            }
        }

        static void Mostrar()
        {
            Console.Clear();
            Console.WriteLine(" Información del Paciente ");
            if (expediente == "")
            {
                Console.WriteLine("No hay información registrada.");
            }
            else
            {
                Console.WriteLine($"Expediente: {expediente}");
                Console.WriteLine($"Nombre: {nombre}");
                Console.WriteLine($"Edad: {edad}");
                Console.WriteLine($"Sexo: {sexo}");
                Console.WriteLine($"Tipo de sangre: {tipoSangre}");
                Console.WriteLine($"Teléfono: {telefono}");
            }
            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey();
        }
    }
}