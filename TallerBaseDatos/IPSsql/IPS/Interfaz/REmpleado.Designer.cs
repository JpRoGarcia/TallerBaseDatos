namespace IPS.Interfaz
{
    partial class REmpleado
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
            this.txtCedE = new System.Windows.Forms.TextBox();
            this.txtNomE = new System.Windows.Forms.TextBox();
            this.txtApeE = new System.Windows.Forms.TextBox();
            this.txtConE = new System.Windows.Forms.TextBox();
            this.txtConRE = new System.Windows.Forms.TextBox();
            this.btnRegE = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtCedE
            // 
            this.txtCedE.Location = new System.Drawing.Point(341, 92);
            this.txtCedE.Name = "txtCedE";
            this.txtCedE.Size = new System.Drawing.Size(100, 20);
            this.txtCedE.TabIndex = 0;
            this.txtCedE.Text = "Cedula";
            // 
            // txtNomE
            // 
            this.txtNomE.Location = new System.Drawing.Point(341, 118);
            this.txtNomE.Name = "txtNomE";
            this.txtNomE.Size = new System.Drawing.Size(100, 20);
            this.txtNomE.TabIndex = 1;
            this.txtNomE.Text = "Nombre";
            // 
            // txtApeE
            // 
            this.txtApeE.Location = new System.Drawing.Point(341, 144);
            this.txtApeE.Name = "txtApeE";
            this.txtApeE.Size = new System.Drawing.Size(100, 20);
            this.txtApeE.TabIndex = 2;
            this.txtApeE.Text = "Apellido";
            // 
            // txtConE
            // 
            this.txtConE.Location = new System.Drawing.Point(341, 170);
            this.txtConE.Name = "txtConE";
            this.txtConE.Size = new System.Drawing.Size(100, 20);
            this.txtConE.TabIndex = 3;
            this.txtConE.Text = "Contraseña";
            // 
            // txtConRE
            // 
            this.txtConRE.Location = new System.Drawing.Point(341, 196);
            this.txtConRE.Name = "txtConRE";
            this.txtConRE.Size = new System.Drawing.Size(100, 20);
            this.txtConRE.TabIndex = 4;
            this.txtConRE.Text = "Repetir Contraseña";
            // 
            // btnRegE
            // 
            this.btnRegE.Location = new System.Drawing.Point(341, 223);
            this.btnRegE.Name = "btnRegE";
            this.btnRegE.Size = new System.Drawing.Size(100, 23);
            this.btnRegE.TabIndex = 5;
            this.btnRegE.Text = "Registrar";
            this.btnRegE.UseVisualStyleBackColor = true;
            this.btnRegE.Click += new System.EventHandler(this.btnRegE_Click);
            // 
            // REmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRegE);
            this.Controls.Add(this.txtConRE);
            this.Controls.Add(this.txtConE);
            this.Controls.Add(this.txtApeE);
            this.Controls.Add(this.txtNomE);
            this.Controls.Add(this.txtCedE);
            this.Name = "REmpleado";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCedE;
        private System.Windows.Forms.TextBox txtNomE;
        private System.Windows.Forms.TextBox txtApeE;
        private System.Windows.Forms.TextBox txtConE;
        private System.Windows.Forms.TextBox txtConRE;
        private System.Windows.Forms.Button btnRegE;
    }
}