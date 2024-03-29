﻿using System;
using System.Collections.Generic;
using System.IO.Ports;

using System.Drawing;

using System.Windows.Forms;

namespace AplicacionesArduino
{
    public partial class Foco : Form

    {
        SerialPort miPuerto ;
        bool encender = true;
        public Foco(SerialPort puertoSerie)
        {
            this.miPuerto = puertoSerie;
            InitializeComponent();
            ptbFoco.BackColor = Color.Aqua;

        }

        private void PtbFoco_Click(object sender, EventArgs e)
        {

            chart1.Series["serieTemperatura"].Points.AddXY(1, 2);


            if (encender)
            {
                miPuerto.Write("a");
                ptbFoco.BackColor = Color.Yellow;
                encender = false;
            }
            else
            {
                miPuerto.Write("b");
                ptbFoco.BackColor = Color.Aqua;
                encender = true;
            }
        }
    }
}
