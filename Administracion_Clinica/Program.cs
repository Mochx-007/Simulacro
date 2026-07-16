class program
{
        list <Paciente> pacientes = new list<Paciente>();

        list <Medico> medicos = new list<Medico>();

        list <Consultorio> consultorios = new list<Consultorio>();}


    static void Main(string[] args)
    {
        MenuPrincipal();
    }

    static void MenuPrincipal()
    {
        string opcion;
        do
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
            Console.Write("Seleccione una opción: ");
            opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    AdministracionPacientes();
                    break;
                case "2":
                    AdministracionMedicos();
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
                    Console.WriteLine("Opción no válida. Intente de nuevo.");
                    break;

            }
        } while (opcion != "6");
    }

    private static void AdministracionCitas()
    {
        throw new NotImplementedException();
    }

    static void AdministracionPacientes()
    {
        string opcion;
        do
        {
            Console.WriteLine("1. Registrar Paciente");
            Console.WriteLine("2. Consultar Paciente");
            Console.WriteLine("3. Mostrar información registrada");
            Console.WriteLine("4. Regresar");

            opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    RegistrarPaciente();
                    break;
                case "2":
                    ConsultarPaciente();
                    break;
                case "3":
                    MostrarInformacionRegistrada();
                    break;
                case "4":
                    // No hace nada, simplemente saldrá del bucle y regresará al menú principal.
                    break;
                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }
        } while (opcion != "4");
    }

    static void RegistrarPaciente()
    {
        Console.Write("Escriba el número de expediente del paciente: ");
        paciente1.Numero_Expediente = int.Parse(Console.ReadLine());
        Console.Write("Escriba el nombre completo del paciente: ");
        paciente1.Nombre_Completo = Console.ReadLine();
        Console.Write("Escriba la edad del paciente: ");
        paciente1.Edad = int.Parse(Console.ReadLine());
        Console.Write("Escriba el sexo del paciente: ");
        paciente1.Sexo = Console.ReadLine();
        Console.Write("Escriba el tipo de sangre del paciente: ");
        paciente1.Tipo_Sangre = Console.ReadLine();
        Console.Write("Escriba el número de teléfono del paciente: ");
        paciente1.Telefono = int.Parse(Console.ReadLine());
        Console.WriteLine("Paciente registrado exitosamente.");
    }

    static void ConsultarPaciente()
    {
        Console.WriteLine(" Consultar Paciente ");
        Console.Write("Escriba el número de expediente del paciente a consultar: ");
        int numeroExpediente = int.Parse(Console.ReadLine());
        if (numeroExpediente == paciente1.Numero_Expediente && paciente1.Numero_Expediente != 0)
        {
            MostrarInformacionRegistrada();
        }
        else
        {
            Console.WriteLine("Paciente no encontrado o no registrado.");
        }
    }

    static void MostrarInformacionRegistrada()
    {
        if (paciente1.Numero_Expediente != 0)
        {
            Console.WriteLine($"Número de Expediente: {paciente1.Numero_Expediente}\nNombre Completo: {paciente1.Nombre_Completo}\nEdad: {paciente1.Edad}\nSexo: {paciente1.Sexo}\nTipo de Sangre: {paciente1.Tipo_Sangre}\nTeléfono: {paciente1.Telefono}");
        }
        else
        {
            Console.WriteLine("No hay información de paciente registrada.");
        }
    }

    static void AdministracionEspecialidades()
    {
        Console.WriteLine("1. Registrar nombre de la especialidad.");
    }

    static void AdministracionMedicos()
    {
        string opcion;
        do
        {
            Console.WriteLine("1. Registrar Médico");
            Console.WriteLine("2. Consultar Médico");
            Console.WriteLine("3. Mostrar información registrada");
            Console.WriteLine("4. Regresar");

            opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    RegistrarMedico();
                    break;
                case "2":
                    ConsultarMedico();
                    break;
                case "3":
                    MostrarInformacionMedicoRegistrada();
                    break;
                case "4":
                    // No hace nada, simplemente saldrá del bucle y regresará al menú principal.
                    break;
                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }
        } while (opcion != "4");
    }

    static void RegistrarMedico()
    {
        Console.Write("Escriba el código del médico: ");
        medico1.Codigo_Medico = int.Parse(Console.ReadLine());
        Console.Write("Escriba el nombre completo del médico: ");
        medico1.Nombre_Completo = Console.ReadLine();
        Console.Write("Escriba la especialidad del médico: ");
        medico1.Especialidad = Console.ReadLine();
        Console.Write("Escriba los años de experiencia del médico: ");
        medico1.Años_Experiencia = int.Parse(Console.ReadLine());
        Console.Write("Escriba el horario de atención del médico (ej. 8-12): ");
        medico1.Horario_Atencion = Console.ReadLine();
        Console.WriteLine("Médico registrado exitosamente.");
    }

    static void ConsultarMedico()
    {
        Console.Write("Ingrese el código del médico a consultar: ");
        int codigoMedico = int.Parse(Console.ReadLine());
        if (codigoMedico == medico1.Codigo_Medico && medico1.Codigo_Medico != 0)
        {
            MostrarInformacionMedicoRegistrada();
        }
        else
        {
            Console.WriteLine("Médico no encontrado o no registrado.");
        }
    }

    static void MostrarInformacionMedicoRegistrada()
    {
        if (medico1.Codigo_Medico != 0)
        {
            Console.WriteLine($"Código: {medico1.Codigo_Medico}\nNombre Completo: {medico1.Nombre_Completo}\nEspecialidad: {medico1.Especialidad}\nAños de Experiencia: {medico1.Años_Experiencia}\nHorario de Atención: {medico1.Horario_Atencion}");
        }
        else
        {
            Console.WriteLine("No hay información de médico registrada.");
        }
    }

    static void AdministracionConsultorios()
    {
        string opcion;
        do
        {
            Console.WriteLine("1. Registrar Consultorio");
            Console.WriteLine("2. Mostrar información registrada");
            Console.WriteLine("3. Regresar");

            switch (opcion)
            {
                case "1":
                    RegistrarConsultorio();
                    break;
                case "2":
                    MostrarInformacionConsultorioRegistrada();
                    break;
                case "3":
                    // No hace nada, simplemente saldrá del bucle y regresará al menú principal.
                    break;
                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }
        } while (opcion != "3");

        RegistrarConsultorio();
        Console.WriteLine("Escriba el número del consultorio ");
        Consultorio1.Numero_Consultorio = int.Parse(Console.ReadLine());
        Console.WriteLine("Escriba el numero de piso del consultorio ");
        Consultorio1.Numero_Piso = int.Parse(Console.ReadLine());
        Console.WriteLine("Escriba la cantidad de pacientes en espera");
        Consultorio1.Cantidad_Pacientes_En_Espera = int.Parse(Console.ReadLine());
        Console.WriteLine("Escriba la cantidad de pacientes esperando");
        Consultorio1.Cantidad_Pacientes_Atendidos = int.Parse(Console.ReadLine());
        Console.WriteLine("Consultorio disponible (Si/No)");
        Consultorio1.Disponibilidad = Console.ReadLine();


    }


}
