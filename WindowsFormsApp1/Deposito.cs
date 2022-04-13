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
    public partial class Deposito : Form
    {
        public Deposito()
        {
            InitializeComponent();
            cmbxformapago.DataSource = DatosFormaPago();
            cmbxformapago.DisplayMember = "NOMBRE_FORMA_PAGO";
        }

        public DataTable DatosFormaPago()
        {
            //Crea una conexión a la BD
            OracleConnection conexion = new OracleConnection("Data source = xe; Password = #Physical; User ID = SYSTEM");

            //Crea una tala data
            DataTable dt = new DataTable();
            //Abre la conexión creada a la bd
            conexion.Open();
            //Con el comando, hace una consulta a la tabla USUARIO 
            OracleCommand comando = new OracleCommand("SELECT * FROM FORMA_PAGO", conexion);
            //Captura los parámetros del txt y los envía a la consulta comando
            OracleDataAdapter da = new OracleDataAdapter(comando);
            da.Fill(dt);
            return dt;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            // Ejecuta el formulario operaciones
            Operaciones formulario = new Operaciones();
            //cierra el presente formulario de operaciones
            this.Hide();
            //Muestra el fomulario 1
            formulario.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {

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
            if (lector.Read()) { 

                lblNombrecuenta.Text = lector["CLIENTE"].ToString();
                lbltipocuenta.Text = lector["TIPO_CUENTA"].ToString();
                lblsaldo.Text = lector["SCUENTA"].ToString();

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

        private void button2_Click(object sender, EventArgs e)
        {
            //Crea una conexión a la BD
            OracleConnection conexion = new OracleConnection("Data source = xe; Password = #Physical; User ID = SYSTEM");

            //Abre la conexión creada a la bd
            conexion.Open();

            //Con el comando, hace una consulta a la tabla USUARIO 
            //OracleCommand comando = new OracleCommand("SELECT * FROM CUENTA WHERE NO_CUENTA= :No_cuenta", conexion);

            OracleCommand comando = new OracleCommand("actualizar", conexion);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("SALDO", OracleType.Number).Value = Convert.ToInt32(txtDepositar);
            comando.ExecuteNonQuery();
            MessageBox.Show("Deposito realizado con éxito");
            conexion.Close();


        }

        private void Deposito_Load(object sender, EventArgs e)
        {

        }



        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtNoCuenta_TextChanged(object sender, EventArgs e)
        {

        }
    }
}