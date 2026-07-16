using System;

namespace Administracion_Clinica
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("=========================================");
                Console.WriteLine(" CLÍNICA MÉDICA UNICAES");
                Console.WriteLine(" Sistema Administrativo");
                Console.WriteLine("=========================================");
                Console.WriteLine("1. Administración de Pacientes");
                Console.WriteLine("2. Administración de Médicos");
                Console.WriteLine("3. Administración de Consultorios");
                Console.WriteLine("4. Administración de Citas");
                Console.WriteLine("5. Administración de Especialidades");
                Console.WriteLine("6. Salir");
                Console.Write("Seleccione una opción: ");
                
                if (int.TryParse(Console.ReadLine(), out opcion))
                {
                    switch (opcion)
                    {
                        case 1: 
                        Paciente.MenuPacientes(); 
                        break;
                        case 2: 
                        Medico.MenuMedicos();
                         break;
                        case 3: 
                        Consultorios.MenuConsultorios(); 
                        break;
                        case 4:
                         Citas_Medicas.MenuCitas(); 
                         break;
                        case 5: 
                        Especialidades.MenuEspecialidades();
                         break;
                        case 6:
                         Console.WriteLine("Saliendo del sistema..."); 
                         break;
                        default: 
                            Console.WriteLine("Opción no válida. Presione cualquier tecla para continuar."); 
                            Console.ReadKey(); 
                            break;
                    }
                }
            } while (opcion != 6);
        }
    }
}