namespace Laboratorio__3
{
    partial class Menu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.problema1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.problema2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.problema3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.problema1ToolStripMenuItem,
            this.problema2ToolStripMenuItem,
            this.problema3ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 31);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // problema1ToolStripMenuItem
            // 
            this.problema1ToolStripMenuItem.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.problema1ToolStripMenuItem.Name = "problema1ToolStripMenuItem";
            this.problema1ToolStripMenuItem.Size = new System.Drawing.Size(113, 27);
            this.problema1ToolStripMenuItem.Text = "Problema #1";
            this.problema1ToolStripMenuItem.Click += new System.EventHandler(this.problema1ToolStripMenuItem_Click);
            // 
            // problema2ToolStripMenuItem
            // 
            this.problema2ToolStripMenuItem.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.problema2ToolStripMenuItem.Name = "problema2ToolStripMenuItem";
            this.problema2ToolStripMenuItem.Size = new System.Drawing.Size(116, 27);
            this.problema2ToolStripMenuItem.Text = "Problema #2";
            this.problema2ToolStripMenuItem.Click += new System.EventHandler(this.problema2ToolStripMenuItem_Click);
            // 
            // problema3ToolStripMenuItem
            // 
            this.problema3ToolStripMenuItem.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.problema3ToolStripMenuItem.Name = "problema3ToolStripMenuItem";
            this.problema3ToolStripMenuItem.Size = new System.Drawing.Size(121, 27);
            this.problema3ToolStripMenuItem.Text = "Problema # 3";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem problema1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem problema2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem problema3ToolStripMenuItem;
    }
}