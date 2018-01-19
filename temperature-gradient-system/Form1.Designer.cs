namespace temperature_gradient_system
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tFitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblRawValue_4 = new System.Windows.Forms.Label();
            this.lblRawValue_3 = new System.Windows.Forms.Label();
            this.lblRawValue_2 = new System.Windows.Forms.Label();
            this.lblRawValue_1 = new System.Windows.Forms.Label();
            this.lblT_4 = new System.Windows.Forms.Label();
            this.lblT_3 = new System.Windows.Forms.Label();
            this.lblT_2 = new System.Windows.Forms.Label();
            this.lblT_1 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.gbTFit_1 = new System.Windows.Forms.GroupBox();
            this.tbInputCurrentT_1 = new System.Windows.Forms.TextBox();
            this.lblAddNumber_1 = new System.Windows.Forms.Label();
            this.btnAdd_1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbInputCurrentT_2 = new System.Windows.Forms.TextBox();
            this.lblAddNumber_2 = new System.Windows.Forms.Label();
            this.btnAdd_2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbInputCurrentT_3 = new System.Windows.Forms.TextBox();
            this.lblAddNumber_3 = new System.Windows.Forms.Label();
            this.btnAdd_3 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tbInputCurrentT_4 = new System.Windows.Forms.TextBox();
            this.lblAddNumber_4 = new System.Windows.Forms.Label();
            this.btnAdd_4 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblXValue = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblYValue = new System.Windows.Forms.Label();
            this.btnSet_1 = new System.Windows.Forms.Button();
            this.btnSet_2 = new System.Windows.Forms.Button();
            this.btnSet_3 = new System.Windows.Forms.Button();
            this.btnSet_4 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblTFitValue_4 = new System.Windows.Forms.Label();
            this.lblTFitValue_3 = new System.Windows.Forms.Label();
            this.lblTFitValue_2 = new System.Windows.Forms.Label();
            this.lblTFitValue_1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbTFit_1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(799, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tFitToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // tFitToolStripMenuItem
            // 
            this.tFitToolStripMenuItem.Name = "tFitToolStripMenuItem";
            this.tFitToolStripMenuItem.Size = new System.Drawing.Size(94, 22);
            this.tFitToolStripMenuItem.Text = "TFit";
            this.tFitToolStripMenuItem.Click += new System.EventHandler(this.tFitToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblRawValue_4);
            this.groupBox1.Controls.Add(this.lblRawValue_3);
            this.groupBox1.Controls.Add(this.lblRawValue_2);
            this.groupBox1.Controls.Add(this.lblRawValue_1);
            this.groupBox1.Controls.Add(this.lblT_4);
            this.groupBox1.Controls.Add(this.lblT_3);
            this.groupBox1.Controls.Add(this.lblT_2);
            this.groupBox1.Controls.Add(this.lblT_1);
            this.groupBox1.Location = new System.Drawing.Point(82, 91);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Size = new System.Drawing.Size(560, 127);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Temperture";
            // 
            // lblRawValue_4
            // 
            this.lblRawValue_4.Font = new System.Drawing.Font("SimSun", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblRawValue_4.Location = new System.Drawing.Point(456, 70);
            this.lblRawValue_4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRawValue_4.Name = "lblRawValue_4";
            this.lblRawValue_4.Size = new System.Drawing.Size(86, 45);
            this.lblRawValue_4.TabIndex = 11;
            this.lblRawValue_4.Text = "NULL";
            // 
            // lblRawValue_3
            // 
            this.lblRawValue_3.Font = new System.Drawing.Font("SimSun", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblRawValue_3.Location = new System.Drawing.Point(314, 70);
            this.lblRawValue_3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRawValue_3.Name = "lblRawValue_3";
            this.lblRawValue_3.Size = new System.Drawing.Size(86, 45);
            this.lblRawValue_3.TabIndex = 10;
            this.lblRawValue_3.Text = "NULL";
            // 
            // lblRawValue_2
            // 
            this.lblRawValue_2.Font = new System.Drawing.Font("SimSun", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblRawValue_2.Location = new System.Drawing.Point(159, 70);
            this.lblRawValue_2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRawValue_2.Name = "lblRawValue_2";
            this.lblRawValue_2.Size = new System.Drawing.Size(86, 45);
            this.lblRawValue_2.TabIndex = 9;
            this.lblRawValue_2.Text = "NULL";
            // 
            // lblRawValue_1
            // 
            this.lblRawValue_1.Font = new System.Drawing.Font("SimSun", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblRawValue_1.Location = new System.Drawing.Point(34, 70);
            this.lblRawValue_1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRawValue_1.Name = "lblRawValue_1";
            this.lblRawValue_1.Size = new System.Drawing.Size(86, 45);
            this.lblRawValue_1.TabIndex = 8;
            this.lblRawValue_1.Text = "NULL";
            // 
            // lblT_4
            // 
            this.lblT_4.Font = new System.Drawing.Font("SimSun", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblT_4.Location = new System.Drawing.Point(456, 25);
            this.lblT_4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblT_4.Name = "lblT_4";
            this.lblT_4.Size = new System.Drawing.Size(75, 45);
            this.lblT_4.TabIndex = 7;
            this.lblT_4.Text = "NULL";
            // 
            // lblT_3
            // 
            this.lblT_3.Font = new System.Drawing.Font("SimSun", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblT_3.Location = new System.Drawing.Point(314, 25);
            this.lblT_3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblT_3.Name = "lblT_3";
            this.lblT_3.Size = new System.Drawing.Size(74, 45);
            this.lblT_3.TabIndex = 6;
            this.lblT_3.Text = "NULL";
            // 
            // lblT_2
            // 
            this.lblT_2.Font = new System.Drawing.Font("SimSun", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblT_2.Location = new System.Drawing.Point(159, 25);
            this.lblT_2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblT_2.Name = "lblT_2";
            this.lblT_2.Size = new System.Drawing.Size(79, 45);
            this.lblT_2.TabIndex = 5;
            this.lblT_2.Text = "NULL";
            // 
            // lblT_1
            // 
            this.lblT_1.Font = new System.Drawing.Font("SimSun", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblT_1.Location = new System.Drawing.Point(34, 25);
            this.lblT_1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblT_1.Name = "lblT_1";
            this.lblT_1.Size = new System.Drawing.Size(86, 45);
            this.lblT_1.TabIndex = 4;
            this.lblT_1.Text = "NULL";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(548, 268);
            this.btnStart.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(94, 35);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // gbTFit_1
            // 
            this.gbTFit_1.Controls.Add(this.btnSet_1);
            this.gbTFit_1.Controls.Add(this.tbInputCurrentT_1);
            this.gbTFit_1.Controls.Add(this.lblAddNumber_1);
            this.gbTFit_1.Controls.Add(this.btnAdd_1);
            this.gbTFit_1.Controls.Add(this.label1);
            this.gbTFit_1.Location = new System.Drawing.Point(103, 109);
            this.gbTFit_1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gbTFit_1.Name = "gbTFit_1";
            this.gbTFit_1.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gbTFit_1.Size = new System.Drawing.Size(120, 187);
            this.gbTFit_1.TabIndex = 8;
            this.gbTFit_1.TabStop = false;
            this.gbTFit_1.Text = "TFit-1";
            // 
            // tbInputCurrentT_1
            // 
            this.tbInputCurrentT_1.Location = new System.Drawing.Point(20, 68);
            this.tbInputCurrentT_1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbInputCurrentT_1.Name = "tbInputCurrentT_1";
            this.tbInputCurrentT_1.Size = new System.Drawing.Size(87, 20);
            this.tbInputCurrentT_1.TabIndex = 10;
            // 
            // lblAddNumber_1
            // 
            this.lblAddNumber_1.AutoSize = true;
            this.lblAddNumber_1.Location = new System.Drawing.Point(18, 156);
            this.lblAddNumber_1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAddNumber_1.Name = "lblAddNumber_1";
            this.lblAddNumber_1.Size = new System.Drawing.Size(35, 13);
            this.lblAddNumber_1.TabIndex = 9;
            this.lblAddNumber_1.Text = "NULL";
            // 
            // btnAdd_1
            // 
            this.btnAdd_1.Location = new System.Drawing.Point(20, 111);
            this.btnAdd_1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnAdd_1.Name = "btnAdd_1";
            this.btnAdd_1.Size = new System.Drawing.Size(87, 20);
            this.btnAdd_1.TabIndex = 2;
            this.btnAdd_1.Text = "Add";
            this.btnAdd_1.UseVisualStyleBackColor = true;
            this.btnAdd_1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "CurrentT:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSet_2);
            this.groupBox2.Controls.Add(this.tbInputCurrentT_2);
            this.groupBox2.Controls.Add(this.lblAddNumber_2);
            this.groupBox2.Controls.Add(this.btnAdd_2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(245, 109);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox2.Size = new System.Drawing.Size(120, 187);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "TFit-1";
            // 
            // tbInputCurrentT_2
            // 
            this.tbInputCurrentT_2.Location = new System.Drawing.Point(20, 68);
            this.tbInputCurrentT_2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbInputCurrentT_2.Name = "tbInputCurrentT_2";
            this.tbInputCurrentT_2.Size = new System.Drawing.Size(83, 20);
            this.tbInputCurrentT_2.TabIndex = 10;
            // 
            // lblAddNumber_2
            // 
            this.lblAddNumber_2.AutoSize = true;
            this.lblAddNumber_2.Location = new System.Drawing.Point(17, 156);
            this.lblAddNumber_2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAddNumber_2.Name = "lblAddNumber_2";
            this.lblAddNumber_2.Size = new System.Drawing.Size(35, 13);
            this.lblAddNumber_2.TabIndex = 9;
            this.lblAddNumber_2.Text = "NULL";
            // 
            // btnAdd_2
            // 
            this.btnAdd_2.Location = new System.Drawing.Point(20, 111);
            this.btnAdd_2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnAdd_2.Name = "btnAdd_2";
            this.btnAdd_2.Size = new System.Drawing.Size(83, 20);
            this.btnAdd_2.TabIndex = 2;
            this.btnAdd_2.Text = "Add";
            this.btnAdd_2.UseVisualStyleBackColor = true;
            this.btnAdd_2.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 35);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "CurrentT:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnSet_3);
            this.groupBox3.Controls.Add(this.tbInputCurrentT_3);
            this.groupBox3.Controls.Add(this.lblAddNumber_3);
            this.groupBox3.Controls.Add(this.btnAdd_3);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(395, 109);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox3.Size = new System.Drawing.Size(120, 187);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "TFit-1";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // tbInputCurrentT_3
            // 
            this.tbInputCurrentT_3.Location = new System.Drawing.Point(20, 68);
            this.tbInputCurrentT_3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbInputCurrentT_3.Name = "tbInputCurrentT_3";
            this.tbInputCurrentT_3.Size = new System.Drawing.Size(81, 20);
            this.tbInputCurrentT_3.TabIndex = 10;
            // 
            // lblAddNumber_3
            // 
            this.lblAddNumber_3.AutoSize = true;
            this.lblAddNumber_3.Location = new System.Drawing.Point(17, 156);
            this.lblAddNumber_3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAddNumber_3.Name = "lblAddNumber_3";
            this.lblAddNumber_3.Size = new System.Drawing.Size(35, 13);
            this.lblAddNumber_3.TabIndex = 9;
            this.lblAddNumber_3.Text = "NULL";
            // 
            // btnAdd_3
            // 
            this.btnAdd_3.Location = new System.Drawing.Point(20, 111);
            this.btnAdd_3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnAdd_3.Name = "btnAdd_3";
            this.btnAdd_3.Size = new System.Drawing.Size(81, 20);
            this.btnAdd_3.TabIndex = 2;
            this.btnAdd_3.Text = "Add";
            this.btnAdd_3.UseVisualStyleBackColor = true;
            this.btnAdd_3.Click += new System.EventHandler(this.btnAdd_3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 35);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "CurrentT:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnSet_4);
            this.groupBox4.Controls.Add(this.tbInputCurrentT_4);
            this.groupBox4.Controls.Add(this.lblAddNumber_4);
            this.groupBox4.Controls.Add(this.btnAdd_4);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Location = new System.Drawing.Point(544, 109);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox4.Size = new System.Drawing.Size(120, 187);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "TFit-1";
            // 
            // tbInputCurrentT_4
            // 
            this.tbInputCurrentT_4.Location = new System.Drawing.Point(20, 68);
            this.tbInputCurrentT_4.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbInputCurrentT_4.Name = "tbInputCurrentT_4";
            this.tbInputCurrentT_4.Size = new System.Drawing.Size(81, 20);
            this.tbInputCurrentT_4.TabIndex = 10;
            // 
            // lblAddNumber_4
            // 
            this.lblAddNumber_4.AutoSize = true;
            this.lblAddNumber_4.Location = new System.Drawing.Point(17, 156);
            this.lblAddNumber_4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAddNumber_4.Name = "lblAddNumber_4";
            this.lblAddNumber_4.Size = new System.Drawing.Size(35, 13);
            this.lblAddNumber_4.TabIndex = 9;
            this.lblAddNumber_4.Text = "NULL";
            // 
            // btnAdd_4
            // 
            this.btnAdd_4.Location = new System.Drawing.Point(20, 111);
            this.btnAdd_4.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnAdd_4.Name = "btnAdd_4";
            this.btnAdd_4.Size = new System.Drawing.Size(81, 20);
            this.btnAdd_4.TabIndex = 2;
            this.btnAdd_4.Text = "Add";
            this.btnAdd_4.UseVisualStyleBackColor = true;
            this.btnAdd_4.Click += new System.EventHandler(this.btnAdd_4_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 35);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "CurrentT:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(121, 334);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "X:";
            // 
            // lblXValue
            // 
            this.lblXValue.AutoSize = true;
            this.lblXValue.Location = new System.Drawing.Point(175, 334);
            this.lblXValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblXValue.Name = "lblXValue";
            this.lblXValue.Size = new System.Drawing.Size(35, 13);
            this.lblXValue.TabIndex = 13;
            this.lblXValue.Text = "NULL";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(121, 365);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(17, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "Y:";
            // 
            // lblYValue
            // 
            this.lblYValue.AutoSize = true;
            this.lblYValue.Location = new System.Drawing.Point(176, 365);
            this.lblYValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblYValue.Name = "lblYValue";
            this.lblYValue.Size = new System.Drawing.Size(35, 13);
            this.lblYValue.TabIndex = 15;
            this.lblYValue.Text = "NULL";
            // 
            // btnSet_1
            // 
            this.btnSet_1.Location = new System.Drawing.Point(57, 152);
            this.btnSet_1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnSet_1.Name = "btnSet_1";
            this.btnSet_1.Size = new System.Drawing.Size(45, 20);
            this.btnSet_1.TabIndex = 11;
            this.btnSet_1.Text = "Set";
            this.btnSet_1.UseVisualStyleBackColor = true;
            this.btnSet_1.Click += new System.EventHandler(this.btnSet_1_Click);
            // 
            // btnSet_2
            // 
            this.btnSet_2.Location = new System.Drawing.Point(58, 152);
            this.btnSet_2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnSet_2.Name = "btnSet_2";
            this.btnSet_2.Size = new System.Drawing.Size(45, 20);
            this.btnSet_2.TabIndex = 12;
            this.btnSet_2.Text = "Set";
            this.btnSet_2.UseVisualStyleBackColor = true;
            this.btnSet_2.Click += new System.EventHandler(this.btnSet_2_Click);
            // 
            // btnSet_3
            // 
            this.btnSet_3.Location = new System.Drawing.Point(56, 152);
            this.btnSet_3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnSet_3.Name = "btnSet_3";
            this.btnSet_3.Size = new System.Drawing.Size(45, 20);
            this.btnSet_3.TabIndex = 13;
            this.btnSet_3.Text = "Set";
            this.btnSet_3.UseVisualStyleBackColor = true;
            this.btnSet_3.Click += new System.EventHandler(this.btnSet_3_Click);
            // 
            // btnSet_4
            // 
            this.btnSet_4.Location = new System.Drawing.Point(56, 152);
            this.btnSet_4.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnSet_4.Name = "btnSet_4";
            this.btnSet_4.Size = new System.Drawing.Size(45, 20);
            this.btnSet_4.TabIndex = 14;
            this.btnSet_4.Text = "Set";
            this.btnSet_4.UseVisualStyleBackColor = true;
            this.btnSet_4.Click += new System.EventHandler(this.btnSet_4_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(799, 525);
            this.tabControl1.TabIndex = 16;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.btnStart);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(791, 499);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Exp";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lblTFitValue_4);
            this.tabPage2.Controls.Add(this.lblTFitValue_3);
            this.tabPage2.Controls.Add(this.lblTFitValue_2);
            this.tabPage2.Controls.Add(this.lblTFitValue_1);
            this.tabPage2.Controls.Add(this.gbTFit_1);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.lblYValue);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.lblXValue);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(791, 499);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "T-Fit";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblTFitValue_4
            // 
            this.lblTFitValue_4.Font = new System.Drawing.Font("SimSun", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTFitValue_4.Location = new System.Drawing.Point(559, 36);
            this.lblTFitValue_4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTFitValue_4.Name = "lblTFitValue_4";
            this.lblTFitValue_4.Size = new System.Drawing.Size(86, 45);
            this.lblTFitValue_4.TabIndex = 19;
            this.lblTFitValue_4.Text = "NULL";
            // 
            // lblTFitValue_3
            // 
            this.lblTFitValue_3.Font = new System.Drawing.Font("SimSun", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTFitValue_3.Location = new System.Drawing.Point(417, 36);
            this.lblTFitValue_3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTFitValue_3.Name = "lblTFitValue_3";
            this.lblTFitValue_3.Size = new System.Drawing.Size(86, 45);
            this.lblTFitValue_3.TabIndex = 18;
            this.lblTFitValue_3.Text = "NULL";
            // 
            // lblTFitValue_2
            // 
            this.lblTFitValue_2.Font = new System.Drawing.Font("SimSun", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTFitValue_2.Location = new System.Drawing.Point(262, 36);
            this.lblTFitValue_2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTFitValue_2.Name = "lblTFitValue_2";
            this.lblTFitValue_2.Size = new System.Drawing.Size(86, 45);
            this.lblTFitValue_2.TabIndex = 17;
            this.lblTFitValue_2.Text = "NULL";
            // 
            // lblTFitValue_1
            // 
            this.lblTFitValue_1.Font = new System.Drawing.Font("SimSun", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTFitValue_1.Location = new System.Drawing.Point(137, 36);
            this.lblTFitValue_1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTFitValue_1.Name = "lblTFitValue_1";
            this.lblTFitValue_1.Size = new System.Drawing.Size(86, 45);
            this.lblTFitValue_1.TabIndex = 16;
            this.lblTFitValue_1.Text = "NULL";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 537);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Form1";
            this.Text = "不存在";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.gbTFit_1.ResumeLayout(false);
            this.gbTFit_1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tFitToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblT_1;
        private System.Windows.Forms.Label lblT_4;
        private System.Windows.Forms.Label lblT_3;
        private System.Windows.Forms.Label lblT_2;
        private System.Windows.Forms.Timer timer1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox gbTFit_1;
        private System.Windows.Forms.Label lblAddNumber_1;
        private System.Windows.Forms.Button btnAdd_1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbInputCurrentT_1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbInputCurrentT_2;
        private System.Windows.Forms.Label lblAddNumber_2;
        private System.Windows.Forms.Button btnAdd_2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tbInputCurrentT_3;
        private System.Windows.Forms.Label lblAddNumber_3;
        private System.Windows.Forms.Button btnAdd_3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox tbInputCurrentT_4;
        private System.Windows.Forms.Label lblAddNumber_4;
        private System.Windows.Forms.Button btnAdd_4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblXValue;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblYValue;
        private System.Windows.Forms.Label lblRawValue_4;
        private System.Windows.Forms.Label lblRawValue_3;
        private System.Windows.Forms.Label lblRawValue_2;
        private System.Windows.Forms.Label lblRawValue_1;
        private System.Windows.Forms.Button btnSet_1;
        private System.Windows.Forms.Button btnSet_2;
        private System.Windows.Forms.Button btnSet_3;
        private System.Windows.Forms.Button btnSet_4;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lblTFitValue_4;
        private System.Windows.Forms.Label lblTFitValue_3;
        private System.Windows.Forms.Label lblTFitValue_2;
        private System.Windows.Forms.Label lblTFitValue_1;
    }
}

