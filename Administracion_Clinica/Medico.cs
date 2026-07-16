using System;

namespace Administracion_Clinica
{
    public class Medico
    {
        static string codigo = "";
        static string nombre = "";
        static string especialidad = "";
        static int experiencia = 0;
        static string horario = "";

        public static void MenuMedicos()
        {
            string opcion;
            do
            {
                Console.Clear();
                Console.WriteLine("--- Módulo de Médicos ---");
                Console.WriteLine("1. Registrar médico");
                Console.WriteLine("2. Consultar médico");
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
            Console.Write("Código del médico: ");
            codigo = Console.ReadLine();
            Console.Write("Nombre completo: ");
            nombre = Console.ReadLine();
            Console.Write("Especialidad: ");
            especialidad = Console.ReadLine();
            Console.Write("Años de experiencia: ");
            experiencia = int.Parse(Console.ReadLine());
            Console.Write("Horario de atención: ");
            horario = Console.ReadLine();
            Console.WriteLine("\nMédico registrado con éxito. Presione una tecla...");
            Console.ReadKey();
        }

        static void Consultar()
        {
            Console.Clear();
            Console.Write("Ingrese el código del médico a consultar: ");
            string cod = Console.ReadLine();
            if (cod == codigo && codigo != "")
            {
                Mostrar();
            }
            else
            {
                Console.WriteLine("\nMédico no encontrado. Presione una tecla...");
                Console.ReadKey();
            }
        }

        static void Mostrar()
        {
            Console.Clear();
            Console.WriteLine("--- Información del Médico ---");
            if (codigo == "")
            {
                Console.WriteLine("No hay información registrada.");
            }
            else
            {
                Console.WriteLine($"Código: {codigo}");
                Console.WriteLine($"Nombre: {nombre}");
                Console.WriteLine($"Especialidad: {especialidad}");
                Console.WriteLine($"Años de experiencia: {experiencia}");
                Console.WriteLine($"Horario: {horario}");
            }
            Console.WriteLine("\nPresione una tecla para continuar...");
            Console.ReadKey();
        }
    }
}