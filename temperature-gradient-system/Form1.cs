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
using PID_WinForm;

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


        //goal of temperature
        private double desT_1;
        private double desT_2;
        private double desT_3;
        private double desT_4;



        private void button1_Click_1(object sender, EventArgs e)
        {
            lsm_2.AddValueToX(double.Parse(this.lblTFitValue_2.Text));
            lsm_2.AddValueToY(double.Parse(this.tbInputCurrentT_2.Text));
            lblXValue.Text = lsm_2.X_temp.ToString();
            lblYValue.Text = lsm_2.Y_temp.ToString();

            lblAddNumber_2.Text = lsm_2.Count.ToString();
        }


        private void btnAdd_3_Click(object sender, EventArgs e)
        {
            lsm_3.AddValueToX(double.Parse(this.lblTFitValue_3.Text));
            lsm_3.AddValueToY(double.Parse(this.tbInputCurrentT_3.Text));
            lblXValue.Text = lsm_3.X_temp.ToString();
            lblYValue.Text = lsm_3.Y_temp.ToString();

            lblAddNumber_3.Text = lsm_3.Count.ToString();
        }


        private void btnAdd_4_Click(object sender, EventArgs e)
        {
            lsm_4.AddValueToX(double.Parse(this.lblTFitValue_4.Text));
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

            tp.a3 = a_3;
            tp.b3 = b_3;
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

        private void button4_Click(object sender, EventArgs e)
        {
            if (ifStart)
            {
                this.btnStartTFit.Text = "Start";

                ifStart = false;

                timer1.Stop();
            }
            else
            {
                this.btnStartTFit.Text = "Stop";
                ifStart = true;

                timer1.Interval = 100;
                timer1.Start();
            }
        }

        private double temperatureValue_1;





        /// <summary>
        /// 控制温度升降
        /// </summary>
        /// <param name="groupNumber">from 1 to 8</param>
        private void TUp(int groupNumber)
        {
            switch (groupNumber)
            {
                case 1:
                    pc.DigitOutput(1, MccDaq.DigitalLogicState.Low);
                    pc.DigitOutput(0, MccDaq.DigitalLogicState.Low);
                    break;
                case 2:
                    pc.DigitOutput(3, MccDaq.DigitalLogicState.Low);
                    pc.DigitOutput(2, MccDaq.DigitalLogicState.Low);
                    
                    break;
                
            }

        }


        /// <summary>
        /// 控制温度下降 
        /// </summary>
        /// <param name="groupNumber">protNumber form 1 to 8</param>
        public void TDown(int groupNumber)
        {

            switch (groupNumber)
            {
                case 1:
                    pc.DigitOutput(1, MccDaq.DigitalLogicState.Low);
                    pc.DigitOutput(0, MccDaq.DigitalLogicState.High);
                    break;
                case 2:
                    pc.DigitOutput(3, MccDaq.DigitalLogicState.Low);
                    pc.DigitOutput(2, MccDaq.DigitalLogicState.High);
                    break;
             
            }

        }

        /// <summary>
        /// 将端口清0，不控制温度升降，让其处于自然状态
        /// when PortINH form 9 to 23 is low
        /// the temperature will not control by computer
        /// </summary>
        /// <param name="groupNumber">port number</param>
        public void TNature(int groupNumber)
        {

            switch (groupNumber)
            {
                case 1:
                    pc.DigitOutput(1, MccDaq.DigitalLogicState.High);
                   
                    break;
                case 2:
                    pc.DigitOutput(3, MccDaq.DigitalLogicState.High);
                    
                    break;
                

            }

        }





        private bool isUp_1;
        private bool startPID_1;
        private bool isStartPID_1;
        private PIDControl PID_1;
        private double result_1;
        private int FirstProporation_1;
        private int proporation_1;
        private int circle;
        private int PID_Count_1;


        private bool isUp_2;
        private bool startPID_2;
        private bool isStartPID_2;
        private PIDControl PID_2;
        private double result_2;
        private int FirstProporation_2;
        private int proporation_2;
        private int PID_Count_2;




        private void timer2_Tick(object sender, EventArgs e)
        {
           
            /*
             * time get module
             */

            int RawValue;
            int rawData_1 = int.Parse(pc.AnalogInput(0));
            
           
            double temperatureValue_1 = rawData_1 * a_1 + b_1;

            lblRawValue_1.Text = rawData_1.ToString();
            lblT_1.Text = temperatureValue_1.ToString("00.00");

            int rawData_3 = int.Parse(pc.AnalogInput(2));


            double temperatureValue_3 = rawData_3 * a_3 + b_3;

            lblRawValue_3.Text = rawData_3.ToString();
            lblT_3.Text = temperatureValue_3.ToString("00.00");


            if (temperatureValue_1 > 60 || temperatureValue_1 < 0)
            {
                TNature(1);
                tControl_1.Stop();
                MessageBox.Show("Temperature Out");
            }

            /*
             *  Up and Down control module
             */
             

            if (isUp_1 == true)
            {
                if (Math.Abs(desT_1 - temperatureValue_1) < 10 && isStartPID_1 == true)
                {
                    startPID_1 = true;
                    isStartPID_1 = false;

                    result_1 = PID_1.PIDCalcDirect(temperatureValue_1);

                    if (result_1 > 0)
                    {

                        TUp(1);

                    }
                    else
                    {
                        TDown(1);
                    }


                    FirstProporation_1 = Convert.ToInt32(result_1);
                    proporation_1 = Convert.ToInt32(result_1);
                    proporation_1 = PID_1.ConvertAccordToPropotation(proporation_1, circle, FirstProporation_1);

                    PID_Count_1 = 0;
                    


                }





                if (PID_Count_1 == proporation_1 && startPID_1 == true)
                {
                    TNature(1);
                }


                if (startPID_1 == true)
                {
                    PID_Count_1++;

                }


                if (startPID_1 == true && PID_Count_1 == circle)
                {
                    result_1 = PID_1.PIDCalcDirect(temperatureValue_1);

                    proporation_1 = Convert.ToInt32(result_1);
                    PID_Count_1 = 0;



                    if (result_1 > 0)
                    {

                        TUp(1);

                    }
                    else
                    {
                        TDown(1);
                    }

                    proporation_1 = PID_1.ConvertAccordToPropotation(proporation_1, circle, FirstProporation_1);

                }


            }


            


        }

        private bool ifStart_1 = false;
        private bool ifStart_2 = false;

        private void btnStart_1_Click(object sender, EventArgs e)
        {
            if (ifStart_1)
            {
                this.btnStart_1.Text = "Start";

                ifStart_1 = false;
                this.tControl_1.Interval = 10;

                TNature(1);

                isUp_1 = false;
            }
            else
            {
                this.btnStart_1.Text = "Stop";
                ifStart_1 = true;



                isStartPID_1 = true;
                
                PID_Count_1 = 0;

                //isFirstPor = true;
                
                startPID_1 = false;
                circle = 10;
                
                
                
                this.desT_1 = double.Parse(tbDesT_1.Text);
                double rawData_1 = double.Parse(pc.AnalogInput(0))*a_1+b_1;
                if (rawData_1 > desT_1)
                {
                    TDown(1);
                }
                else
                {
                   TUp(1);
                }
                PID_1 = new PIDControl(3, 0.1, 0.5, desT_1);
                isUp_1 = true;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            TUp(1);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            TDown(1);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            TNature(1);
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            TUp(2);
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            TDown(2);
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            TNature(2);
        }

        private int testTimeCount;
        private int testSpikeCount;
        private int testCount;
        private bool countSwitch;
       
        
        private void timer3_Tick(object sender, EventArgs e)
        {
            int rawData_1 = int.Parse(pc.AnalogInput(0));
            this.lblTestTValue.Text = (double.Parse(rawData_1.ToString()) * a_1 + b_1).ToString();
            countSwitch = true;
            if (testCount < testSpikeCount)
            {

                if (cbTestUpOrDown.Checked)
                {
                    TDown(1);
                }
                else
                {
                    TUp(1);
                }


            }


            else if (testCount < testTimeCount & testCount >= testSpikeCount)
            {
                TNature(1);

            }

            else
            {
                countSwitch = false;
                testCount = 0;
            }

            if (countSwitch)
            {
                testCount++;
            }

            
            
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            if (ifStart_2)
            {
                this.btnStart_2.Text = "Start";

                ifStart_2 = false;
                this.tControl_2.Interval = 10;

                TNature(2);

                isUp_2 = false;
            }
            else
            {
                this.btnStart_2.Text = "Stop";
                ifStart_2 = true;



                isStartPID_2 = true;

                PID_Count_2 = 0;

                //isFirstPor = true;

                startPID_2 = false;
                circle = 10;



                this.desT_2 = double.Parse(tbDesT_2.Text);
                double rawData_2 = double.Parse(pc.AnalogInput(1)) * a_2 + b_2;
                if (rawData_2 > desT_2)
                {
                    TDown(2);
                }
                else
                {
                    TUp(2);
                }
                PID_2 = new PIDControl(3, 0.1, 0.5, desT_2);
                isUp_2 = true;
            }
        }

        private void tControl_2_Tick(object sender, EventArgs e)
        {
            /*
            * time get module
            */

            int RawValue;
            int rawData_2 = int.Parse(pc.AnalogInput(1));


            double temperatureValue_2 = rawData_2 * a_2 + b_2;

            lblRawValue_2.Text = rawData_2.ToString();
            lblT_2.Text = temperatureValue_2.ToString("00.00");

            int rawData_4 = int.Parse(pc.AnalogInput(3));


            double temperatureValue_4 = rawData_4 * a_4 + b_4;

            lblRawValue_4.Text = rawData_4.ToString();
            lblT_4.Text = temperatureValue_4.ToString("00.00");


            if (temperatureValue_1 > 60 || temperatureValue_1 < 0)
            {
                TNature(2);
                tControl_2.Stop();
                MessageBox.Show("Temperature Out");
            }

            /*
             *  Up and Down control module
             */


            if (isUp_2 == true)
            {
                if (Math.Abs(desT_2 - temperatureValue_2) < 10 && isStartPID_2 == true)
                {
                    startPID_2 = true;
                    isStartPID_2 = false;

                    result_2 = PID_2.PIDCalcDirect(temperatureValue_2);

                    if (result_2 > 0)
                    {

                        TUp(2);

                    }
                    else
                    {
                        TDown(2);
                    }


                    FirstProporation_2 = Convert.ToInt32(result_2);
                    proporation_2 = Convert.ToInt32(result_2);
                    proporation_2 = PID_2.ConvertAccordToPropotation(proporation_2, circle, FirstProporation_2);

                    PID_Count_2 = 0;



                }





                if (PID_Count_2 == proporation_2 && startPID_2 == true)
                {
                    TNature(2);
                }


                if (startPID_2 == true)
                {
                    PID_Count_2++;

                }


                if (startPID_2 == true && PID_Count_2 == circle)
                {
                    result_2 = PID_2.PIDCalcDirect(temperatureValue_2);

                    proporation_2 = Convert.ToInt32(result_2);
                    PID_Count_2 = 0;



                    if (result_2 > 0)
                    {

                        TUp(2);

                    }
                    else
                    {
                        TDown(2);
                    }

                    proporation_2 = PID_2.ConvertAccordToPropotation(proporation_2, circle, FirstProporation_2);

                }


            }
        }

        private void cbChooseT1_CheckedChanged(object sender, EventArgs e)
        {
            if (this.cbChooseT1.Checked)
            {
                
                a_2 = a_1;
                b_2 = b_1;
                a_3 = a_1;
                b_3 = b_1;
                a_4 = a_1;
                b_4 = b_1;
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            TNature(2);
            TNature(1);
        }

        private bool ifTestStartOpen = false;

        private void btnTestStart_Click(object sender, EventArgs e)
        {
            if (ifTestStartOpen)
            {
                ifTestStartOpen = false;
                this.btnTestStart.Text = "Start";
                this.timer3.Stop();
            }
            else
            {
                ifTestStartOpen = true;
                this.btnTestStart.Text = "Stop";
                this.testTimeCount = int.Parse(this.tbTestTime.Text);
                this.testSpikeCount = int.Parse(this.tbTestSpikeTime.Text);
                testCount = 0;
                this.timer3.Interval = 100;
                this.timer3.Start();
            }
        }

        private void cbTestUpOrDown_CheckedChanged(object sender, EventArgs e)
        {

            if (cbTestUpOrDown.Checked)
            {
                this.cbTestUpOrDown.Text = "Down";
            }
            else
            {
                this.cbTestUpOrDown.Text = "Up";
            }


        }

        private void btnTestClear_Click(object sender, EventArgs e)
        {
            TNature(1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            lsm_1.AddValueToX(double.Parse(this.lblTFitValue_1.Text));
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

            TNature(1);
            TNature(2);
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
                TNature(0);
                TNature(1);
                tControl_1.Stop();
                tControl_2.Stop();
            }
            else
            {
                this.btnStart.Text = "Stop";
                ifStart = true;
                
                
                tControl_1.Interval = 10;
                tControl_2.Interval = 10;
                tControl_2.Start();
                tControl_1.Start();
            }
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            int rawData_1 = int.Parse(pc.AnalogInput(0));
            int rawData_2 = int.Parse(pc.AnalogInput(1));
            int rawData_3 = int.Parse(pc.AnalogInput(2));
            int rawData_4 = int.Parse(pc.AnalogInput(3));
            this.lblTFitValue_1.Text = rawData_1.ToString();
            this.lblTFitValue_2.Text = rawData_2.ToString();
            this.lblTFitValue_3.Text = rawData_3.ToString();
            this.lblTFitValue_4.Text = rawData_4.ToString();

            this.lblTFitTemperature_1.Text = (double.Parse(rawData_1.ToString()) * a_1 + b_1).ToString();
            this.lblTFitTemperature_2.Text = (double.Parse(rawData_2.ToString()) * a_2 + b_2).ToString();
            this.lblTFitTemperature_3.Text = (double.Parse(rawData_3.ToString()) * a_3 + b_3).ToString();
            this.lblTFitTemperature_4.Text = (double.Parse(rawData_4.ToString()) * a_4 + b_4).ToString();
        }

    }
}
