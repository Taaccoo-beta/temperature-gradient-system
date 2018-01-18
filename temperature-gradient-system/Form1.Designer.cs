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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tFitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblT_1 = new System.Windows.Forms.Label();
            this.lblT_2 = new System.Windows.Forms.Label();
            this.lblT_3 = new System.Windows.Forms.Label();
            this.lblT_4 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1202, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tFitToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(61, 24);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // tFitToolStripMenuItem
            // 
            this.tFitToolStripMenuItem.Name = "tFitToolStripMenuItem";
            this.tFitToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.tFitToolStripMenuItem.Text = "TFit";
            this.tFitToolStripMenuItem.Click += new System.EventHandler(this.tFitToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblT_4);
            this.groupBox1.Controls.Add(this.lblT_3);
            this.groupBox1.Controls.Add(this.lblT_2);
            this.groupBox1.Controls.Add(this.lblT_1);
            this.groupBox1.Location = new System.Drawing.Point(150, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(661, 146);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Temperture";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(626, 538);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(126, 40);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblT_1
            // 
            this.lblT_1.Font = new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblT_1.Location = new System.Drawing.Point(46, 52);
            this.lblT_1.Name = "lblT_1";
            this.lblT_1.Size = new System.Drawing.Size(114, 52);
            this.lblT_1.TabIndex = 4;
            this.lblT_1.Text = "NULL";
            // 
            // lblT_2
            // 
            this.lblT_2.Font = new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblT_2.Location = new System.Drawing.Point(187, 52);
            this.lblT_2.Name = "lblT_2";
            this.lblT_2.Size = new System.Drawing.Size(105, 52);
            this.lblT_2.TabIndex = 5;
            this.lblT_2.Text = "NULL";
            // 
            // lblT_3
            // 
            this.lblT_3.Font = new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblT_3.Location = new System.Drawing.Point(365, 52);
            this.lblT_3.Name = "lblT_3";
            this.lblT_3.Size = new System.Drawing.Size(98, 52);
            this.lblT_3.TabIndex = 6;
            this.lblT_3.Text = "NULL";
            // 
            // lblT_4
            // 
            this.lblT_4.Font = new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblT_4.Location = new System.Drawing.Point(537, 52);
            this.lblT_4.Name = "lblT_4";
            this.lblT_4.Size = new System.Drawing.Size(100, 52);
            this.lblT_4.TabIndex = 7;
            this.lblT_4.Text = "NULL";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1202, 620);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "不存在";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
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
    }
}

