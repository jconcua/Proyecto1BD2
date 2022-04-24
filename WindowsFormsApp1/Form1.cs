using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using System.Configuration;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int Id_usuario;

        private void button1_Click(object sender, EventArgs e)
        {
            string connString = "Data Source = (DESCRIPTION = " +
    "(ADDRESS = (PROTOCOL = TCP)(HOST = 25.77.205.156)(PORT = 1521))" +
    "(CONNECT_DATA =" +
      "(SERVER = DEDICATED)" +
      "(SERVICE_NAME = XE)" +
    ")" +
  "); User Id = system; password = #Physical";
            OracleConnection con = new OracleConnection();
            con.ConnectionString = connString;
            // Program.Id_usuarioaux = Id_usuario;
            int Id_rol_usuario;
            int Id_permiso_usuario;

            try
            {
                //Abre la conexión creada a la bd
                con.Open();
                //Con el comando, hace una consulta a la tabla USUARIO 
                OracleCommand comando = new OracleCommand();
                comando.CommandText = "SELECT Id_usuario AS IDUSER, Contrasena, Id_Rol AS rol, Id_Permiso AS permiso FROM USUARIO WHERE ID_USUARIO= :ID_USUARIO AND CONTRASENA= :CONTRASENA";
                comando.Connection = con;
                //Captura los parámetros del txt y los envía a la consulta comando
                String usuario = txtUsuario.Text;
                comando.Parameters.Add(":ID_USUARIO", int.Parse(usuario));
                comando.Parameters.Add(":CONTRASENA", txtContraseña.Text);
                // Aplica el lector a la bd de acuerdo a la consulta de Comando
                OracleDataReader lector = comando.ExecuteReader();
                // Si el lector logra leer los datos, entonces
                if (lector.Read())
                {
                    object I = lector["IDUSER"];
                    Id_usuario = Convert.ToInt32(I);

                    object v = lector["rol"];
                    Id_rol_usuario = Convert.ToInt32(v);

                    object p = lector["permiso"];
                    Id_permiso_usuario = Convert.ToInt32(v);

                    if (Id_rol_usuario == 1 && Id_permiso_usuario ==1)
                    {
                        //MessageBox.Show("Bienvenido " + Id_usuario);
                        // Ejecuta el formulario 2
                        OperacionesSup formulario = new OperacionesSup(Id_usuario);
                        // cierra la conexión creada
                        con.Close();
                        //cierra el presente formulario de login
                        this.Hide();
                        //Muestra el fomulario 2
                        formulario.Show();
                        formulario.StartPosition = FormStartPosition.CenterParent;
                    }

                    if (Id_rol_usuario == 2 && Id_permiso_usuario == 2)
                    {
                        lblBienvenido.Text = ("Bienvenido " + Id_usuario);
                        // Ejecuta el formulario 2
                        Operaciones formulario = new Operaciones(Id_usuario);
                        // cierra la conexión creada
                        con.Close();
                        //cierra el presente formulario de login
                        this.Hide();
                        //Muestra el fomulario 2
                        formulario.Show();
                        formulario.StartPosition = FormStartPosition.CenterParent;
                    }

                    if (Id_rol_usuario == 3 && Id_permiso_usuario == 3)
                    {
                        MessageBox.Show("Bienvenido " + Id_usuario);
                        // Ejecuta el formulario 2
                        EstadoCuenta formulario = new EstadoCuenta(Id_usuario);
                        // cierra la conexión creada
                        con.Close();
                        //cierra el presente formulario de login
                        this.Hide();
                        //Muestra el fomulario 2
                        formulario.Show();
                        formulario.StartPosition = FormStartPosition.CenterParent;

                    }

                }

                else //Si no cumple con la lectura
                {
                    // Muestra un mensaje de usuario o contrasñea no encontrado
                    MessageBox.Show("Usuario o contraseña no encontrado");
                    // cierra la conexión creada
                    con.Close();
                }

            }
            catch(Exception error)
            {
                MessageBox.Show("Error, intentemos de nuevo");
                // Ejecuta el formulario 1
                Form1 formulario = new Form1();
                //cierra el presente formulario de operaciones
                this.Hide();
                //Muestra el fomulario 1
                formulario.Show();

            }


        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {
            txtContraseña.UseSystemPasswordChar = true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
