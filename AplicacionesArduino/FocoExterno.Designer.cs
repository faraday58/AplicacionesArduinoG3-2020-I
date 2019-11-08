namespace AplicacionesArduino
{
    partial class FocoExterno
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
            this.ptbFoco = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ptbFoco
            // 
            this.ptbFoco.Location = new System.Drawing.Point(259, 138);
            this.ptbFoco.Name = "ptbFoco";
            this.ptbFoco.Size = new System.Drawing.Size(243, 135);
            this.ptbFoco.TabIndex = 0;
            this.ptbFoco.UseVisualStyleBackColor = true;
            this.ptbFoco.Click += new System.EventHandler(this.PtbFoco_Click);
            // 
            // FocoExterno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ptbFoco);
            this.Name = "FocoExterno";
            this.Text = "FocoExterno";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ptbFoco;
    }
}