using System;
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
    public partial class EstadoCuenta : Form
    {
        public EstadoCuenta(int Id_usuario)
        {
            InitializeComponent();
            this.Id_usuario = Id_usuario;
        }

        int Id_usuario;
        private void btnBuscarCuenta_Click(object sender, EventArgs e)
        {

            float NoCuenta;
            float Monto;
            NoCuenta = float.Parse(txtNoCuenta.Text);


            //Crea una conexión a la BD
            OracleConnection conexion = new OracleConnection("Data source = xe; Password = #Physical; User ID = SYSTEM");

            //Abre la conexión creada a la bd
            conexion.Open();

            //Con el comando, hace una consulta a la tabla USUARIO 
            //OracleCommand comando = new OracleCommand("SELECT * FROM CUENTA WHERE NO_CUENTA= :No_cuenta", conexion);

            OracleCommand comando = new OracleCommand("SELECT c.NO_CUENTA AS CUENTA, cl.NOMBRE_CLIENTE AS CLIENTE, tc.NOMBRE_TIPO_CUENTA AS TIPO_CUENTA, c.Saldo AS SCUENTA FROM CUENTA c, Cliente cl, TIPO_CUENTA tc WHERE c.ID_CLIENTE=cl.ID_CLIENTE AND c.ID_TIPO=tc.ID_Tipo_Cuenta AND NO_CUENTA= :No_cuenta", conexion);

            //Captura los parámetros del txt y los envía a la consulta comando
            comando.Parameters.AddWithValue(":No_cuenta", txtNoCuenta.Text);

            // Aplica el lector a la bd de acuerdo a la consulta de Comando
            OracleDataReader lector = comando.ExecuteReader();

            // Si el lector logra leer los datos, entonces
            if (lector.Read())
            {

                lblNombrecuenta.Text = lector["CLIENTE"].ToString();
                lbltipocuenta.Text = lector["TIPO_CUENTA"].ToString();
                lblsaldo.Text = lector["SCUENTA"].ToString();

                OracleCommand comandodeptrans = new OracleCommand("TRANSACCIONES_CONSULTASALD", conexion);
                comandodeptrans.CommandType = System.Data.CommandType.StoredProcedure;
                comandodeptrans.Parameters.Add("TRANS", OracleType.Number).Value = 1;
                comandodeptrans.Parameters.Add("OPERACION", OracleType.Number).Value = 1;
                comandodeptrans.Parameters.Add("CUENTA", OracleType.Number).Value = NoCuenta;
                comandodeptrans.Parameters.Add("USUARIO", OracleType.Number).Value = Id_usuario;

                comandodeptrans.ExecuteNonQuery();

                MessageBox.Show("cuenta válida");

                // cierra la conexión creada
                conexion.Close();

            }
            else
            {
                MessageBox.Show("Cuenta no válida");
                // cierra la conexión creada
                conexion.Close();
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            // Ejecuta el formulario operaciones
            Form1 formulario = new Form1();
            //cierra el presente formulario de operaciones
            this.Hide();
            //Muestra el fomulario 1
            formulario.Show();
        }
    }
}
