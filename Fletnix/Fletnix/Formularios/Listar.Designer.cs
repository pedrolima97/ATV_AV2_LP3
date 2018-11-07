namespace Fletnix
{
    partial class Listar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Listar));
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.adicionarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ver = new System.Windows.Forms.Button();
            this.editar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Montserrat", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(13, 79);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 28);
            this.button1.TabIndex = 0;
            this.button1.Text = "Remover";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adicionarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(656, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // adicionarToolStripMenuItem
            // 
            this.adicionarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("adicionarToolStripMenuItem.Image")));
            this.adicionarToolStripMenuItem.Name = "adicionarToolStripMenuItem";
            this.adicionarToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.adicionarToolStripMenuItem.Text = "Adicionar ";
            this.adicionarToolStripMenuItem.Click += new System.EventHandler(this.adicionarToolStripMenuItem_Click);
            // 
            // ver
            // 
            this.ver.Font = new System.Drawing.Font("Montserrat", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ver.Image = ((System.Drawing.Image)(resources.GetObject("ver.Image")));
            this.ver.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ver.Location = new System.Drawing.Point(13, 45);
            this.ver.Name = "ver";
            this.ver.Size = new System.Drawing.Size(92, 28);
            this.ver.TabIndex = 3;
            this.ver.Text = "Visualizar";
            this.ver.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ver.UseVisualStyleBackColor = true;
            // 
            // editar
            // 
            this.editar.Font = new System.Drawing.Font("Montserrat", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editar.Image = ((System.Drawing.Image)(resources.GetObject("editar.Image")));
            this.editar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.editar.Location = new System.Drawing.Point(31, 11);
            this.editar.Name = "editar";
            this.editar.Size = new System.Drawing.Size(74, 28);
            this.editar.TabIndex = 4;
            this.editar.Text = "Editar";
            this.editar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.editar.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ver);
            this.panel1.Controls.Add(this.editar);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(525, 252);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(119, 114);
            this.panel1.TabIndex = 5;
            // 
            // Listar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 378);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Listar";
            this.Text = "Listar Títulos";
            this.Load += new System.EventHandler(this.Listar_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adicionarToolStripMenuItem;
        private System.Windows.Forms.Button ver;
        private System.Windows.Forms.Button editar;
        private System.Windows.Forms.Panel panel1;
    }
}