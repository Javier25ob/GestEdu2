using System;

public class Docente:Persona
{
	//Atributos
	//public string direccionDocente {  get; set; }
	public double salarioDocente {  get; set; }
	public string profesiónDocente { get; set; }
	//Constructor vacio
	public Docente() { }
    //Contructor con parametros
    public Docente( double salarioDocente) {
		//this.direccionDocente = direccionDocente;
		this.salarioDocente = salarioDocente;
	}
    //Metodo
    public override void mostrarPerfilcompleto()
    {
        base.mostrarPerfilcompleto();
		Console.WriteLine($"La profesión del docente es: {profesiónDocente} y su salario es: {salarioDocente}");
    }
}
