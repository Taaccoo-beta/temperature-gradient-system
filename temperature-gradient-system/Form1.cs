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
using SerieslizeControlModule;

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
            lsm_2.AddValueToX(double.Parse(this.lblRawValue_2.Text));
            lsm_2.AddValueToY(double.Parse(this.tbInputCurrentT_2.Text));
            lblXValue.Text = lsm_2.X_temp.ToString();
            lblYValue.Text = lsm_2.Y_temp.ToString();

            lblAddNumber_2.Text = lsm_2.Count.ToString();
        }

        private void btnAdd_3_Click(object sender, EventArgs e)
        {
            lsm_3.AddValueToX(double.Parse(this.lblRawValue_3.Text));
            lsm_3.AddValueToY(double.Parse(this.tbInputCurrentT_3.Text));
            lblXValue.Text = lsm_3.X_temp.ToString();
            lblYValue.Text = lsm_3.Y_temp.ToString();

            lblAddNumber_3.Text = lsm_3.Count.ToString();
        }

        private void btnAdd_4_Click(object sender, EventArgs e)
        {
            lsm_4.AddValueToX(double.Parse(this.lblRawValue_4.Text));
            lsm_4.AddValueToY(double.Parse(this.tbInputCurrentT_4.Text));
            lblXValue.Text = lsm_4.X_temp.ToString();
            lblYValue.Text = lsm_4.Y_temp.ToString();

            lblAddNumber_4.Text = lsm_4.Count.ToString();
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            TParameters tp = new TParameters();
            lsm_1.getParameter(ref tp.a1, ref tp.b1);
            //tp.b1 = -tp.b1;

            lsm_2.getParameter(ref tp.a2, ref tp.b2);
            //tp.b2 = -tp.b2;

            lsm_3.getParameter(ref tp.a3, ref tp.b3);
            //tp.b3 = -tp.b3;

            lsm_4.getParameter(ref tp.a4, ref tp.b4);
            //tp.b4 = -tp.b4;

            CoreSerialize cs = new CoreSerialize();
            cs.TParammSerializeNow(tp);

            a_1 = tp.a1;
            b_1 = tp.b1;
            a_2 = tp.a2;
            b_2 = tp.b2;
            a_3 = tp.a3;
            b_3 = tp.b3;
            a_4 = tp.a4;
            b_4 = tp.b4;




        }
        
        private void btnTest_Click(object sender, EventArgs e)
        {
            
            
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
           

        }

        private void btnSet_1_Click(object sender, EventArgs e)
        {
            TParameters tp = new TParameters();
            lsm_1.getParameter(ref tp.a1, ref tp.b1);
            //tp.b1 = -tp.b1;

            tp.a2 = a_2;
            tp.b2 = b_2;
            tp.a3 = a_3;
            tp.b3 = b_3;
            tp.a4 = a_4;
            tp.b4 = b_4;

            CoreSerialize cs = new CoreSerialize();
            cs.TParammSerializeNow(tp);

            a_1 = tp.a1;
            b_1 = tp.b1;
            a_2 = tp.a2;
            b_2 = tp.b2;
            a_3 = tp.a3;
            b_3 = tp.b3;
            a_4 = tp.a4;
            b_4 = tp.b4;
        }

        private void btnSet_2_Click(object sender, EventArgs e)
        {
            TParameters tp = new TParameters();
            lsm_2.getParameter(ref tp.a2, ref tp.b2);
            //tp.b1 = -tp.b1;

            tp.a1 = a_1;
            tp.b1 = b_1;
            tp.a3 = a_3;
            tp.b3 = b_3;
            tp.a4 = a_4;
            tp.b4 = b_4;

            CoreSerialize cs = new CoreSerialize();
            cs.TParammSerializeNow(tp);

            a_1 = tp.a1;
            b_1 = tp.b1;
            a_2 = tp.a2;
            b_2 = tp.b2;
            a_3 = tp.a3;
            b_3 = tp.b3;
            a_4 = tp.a4;
            b_4 = tp.b4;
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void btnSet_3_Click(object sender, EventArgs e)
        {
            TParameters tp = new TParameters();
            lsm_3.getParameter(ref tp.a3, ref tp.b3);
            //tp.b1 = -tp.b1;

            tp.a2 = a_2;
            tp.b2 = b_2;
            tp.a1 = a_1;
            tp.b1 = b_1;
            tp.a4 = a_4;
            tp.b4 = b_4;

            CoreSerialize cs = new CoreSerialize();
            cs.TParammSerializeNow(tp);

            a_1 = tp.a1;
            b_1 = tp.b1;
            a_2 = tp.a2;
            b_2 = tp.b2;
            a_3 = tp.a3;
            b_3 = tp.b3;
            a_4 = tp.a4;
            b_4 = tp.b4;
        }

        private void btnSet_4_Click(object sender, EventArgs e)
        {
            TParameters tp = new TParameters();
            lsm_4.getParameter(ref tp.a4, ref tp.b4);
            //tp.b1 = -tp.b1;

            tp.a2 = a_2;
            tp.b2 = b_2;
            tp.a3 = a_3;
            tp.b3 = b_3;
            tp.a1 = a_1;
            tp.b1 = b_1;

            CoreSerialize cs = new CoreSerialize();
            cs.TParammSerializeNow(tp);

            a_1 = tp.a1;
            b_1 = tp.b1;
            a_2 = tp.a2;
            b_2 = tp.b2;
            a_3 = tp.a3;
            b_3 = tp.b3;
            a_4 = tp.a4;
            b_4 = tp.b4;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            lsm_1.AddValueToX(double.Parse(this.lblRawValue_1.Text));
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


            CoreSerialize cs = new CoreSerialize();
            TParameters dataT = new TParameters();
            try
            {

                dataT = cs.TParamDeSerializeNow();
                a_1 = dataT.a1;
                b_1 = dataT.b1;
                a_2 = dataT.a2;
                b_2 = dataT.b2;
                a_3 = dataT.a3;
                b_3 = dataT.b3;
                a_4 = dataT.a4;
                b_4 = dataT.b4;

            }
            catch
            {
                a_1 = 10;
                b_1 = 1000;
                a_2 = 10;
                b_2 = 1000;
                a_3 = 10;
                b_3 = 1000;
                a_4 = 10;
                b_4 = 1000;

            }


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
            this.lblRawValue_1.Text = rawData_1.ToString();
            this.lblRawValue_2.Text = rawData_2.ToString();
            this.lblRawValue_3.Text = rawData_3.ToString();
            this.lblRawValue_4.Text = rawData_4.ToString();

            this.lblT_1.Text = (double.Parse(rawData_1.ToString())*a_1+b_1).ToString();
            this.lblT_2.Text = (double.Parse(rawData_2.ToString()) * a_2 + b_2).ToString();
            this.lblT_3.Text = (double.Parse(rawData_3.ToString()) * a_3 + b_3).ToString();
            this.lblT_4.Text = (double.Parse(rawData_4.ToString()) * a_4 + b_4).ToString();
        }
    }
}
