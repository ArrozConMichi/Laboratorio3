namespace Laboratorio__3
{
    partial class Problema2
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.dgvNumeros = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNumeros)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnRemover);
            this.panel1.Controls.Add(this.dgvNumeros);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 426);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.button1.Location = new System.Drawing.Point(95, 319);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 47);
            this.button1.TabIndex = 2;
            this.button1.Text = "Agregar Número";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.btnRemover.Location = new System.Drawing.Point(507, 319);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(148, 47);
            this.btnRemover.TabIndex = 1;
            this.btnRemover.Text = "Remover Número";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // dgvNumeros
            // 
            this.dgvNumeros.BackgroundColor = System.Drawing.Color.White;
            this.dgvNumeros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNumeros.Location = new System.Drawing.Point(95, 70);
            this.dgvNumeros.Name = "dgvNumeros";
            this.dgvNumeros.Size = new System.Drawing.Size(560, 201);
            this.dgvNumeros.TabIndex = 0;
            this.dgvNumeros.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNumeros_CellContentClick);
            // 
            // Problema2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Problema2";
            this.Text = "Problema2";
            this.Load += new System.EventHandler(this.Problema2_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNumeros)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvNumeros;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button button1;
    }
}