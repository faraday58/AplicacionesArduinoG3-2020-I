using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;

namespace AplicacionesArduino
{
     public partial class FormMdiPadre : Form
    {
        private SerialPort miPuerto;

        public FormMdiPadre()
        {
            InitializeComponent();
            miPuerto = new SerialPort();
        }

        private void selecciona()
        {
            tscmbPuertos.Items.Clear();
            string[] puertos = SerialPort.GetPortNames();
            Array.Sort(puertos);
            tscmbPuertos.Items.AddRange(puertos);                     
        }




        private void GuaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            selecciona();
        }

        private void ConectarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            desconectarToolStripMenuItem.Enabled = true;
            conectarToolStripMenuItem.Enabled = false;
            try
            {
                miPuerto.PortName = tscmbPuertos.SelectedItem.ToString();
                miPuerto.BaudRate = int.Parse(tscmbVelocidad.SelectedItem.ToString());
                miPuerto.Open();
                if(miPuerto.IsOpen  )
                {
                    conectarToolStripMenuItem.Checked = true;
                }
                desconectarToolStripMenuItem.Enabled = true;
            }
            catch( IOException error )
            {
                MessageBox.Show("Error " + error.Message);
            }

        }

        private void ConfirmarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (tscmbPuertos.Text !="" && tscmbVelocidad.Text != "")
            {
                conectarToolStripMenuItem.Enabled = true;
            }
            
        }

        private void DesconectarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            desconectarToolStripMenuItem.Enabled = false;
            conectarToolStripMenuItem.Enabled = false;
            conectarToolStripMenuItem.Checked = false;
        }

        private void FocoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Foco miFoco = new Foco(miPuerto);
            miFoco.MdiParent = this;
            miFoco.Show();
        }
    }
}
