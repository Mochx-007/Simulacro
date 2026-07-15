class Consultorios
{
    public int Numero_Consultorio { get; set; }
    public int Piso { get; set; }
    public int Capacidad_de_Pacientes_en_Espera { get; set; }
    public bool Consultorio_Disponible { get; set; }

    static void Main(string[] args)
    {
        Console.WriteLine("Número de Consultorio: " + consultorio1.Numero_Consultorio);
        Console.WriteLine("Piso: " + consultorio1.Piso);
        Console.WriteLine("Capacidad de Pacientes en Espera: " + consultorio1.Capacidad_de_Pacientes_en_Espera);
        Console.WriteLine("Consultorio Disponible: " + consultorio1.Consultorio_Disponible);
    }

}