using System;

public class Usuario
{
    //Atributos
    public int idUsuario { get; set; }
    public string nombreUsuario { get; set; }
    public string emailUsuario { get; set; }
    public string rolUsuario { get; set; }
    public string passwordUsuario { get; set; }

    //Contructor Vacio
    public Usuario() { }

    //Contructor Atributos 
    public Usuario(int idUsuario,string nombreUsuario,string emailUsuario,string rolUsuario, string passwordUsuario) {
        this.nombreUsuario = nombreUsuario;
        this.emailUsuario = emailUsuario;
        this.rolUsuario = rolUsuario;
        this.passwordUsuario = passwordUsuario;
    }
    //Metodo




}
