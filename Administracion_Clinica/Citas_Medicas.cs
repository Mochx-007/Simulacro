using System;

namespace Administracion_Clinica
{
    public class Citas_Medicas
    {
        public static void MenuCitas()
        {
            Console.Clear();
            Console.WriteLine("--- Módulo de Citas Médicas ---");
            
            Console.Write("Número de cita: ");
            string numero = Console.ReadLine();
            Console.Write("Nombre del paciente: ");
            string paciente = Console.ReadLine();
            Console.Write("Nombre del médico: ");
            string medico = Console.ReadLine();
            Console.Write("Fecha (DD/MM/AAAA): ");
            string fecha = Console.ReadLine();
            Console.Write("Hora: ");
            string hora = Console.ReadLine();
            Console.Write("Tipo de consulta (General o Especializada): ");
            string tipo = Console.ReadLine();

            Console.Clear();
            Console.WriteLine("--- Cita Registrada Correctamente ---");
            Console.WriteLine($"Número de cita: {numero}");
            Console.WriteLine($"Paciente: {paciente}");
            Console.WriteLine($"Médico: {medico}");
            Console.WriteLine($"Fecha: {fecha} | Hora: {hora}");
            Console.WriteLine($"Tipo: {tipo}");
            
            Console.WriteLine("\nPresione una tecla para regresar al menú principal...");
            Console.ReadKey();
        }
    }
}