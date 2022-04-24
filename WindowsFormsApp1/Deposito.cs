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
    public partial class Deposito : Form
    {
        public Deposito(int Id_usuario)
        {
            InitializeComponent();
            cmbxformapago.DataSource = DatosFormaPago();
            cmbxformapago.DisplayMember = "ID_FORMA_Pago";
            this.Id_usuarioaux= Id_usuario;
 
        }

        int Id_usuarioaux;

        public DataTable DatosFormaPago()
        {
            //Crea una conexión a la BD
            string connString = "Data Source = (DESCRIPTION = " +
      "(ADDRESS = (PROTOCOL = TCP)(HOST = 25.77.205.156)(PORT = 1521))" +
      "(CONNECT_DATA =" +
        "(SERVER = DEDICATED)" +
        "(SERVICE_NAME = XE)" +
      ")" +
    "); User Id = system; password = #Physical";
            OracleConnection con = new OracleConnection();
            con.ConnectionString = connString;
            con.Open();
            //Crea una tala data
            DataTable dt = new DataTable();
            //Con el comando, hace una consulta a la tabla USUARIO 
            OracleCommand comando = new OracleCommand("SELECT * FROM FORMA_PAGO", con);
            //Captura los parámetros del txt y los envía a la consulta comando
            OracleDataAdapter da = new OracleDataAdapter(comando);
            da.Fill(dt);
            return dt;
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

            string connString = "Data Source = (DESCRIPTION = " +
     "(ADDRESS = (PROTOCOL = TCP)(HOST = 25.77.205.156)(PORT = 1521))" +
     "(CONNECT_DATA =" +
       "(SERVER = DEDICATED)" +
       "(SERVICE_NAME = XE)" +
     ")" +
   "); User Id = system; password = #Physical";
            OracleConnection con = new OracleConnection();
            con.ConnectionString = connString;
            con.Open();

            //Con el comando, hace una consulta a la tabla USUARIO 
            //OracleCommand comando = new OracleCommand("SELECT * FROM CUENTA WHERE NO_CUENTA= :No_cuenta", conexion);

            OracleCommand comando = new OracleCommand("SELECT c.NO_CUENTA AS CUENTA, cl.NOMBRE_CLIENTE AS CLIENTE, tc.NOMBRE_TIPO_CUENTA AS TIPO_CUENTA, c.Saldo AS SCUENTA FROM CUENTA c, Cliente cl, TIPO_CUENTA tc WHERE c.ID_CLIENTE=cl.ID_CLIENTE AND c.ID_TIPO=tc.ID_Tipo_Cuenta AND NO_CUENTA= :No_cuenta", con);

            //Captura los parámetros del txt y los envía a la consulta comando
            comando.Parameters.Add(":No_cuenta", txtNoCuenta.Text);

            // Aplica el lector a la bd de acuerdo a la consulta de Comando
            OracleDataReader lector = comando.ExecuteReader();

            // Si el lector logra leer los datos, entonces
            if (lector.Read()) { 

                lblNombrecuenta.Text = lector["CLIENTE"].ToString();
                lbltipocuenta.Text = lector["TIPO_CUENTA"].ToString();
                lblsaldo.Text = lector["SCUENTA"].ToString();

                MessageBox.Show("cuenta válida");

                // cierra la conexión creada
                con.Close();

            }
            else
            {
                MessageBox.Show("Cuenta no válida");
                // cierra la conexión creada
                con.Close();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        { 
            float NoCuenta;
            float Monto;
            NoCuenta = float.Parse(txtNoCuenta.Text);
            Monto = float.Parse(txtDepositar.Text);
            int Id_usuario=Id_usuarioaux;
            int Id_forma_pago=int.Parse(cmbxformapago.Text);

            if (Monto >= 0)
            {

            try
            {
                    // Crea una conexión a la BD
                    string connString = "Data Source = (DESCRIPTION = " +
             "(ADDRESS = (PROTOCOL = TCP)(HOST = 25.77.205.156)(PORT = 1521))" +
             "(CONNECT_DATA =" +
               "(SERVER = DEDICATED)" +
               "(SERVICE_NAME = XE)" +
             ")" +
           "); User Id = system; password = #Physical";
                    OracleConnection con = new OracleConnection();
                    con.ConnectionString = connString;
                    con.Open();

                    OracleCommand comando = new OracleCommand("Deposito", con);
                    comando.CommandType = System.Data.CommandType.StoredProcedure;


                    //comando.Parameters.Add("P_NO_CUENTA", OracleType.Number).Value = Convert.ToInt32(txtNoCuenta);
                    comando.Parameters.Add("P_NO_CUENTA", OracleDbType.Int64).Value = NoCuenta;
                    comando.Parameters.Add("P_MONTO", OracleDbType.Int64).Value = Monto;

                    comando.ExecuteNonQuery();

                    lblNombrecuenta.Text = " ";
                    lblsaldo.Text = " ";
                    lbltipocuenta.Text = " ";
                    txtDepositar.Text = " ";

                    OracleCommand comandodeptrans = new OracleCommand("TRANSACCIONES_AUDITORIA", con);
                    comandodeptrans.CommandType = System.Data.CommandType.StoredProcedure;
                    comandodeptrans.Parameters.Add("TRANS", OracleDbType.Int64).Value = 1;
                    comandodeptrans.Parameters.Add("OPERACION", OracleDbType.Int64).Value = 2;
                    comandodeptrans.Parameters.Add("CUENTA", OracleDbType.Int64).Value = NoCuenta;
                    comandodeptrans.Parameters.Add("USUARIO", OracleDbType.Int64).Value = Id_usuario;
                    comandodeptrans.Parameters.Add("FORMA_PAGO", OracleDbType.Int64).Value = Id_forma_pago;
                    comandodeptrans.Parameters.Add("MONTO", OracleDbType.Int64).Value = Monto;

                    comandodeptrans.ExecuteNonQuery();

                    MessageBox.Show("Deposito realizado con éxito");

            con.Close();


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
           }
           else
           {
              MessageBox.Show("Monto no válido");
           }

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