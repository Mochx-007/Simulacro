using System;

namespace Administracion_Clinica
{
    public class Especialidades
    {
        public static void MenuEspecialidades()
        {
            Console.Clear();
            Console.WriteLine("--- Módulo de Especialidades ---");
            
            Console.Write("Nombre de la especialidad: ");
            string nombre = Console.ReadLine();
            Console.Write("Cantidad de médicos asignados: ");
            int medicos = int.Parse(Console.ReadLine());
            Console.Write("Cantidad de consultorios disponibles: ");
            int consultorios = int.Parse(Console.ReadLine());
            Console.Write("Responsable del área: ");
            string responsable = Console.ReadLine();

            Console.Clear();
            Console.WriteLine("Información de Especialidad Registrada");
            Console.WriteLine($"Especialidad: {nombre}");
            Console.WriteLine($"Médicos Asignados: {medicos}");
            Console.WriteLine($"Consultorios Disponibles: {consultorios}");
            Console.WriteLine($"Responsable: {responsable}");
            
            Console.WriteLine("Presione una tecla para regresar al menú principal...");
            Console.ReadKey();
        }
    }
}