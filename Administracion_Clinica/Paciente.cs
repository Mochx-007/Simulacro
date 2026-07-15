class paciente
{
    public int Numero_Expediente { get; set; }
    public string Nombre_Completo { get; set; }
    public int Edad { get; set; }
    public string Sexo { get; set; }
    public string Tipo_Sangre { get; set; }
    public int Telefono { get; set; }

    static void Main(string[] args)
    {
   
        Console.WriteLine("Número de Expediente: " + paciente1.Numero_Expediente);
        Console.WriteLine("Nombre Completo: " + paciente1.Nombre_Completo);
        Console.WriteLine("Edad: " + paciente1.Edad);
        Console.WriteLine("Sexo: " + paciente1.Sexo);
        Console.WriteLine("Tipo de Sangre: " + paciente1.Tipo_Sangre);
        Console.WriteLine("Teléfono: " + paciente1.Telefono);

    }
 
}