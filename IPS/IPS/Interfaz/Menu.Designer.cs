namespace IPS.Interfaz
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
            this.registroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.medicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pacienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.multasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.citasPacienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.medícoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroMédicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizarDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.valorAPagarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.citaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarCitaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.citasIncumplidasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroToolStripMenuItem,
            this.medícoToolStripMenuItem,
            this.citaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // registroToolStripMenuItem
            // 
            this.registroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.medicoToolStripMenuItem,
            this.pacienteToolStripMenuItem,
            this.multasToolStripMenuItem,
            this.citasPacienteToolStripMenuItem});
            this.registroToolStripMenuItem.Name = "registroToolStripMenuItem";
            this.registroToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.registroToolStripMenuItem.Text = "Paciente";
            // 
            // medicoToolStripMenuItem
            // 
            this.medicoToolStripMenuItem.Name = "medicoToolStripMenuItem";
            this.medicoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.medicoToolStripMenuItem.Text = "Registrar Paciente";
            this.medicoToolStripMenuItem.Click += new System.EventHandler(this.medicoToolStripMenuItem_Click);
            // 
            // pacienteToolStripMenuItem
            // 
            this.pacienteToolStripMenuItem.Name = "pacienteToolStripMenuItem";
            this.pacienteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pacienteToolStripMenuItem.Text = "Actualizar Datos";
            // 
            // multasToolStripMenuItem
            // 
            this.multasToolStripMenuItem.Name = "multasToolStripMenuItem";
            this.multasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.multasToolStripMenuItem.Text = "Multas Paciente";
            // 
            // citasPacienteToolStripMenuItem
            // 
            this.citasPacienteToolStripMenuItem.Name = "citasPacienteToolStripMenuItem";
            this.citasPacienteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.citasPacienteToolStripMenuItem.Text = "Citas Paciente";
            // 
            // medícoToolStripMenuItem
            // 
            this.medícoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroMédicoToolStripMenuItem,
            this.actualizarDatosToolStripMenuItem,
            this.valorAPagarToolStripMenuItem});
            this.medícoToolStripMenuItem.Name = "medícoToolStripMenuItem";
            this.medícoToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.medícoToolStripMenuItem.Text = "Médico";
            // 
            // registroMédicoToolStripMenuItem
            // 
            this.registroMédicoToolStripMenuItem.Name = "registroMédicoToolStripMenuItem";
            this.registroMédicoToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.registroMédicoToolStripMenuItem.Text = "Registro Médico";
            this.registroMédicoToolStripMenuItem.Click += new System.EventHandler(this.registroMédicoToolStripMenuItem_Click);
            // 
            // actualizarDatosToolStripMenuItem
            // 
            this.actualizarDatosToolStripMenuItem.Name = "actualizarDatosToolStripMenuItem";
            this.actualizarDatosToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.actualizarDatosToolStripMenuItem.Text = "Actualizar Datos";
            // 
            // valorAPagarToolStripMenuItem
            // 
            this.valorAPagarToolStripMenuItem.Name = "valorAPagarToolStripMenuItem";
            this.valorAPagarToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.valorAPagarToolStripMenuItem.Text = "Valor a Pagar";
            // 
            // citaToolStripMenuItem
            // 
            this.citaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarCitaToolStripMenuItem,
            this.citasIncumplidasToolStripMenuItem});
            this.citaToolStripMenuItem.Name = "citaToolStripMenuItem";
            this.citaToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.citaToolStripMenuItem.Text = "Cita";
            // 
            // registrarCitaToolStripMenuItem
            // 
            this.registrarCitaToolStripMenuItem.Name = "registrarCitaToolStripMenuItem";
            this.registrarCitaToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.registrarCitaToolStripMenuItem.Text = "Registrar Cita";
            // 
            // citasIncumplidasToolStripMenuItem
            // 
            this.citasIncumplidasToolStripMenuItem.Name = "citasIncumplidasToolStripMenuItem";
            this.citasIncumplidasToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.citasIncumplidasToolStripMenuItem.Text = "Citas Incumplidas";
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
            this.Text = "Form1";
            this.TopMost = true;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem registroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem medicoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pacienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem medícoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroMédicoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actualizarDatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem valorAPagarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem citaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarCitaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem citasIncumplidasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem multasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem citasPacienteToolStripMenuItem;
    }
}