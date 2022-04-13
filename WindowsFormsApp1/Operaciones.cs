using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Operaciones : Form
    {
        public Operaciones()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Ejecuta el formulario 1
            Form1 formulario = new Form1();
            //cierra el presente formulario de operaciones
            this.Hide();
            //Muestra el fomulario 1
            formulario.Show();
            formulario.StartPosition = FormStartPosition.CenterParent;

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            // Ejecuta el formulario 1
            Deposito formulario = new Deposito();
            //cierra el presente formulario de operaciones
            this.Hide();
            //Muestra el fomulario 1
            formulario.Show();
            formulario.StartPosition = FormStartPosition.CenterParent;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            // Ejecuta el formulario 1
            Retiro formulario = new Retiro();
            //cierra el presente formulario de operaciones
            this.Hide();
            //Muestra el fomulario 1
            formulario.Show();
            formulario.StartPosition = FormStartPosition.CenterParent;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            // Ejecuta el formulario 1
            EstadoCuenta formulario = new EstadoCuenta();
            //cierra el presente formulario de operaciones
            this.Hide();
            //Muestra el fomulario 1
            formulario.Show();
            formulario.StartPosition = FormStartPosition.CenterParent;
        }
    }
}
