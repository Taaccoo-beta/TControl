namespace NewPortTest
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnClearAll = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label_temValue1 = new System.Windows.Forms.Label();
            this.label_temValue2 = new System.Windows.Forms.Label();
            this.label_temValue3 = new System.Windows.Forms.Label();
            this.label_temValue4 = new System.Windows.Forms.Label();
            this.btnStart1 = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BoardDec = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblSingl = new System.Windows.Forms.Label();
            this.lblVot_2 = new System.Windows.Forms.Label();
            this.lblVot_1 = new System.Windows.Forms.Label();
            this.lbOnOff_2 = new System.Windows.Forms.Label();
            this.lbOnOff_1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblVot_4 = new System.Windows.Forms.Label();
            this.lblVot_3 = new System.Windows.Forms.Label();
            this.lbOnOff_4 = new System.Windows.Forms.Label();
            this.lbOnOff_3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbMaxTemp = new System.Windows.Forms.TextBox();
            this.tbMinTemp = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.timer1_selfTest_down = new System.Windows.Forms.Timer(this.components);
            this.btnSettingT = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.tbG4_Hand2 = new System.Windows.Forms.TextBox();
            this.tbG4_Hand1 = new System.Windows.Forms.TextBox();
            this.tbG3_Hand2 = new System.Windows.Forms.TextBox();
            this.tbG3_Hand1 = new System.Windows.Forms.TextBox();
            this.tbG2_Hand2 = new System.Windows.Forms.TextBox();
            this.tbG2_Hand1 = new System.Windows.Forms.TextBox();
            this.tbG1_Hand2 = new System.Windows.Forms.TextBox();
            this.tbG1_Hand1 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.btnOnoff_1 = new System.Windows.Forms.Button();
            this.btnOnoff_2 = new System.Windows.Forms.Button();
            this.btnOnoff_3 = new System.Windows.Forms.Button();
            this.btnOnoff_4 = new System.Windows.Forms.Button();
            this.tbKd = new System.Windows.Forms.TextBox();
            this.lblKd = new System.Windows.Forms.Label();
            this.tbKi = new System.Windows.Forms.TextBox();
            this.lblKi = new System.Windows.Forms.Label();
            this.tbKp = new System.Windows.Forms.TextBox();
            this.lblKp = new System.Windows.Forms.Label();
            this.lblPropotation = new System.Windows.Forms.Label();
            this.tbCircle = new System.Windows.Forms.TextBox();
            this.lblCircle = new System.Windows.Forms.Label();
            this.btnSelfTestDown = new System.Windows.Forms.Button();
            this.lblTestStatus = new System.Windows.Forms.Label();
            this.tbDownKd = new System.Windows.Forms.TextBox();
            this.tbDownKi = new System.Windows.Forms.TextBox();
            this.tbDownKp = new System.Windows.Forms.TextBox();
            this.btnSelfTestUp = new System.Windows.Forms.Button();
            this.timer1_selfTest_up = new System.Windows.Forms.Timer(this.components);
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnClearAll
            // 
            this.btnClearAll.Location = new System.Drawing.Point(425, 356);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(83, 33);
            this.btnClearAll.TabIndex = 1;
            this.btnClearAll.Text = "clearAll";
            this.btnClearAll.UseVisualStyleBackColor = true;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.ForeColor = System.Drawing.Color.Blue;
            this.lblStatus.Location = new System.Drawing.Point(223, 358);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(41, 12);
            this.lblStatus.TabIndex = 21;
            this.lblStatus.Text = "Status";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 12);
            this.label2.TabIndex = 22;
            this.label2.Text = "Temperature1:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 12);
            this.label3.TabIndex = 23;
            this.label3.Text = "Temperature2:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 12);
            this.label4.TabIndex = 24;
            this.label4.Text = "Temperature3:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 12);
            this.label5.TabIndex = 25;
            this.label5.Text = "Temperature4:";
            // 
            // label_temValue1
            // 
            this.label_temValue1.AutoSize = true;
            this.label_temValue1.Location = new System.Drawing.Point(129, 33);
            this.label_temValue1.Name = "label_temValue1";
            this.label_temValue1.Size = new System.Drawing.Size(29, 12);
            this.label_temValue1.TabIndex = 26;
            this.label_temValue1.Text = "NULL";
            // 
            // label_temValue2
            // 
            this.label_temValue2.AutoSize = true;
            this.label_temValue2.Location = new System.Drawing.Point(129, 74);
            this.label_temValue2.Name = "label_temValue2";
            this.label_temValue2.Size = new System.Drawing.Size(29, 12);
            this.label_temValue2.TabIndex = 27;
            this.label_temValue2.Text = "NULL";
            // 
            // label_temValue3
            // 
            this.label_temValue3.AutoSize = true;
            this.label_temValue3.Location = new System.Drawing.Point(129, 29);
            this.label_temValue3.Name = "label_temValue3";
            this.label_temValue3.Size = new System.Drawing.Size(29, 12);
            this.label_temValue3.TabIndex = 28;
            this.label_temValue3.Text = "NULL";
            // 
            // label_temValue4
            // 
            this.label_temValue4.AutoSize = true;
            this.label_temValue4.Location = new System.Drawing.Point(129, 73);
            this.label_temValue4.Name = "label_temValue4";
            this.label_temValue4.Size = new System.Drawing.Size(29, 12);
            this.label_temValue4.TabIndex = 29;
            this.label_temValue4.Text = "NULL";
            // 
            // btnStart1
            // 
            this.btnStart1.Location = new System.Drawing.Point(23, 306);
            this.btnStart1.Name = "btnStart1";
            this.btnStart1.Size = new System.Drawing.Size(112, 32);
            this.btnStart1.TabIndex = 30;
            this.btnStart1.Text = "Start";
            this.btnStart1.UseVisualStyleBackColor = true;
            this.btnStart1.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(425, 395);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(83, 30);
            this.BtnCancel.TabIndex = 31;
            this.BtnCancel.Text = "Exit";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BoardDec
            // 
            this.BoardDec.AutoSize = true;
            this.BoardDec.Location = new System.Drawing.Point(223, 395);
            this.BoardDec.Name = "BoardDec";
            this.BoardDec.Size = new System.Drawing.Size(29, 12);
            this.BoardDec.TabIndex = 32;
            this.BoardDec.Text = "NULL";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblSingl);
            this.groupBox2.Controls.Add(this.lblVot_2);
            this.groupBox2.Controls.Add(this.lblVot_1);
            this.groupBox2.Controls.Add(this.lbOnOff_2);
            this.groupBox2.Controls.Add(this.lbOnOff_1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label_temValue1);
            this.groupBox2.Controls.Add(this.label_temValue2);
            this.groupBox2.Location = new System.Drawing.Point(23, 156);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(318, 118);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Board--1";
            // 
            // lblSingl
            // 
            this.lblSingl.AutoSize = true;
            this.lblSingl.Location = new System.Drawing.Point(184, 15);
            this.lblSingl.Name = "lblSingl";
            this.lblSingl.Size = new System.Drawing.Size(29, 12);
            this.lblSingl.TabIndex = 118;
            this.lblSingl.Text = "NULL";
            // 
            // lblVot_2
            // 
            this.lblVot_2.AutoSize = true;
            this.lblVot_2.Location = new System.Drawing.Point(243, 74);
            this.lblVot_2.Name = "lblVot_2";
            this.lblVot_2.Size = new System.Drawing.Size(29, 12);
            this.lblVot_2.TabIndex = 31;
            this.lblVot_2.Text = "NULL";
            // 
            // lblVot_1
            // 
            this.lblVot_1.AutoSize = true;
            this.lblVot_1.Location = new System.Drawing.Point(243, 33);
            this.lblVot_1.Name = "lblVot_1";
            this.lblVot_1.Size = new System.Drawing.Size(29, 12);
            this.lblVot_1.TabIndex = 30;
            this.lblVot_1.Text = "NULL";
            // 
            // lbOnOff_2
            // 
            this.lbOnOff_2.AutoSize = true;
            this.lbOnOff_2.Location = new System.Drawing.Point(184, 74);
            this.lbOnOff_2.Name = "lbOnOff_2";
            this.lbOnOff_2.Size = new System.Drawing.Size(29, 12);
            this.lbOnOff_2.TabIndex = 29;
            this.lbOnOff_2.Text = "NULL";
            // 
            // lbOnOff_1
            // 
            this.lbOnOff_1.AutoSize = true;
            this.lbOnOff_1.Location = new System.Drawing.Point(184, 33);
            this.lbOnOff_1.Name = "lbOnOff_1";
            this.lbOnOff_1.Size = new System.Drawing.Size(29, 12);
            this.lbOnOff_1.TabIndex = 28;
            this.lbOnOff_1.Text = "NULL";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblVot_4);
            this.groupBox3.Controls.Add(this.lblVot_3);
            this.groupBox3.Controls.Add(this.lbOnOff_4);
            this.groupBox3.Controls.Add(this.lbOnOff_3);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label_temValue3);
            this.groupBox3.Controls.Add(this.label_temValue4);
            this.groupBox3.Location = new System.Drawing.Point(347, 156);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(316, 123);
            this.groupBox3.TabIndex = 33;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Board--2";
            // 
            // lblVot_4
            // 
            this.lblVot_4.AutoSize = true;
            this.lblVot_4.Location = new System.Drawing.Point(265, 74);
            this.lblVot_4.Name = "lblVot_4";
            this.lblVot_4.Size = new System.Drawing.Size(29, 12);
            this.lblVot_4.TabIndex = 33;
            this.lblVot_4.Text = "NULL";
            // 
            // lblVot_3
            // 
            this.lblVot_3.AutoSize = true;
            this.lblVot_3.Location = new System.Drawing.Point(265, 29);
            this.lblVot_3.Name = "lblVot_3";
            this.lblVot_3.Size = new System.Drawing.Size(29, 12);
            this.lblVot_3.TabIndex = 32;
            this.lblVot_3.Text = "NULL";
            // 
            // lbOnOff_4
            // 
            this.lbOnOff_4.AutoSize = true;
            this.lbOnOff_4.Location = new System.Drawing.Point(206, 74);
            this.lbOnOff_4.Name = "lbOnOff_4";
            this.lbOnOff_4.Size = new System.Drawing.Size(29, 12);
            this.lbOnOff_4.TabIndex = 31;
            this.lbOnOff_4.Text = "NULL";
            // 
            // lbOnOff_3
            // 
            this.lbOnOff_3.AutoSize = true;
            this.lbOnOff_3.Location = new System.Drawing.Point(206, 29);
            this.lbOnOff_3.Name = "lbOnOff_3";
            this.lbOnOff_3.Size = new System.Drawing.Size(29, 12);
            this.lbOnOff_3.TabIndex = 30;
            this.lbOnOff_3.Text = "NULL";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 12);
            this.label1.TabIndex = 34;
            this.label1.Text = "Punishment temperature:";
            // 
            // tbMaxTemp
            // 
            this.tbMaxTemp.Location = new System.Drawing.Point(210, 32);
            this.tbMaxTemp.Name = "tbMaxTemp";
            this.tbMaxTemp.Size = new System.Drawing.Size(100, 21);
            this.tbMaxTemp.TabIndex = 35;
            this.tbMaxTemp.Text = "37";
            // 
            // tbMinTemp
            // 
            this.tbMinTemp.Location = new System.Drawing.Point(210, 82);
            this.tbMinTemp.Name = "tbMinTemp";
            this.tbMinTemp.Size = new System.Drawing.Size(100, 21);
            this.tbMinTemp.TabIndex = 37;
            this.tbMinTemp.Text = "25";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 12);
            this.label6.TabIndex = 36;
            this.label6.Text = "Comfortable temperature:";
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // timer4
            // 
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // timer1_selfTest_down
            // 
            this.timer1_selfTest_down.Tick += new System.EventHandler(this.timer5_Tick);
            // 
            // btnSettingT
            // 
            this.btnSettingT.Location = new System.Drawing.Point(776, 112);
            this.btnSettingT.Name = "btnSettingT";
            this.btnSettingT.Size = new System.Drawing.Size(43, 32);
            this.btnSettingT.TabIndex = 99;
            this.btnSettingT.Text = "Reset";
            this.btnSettingT.UseVisualStyleBackColor = true;
            this.btnSettingT.Click += new System.EventHandler(this.button2_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(546, 38);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(17, 12);
            this.label12.TabIndex = 97;
            this.label12.Text = "P1";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(546, 88);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(17, 12);
            this.label16.TabIndex = 98;
            this.label16.Text = "P2";
            // 
            // tbG4_Hand2
            // 
            this.tbG4_Hand2.Location = new System.Drawing.Point(776, 85);
            this.tbG4_Hand2.Name = "tbG4_Hand2";
            this.tbG4_Hand2.Size = new System.Drawing.Size(43, 21);
            this.tbG4_Hand2.TabIndex = 96;
            this.tbG4_Hand2.Text = "675.3";
            // 
            // tbG4_Hand1
            // 
            this.tbG4_Hand1.Location = new System.Drawing.Point(776, 35);
            this.tbG4_Hand1.Name = "tbG4_Hand1";
            this.tbG4_Hand1.Size = new System.Drawing.Size(43, 21);
            this.tbG4_Hand1.TabIndex = 95;
            this.tbG4_Hand1.Text = "0.2041";
            // 
            // tbG3_Hand2
            // 
            this.tbG3_Hand2.Location = new System.Drawing.Point(705, 85);
            this.tbG3_Hand2.Name = "tbG3_Hand2";
            this.tbG3_Hand2.Size = new System.Drawing.Size(43, 21);
            this.tbG3_Hand2.TabIndex = 94;
            this.tbG3_Hand2.Text = "671.6";
            // 
            // tbG3_Hand1
            // 
            this.tbG3_Hand1.Location = new System.Drawing.Point(705, 35);
            this.tbG3_Hand1.Name = "tbG3_Hand1";
            this.tbG3_Hand1.Size = new System.Drawing.Size(43, 21);
            this.tbG3_Hand1.TabIndex = 93;
            this.tbG3_Hand1.Text = "0.20186";
            // 
            // tbG2_Hand2
            // 
            this.tbG2_Hand2.Location = new System.Drawing.Point(645, 85);
            this.tbG2_Hand2.Name = "tbG2_Hand2";
            this.tbG2_Hand2.Size = new System.Drawing.Size(43, 21);
            this.tbG2_Hand2.TabIndex = 92;
            this.tbG2_Hand2.Text = "766.4";
            // 
            // tbG2_Hand1
            // 
            this.tbG2_Hand1.Location = new System.Drawing.Point(645, 35);
            this.tbG2_Hand1.Name = "tbG2_Hand1";
            this.tbG2_Hand1.Size = new System.Drawing.Size(43, 21);
            this.tbG2_Hand1.TabIndex = 91;
            this.tbG2_Hand1.Text = "0.2294";
            // 
            // tbG1_Hand2
            // 
            this.tbG1_Hand2.Location = new System.Drawing.Point(581, 85);
            this.tbG1_Hand2.Name = "tbG1_Hand2";
            this.tbG1_Hand2.Size = new System.Drawing.Size(43, 21);
            this.tbG1_Hand2.TabIndex = 90;
            this.tbG1_Hand2.Text = "686.00991";
            // 
            // tbG1_Hand1
            // 
            this.tbG1_Hand1.Location = new System.Drawing.Point(581, 35);
            this.tbG1_Hand1.Name = "tbG1_Hand1";
            this.tbG1_Hand1.Size = new System.Drawing.Size(43, 21);
            this.tbG1_Hand1.TabIndex = 89;
            this.tbG1_Hand1.Text = "0.20662";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(587, 356);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(65, 12);
            this.label17.TabIndex = 100;
            this.label17.Text = "SimInput：";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(671, 356);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(11, 12);
            this.label18.TabIndex = 101;
            this.label18.Text = "1";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(723, 356);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(11, 12);
            this.label19.TabIndex = 102;
            this.label19.Text = "2";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(762, 356);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(11, 12);
            this.label20.TabIndex = 103;
            this.label20.Text = "3";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(811, 356);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(11, 12);
            this.label21.TabIndex = 104;
            this.label21.Text = "4";
            // 
            // btnOnoff_1
            // 
            this.btnOnoff_1.Location = new System.Drawing.Point(664, 379);
            this.btnOnoff_1.Name = "btnOnoff_1";
            this.btnOnoff_1.Size = new System.Drawing.Size(31, 21);
            this.btnOnoff_1.TabIndex = 105;
            this.btnOnoff_1.Text = "On";
            this.btnOnoff_1.UseVisualStyleBackColor = true;
            this.btnOnoff_1.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // btnOnoff_2
            // 
            this.btnOnoff_2.Location = new System.Drawing.Point(705, 379);
            this.btnOnoff_2.Name = "btnOnoff_2";
            this.btnOnoff_2.Size = new System.Drawing.Size(35, 21);
            this.btnOnoff_2.TabIndex = 106;
            this.btnOnoff_2.Text = "On";
            this.btnOnoff_2.UseVisualStyleBackColor = true;
            this.btnOnoff_2.Click += new System.EventHandler(this.btnOnoff_2_Click);
            // 
            // btnOnoff_3
            // 
            this.btnOnoff_3.Location = new System.Drawing.Point(754, 379);
            this.btnOnoff_3.Name = "btnOnoff_3";
            this.btnOnoff_3.Size = new System.Drawing.Size(36, 21);
            this.btnOnoff_3.TabIndex = 107;
            this.btnOnoff_3.Text = "On";
            this.btnOnoff_3.UseVisualStyleBackColor = true;
            this.btnOnoff_3.Click += new System.EventHandler(this.btnOnoff_3_Click);
            // 
            // btnOnoff_4
            // 
            this.btnOnoff_4.Location = new System.Drawing.Point(796, 379);
            this.btnOnoff_4.Name = "btnOnoff_4";
            this.btnOnoff_4.Size = new System.Drawing.Size(41, 21);
            this.btnOnoff_4.TabIndex = 108;
            this.btnOnoff_4.Text = "On";
            this.btnOnoff_4.UseVisualStyleBackColor = true;
            this.btnOnoff_4.Click += new System.EventHandler(this.btnOnoff_4_Click);
            // 
            // tbKd
            // 
            this.tbKd.Location = new System.Drawing.Point(724, 237);
            this.tbKd.Name = "tbKd";
            this.tbKd.Size = new System.Drawing.Size(100, 21);
            this.tbKd.TabIndex = 115;
            this.tbKd.Text = "3";
            // 
            // lblKd
            // 
            this.lblKd.AutoSize = true;
            this.lblKd.Location = new System.Drawing.Point(669, 240);
            this.lblKd.Name = "lblKd";
            this.lblKd.Size = new System.Drawing.Size(23, 12);
            this.lblKd.TabIndex = 114;
            this.lblKd.Text = "Kd:";
            // 
            // tbKi
            // 
            this.tbKi.Location = new System.Drawing.Point(724, 210);
            this.tbKi.Name = "tbKi";
            this.tbKi.Size = new System.Drawing.Size(100, 21);
            this.tbKi.TabIndex = 113;
            this.tbKi.Text = "0";
            // 
            // lblKi
            // 
            this.lblKi.AutoSize = true;
            this.lblKi.Location = new System.Drawing.Point(669, 212);
            this.lblKi.Name = "lblKi";
            this.lblKi.Size = new System.Drawing.Size(23, 12);
            this.lblKi.TabIndex = 112;
            this.lblKi.Text = "Ki:";
            // 
            // tbKp
            // 
            this.tbKp.Location = new System.Drawing.Point(724, 178);
            this.tbKp.Name = "tbKp";
            this.tbKp.Size = new System.Drawing.Size(100, 21);
            this.tbKp.TabIndex = 111;
            this.tbKp.Text = "4";
            // 
            // lblKp
            // 
            this.lblKp.AutoSize = true;
            this.lblKp.Location = new System.Drawing.Point(669, 181);
            this.lblKp.Name = "lblKp";
            this.lblKp.Size = new System.Drawing.Size(23, 12);
            this.lblKp.TabIndex = 110;
            this.lblKp.Text = "Kp:";
            // 
            // lblPropotation
            // 
            this.lblPropotation.AutoSize = true;
            this.lblPropotation.Location = new System.Drawing.Point(660, 327);
            this.lblPropotation.Name = "lblPropotation";
            this.lblPropotation.Size = new System.Drawing.Size(29, 12);
            this.lblPropotation.TabIndex = 109;
            this.lblPropotation.Text = "NULL";
            // 
            // tbCircle
            // 
            this.tbCircle.Location = new System.Drawing.Point(724, 273);
            this.tbCircle.Name = "tbCircle";
            this.tbCircle.Size = new System.Drawing.Size(100, 21);
            this.tbCircle.TabIndex = 117;
            this.tbCircle.Text = "10";
            // 
            // lblCircle
            // 
            this.lblCircle.AutoSize = true;
            this.lblCircle.Location = new System.Drawing.Point(669, 276);
            this.lblCircle.Name = "lblCircle";
            this.lblCircle.Size = new System.Drawing.Size(47, 12);
            this.lblCircle.TabIndex = 116;
            this.lblCircle.Text = "Circle:";
            // 
            // btnSelfTestDown
            // 
            this.btnSelfTestDown.Location = new System.Drawing.Point(664, 420);
            this.btnSelfTestDown.Name = "btnSelfTestDown";
            this.btnSelfTestDown.Size = new System.Drawing.Size(173, 21);
            this.btnSelfTestDown.TabIndex = 118;
            this.btnSelfTestDown.Text = "Test-Down";
            this.btnSelfTestDown.UseVisualStyleBackColor = true;
            this.btnSelfTestDown.Click += new System.EventHandler(this.btnSelfTest_Click);
            // 
            // lblTestStatus
            // 
            this.lblTestStatus.AutoSize = true;
            this.lblTestStatus.Location = new System.Drawing.Point(662, 508);
            this.lblTestStatus.Name = "lblTestStatus";
            this.lblTestStatus.Size = new System.Drawing.Size(29, 12);
            this.lblTestStatus.TabIndex = 119;
            this.lblTestStatus.Text = "NULL";
            // 
            // tbDownKd
            // 
            this.tbDownKd.Location = new System.Drawing.Point(830, 237);
            this.tbDownKd.Name = "tbDownKd";
            this.tbDownKd.Size = new System.Drawing.Size(100, 21);
            this.tbDownKd.TabIndex = 125;
            this.tbDownKd.Text = "3";
            // 
            // tbDownKi
            // 
            this.tbDownKi.Location = new System.Drawing.Point(830, 210);
            this.tbDownKi.Name = "tbDownKi";
            this.tbDownKi.Size = new System.Drawing.Size(100, 21);
            this.tbDownKi.TabIndex = 123;
            this.tbDownKi.Text = "0";
            // 
            // tbDownKp
            // 
            this.tbDownKp.Location = new System.Drawing.Point(830, 178);
            this.tbDownKp.Name = "tbDownKp";
            this.tbDownKp.Size = new System.Drawing.Size(100, 21);
            this.tbDownKp.TabIndex = 121;
            this.tbDownKp.Text = "4";
            // 
            // btnSelfTestUp
            // 
            this.btnSelfTestUp.Location = new System.Drawing.Point(664, 457);
            this.btnSelfTestUp.Name = "btnSelfTestUp";
            this.btnSelfTestUp.Size = new System.Drawing.Size(173, 21);
            this.btnSelfTestUp.TabIndex = 126;
            this.btnSelfTestUp.Text = "Test-up";
            this.btnSelfTestUp.UseVisualStyleBackColor = true;
            this.btnSelfTestUp.Click += new System.EventHandler(this.btnSelfTestUp_Click);
            // 
            // timer1_selfTest_up
            // 
            this.timer1_selfTest_up.Tick += new System.EventHandler(this.timer1_selfTest_up_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 529);
            this.Controls.Add(this.btnSelfTestUp);
            this.Controls.Add(this.tbDownKd);
            this.Controls.Add(this.tbDownKi);
            this.Controls.Add(this.tbDownKp);
            this.Controls.Add(this.lblTestStatus);
            this.Controls.Add(this.btnSelfTestDown);
            this.Controls.Add(this.tbCircle);
            this.Controls.Add(this.lblCircle);
            this.Controls.Add(this.tbKd);
            this.Controls.Add(this.lblKd);
            this.Controls.Add(this.tbKi);
            this.Controls.Add(this.lblKi);
            this.Controls.Add(this.tbKp);
            this.Controls.Add(this.lblKp);
            this.Controls.Add(this.lblPropotation);
            this.Controls.Add(this.btnOnoff_4);
            this.Controls.Add(this.btnOnoff_3);
            this.Controls.Add(this.btnOnoff_2);
            this.Controls.Add(this.btnOnoff_1);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.btnSettingT);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.tbG4_Hand2);
            this.Controls.Add(this.tbG4_Hand1);
            this.Controls.Add(this.tbG3_Hand2);
            this.Controls.Add(this.tbG3_Hand1);
            this.Controls.Add(this.tbG2_Hand2);
            this.Controls.Add(this.tbG2_Hand1);
            this.Controls.Add(this.tbG1_Hand2);
            this.Controls.Add(this.tbG1_Hand1);
            this.Controls.Add(this.tbMinTemp);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbMaxTemp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.BoardDec);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.btnStart1);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnClearAll);
            this.Name = "Form1";
            this.Text = "Test";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label_temValue1;
        private System.Windows.Forms.Label label_temValue2;
        private System.Windows.Forms.Label label_temValue3;
        private System.Windows.Forms.Label label_temValue4;
        private System.Windows.Forms.Button btnStart1;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Label BoardDec;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbMaxTemp;
        private System.Windows.Forms.TextBox tbMinTemp;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.Label lbOnOff_2;
        private System.Windows.Forms.Label lbOnOff_1;
        private System.Windows.Forms.Label lbOnOff_4;
        private System.Windows.Forms.Label lbOnOff_3;
        private System.Windows.Forms.Timer timer1_selfTest_down;
        private System.Windows.Forms.Button btnSettingT;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tbG4_Hand2;
        private System.Windows.Forms.TextBox tbG4_Hand1;
        private System.Windows.Forms.TextBox tbG3_Hand2;
        private System.Windows.Forms.TextBox tbG3_Hand1;
        private System.Windows.Forms.TextBox tbG2_Hand2;
        private System.Windows.Forms.TextBox tbG2_Hand1;
        private System.Windows.Forms.TextBox tbG1_Hand2;
        private System.Windows.Forms.TextBox tbG1_Hand1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button btnOnoff_1;
        private System.Windows.Forms.Button btnOnoff_2;
        private System.Windows.Forms.Button btnOnoff_3;
        private System.Windows.Forms.Button btnOnoff_4;
        private System.Windows.Forms.TextBox tbKd;
        private System.Windows.Forms.Label lblKd;
        private System.Windows.Forms.TextBox tbKi;
        private System.Windows.Forms.Label lblKi;
        private System.Windows.Forms.TextBox tbKp;
        private System.Windows.Forms.Label lblKp;
        private System.Windows.Forms.Label lblPropotation;
        private System.Windows.Forms.TextBox tbCircle;
        private System.Windows.Forms.Label lblCircle;
        private System.Windows.Forms.Label lblVot_2;
        private System.Windows.Forms.Label lblVot_1;
        private System.Windows.Forms.Label lblVot_4;
        private System.Windows.Forms.Label lblVot_3;
        private System.Windows.Forms.Label lblSingl;
        private System.Windows.Forms.Button btnSelfTestDown;
        private System.Windows.Forms.Label lblTestStatus;
        private System.Windows.Forms.TextBox tbDownKd;
        private System.Windows.Forms.TextBox tbDownKi;
        private System.Windows.Forms.TextBox tbDownKp;
        private System.Windows.Forms.Button btnSelfTestUp;
        private System.Windows.Forms.Timer timer1_selfTest_up;
    }
}

