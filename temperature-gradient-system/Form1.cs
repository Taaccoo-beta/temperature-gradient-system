using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XControl;
namespace temperature_gradient_system
{
    public partial class Form1 : Form
    {

        private bool ifStart;
        private PortControl pc;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pc = new PortControl(0);
            pc.AnalogPortConfigurationIn();
            pc.DigitalConfigurationOut();

            ifStart = false;
          
            
        }

        private void tFitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TFit tf = new TFit();
            tf.Show();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (ifStart)
            {
                this.btnStart.Text = "Start";

                ifStart = false;

                timer1.Stop();
            }
            else
            {
                this.btnStart.Text = "Stop";
                ifStart = true;

                timer1.Interval = 100;
                timer1.Start();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int rawData_1 = int.Parse(pc.AnalogInput(0));
            int rawData_2 = int.Parse(pc.AnalogInput(1));
            int rawData_3 = int.Parse(pc.AnalogInput(2));
            int rawData_4 = int.Parse(pc.AnalogInput(3));

            this.lblT_1.Text = rawData_1.ToString();
            this.lblT_2.Text = rawData_2.ToString();
            this.lblT_3.Text = rawData_3.ToString();
            this.lblT_4.Text = rawData_4.ToString();
        }
    }
}
