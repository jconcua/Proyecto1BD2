﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OracleClient;
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
        //Crea una conexión a la BD
        OracleConnection conexion = new OracleConnection("Data source = xe; Password = #Physical; User ID = SYSTEM");
        
        private void button1_Click(object sender, EventArgs e)
        {


            try
            {

                //Abre la conexión creada a la bd
                conexion.Open();
                //Con el comando, hace una consulta a la tabla USUARIO 
                OracleCommand comando = new OracleCommand("SELECT Id_usuario, Contrasena, Id_Rol FROM USUARIO WHERE ID_USUARIO= :ID_USUARIO AND CONTRASENA= :CONTRASENA", conexion);
                //Captura los parámetros del txt y los envía a la consulta comando
                String usuario = txtUsuario.Text;
                comando.Parameters.AddWithValue(":ID_USUARIO", int.Parse(usuario));
                comando.Parameters.AddWithValue(":CONTRASENA", txtContraseña.Text);

                // Aplica el lector a la bd de acuerdo a la consulta de Comando
                OracleDataReader lector = comando.ExecuteReader();

                // Si el lector logra leer los datos, entonces
                if (lector.Read())
                {
                    // Ejecuta el formulario 2
                    Operaciones formulario = new Operaciones();
                    // cierra la conexión creada
                    conexion.Close();
                    //cierra el presente formulario de login
                    this.Hide();
                    //Muestra el fomulario 2
                    formulario.Show();
                    formulario.StartPosition = FormStartPosition.CenterParent;
                }

                else //Si no cumple con la lectura
                {
                    // Muestra un mensaje de usuario o contrasñea no encontrado
                    MessageBox.Show("Usuario o contraseña no encontrado");
                    // cierra la conexión creada
                    conexion.Close();
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