using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppAboutFlashyColors
{
    public partial class Form1 : Form
    {
        private int red, green, blue;
        private int dred, dgreen, dblue;

        private void timer1_Tick(object sender, EventArgs e)
        {
            red = red + dred;
            if (red > 255)
            { red = 255; dred = (-1) * dred; }
            if (red < 0) { red = 0; dred = (-1) * dred; }

            green = green + dgreen;
            if (green > 255)
            { green = 255; dgreen = (-1) * dgreen; }
            if (green < 0) { green = 0; dgreen = (-1) * dgreen; }

            blue = blue + dblue;
            if (blue > 255)
            { blue = 255; dblue = (-1) * dblue; }
            if (blue < 0) { blue = 0; dblue = (-1) * dblue; }

            this.BackColor = Color.FromArgb(red, green, blue);
        }

        public Form1()
        {
            InitializeComponent();
            this.red = 27;
            this.green = 200;
            this.blue = 79;
            this.dred = 8;
            dgreen = -7;
            dblue = 10;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.timer1.Enabled == false)
                this.timer1.Enabled = true;
            else
                this.timer1.Enabled = false;

            //trick to write it shorter:
            //this.timer1.Enabled = !this.timer1.Enabled;

        }
    }
}
