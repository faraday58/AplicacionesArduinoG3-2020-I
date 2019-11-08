using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Drawing;
using System.Windows.Forms;

namespace AplicacionesArduino
{
    public partial class FocoExterno : Form
    {
        SerialPort miPuerto;
        
        public FocoExterno(SerialPort puertoSerie)
        {
            this.miPuerto = puertoSerie;
            InitializeComponent();
            ptbFoco.BackColor = Color.Aqua;
            miPuerto.DataReceived += PtbFoco_Click;

        }

        private void PtbFoco_Click(object sender, EventArgs e)
        {
            char caracter =Convert.ToChar(miPuerto.ReadChar());
           

            if (caracter=='a')
            {
                
                ptbFoco.BackColor = Color.Yellow;
                
            }
            else
            {
                
                ptbFoco.BackColor = Color.Aqua;
                
            }
        }
    }
}
