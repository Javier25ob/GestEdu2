using MySql.Data.MySqlClient;
using System.Text.RegularExpressions;

namespace GestEdu
{
    public partial class frminicioSesiónusuario : Form
    {
        //Crear conexión a base de datos
        string connectionString = "server=localhost;port=3306;user=root;password=;database=db_gestedu";
        public frminicioSesiónusuario()
        {
            InitializeComponent();
            mostrarRol();
        }

        private void frminicioSesiónusuario_Load(object sender, EventArgs e)
        {


        }

        private void btnprobarConexion_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection conexion = new MySqlConnection(connectionString))
                {
                    conexion.Open();
                    MessageBox.Show("Conexion exitosa a la base de datos ", "conectado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conexion.Close();
                }




            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al conectar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
        }
        //Metodos para mostrar enum en comboBox 
        private void mostrarRol()
        {
            //sentencia query
            string query = "SHOW COLUMNS FROM tbl_usuario LIKE 'rol_usuario'";
            //
            List<string> roles = new List<string>();

            //usar la conexion y el query de la base de datos 
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn)) //nueva conexxion segun query
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        string type = reader["Type"].ToString();

                        //Extraer los valores usando regex
                        MatchCollection matches = Regex.Matches(type, @"'([^']*)'");
                        foreach (Match match in matches)
                        {
                            roles.Add(match.Groups[1].Value);
                        }
                    }
                    conn.Close();
                }
            }
            cborolUsuario.DataSource = roles;
        }

        private void btniniciarSesión_Click(object sender, EventArgs e)
        {
            //asignar los datos ingresados a los texbox
            string nombreusuario=txtnombreUsuario.Text;
            string password=txtPassword.Text;
            string rol=cborolUsuario.Text;
            //Mirar si hay valores null o que no se hayan llenado el campo
            if (string.IsNullOrEmpty(nombreusuario) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Los campos deben estar llenos");
            }
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        string query = "SELECT * FROM tbl_usuario WHERE nombre_usuario=@nombreusuario AND password_usuario=@password AND rol_usuario=@rol";
                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@nombreusuario", nombreusuario);
                        cmd.Parameters.AddWithValue("@password", password);
                        cmd.Parameters.AddWithValue("@rol", rol);
                        MySqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            string rolU = reader["rol_usuario"].ToString();
                            MessageBox.Show("Inicio de sesión exitoso. Rol: " + rolU);
                            frmUsuario usuario = new frmUsuario();
                            usuario.ShowDialog();
                            //aqui se puede abrir otro formulario segun el rol

                        }
                        else
                        {
                            MessageBox.Show("Usuario, contraseña o rol incorrecto");


                        }
                        reader.Close();


                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message, "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                
                
                }
            

        }
    }

