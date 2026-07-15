class Citas_Medicas
{
    public int Numero_Cita { get; set; }
    public string Nombre_Paciente { get; set; }
    public string Nombre_Medico { get; set; }
    public string Fecha { get; set; }
    public string Hora { get; set; }
    
    //	Tipo de consulta (General o Especializada) 
    public string Tipo_Consulta { get; set; }

    static void Main(string[] args)
    {
        Console.WriteLine("Número de Cita: " + cita1.Numero_Cita);
        Console.WriteLine("Nombre del Paciente: " + cita1.Nombre_Paciente);
        Console.WriteLine("Nombre del Médico: " + cita1.Nombre_Medico);
        Console.WriteLine("Fecha: " + cita1.Fecha);
        Console.WriteLine("Hora: " + cita1.Hora);
        Console.WriteLine("Tipo de Consulta: " + cita1.Tipo_Consulta);
    }
    
  

    

}