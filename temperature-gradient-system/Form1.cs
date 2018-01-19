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

        //funciton   y = ax + b
        private double a_1, a_2, a_3, a_4;
        private double b_1, b_2, b_3, b_4;

        //Tfit
        LeastSquareMethod lsm_1;
        LeastSquareMethod lsm_2;
        LeastSquareMethod lsm_3;
        LeastSquareMethod lsm_4;

        private void button1_Click_1(object sender, EventArgs e)
        {
            lsm_2.AddValueToX(double.Parse(this.lblT_2.Text));
            lsm_2.AddValueToY(double.Parse(this.tbInputCurrentT_2.Text));
            lblXValue.Text = lsm_2.X_temp.ToString();
            lblYValue.Text = lsm_2.Y_temp.ToString();

            lblAddNumber_2.Text = lsm_2.Count.ToString();
        }

        private void btnAdd_3_Click(object sender, EventArgs e)
        {
            lsm_3.AddValueToX(double.Parse(this.lblT_3.Text));
            lsm_3.AddValueToY(double.Parse(this.tbInputCurrentT_3.Text));
            lblXValue.Text = lsm_3.X_temp.ToString();
            lblYValue.Text = lsm_3.Y_temp.ToString();

            lblAddNumber_3.Text = lsm_3.Count.ToString();
        }

        private void btnAdd_4_Click(object sender, EventArgs e)
        {
            lsm_4.AddValueToX(double.Parse(this.lblT_4.Text));
            lsm_4.AddValueToY(double.Parse(this.tbInputCurrentT_4.Text));
            lblXValue.Text = lsm_4.X_temp.ToString();
            lblYValue.Text = lsm_4.Y_temp.ToString();

            lblAddNumber_4.Text = lsm_4.Count.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lsm_1.AddValueToX(double.Parse(this.lblT_1.Text));
            lsm_1.AddValueToY(double.Parse(this.tbInputCurrentT_1.Text));
            lblXValue.Text = lsm_1.X_temp.ToString();
            lblYValue.Text = lsm_1.Y_temp.ToString();

            lblAddNumber_1.Text = lsm_1.Count.ToString();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pc = new PortControl(0);
            pc.AnalogPortConfigurationIn();
            pc.DigitalConfigurationOut();


            ///test module
            a_1 = 10;
            a_2 = 10;
            a_3 = 10;
            a_4 = 10;
            b_1 = 10;
            b_2 = 10;
            b_3 = 10;
            b_4 = 10;


            ifStart = false;

            lsm_1 = new LeastSquareMethod();
            lsm_2 = new LeastSquareMethod();
            lsm_3 = new LeastSquareMethod();
            lsm_4 = new LeastSquareMethod();

        }

        private void tFitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
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
