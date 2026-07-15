class Medico
{
    public int Codigo_Medico { get; set; }
    public string Nombre_Completo { get; set; }
    public string Especialidad { get; set; }
    public int Años_Experiencia { get; set; }
    public int Horario_Atencion { get; set; }

    static void Main(string[] args)
    {

        Console.WriteLine("Código de Médico: " + medico1.Codigo_Medico);
        Console.WriteLine("Nombre Completo: " + medico1.Nombre_Completo);
        Console.WriteLine("Especialidad: " + medico1.Especialidad);
        Console.WriteLine("Años de Experiencia: " + medico1.Años_Experiencia);
        Console.WriteLine("Horario de Atención: " + medico1.Horario_Atencion);
    }
}