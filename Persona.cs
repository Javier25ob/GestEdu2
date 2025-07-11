using System;

public class Persona
{
    //Atributos
    public int idPersona { get; set; }
    public string nombre { get; set; }
    public string apellidoPersona { get; set; }
    public string direcciónPersona { get; set; }


    //constructor Vacio
    public Persona() { }

    //Constructor

    public Persona(int idPersona, string nombre, string apellidoPersona, string direccionPersona)
    {
        this.idPersona = idPersona;
        this.nombre = nombre;
        this.apellidoPersona = apellidoPersona;
        this.direcciónPersona = direccionPersona;
    }

    public virtual void mostrarPerfilcompleto() {
        Console.WriteLine($"Id: {idPersona}, Nombre y apellidos: {nombre} {apellidoPersona}, dirección: {direcciónPersona} ");
    
    
    }

}
