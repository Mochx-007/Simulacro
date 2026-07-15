
/*
Restricciones Técnicas
Los estudiantes únicamente podrán utilizar:
	Variables 
	Constantes 
	Funciones (métodos) 
	Estructuras de control anidadas 
	Operaciones aritméticas y lógicas
*/

class program
{
  static void Main(string[] args)
    {
        Console.WriteLine("=========================================");
        Console.WriteLine("CLÍNICA MÉDICA UNICAES");
        Console.WriteLine("Sistema Administrativo");
        Console.WriteLine("=========================================");

        Console.WriteLine("1. Administración de Pacientes");
        Console.WriteLine("2. Administración de Medico");
        Console.WriteLine("3. Administración de Consultorios");
        Console.WriteLine("4. Administración de Citas");
        Console.WriteLine("5. Administración de Especialidades");
        Console.WriteLine("6. Salir");

        LeerOpcion = Console.ReadLine();

        switch (LeerOpcion)
        {
            /*
    Módulo de Pacientes
    Permitir las siguientes operaciones:
    1. Registrar paciente
    2. Consultar paciente
    3. Mostrar información registrada
    4. Regresar
            */
            case "1":
                AdministracionPacientes();

                Console.WriteLine("1.Registrar Paciente");
                Console.WriteLine("2.Consultar Paciente");
                Console.WriteLine("3.Mostrar información registrada");
                Console.WriteLine("4.Regresar");
                LeerOpcion = Console.ReadLine();

                switch (LeerOpcion)

                /*
        Información solicitada:
    	Número de expediente 
    	Nombre completo 
      	Edad 
    	Sexo 
    	Tipo de sangre 
    	Número de teléfono
                */
                {
                    case "1":
                        RegistrarPaciente();
                        Console.WriteLine("Escriba el número de expediente del paciente:");
                        paciente1.Numero_Expediente = int.Parse(Console.ReadLine());
                        Console.WriteLine("Escriba el nombre completo del paciente:");
                        paciente1.Nombre_Completo = Console.ReadLine();
                        Console.WriteLine("Escriba la edad del paciente:");
                        paciente1.Edad = int.Parse(Console.ReadLine());
                        Console.WriteLine("Escriba el sexo del paciente:");
                        paciente1.Sexo = Console.ReadLine();
                        Console.WriteLine("Escriba el tipo de sangre del paciente:");
                        paciente1.Tipo_Sangre = Console.ReadLine();
                        Console.WriteLine("Escriba el número de teléfono del paciente:");
                        paciente1.Telefono = int.Parse(Console.ReadLine());
                        Console.WriteLine("Paciente registrado exitosamente."); 

                        break;
                    case "2":
                        ConsultarPaciente();
                        Console.WriteLine("Escriba el número de expediente del paciente a consultar:");
                        int Numero_Expediente = int.Parse(Console.ReadLine());
                        if (Numero_Expediente == paciente1.Numero_Expediente)
                        {
                            Console.WriteLine("Número de Expediente: " + paciente1.Numero_Expediente);
                            Console.WriteLine("Nombre Completo: " + paciente1.Nombre_Completo);
                            Console.WriteLine("Edad: " + paciente1.Edad);
                            Console.WriteLine("Sexo: " + paciente1.Sexo);
                            Console.WriteLine("Tipo de Sangre: " + paciente1.Tipo_Sangre);
                            Console.WriteLine("Teléfono: " + paciente1.Telefono);
                        }
                        else
                        {
                            Console.WriteLine("Paciente no encontrado.");
                        }
                        break;
                    case "3":
                        MostrarInformacionRegistrada();
                       if (paciente1.Numero_Expediente != 0)
                        {
                            Console.WriteLine("Número de Expediente: " + paciente1.Numero_Expediente);
                            Console.WriteLine("Nombre Completo: " + paciente1.Nombre_Completo);
                            Console.WriteLine("Edad: " + paciente1.Edad);
                            Console.WriteLine("Sexo: " + paciente1.Sexo);
                            Console.WriteLine("Tipo de Sangre: " + paciente1.Tipo_Sangre);
                            Console.WriteLine("Teléfono: " + paciente1.Telefono);
                        }
                        else
                        {
                            Console.WriteLine("No hay información registrada.");
                        }
                        break;
                    case "4":
                        Console.WriteLine("Regresando al menú principal...");
                        break;
                    default:
                        Console.WriteLine("Opción inválida. Por favor, seleccione una opción válida.");
                        break;
                }
                break;
            case "2":
                AdministracionMedico();
                break;
            case "3":
                AdministracionConsultorios();
                break;
            case "4":
                AdministracionCitas();
                break;
            case "5":
                AdministracionEspecialidades();
                break;
            case "6":
                Console.WriteLine("Saliendo del sistema...");
                break;
            default:
                Console.WriteLine("Opción inválida. Por favor, seleccione una opción válida.");
                break;
        }
    }
}