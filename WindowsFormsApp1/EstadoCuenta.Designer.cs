namespace WindowsFormsApp1
{
    partial class EstadoCuenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EstadoCuenta));
            this.lbltipocuenta = new System.Windows.Forms.Label();
            this.lblNombrecuenta = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblsaldo = new System.Windows.Forms.Label();
            this.txtNoCuenta = new System.Windows.Forms.TextBox();
            this.btnBuscarCuenta = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbltipocuenta
            // 
            this.lbltipocuenta.AutoSize = true;
            this.lbltipocuenta.Location = new System.Drawing.Point(186, 196);
            this.lbltipocuenta.Name = "lbltipocuenta";
            this.lbltipocuenta.Size = new System.Drawing.Size(79, 13);
            this.lbltipocuenta.TabIndex = 42;
            this.lbltipocuenta.Text = "Tipo de cuenta";
            // 
            // lblNombrecuenta
            // 
            this.lblNombrecuenta.AutoSize = true;
            this.lblNombrecuenta.Location = new System.Drawing.Point(183, 168);
            this.lblNombrecuenta.Name = "lblNombrecuenta";
            this.lblNombrecuenta.Size = new System.Drawing.Size(80, 13);
            this.lblNombrecuenta.TabIndex = 41;
            this.lblNombrecuenta.Text = "Nombre cuenta";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(56, 219);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 21);
            this.label8.TabIndex = 40;
            this.label8.Text = "Saldo";
            // 
            // lblsaldo
            // 
            this.lblsaldo.AutoSize = true;
            this.lblsaldo.Location = new System.Drawing.Point(184, 225);
            this.lblsaldo.Name = "lblsaldo";
            this.lblsaldo.Size = new System.Drawing.Size(34, 13);
            this.lblsaldo.TabIndex = 39;
            this.lblsaldo.Text = "Saldo";
            // 
            // txtNoCuenta
            // 
            this.txtNoCuenta.Location = new System.Drawing.Point(186, 139);
            this.txtNoCuenta.Name = "txtNoCuenta";
            this.txtNoCuenta.Size = new System.Drawing.Size(212, 20);
            this.txtNoCuenta.TabIndex = 38;
            // 
            // btnBuscarCuenta
            // 
            this.btnBuscarCuenta.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBuscarCuenta.Location = new System.Drawing.Point(419, 186);
            this.btnBuscarCuenta.Name = "btnBuscarCuenta";
            this.btnBuscarCuenta.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarCuenta.TabIndex = 36;
            this.btnBuscarCuenta.Text = "Buscar";
            this.btnBuscarCuenta.UseVisualStyleBackColor = true;
            this.btnBuscarCuenta.Click += new System.EventHandler(this.btnBuscarCuenta_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(58, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 21);
            this.label4.TabIndex = 35;
            this.label4.Text = "Tipo cuenta";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(58, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 21);
            this.label3.TabIndex = 34;
            this.label3.Text = "Nombre ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(58, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 21);
            this.label1.TabIndex = 33;
            this.label1.Text = "No cuenta";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(476, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(65, 36);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 32;
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
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 25);
            this.label2.TabIndex = 30;
            this.label2.Text = "Estado de Cuenta";
            // 
            // EstadoCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(577, 343);
            this.Controls.Add(this.lbltipocuenta);
            this.Controls.Add(this.lblNombrecuenta);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblsaldo);
            this.Controls.Add(this.txtNoCuenta);
            this.Controls.Add(this.btnBuscarCuenta);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.ForeColor = System.Drawing.Color.Snow;
            this.Name = "EstadoCuenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EstadoCuenta";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltipocuenta;
        private System.Windows.Forms.Label lblNombrecuenta;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblsaldo;
        private System.Windows.Forms.TextBox txtNoCuenta;
        private System.Windows.Forms.Button btnBuscarCuenta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
    }
}