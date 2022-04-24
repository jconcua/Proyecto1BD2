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
    public partial class Retiro : Form
    {
        public Retiro(int Id_usuario)
        {
            InitializeComponent();
            cmbxformapago.DataSource = DatosFormaPago();
            cmbxformapago.DisplayMember = "ID_FORMA_Pago";
            this.Id_usuario = Id_usuario;
        }

        int Id_usuario;
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
            //Crea una tala data
            DataTable dt = new DataTable();
            //Abre la conexión creada a la bd
            con.Open();
            //Con el comando, hace una consulta a la tabla USUARIO 
            OracleCommand comando = new OracleCommand("SELECT * FROM FORMA_PAGO", con);
            //Captura los parámetros del txt y los envía a la consulta comando
            OracleDataAdapter da = new OracleDataAdapter(comando);
            da.Fill(dt);
            return dt;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBuscarCuenta_Click(object sender, EventArgs e)
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
            DataTable dt = new DataTable();
            //Abre la conexión creada a la bd
            con.Open();
            //Con el comando, hace una consulta a la tabla USUARIO 
            OracleCommand comando = new OracleCommand("SELECT * FROM CUENTA WHERE NO_CUENTA= :No_cuenta AND ID_CLIENTE= :ID_Cliente AND ID_TIPO= :Id_Tipo", con);
            //Captura los parámetros del txt y los envía a la consulta comando
            comando.Parameters.Add(":No_cuenta", txtNoCuenta.Text);
            // Aplica el lector a la bd de acuerdo a la consulta de Comando
            OracleDataReader lector = comando.ExecuteReader();
            // Si el lector logra leer los datos, entonces
            if (lector.Read())
            {
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

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            // Ejecuta el formulario operaciones
            Operaciones formulario = new Operaciones(Id_usuario);
            //cierra el presente formulario de operaciones
            this.Hide();
            //Muestra el fomulario 1
            formulario.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscarCuenta_Click_1(object sender, EventArgs e)
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
            // BD2 COMO DATA SOURCE
            //Abre la conexión creada a la bd
            con.Open();
            //Con el comando, hace una consulta a la tabla USUARIO 
            //OracleCommand comando = new OracleCommand("SELECT * FROM CUENTA WHERE NO_CUENTA= :No_cuenta", conexion);
            OracleCommand comando = new OracleCommand("SELECT c.NO_CUENTA AS CUENTA, cl.NOMBRE_CLIENTE AS CLIENTE, tc.NOMBRE_TIPO_CUENTA AS TIPO_CUENTA, c.Saldo AS SCUENTA FROM CUENTA c, Cliente cl, TIPO_CUENTA tc WHERE c.ID_CLIENTE=cl.ID_CLIENTE AND c.ID_TIPO=tc.ID_Tipo_Cuenta AND NO_CUENTA= :No_cuenta", con);
            //Captura los parámetros del txt y los envía a la consulta comando
            comando.Parameters.Add(":No_cuenta", txtNoCuenta.Text);
            // Aplica el lector a la bd de acuerdo a la consulta de Comando
            OracleDataReader lector = comando.ExecuteReader();
            // Si el lector logra leer los datos, entonces
            if (lector.Read())
            {
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

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            // Ejecuta el formulario operaciones
            Form1 formulario = new Form1();
            //cierra el presente formulario de operaciones
            this.Hide();
            //Muestra el fomulario 1
            formulario.Show();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            float NoCuenta;
            float Monto;
            NoCuenta = float.Parse(txtNoCuenta.Text);
            Monto = float.Parse(txtMonto.Text);
            int Id_forma_pago = int.Parse(cmbxformapago.Text);
            float saldoactual=0;
            String saldito;

            if (Monto >= 0)
            {

                try
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
                    //Abre la conexión creada a la bd
                    con.Open();
                    OracleCommand consultasaldo = new OracleCommand("SELECT SALDO AS sal  FROM CUENTA WHERE NO_CUENTA= :No_cuenta", con);
                    //Captura los parámetros del txt y los envía a la consulta comando
                    consultasaldo.Parameters.Add(":No_cuenta", NoCuenta);
                    // Aplica el lector a la bd de acuerdo a la consulta de Comando
                    OracleDataReader lector = consultasaldo.ExecuteReader();
                    // Si el lector logra leer los datos, entonces
                    if (lector.Read())
                    {
                        saldito = lector["sal"].ToString();
                        saldoactual = float.Parse(saldito);
                    }

                    //Con el comando, hace una consulta a la tabla USUARIO 
                    //OracleCommand comandomonto = new OracleCommand("SELECT * FROM CUENTA WHERE NO_CUENTA= :No_cuenta", conexion);
                    OracleCommand comando = new OracleCommand("Retiro", con);
                    comando.CommandType = System.Data.CommandType.StoredProcedure;
                
                    //comando.Parameters.Add("P_NO_CUENTA", OracleType.Number).Value = Convert.ToInt32(txtNoCuenta);
                    comando.Parameters.Add("P_NO_CUENTA", OracleDbType.Int64).Value = NoCuenta;
                    comando.Parameters.Add("P_MONTO", OracleDbType.Int64).Value = Monto;

                    if(saldoactual >= Monto && Monto>=0)
                    {
                        comando.ExecuteNonQuery();
                        lblNombrecuenta.Text = " ";
                        lblsaldo.Text = " ";
                        lbltipocuenta.Text = " ";
                        txtMonto.Text = " ";


                        OracleCommand comandorettrans = new OracleCommand("TRANSACCIONES_AUDITORIA", con);
                        comandorettrans.CommandType = System.Data.CommandType.StoredProcedure;
                        comandorettrans.Parameters.Add("TRANS", OracleDbType.Int64).Value = 1;
                        comandorettrans.Parameters.Add("OPERACION", OracleDbType.Int64).Value = 3;
                        comandorettrans.Parameters.Add("CUENTA", OracleDbType.Int64).Value = NoCuenta;
                        comandorettrans.Parameters.Add("USUARIO", OracleDbType.Int64).Value = Id_usuario;
                        comandorettrans.Parameters.Add("FORMA_PAGO", OracleDbType.Int64).Value = Id_forma_pago;
                        comandorettrans.Parameters.Add("MONTO", OracleDbType.Int64).Value = Monto;

                        comandorettrans.ExecuteNonQuery();



                        MessageBox.Show("Retiro realizado con éxito");
                        con.Close();
                    }
                    else
                    {
                        MessageBox.Show("Fondos insuficientes");
                    }

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
    }
}
