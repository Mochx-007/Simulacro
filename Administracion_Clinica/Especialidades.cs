
class Especialidades
{
    public string Nombre_Especialidad { get; set; }
    public int Cantidad_Medicos_Asignados { get; set; }
    public int Cantidad_Consultorios_Disponibles { get; set; }
    public string Responsable_Area { get; set; }

    static void Main(string[] args)
    {
        Console.WriteLine("Nombre de la Especialidad: " + especialidad1.Nombre_Especialidad);
        Console.WriteLine("Cantidad de Médicos Asignados: " + especialidad1.Cantidad_Medicos_Asignados);
        Console.WriteLine("Cantidad de Consultorios Disponibles: " + especialidad1.Cantidad_Consultorios_Disponibles);
        Console.WriteLine("Responsable del Área: " + especialidad1.Responsable_Area);
    }
}