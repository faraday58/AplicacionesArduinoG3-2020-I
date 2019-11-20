namespace AplicacionesArduino
{
    partial class SensaTemperatura
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chtTemperatura = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarEnGoogleDriveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.controlSeñalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iniciarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detenerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tmTemperatura = new System.Windows.Forms.Timer(this.components);
            this.lstArchivos = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.chtTemperatura)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chtTemperatura
            // 
            chartArea1.Name = "ChartArea1";
            this.chtTemperatura.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chtTemperatura.Legends.Add(legend1);
            this.chtTemperatura.Location = new System.Drawing.Point(62, 60);
            this.chtTemperatura.Name = "chtTemperatura";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "SerieTemperatura";
            this.chtTemperatura.Series.Add(series1);
            this.chtTemperatura.Size = new System.Drawing.Size(506, 314);
            this.chtTemperatura.TabIndex = 0;
            this.chtTemperatura.Text = "chart1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.controlSeñalToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1086, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirToolStripMenuItem,
            this.guardarToolStripMenuItem,
            this.guardarEnGoogleDriveToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.abrirToolStripMenuItem.Text = "Abrir";
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.guardarToolStripMenuItem.Text = "Guardar";
            this.guardarToolStripMenuItem.Click += new System.EventHandler(this.GuardarToolStripMenuItem_Click);
            // 
            // guardarEnGoogleDriveToolStripMenuItem
            // 
            this.guardarEnGoogleDriveToolStripMenuItem.Name = "guardarEnGoogleDriveToolStripMenuItem";
            this.guardarEnGoogleDriveToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.guardarEnGoogleDriveToolStripMenuItem.Text = "Guardar en Google Drive";
            this.guardarEnGoogleDriveToolStripMenuItem.Click += new System.EventHandler(this.GuardarEnGoogleDriveToolStripMenuItem_Click);
            // 
            // controlSeñalToolStripMenuItem
            // 
            this.controlSeñalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iniciarToolStripMenuItem,
            this.detenerToolStripMenuItem});
            this.controlSeñalToolStripMenuItem.Name = "controlSeñalToolStripMenuItem";
            this.controlSeñalToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.controlSeñalToolStripMenuItem.Text = "Control Señal";
            // 
            // iniciarToolStripMenuItem
            // 
            this.iniciarToolStripMenuItem.Name = "iniciarToolStripMenuItem";
            this.iniciarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.iniciarToolStripMenuItem.Text = "Iniciar";
            this.iniciarToolStripMenuItem.Click += new System.EventHandler(this.IniciarToolStripMenuItem_Click);
            // 
            // detenerToolStripMenuItem
            // 
            this.detenerToolStripMenuItem.Name = "detenerToolStripMenuItem";
            this.detenerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.detenerToolStripMenuItem.Text = "Detener";
            this.detenerToolStripMenuItem.Click += new System.EventHandler(this.DetenerToolStripMenuItem_Click);
            // 
            // tmTemperatura
            // 
            this.tmTemperatura.Interval = 1000;
            this.tmTemperatura.Tick += new System.EventHandler(this.TmTemperatura_Tick);
            // 
            // lstArchivos
            // 
            this.lstArchivos.FormattingEnabled = true;
            this.lstArchivos.Location = new System.Drawing.Point(652, 60);
            this.lstArchivos.Name = "lstArchivos";
            this.lstArchivos.Size = new System.Drawing.Size(234, 277);
            this.lstArchivos.TabIndex = 2;
            // 
            // SensaTemperatura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 450);
            this.Controls.Add(this.lstArchivos);
            this.Controls.Add(this.chtTemperatura);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "SensaTemperatura";
            this.Text = "Temperatura";
            ((System.ComponentModel.ISupportInitialize)(this.chtTemperatura)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chtTemperatura;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem controlSeñalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iniciarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detenerToolStripMenuItem;
        private System.Windows.Forms.Timer tmTemperatura;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarEnGoogleDriveToolStripMenuItem;
        private System.Windows.Forms.ListBox lstArchivos;
    }
}