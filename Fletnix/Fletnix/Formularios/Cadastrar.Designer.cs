namespace Fletnix
{
    partial class Cadastrar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cadastrar));
            this.salvar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // salvar
            // 
            this.salvar.Font = new System.Drawing.Font("Montserrat", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salvar.Image = ((System.Drawing.Image)(resources.GetObject("salvar.Image")));
            this.salvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.salvar.Location = new System.Drawing.Point(492, 221);
            this.salvar.Name = "salvar";
            this.salvar.Size = new System.Drawing.Size(77, 28);
            this.salvar.TabIndex = 4;
            this.salvar.Text = "Salvar";
            this.salvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.salvar.UseVisualStyleBackColor = true;
            // 
            // Cadastrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 261);
            this.Controls.Add(this.salvar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Cadastrar";
            this.Text = "Cadastrar";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button salvar;
    }
}