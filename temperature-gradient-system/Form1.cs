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

        private void button4_Click(object sender, EventArgs e)
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

        private void timer2_Tick(object sender, EventArgs e)
        {
            //digitalControlSingal_1 = GC.getSingal(1);
            //lblTState_1.Text = digitalControlSingal_1 == 1 ? "On" : "OFF";
            System.Diagnostics.Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();      //  开始监视代码运行时间

            /*
             * time get module
             */

            int RawValue;
            temperatureValue_1 = Board_1.getT(1, out RawValue);
            lblRawData_1.Text = RawValue.ToString();
            lblTValue_1.Text = temperatureValue_1.ToString("00.00");

            if (isExecutePIDModel_1 == true || isExecutePIDModelDown_1 == true)
            {
                lblPIDTValue_1.Text = temperatureValue_1.ToString("00.00");
            }

            /*
             * Test by hand module
             */
            if (isTestByHand_1 == false)
            {
                digitalControlSingal_1 = Board_2.getSingal(1);

            }

            if (temperatureValue_1 > 60 || temperatureValue_1 < 0)
            {
                Board_1.TNature(1);
                timer_1.Stop();
                lblTState_1.Text = "Error";
            }

            /*
             *  Up and Down control module
             */
            if (isExecuteControlModel_1 == true)
            {


                if (digitalControlSingal_1 == 1 && isFirstChangeUp_1 == true)
                {



                    lblTState_1.Text = "On";
                    UpDownSing_1 = 1;
                    punishmentT = float.Parse(tbPunishTValue.Text);
                    confortableT = float.Parse(tbConfortTValue.Text);

                    isFirstChangeUp_1 = false;
                    isFirstChangeDown_1 = true;
                    isUp_1 = true;
                    isDown_1 = false;

                    isStartPID_1 = true;
                    PID_Count_1 = 0;

                    //isFirstPor = true;
                    Board_1.TUp(1);
                    startPID_1 = false;
                    circle = 10;
                    if (isExecutePIDModelDown_1)
                    {
                        PID_1 = new PIDControl(P_1, D_1, I_1, punishmentT);

                    }
                    else
                    {
                        PID_1 = new PIDControl(Kp_up_1, Ki_up_1, Kd_up_1, punishmentT);

                    }


                    System.IO.File.AppendAllText("e:\\result_1.txt", "惩罚：" + "Kp:" + Kp_up_1.ToString() + "  Ki" + Ki_up_1.ToString() + "  Kd" + Kp_up_1.ToString() + "\r\n");
                }
                else if (digitalControlSingal_1 == 0 && isFirstChangeDown_1 == true)
                {
                    punishmentT = float.Parse(tbPunishTValue.Text);
                    confortableT = float.Parse(tbConfortTValue.Text);

                    isDown_1 = true;
                    isStartPID_1 = true;

                    isFirstChangeDown_1 = false;
                    isFirstChangeUp_1 = true;

                    startPID_1 = false;
                    isUp_1 = false;
                    PID_Count_1 = 0;
                    lblTState_1.Text = "Off";
                    UpDownSing_1 = -1;
                    Board_1.TDown(1);
                    circle = 10;
                    if (isExecutePIDModel_1)
                    {
                        PID_1 = new PIDControl(P_1, D_1, I_1, confortableT);

                    }
                    else
                    {
                        PID_1 = new PIDControl(Kp_down_1, Ki_down_1, Kd_down_1, confortableT);

                    }

                    System.IO.File.AppendAllText("e:\\result_1.txt", "舒适：" + "Kp:" + Kp_down_1.ToString() + "  Ki" + Ki_down_1.ToString() + "  Kd" + Kp_down_1.ToString() + "\r\n");
                }
                else
                {
                    ;
                }
            }




            /*
             * PID paramete test module
             */

            if (isExecutePIDModel_1 == true)
            {
                timerCount_1++;

                if (timerCount_1 == 300 && highBalance_1 == true)
                {
                    timerCount_1 = 0;
                    digitalControlSingal_1 = 0;
                    highBalance_1 = false;
                    downLine_1 = true;

                }

                if (timerCount_1 == 150 && downLine_1)
                {
                    //System.IO.File.AppendAllText("e:\\result_1.txt", "舒适：" + "Kp:" + 8 + "  Ki" + 0 + "  Kd" + 3 + "\r\n");
                    isChangeParam_1 = true;
                    downLine_1 = false;
                    timeNotAccept_1 = true;

                }

                if (temperatureValue_1 - confortableT <= 0.5 && downLine_1 == true)
                {
                    beyondNum_1++;
                    if (beyondNum_1 == 3)
                    {


                        timeResult_1 = timerCount_1;
                        timerCount_1 = 0;
                        downLine_1 = false;
                        longKeep_1 = true;
                        beyondNum_1 = 0;

                    }
                }

                if (longKeep_1 == true)
                {
                    tempCollection_1.Add(temperatureValue_1);
                    if (timerCount_1 == 300)
                    {
                        isChangeParam_1 = true;
                        longKeep_1 = false;
                    }

                }






                if (isChangeParam_1)
                {

                    //  lblPIDDebug.Text = isExecutePIDModel_1.ToString();
                    if (timeNotAccept_1)
                    {
                        lblPIDTestStatus_1.Text = (string.Format("P:{0},I:{1},D{2}--时间超出", P_1, I_1, D_1));
                        //System.IO.File.AppendAllText("e:\\result_1.txt", P_1 + "   " + I_1 + "   " + D_1 + "   " + "Tout" + "\r\n");
                        //输出PID 时间超出，舍弃参数

                    }
                    else
                    {
                        string PID_Result_1;
                        resultAnalyse(tempCollection_1, P_1, I_1, D_1, out PID_Result_1, 1);
                        tempCollection_1.Clear();
                        lblPIDTestStatus_1.Text = PID_Result_1;
                        //执行计算，然后输出
                    }
                    if (D_1 == 3)
                    {
                        timer_1.Stop();
                        Board_1.clearALL();
                        lblPIDTestStatus_1.Text = "finished!";
                    }

                    digitalControlSingal_1 = 1;
                    isChangeParam_1 = false;
                    P_1 += 0.5;

                    if (P_1 == 10)
                    {
                        D_1 += 0.5;
                        P_1 = 0.5;
                    }


                    timerCount_1 = 0;
                    beyondNum_1 = 0;
                    highBalance_1 = true;
                }

            }





            /*
             * PID paramete test module
             */

            if (isExecutePIDModelDown_1 == true)
            {
                timerCount_1++;

                if (timerCount_1 == 300 && lowBalance_1 == true)
                {
                    timerCount_1 = 0;
                    digitalControlSingal_1 = 1;
                    lowBalance_1 = false;
                    upLine_1 = true;

                }

                if (timerCount_1 == 100 && upLine_1)
                {
                    //System.IO.File.AppendAllText("e:\\result_1.txt", "舒适：" + "Kp:" + 8 + "  Ki" + 0 + "  Kd" + 3 + "\r\n");
                    isChangeParam_1 = true;
                    upLine_1 = false;
                    timeNotAccept_1 = true;


                }

                if (punishmentT - temperatureValue_1 <= 0.5 && upLine_1 == true)
                {
                    beyondNum_1++;
                    if (beyondNum_1 == 3)
                    {
                        timeResult_1 = timerCount_1;
                        timerCount_1 = 0;
                        upLine_1 = false;
                        longKeep_1 = true;
                        beyondNum_1 = 0;

                    }
                }

                if (longKeep_1 == true)
                {
                    tempCollection_1.Add(temperatureValue_1);
                    if (timerCount_1 == 300)
                    {
                        isChangeParam_1 = true;
                        longKeep_1 = false;
                    }

                }






                if (isChangeParam_1)
                {

                    if (timeNotAccept_1)
                    {
                        lblPIDTestStatus_1.Text = (string.Format("P:{0},I:{1},D{2}--时间超出", P_1, I_1, D_1));
                        //System.IO.File.AppendAllText("e:\\result_1.txt", P_1 + "   " + I_1 + "   " + D_1 + "   " + "Tout" + "\r\n");
                        //输出PID 时间超出，舍弃参数
                    }
                    else
                    {
                        string PID_Result_1;
                        resultAnalyse(tempCollection_1, P_1, I_1, D_1, out PID_Result_1, 1);
                        tempCollection_1.Clear();
                        lblPIDTestStatus_1.Text = PID_Result_1;
                        //执行计算，然后输出
                    }
                    if (D_1 == 10)
                    {
                        timer_1.Stop();
                        Board_1.clearALL();
                        lblPIDTestStatus_1.Text = "Finished!";
                    }

                    digitalControlSingal_1 = 0;
                    isChangeParam_1 = false;
                    P_1 += 0.5;
                    if (P_1 == 10)
                    {
                        D_1 += 0.5;
                        P_1 = 0.5;
                    }


                    timerCount_1 = 0;
                    beyondNum_1 = 0;
                    lowBalance_1 = true;
                }

            }















            if (isUp_1 == true)
            {
                if ((punishmentT - temperatureValue_1) < 10 && isStartPID_1 == true)
                {
                    startPID_1 = true;
                    isStartPID_1 = false;

                    result_1 = PID_1.PIDCalcDirect(temperatureValue_1);
                    FirstProportion_1 = Convert.ToInt32(result_1);
                    proportion_1 = Convert.ToInt32(result_1);
                    proportion_1 = PID_1.ConvertAccordToPropotation(proportion_1, circle, FirstProportion_1);

                    PID_Count_1 = 0;
                    Board_1.TUp(1);


                }





                if (PID_Count_1 == proportion_1 && startPID_1 == true)
                {
                    Board_1.TNature(1);
                }


                if (startPID_1 == true)
                {
                    PID_Count_1++;

                }


                if (startPID_1 == true && PID_Count_1 == circle)
                {
                    result_1 = PID_1.PIDCalcDirect(temperatureValue_1);

                    proportion_1 = Convert.ToInt32(result_1);
                    PID_Count_1 = 0;



                    if (result_1 > 0)
                    {

                        Board_1.TUp(1);

                    }
                    else
                    {
                        Board_1.TDown(1);
                    }

                    proportion_1 = PID_1.ConvertAccordToPropotation(proportion_1, circle, FirstProportion_1);

                }

                if (!isExecuteControlModel_1 || !isExecutePIDModelDown_1)
                {
                    System.IO.File.AppendAllText("e:\\result_1.txt", temperatureValue_1.ToString("00.00") + "   " + UpDownSing_1.ToString() + "\r\n");
                }
            }


            if (isDown_1 == true)
            {
                if ((temperatureValue_1 - confortableT) < 5 && isStartPID_1 == true)
                {
                    startPID_1 = true;
                    isStartPID_1 = false;

                    result_1 = PID_1.PIDCalcDirect(temperatureValue_1);
                    FirstProportion_1 = Convert.ToInt32(result_1);
                    proportion_1 = Convert.ToInt32(result_1);
                    proportion_1 = PID_1.ConvertAccordToPropotation(proportion_1, circle, FirstProportion_1);
                    PID_Count_1 = 0;
                    Board_1.TDown(1);

                }





                if (PID_Count_1 == proportion_1 && startPID_1 == true)
                {
                    Board_1.TNature(1);
                }

                if (startPID_1 == true)
                {
                    PID_Count_1++;

                }

                if (startPID_1 == true && PID_Count_1 == circle)
                {
                    double result_1 = PID_1.PIDCalcDirect(temperatureValue_1);
                    proportion_1 = Convert.ToInt32(result_1);
                    PID_Count_1 = 0;
                    if (result_1 > 0)
                    {
                        Board_1.TUp(1);
                    }
                    else
                    {
                        Board_1.TDown(1);
                    }

                    proportion_1 = PID_1.ConvertAccordToPropotation(proportion_1, circle, FirstProportion_1);


                }
                if (!isExecuteControlModel_1 || !isExecutePIDModelDown_1)
                {
                    System.IO.File.AppendAllText("e:\\result_1.txt", temperatureValue_1.ToString("00.00") + "   " + UpDownSing_1.ToString() + "\r\n");
                }
            }

            stopwatch.Stop(); //  停止监视

            TimeSpan timespan = stopwatch.Elapsed;

            lblExecuteTimeInPID.Text = timespan.TotalMilliseconds.ToString();  //  总毫秒数
        }

        private void btnStart_1_Click(object sender, EventArgs e)
        {

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

                timer2.Stop();
            }
            else
            {
                this.btnStart.Text = "Stop";
                ifStart = true;
                this.desT_1 = double.Parse(tbDesT_1.Text);
                this.desT_2 = double.Parse(tbDesT_2.Text);
                this.desT_3 = double.Parse(tbDesT_3.Text);
                this.desT_4 = double.Parse(tbDesT_4.Text);
                timer2.Interval = 100;
                timer2.Start();
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

            //this.lblT_1.Text = (double.Parse(rawData_1.ToString()) * a_1 + b_1).ToString();
            //this.lblT_2.Text = (double.Parse(rawData_2.ToString()) * a_2 + b_2).ToString();
            //this.lblT_3.Text = (double.Parse(rawData_3.ToString()) * a_3 + b_3).ToString();
            //this.lblT_4.Text = (double.Parse(rawData_4.ToString()) * a_4 + b_4).ToString();
        }
    }
}
