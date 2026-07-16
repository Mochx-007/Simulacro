using System;

namespace Administracion_Clinica
{
    public class Consultorios
    {
        public static void MenuConsultorios()
        {
            Console.Clear();
            Console.WriteLine("--- Módulo de Consultorios ---");
            
            Console.Write("Número de consultorio: ");
            string numero = Console.ReadLine();
            Console.Write("Piso: ");
            string piso = Console.ReadLine();
            Console.Write("Capacidad de pacientes en espera: ");
            int capacidad = int.Parse(Console.ReadLine());
            Console.Write("Cantidad de pacientes esperando: ");
            int esperando = int.Parse(Console.ReadLine());
            Console.Write("Consultorio disponible (Sí/No): ");
            string disponible = Console.ReadLine();

            Console.Clear();
            Console.WriteLine("Información del Consultorio");
            Console.WriteLine($"Consultorio: {numero} (Piso {piso})");
            Console.WriteLine($"Estado: {(disponible.ToLower() == "si" ? "Disponible" : "No Disponible")}");
            
            int espaciosDisponibles = capacidad - esperando;
            
            if (esperando > capacidad)
            {
                Console.WriteLine(" La cantidad de pacientes supera la capacidad de la sala de espera.");
            }
            else
            {
                Console.WriteLine($"Espacios disponibles en sala de espera: {espaciosDisponibles}");
            }
            
            Console.WriteLine("Presione una tecla para regresar al menú principal...");
            Console.ReadKey();
        }
    }
}