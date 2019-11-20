namespace AplicacionesArduino
{
    partial class FormMdiPadre
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tscmbPuertos = new System.Windows.Forms.ToolStripComboBox();
            this.tscmbVelocidad = new System.Windows.Forms.ToolStripComboBox();
            this.confirmarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.conectarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.desconectarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aplicacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.focoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.semáforoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.temperaturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.focoExternoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.aplicacionesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(742, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.guaToolStripMenuItem,
            this.conectarToolStripMenuItem,
            this.desconectarToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.archivoToolStripMenuItem.Text = "Comunicacion";
            // 
            // guaToolStripMenuItem
            // 
            this.guaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tscmbPuertos,
            this.tscmbVelocidad,
            this.confirmarToolStripMenuItem});
            this.guaToolStripMenuItem.Name = "guaToolStripMenuItem";
            this.guaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.guaToolStripMenuItem.Text = "Verificar";
            this.guaToolStripMenuItem.Click += new System.EventHandler(this.GuaToolStripMenuItem_Click);
            // 
            // tscmbPuertos
            // 
            this.tscmbPuertos.Name = "tscmbPuertos";
            this.tscmbPuertos.Size = new System.Drawing.Size(121, 23);
            // 
            // tscmbVelocidad
            // 
            this.tscmbVelocidad.Items.AddRange(new object[] {
            "19200",
            "9600",
            "4800",
            "2400",
            "1200"});
            this.tscmbVelocidad.Name = "tscmbVelocidad";
            this.tscmbVelocidad.Size = new System.Drawing.Size(121, 23);
            // 
            // confirmarToolStripMenuItem
            // 
            this.confirmarToolStripMenuItem.Name = "confirmarToolStripMenuItem";
            this.confirmarToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.confirmarToolStripMenuItem.Text = "Confirmar";
            this.confirmarToolStripMenuItem.Click += new System.EventHandler(this.ConfirmarToolStripMenuItem_Click);
            // 
            // conectarToolStripMenuItem
            // 
            this.conectarToolStripMenuItem.Enabled = false;
            this.conectarToolStripMenuItem.Name = "conectarToolStripMenuItem";
            this.conectarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.conectarToolStripMenuItem.Text = "Conectar";
            this.conectarToolStripMenuItem.Click += new System.EventHandler(this.ConectarToolStripMenuItem_Click);
            // 
            // desconectarToolStripMenuItem
            // 
            this.desconectarToolStripMenuItem.Enabled = false;
            this.desconectarToolStripMenuItem.Name = "desconectarToolStripMenuItem";
            this.desconectarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.desconectarToolStripMenuItem.Text = "Desconectar";
            this.desconectarToolStripMenuItem.Click += new System.EventHandler(this.DesconectarToolStripMenuItem_Click);
            // 
            // aplicacionesToolStripMenuItem
            // 
            this.aplicacionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.focoToolStripMenuItem,
            this.semáforoToolStripMenuItem,
            this.temperaturaToolStripMenuItem,
            this.focoExternoToolStripMenuItem});
            this.aplicacionesToolStripMenuItem.Name = "aplicacionesToolStripMenuItem";
            this.aplicacionesToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.aplicacionesToolStripMenuItem.Text = "Aplicaciones";
            // 
            // focoToolStripMenuItem
            // 
            this.focoToolStripMenuItem.Name = "focoToolStripMenuItem";
            this.focoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.focoToolStripMenuItem.Text = "Foco";
            this.focoToolStripMenuItem.Click += new System.EventHandler(this.FocoToolStripMenuItem_Click);
            // 
            // semáforoToolStripMenuItem
            // 
            this.semáforoToolStripMenuItem.Name = "semáforoToolStripMenuItem";
            this.semáforoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.semáforoToolStripMenuItem.Text = "Semáforo";
            // 
            // temperaturaToolStripMenuItem
            // 
            this.temperaturaToolStripMenuItem.Name = "temperaturaToolStripMenuItem";
            this.temperaturaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.temperaturaToolStripMenuItem.Text = "Temperatura";
            this.temperaturaToolStripMenuItem.Click += new System.EventHandler(this.TemperaturaToolStripMenuItem_Click);
            // 
            // focoExternoToolStripMenuItem
            // 
            this.focoExternoToolStripMenuItem.Name = "focoExternoToolStripMenuItem";
            this.focoExternoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.focoExternoToolStripMenuItem.Text = "FocoExterno";
            this.focoExternoToolStripMenuItem.Click += new System.EventHandler(this.FocoExternoToolStripMenuItem_Click);
            // 
            // FormMdiPadre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 389);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMdiPadre";
            this.Text = "Control Principal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem conectarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem desconectarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aplicacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem focoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem semáforoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem temperaturaToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox tscmbPuertos;
        private System.Windows.Forms.ToolStripComboBox tscmbVelocidad;
        private System.Windows.Forms.ToolStripMenuItem confirmarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem focoExternoToolStripMenuItem;
    }
}

