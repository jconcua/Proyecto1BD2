namespace WindowsFormsApp1
{
    partial class Deposito
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Deposito));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBuscarCuenta = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbxformapago = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDepositar = new System.Windows.Forms.TextBox();
            this.txtNoCuenta = new System.Windows.Forms.TextBox();
            this.lblsaldo = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblNombrecuenta = new System.Windows.Forms.Label();
            this.lbltipocuenta = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Depósito";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 21);
            this.label1.TabIndex = 10;
            this.label1.Text = "No cuenta";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(43, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 21);
            this.label3.TabIndex = 12;
            this.label3.Text = "Nombre ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(43, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 21);
            this.label4.TabIndex = 14;
            this.label4.Text = "Tipo cuenta";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // btnBuscarCuenta
            // 
            this.btnBuscarCuenta.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBuscarCuenta.Location = new System.Drawing.Point(404, 135);
            this.btnBuscarCuenta.Name = "btnBuscarCuenta";
            this.btnBuscarCuenta.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarCuenta.TabIndex = 15;
            this.btnBuscarCuenta.Text = "Buscar";
            this.btnBuscarCuenta.UseVisualStyleBackColor = true;
            this.btnBuscarCuenta.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmbxformapago);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtDepositar);
            this.panel1.Location = new System.Drawing.Point(29, 198);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(524, 113);
            this.panel1.TabIndex = 16;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // cmbxformapago
            // 
            this.cmbxformapago.FormattingEnabled = true;
            this.cmbxformapago.Location = new System.Drawing.Point(164, 43);
            this.cmbxformapago.Name = "cmbxformapago";
            this.cmbxformapago.Size = new System.Drawing.Size(190, 21);
            this.cmbxformapago.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 21);
            this.label6.TabIndex = 21;
            this.label6.Text = "Forma pago";
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(375, 67);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 19;
            this.button2.Text = "Depositar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 21);
            this.label5.TabIndex = 18;
            this.label5.Text = "Cantidad deposito";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtDepositar
            // 
            this.txtDepositar.Location = new System.Drawing.Point(164, 17);
            this.txtDepositar.Name = "txtDepositar";
            this.txtDepositar.Size = new System.Drawing.Size(190, 20);
            this.txtDepositar.TabIndex = 17;
            this.txtDepositar.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtNoCuenta
            // 
            this.txtNoCuenta.Location = new System.Drawing.Point(171, 88);
            this.txtNoCuenta.Name = "txtNoCuenta";
            this.txtNoCuenta.Size = new System.Drawing.Size(212, 20);
            this.txtNoCuenta.TabIndex = 25;
            this.txtNoCuenta.TextChanged += new System.EventHandler(this.txtNoCuenta_TextChanged);
            // 
            // lblsaldo
            // 
            this.lblsaldo.AutoSize = true;
            this.lblsaldo.Location = new System.Drawing.Point(169, 174);
            this.lblsaldo.Name = "lblsaldo";
            this.lblsaldo.Size = new System.Drawing.Size(34, 13);
            this.lblsaldo.TabIndex = 26;
            this.lblsaldo.Text = "Saldo";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(41, 168);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 21);
            this.label8.TabIndex = 27;
            this.label8.Text = "Saldo";
            // 
            // lblNombrecuenta
            // 
            this.lblNombrecuenta.AutoSize = true;
            this.lblNombrecuenta.Location = new System.Drawing.Point(168, 117);
            this.lblNombrecuenta.Name = "lblNombrecuenta";
            this.lblNombrecuenta.Size = new System.Drawing.Size(80, 13);
            this.lblNombrecuenta.TabIndex = 28;
            this.lblNombrecuenta.Text = "Nombre cuenta";
            // 
            // lbltipocuenta
            // 
            this.lbltipocuenta.AutoSize = true;
            this.lbltipocuenta.Location = new System.Drawing.Point(171, 145);
            this.lbltipocuenta.Name = "lbltipocuenta";
            this.lbltipocuenta.Size = new System.Drawing.Size(79, 13);
            this.lbltipocuenta.TabIndex = 29;
            this.lbltipocuenta.Text = "Tipo de cuenta";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(476, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(65, 36);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(536, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Deposito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(577, 343);
            this.Controls.Add(this.lbltipocuenta);
            this.Controls.Add(this.lblNombrecuenta);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblsaldo);
            this.Controls.Add(this.txtNoCuenta);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnBuscarCuenta);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Name = "Deposito";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Deposito_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnBuscarCuenta;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDepositar;
        private System.Windows.Forms.ComboBox cmbxformapago;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtNoCuenta;
        private System.Windows.Forms.Label lblsaldo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblNombrecuenta;
        private System.Windows.Forms.Label lbltipocuenta;
    }
}