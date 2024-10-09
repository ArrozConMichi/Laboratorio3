namespace Laboratorio__3
{
    partial class Problema1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAbrirCuenta = new System.Windows.Forms.Button();
            this.txtMonInicial = new System.Windows.Forms.TextBox();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnTransaccionar = new System.Windows.Forms.Button();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.rdbRetiro = new System.Windows.Forms.RadioButton();
            this.rdbDeposito = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvDeposito = new System.Windows.Forms.DataGridView();
            this.dgvRetiro = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeposito)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRetiro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.btnAbrirCuenta);
            this.groupBox1.Controls.Add(this.txtMonInicial);
            this.groupBox1.Controls.Add(this.txtCliente);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(48, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(694, 132);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingrese Datos";
            // 
            // btnAbrirCuenta
            // 
            this.btnAbrirCuenta.Location = new System.Drawing.Point(540, 56);
            this.btnAbrirCuenta.Name = "btnAbrirCuenta";
            this.btnAbrirCuenta.Size = new System.Drawing.Size(134, 31);
            this.btnAbrirCuenta.TabIndex = 4;
            this.btnAbrirCuenta.Text = "Abrir Cuenta";
            this.btnAbrirCuenta.UseVisualStyleBackColor = true;
            this.btnAbrirCuenta.Click += new System.EventHandler(this.btnAbrirCuenta_Click);
            // 
            // txtMonInicial
            // 
            this.txtMonInicial.Location = new System.Drawing.Point(188, 79);
            this.txtMonInicial.Name = "txtMonInicial";
            this.txtMonInicial.Size = new System.Drawing.Size(266, 30);
            this.txtMonInicial.TabIndex = 3;
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(188, 35);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(266, 30);
            this.txtCliente.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Monto Inicial:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cliente:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.btnTransaccionar);
            this.groupBox2.Controls.Add(this.txtCantidad);
            this.groupBox2.Controls.Add(this.rdbRetiro);
            this.groupBox2.Controls.Add(this.rdbDeposito);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(48, 177);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(694, 121);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Transacciones";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(328, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(228, 23);
            this.label9.TabIndex = 5;
            this.label9.Text = "Cantidad a Retirar/Depositar";
            // 
            // btnTransaccionar
            // 
            this.btnTransaccionar.Location = new System.Drawing.Point(565, 52);
            this.btnTransaccionar.Name = "btnTransaccionar";
            this.btnTransaccionar.Size = new System.Drawing.Size(123, 37);
            this.btnTransaccionar.TabIndex = 4;
            this.btnTransaccionar.Text = "Transaccionar";
            this.btnTransaccionar.UseVisualStyleBackColor = true;
            this.btnTransaccionar.Click += new System.EventHandler(this.btnTransaccionar_Click);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(380, 56);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(103, 30);
            this.txtCantidad.TabIndex = 3;
            // 
            // rdbRetiro
            // 
            this.rdbRetiro.AutoSize = true;
            this.rdbRetiro.Location = new System.Drawing.Point(128, 79);
            this.rdbRetiro.Name = "rdbRetiro";
            this.rdbRetiro.Size = new System.Drawing.Size(82, 27);
            this.rdbRetiro.TabIndex = 2;
            this.rdbRetiro.TabStop = true;
            this.rdbRetiro.Text = "Retiros";
            this.rdbRetiro.UseVisualStyleBackColor = true;
            // 
            // rdbDeposito
            // 
            this.rdbDeposito.AutoSize = true;
            this.rdbDeposito.Location = new System.Drawing.Point(128, 36);
            this.rdbDeposito.Name = "rdbDeposito";
            this.rdbDeposito.Size = new System.Drawing.Size(99, 27);
            this.rdbDeposito.TabIndex = 1;
            this.rdbDeposito.TabStop = true;
            this.rdbDeposito.Text = "Depositos";
            this.rdbDeposito.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 18);
            this.label4.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.btnNuevo);
            this.groupBox3.Controls.Add(this.txtSaldo);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.dgvDeposito);
            this.groupBox3.Controls.Add(this.dgvRetiro);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(48, 328);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(694, 310);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Cuenta de Ahorros";
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(493, 212);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(134, 31);
            this.btnNuevo.TabIndex = 5;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // txtSaldo
            // 
            this.txtSaldo.BackColor = System.Drawing.Color.White;
            this.txtSaldo.Location = new System.Drawing.Point(508, 138);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.ReadOnly = true;
            this.txtSaldo.Size = new System.Drawing.Size(109, 30);
            this.txtSaldo.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(536, 112);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 23);
            this.label8.TabIndex = 6;
            this.label8.Text = "Saldo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(280, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 23);
            this.label7.TabIndex = 5;
            this.label7.Text = "Depósitos";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(78, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 23);
            this.label6.TabIndex = 4;
            this.label6.Text = "Retiros";
            // 
            // dgvDeposito
            // 
            this.dgvDeposito.BackgroundColor = System.Drawing.Color.White;
            this.dgvDeposito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDeposito.Location = new System.Drawing.Point(223, 69);
            this.dgvDeposito.Name = "dgvDeposito";
            this.dgvDeposito.Size = new System.Drawing.Size(195, 216);
            this.dgvDeposito.TabIndex = 3;
            // 
            // dgvRetiro
            // 
            this.dgvRetiro.BackgroundColor = System.Drawing.Color.White;
            this.dgvRetiro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRetiro.Location = new System.Drawing.Point(12, 69);
            this.dgvRetiro.Name = "dgvRetiro";
            this.dgvRetiro.Size = new System.Drawing.Size(195, 216);
            this.dgvRetiro.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 18);
            this.label3.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 18);
            this.label5.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Laboratorio__3.Properties.Resources.FONDO;
            this.pictureBox1.Location = new System.Drawing.Point(-3, -5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(792, 683);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Problema1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(784, 688);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.MaximumSize = new System.Drawing.Size(800, 1000);
            this.MinimumSize = new System.Drawing.Size(100, 39);
            this.Name = "Problema1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeposito)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRetiro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAbrirCuenta;
        private System.Windows.Forms.TextBox txtMonInicial;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rdbDeposito;
        private System.Windows.Forms.RadioButton rdbRetiro;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvDeposito;
        private System.Windows.Forms.DataGridView dgvRetiro;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnTransaccionar;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

