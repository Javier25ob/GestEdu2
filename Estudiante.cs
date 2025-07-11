using System;

public class Estudiante:Persona
{
    //Atributos
    public string matrículaEstudiante { get; set; }
    public float promedioEstudiante { get; set; }
    //Contructor Vacio
    public Estudiante()
    {

    }
    //Contructor 
    public Estudiante(string matriculaEstudiante, float promedioEstudiante)
    {
        this.matrículaEstudiante = matrículaEstudiante;
        this.promedioEstudiante = promedioEstudiante;
    }
    
    //Metodo con polimorfismo
    public override void mostrarPerfilcompleto()
    {
        base.mostrarPerfilcompleto();
        Console.WriteLine($" La Matrícula es:  {matrículaEstudiante} y el promedio es: {promedioEstudiante:F1}");
    }

}
