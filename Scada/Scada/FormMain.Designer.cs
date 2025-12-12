
namespace Scada
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Sys_btt_PLC_Data_Save = new System.Windows.Forms.Button();
            this.Sys_btt_PLC_Data_Edit = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.Sys_tbx_PLC_Tag_Scan_Time = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.Sys_tbx_Channel = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Sys_tbx_IOServer = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Sys_btt_Disconnect = new System.Windows.Forms.Button();
            this.Sys_btt_Connect = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Sys_tbx_WatchDog = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Sys_tbx_PLC_Connect_Status = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.timer_TagScan = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.tbx_TagBool = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.tbx_TagInt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.tbx_TagReal = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.tbx_TagString = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.panel11 = new System.Windows.Forms.Panel();
            this.tbx_Write_TagString = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panel12 = new System.Windows.Forms.Panel();
            this.tbx_Write_TagReal = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.panel13 = new System.Windows.Forms.Panel();
            this.tbx_Write_TagInt = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.panel14 = new System.Windows.Forms.Panel();
            this.tbx_Write_TagBool = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btt_PLC_WriteToPLC = new System.Windows.Forms.Button();
            this.tabPage5.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel10.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel14.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "icons8-home-48.png");
            this.imageList1.Images.SetKeyName(1, "icons8-automatic-64.png");
            this.imageList1.Images.SetKeyName(2, "icons8-hand-100.png");
            this.imageList1.Images.SetKeyName(3, "icons8-automation-48.png");
            this.imageList1.Images.SetKeyName(4, "icons8-repair-48.png");
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.groupBox2);
            this.tabPage5.Controls.Add(this.label5);
            this.tabPage5.ImageIndex = 4;
            this.tabPage5.Location = new System.Drawing.Point(4, 54);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(1054, 615);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "System";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Sys_btt_PLC_Data_Save);
            this.groupBox2.Controls.Add(this.Sys_btt_PLC_Data_Edit);
            this.groupBox2.Controls.Add(this.panel6);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.panel5);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Controls.Add(this.Sys_btt_Disconnect);
            this.groupBox2.Controls.Add(this.Sys_btt_Connect);
            this.groupBox2.Controls.Add(this.panel3);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.panel4);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(129, 43);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(538, 365);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Display communication with PLC";
            // 
            // Sys_btt_PLC_Data_Save
            // 
            this.Sys_btt_PLC_Data_Save.BackColor = System.Drawing.Color.Silver;
            this.Sys_btt_PLC_Data_Save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Sys_btt_PLC_Data_Save.Location = new System.Drawing.Point(243, 310);
            this.Sys_btt_PLC_Data_Save.Name = "Sys_btt_PLC_Data_Save";
            this.Sys_btt_PLC_Data_Save.Size = new System.Drawing.Size(103, 49);
            this.Sys_btt_PLC_Data_Save.TabIndex = 13;
            this.Sys_btt_PLC_Data_Save.Text = "Save";
            this.Sys_btt_PLC_Data_Save.UseVisualStyleBackColor = false;
            this.Sys_btt_PLC_Data_Save.Visible = false;
            this.Sys_btt_PLC_Data_Save.Click += new System.EventHandler(this.Sys_btt_PLC_Data_Save_Click);
            // 
            // Sys_btt_PLC_Data_Edit
            // 
            this.Sys_btt_PLC_Data_Edit.BackColor = System.Drawing.Color.Silver;
            this.Sys_btt_PLC_Data_Edit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Sys_btt_PLC_Data_Edit.Location = new System.Drawing.Point(412, 310);
            this.Sys_btt_PLC_Data_Edit.Name = "Sys_btt_PLC_Data_Edit";
            this.Sys_btt_PLC_Data_Edit.Size = new System.Drawing.Size(103, 49);
            this.Sys_btt_PLC_Data_Edit.TabIndex = 12;
            this.Sys_btt_PLC_Data_Edit.Text = "Edit";
            this.Sys_btt_PLC_Data_Edit.UseVisualStyleBackColor = false;
            this.Sys_btt_PLC_Data_Edit.Click += new System.EventHandler(this.Sys_btt_PLC_Data_Edit_Click);
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel6.Controls.Add(this.Sys_tbx_PLC_Tag_Scan_Time);
            this.panel6.Controls.Add(this.textBox8);
            this.panel6.Location = new System.Drawing.Point(243, 270);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(289, 37);
            this.panel6.TabIndex = 10;
            // 
            // Sys_tbx_PLC_Tag_Scan_Time
            // 
            this.Sys_tbx_PLC_Tag_Scan_Time.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Sys_tbx_PLC_Tag_Scan_Time.Enabled = false;
            this.Sys_tbx_PLC_Tag_Scan_Time.Location = new System.Drawing.Point(3, 4);
            this.Sys_tbx_PLC_Tag_Scan_Time.Name = "Sys_tbx_PLC_Tag_Scan_Time";
            this.Sys_tbx_PLC_Tag_Scan_Time.Size = new System.Drawing.Size(279, 21);
            this.Sys_tbx_PLC_Tag_Scan_Time.TabIndex = 2;
            this.Sys_tbx_PLC_Tag_Scan_Time.Text = "1000";
            // 
            // textBox8
            // 
            this.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox8.Location = new System.Drawing.Point(7, 226);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(120, 21);
            this.textBox8.TabIndex = 1;
            this.textBox8.Text = "Disconnected";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 270);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(202, 24);
            this.label6.TabIndex = 9;
            this.label6.Text = "PLC tag scan time (ms)";
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.Sys_tbx_Channel);
            this.panel5.Controls.Add(this.textBox6);
            this.panel5.Location = new System.Drawing.Point(243, 227);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(289, 37);
            this.panel5.TabIndex = 8;
            // 
            // Sys_tbx_Channel
            // 
            this.Sys_tbx_Channel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Sys_tbx_Channel.Enabled = false;
            this.Sys_tbx_Channel.Location = new System.Drawing.Point(3, 4);
            this.Sys_tbx_Channel.Name = "Sys_tbx_Channel";
            this.Sys_tbx_Channel.Size = new System.Drawing.Size(279, 21);
            this.Sys_tbx_Channel.TabIndex = 2;
            this.Sys_tbx_Channel.Text = "Channel1.Device1";
            // 
            // textBox6
            // 
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.Location = new System.Drawing.Point(7, 226);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(120, 21);
            this.textBox6.TabIndex = 1;
            this.textBox6.Text = "Disconnected";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Channel and Device";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.Sys_tbx_IOServer);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Location = new System.Drawing.Point(243, 184);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(289, 37);
            this.panel2.TabIndex = 4;
            // 
            // Sys_tbx_IOServer
            // 
            this.Sys_tbx_IOServer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Sys_tbx_IOServer.Enabled = false;
            this.Sys_tbx_IOServer.Location = new System.Drawing.Point(3, 4);
            this.Sys_tbx_IOServer.Name = "Sys_tbx_IOServer";
            this.Sys_tbx_IOServer.Size = new System.Drawing.Size(279, 21);
            this.Sys_tbx_IOServer.TabIndex = 2;
            this.Sys_tbx_IOServer.Text = "Kepware.KEPSERVEREX.V6";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(7, 226);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(120, 21);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Disconnected";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "IO Server Name:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(21, 167);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(494, 2);
            this.panel1.TabIndex = 6;
            // 
            // Sys_btt_Disconnect
            // 
            this.Sys_btt_Disconnect.BackColor = System.Drawing.Color.Silver;
            this.Sys_btt_Disconnect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Sys_btt_Disconnect.Location = new System.Drawing.Point(375, 104);
            this.Sys_btt_Disconnect.Name = "Sys_btt_Disconnect";
            this.Sys_btt_Disconnect.Size = new System.Drawing.Size(140, 49);
            this.Sys_btt_Disconnect.TabIndex = 5;
            this.Sys_btt_Disconnect.Text = "Disconnect";
            this.Sys_btt_Disconnect.UseVisualStyleBackColor = false;
            this.Sys_btt_Disconnect.Click += new System.EventHandler(this.Sys_btt_Disconnect_Click);
            // 
            // Sys_btt_Connect
            // 
            this.Sys_btt_Connect.BackColor = System.Drawing.Color.Silver;
            this.Sys_btt_Connect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Sys_btt_Connect.Location = new System.Drawing.Point(83, 104);
            this.Sys_btt_Connect.Name = "Sys_btt_Connect";
            this.Sys_btt_Connect.Size = new System.Drawing.Size(140, 49);
            this.Sys_btt_Connect.TabIndex = 1;
            this.Sys_btt_Connect.Text = "Connect";
            this.Sys_btt_Connect.UseVisualStyleBackColor = false;
            this.Sys_btt_Connect.Click += new System.EventHandler(this.Sys_btt_Connect_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.Sys_tbx_WatchDog);
            this.panel3.Location = new System.Drawing.Point(375, 40);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(140, 37);
            this.panel3.TabIndex = 4;
            // 
            // Sys_tbx_WatchDog
            // 
            this.Sys_tbx_WatchDog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Sys_tbx_WatchDog.Location = new System.Drawing.Point(8, 7);
            this.Sys_tbx_WatchDog.Name = "Sys_tbx_WatchDog";
            this.Sys_tbx_WatchDog.Size = new System.Drawing.Size(120, 21);
            this.Sys_tbx_WatchDog.TabIndex = 1;
            this.Sys_tbx_WatchDog.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(269, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "WatchDog";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.Sys_tbx_PLC_Connect_Status);
            this.panel4.Location = new System.Drawing.Point(83, 40);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(140, 37);
            this.panel4.TabIndex = 2;
            // 
            // Sys_tbx_PLC_Connect_Status
            // 
            this.Sys_tbx_PLC_Connect_Status.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Sys_tbx_PLC_Connect_Status.Location = new System.Drawing.Point(7, 7);
            this.Sys_tbx_PLC_Connect_Status.Name = "Sys_tbx_PLC_Connect_Status";
            this.Sys_tbx_PLC_Connect_Status.Size = new System.Drawing.Size(120, 21);
            this.Sys_tbx_PLC_Connect_Status.TabIndex = 1;
            this.Sys_tbx_PLC_Connect_Status.Text = "Disconnected";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "Status";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(156, 366);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 24);
            this.label5.TabIndex = 9;
            this.label5.Text = "IO Server Name:";
            // 
            // tabPage4
            // 
            this.tabPage4.ImageIndex = 3;
            this.tabPage4.Location = new System.Drawing.Point(4, 54);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1054, 615);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Setting";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.ImageIndex = 2;
            this.tabPage3.Location = new System.Drawing.Point(4, 54);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1054, 615);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Manu";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.ImageIndex = 1;
            this.tabPage2.Location = new System.Drawing.Point(4, 54);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1054, 615);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Auto";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.ImageIndex = 0;
            this.tabPage1.Location = new System.Drawing.Point(4, 54);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1054, 615);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Home";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.tabControl1.ImageList = this.imageList1;
            this.tabControl1.ItemSize = new System.Drawing.Size(95, 50);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1062, 673);
            this.tabControl1.TabIndex = 0;
            // 
            // timer_TagScan
            // 
            this.timer_TagScan.Tick += new System.EventHandler(this.timer_TagScan_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel10);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.panel9);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.panel8);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.panel7);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(8, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(308, 316);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Show tag PLC";
            // 
            // panel7
            // 
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel7.Controls.Add(this.tbx_TagBool);
            this.panel7.Location = new System.Drawing.Point(156, 53);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(140, 37);
            this.panel7.TabIndex = 6;
            // 
            // tbx_TagBool
            // 
            this.tbx_TagBool.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbx_TagBool.Location = new System.Drawing.Point(8, 7);
            this.tbx_TagBool.Name = "tbx_TagBool";
            this.tbx_TagBool.Size = new System.Drawing.Size(120, 21);
            this.tbx_TagBool.TabIndex = 1;
            this.tbx_TagBool.Text = "FALSE";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 24);
            this.label7.TabIndex = 5;
            this.label7.Text = "Tag_1 Bool";
            // 
            // panel8
            // 
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel8.Controls.Add(this.tbx_TagInt);
            this.panel8.Location = new System.Drawing.Point(156, 96);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(140, 37);
            this.panel8.TabIndex = 8;
            // 
            // tbx_TagInt
            // 
            this.tbx_TagInt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbx_TagInt.Location = new System.Drawing.Point(8, 7);
            this.tbx_TagInt.Name = "tbx_TagInt";
            this.tbx_TagInt.Size = new System.Drawing.Size(120, 21);
            this.tbx_TagInt.TabIndex = 1;
            this.tbx_TagInt.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 102);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 24);
            this.label8.TabIndex = 7;
            this.label8.Text = "Tag_2 Int";
            // 
            // panel9
            // 
            this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel9.Controls.Add(this.tbx_TagReal);
            this.panel9.Location = new System.Drawing.Point(156, 139);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(140, 37);
            this.panel9.TabIndex = 8;
            // 
            // tbx_TagReal
            // 
            this.tbx_TagReal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbx_TagReal.Location = new System.Drawing.Point(8, 7);
            this.tbx_TagReal.Name = "tbx_TagReal";
            this.tbx_TagReal.Size = new System.Drawing.Size(120, 21);
            this.tbx_TagReal.TabIndex = 1;
            this.tbx_TagReal.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 145);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 24);
            this.label9.TabIndex = 7;
            this.label9.Text = "Tag_3 Real";
            // 
            // panel10
            // 
            this.panel10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel10.Controls.Add(this.tbx_TagString);
            this.panel10.Location = new System.Drawing.Point(156, 182);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(140, 37);
            this.panel10.TabIndex = 8;
            // 
            // tbx_TagString
            // 
            this.tbx_TagString.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbx_TagString.Location = new System.Drawing.Point(8, 7);
            this.tbx_TagString.Name = "tbx_TagString";
            this.tbx_TagString.Size = new System.Drawing.Size(120, 21);
            this.tbx_TagString.TabIndex = 1;
            this.tbx_TagString.Text = "ABC";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 188);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(116, 24);
            this.label10.TabIndex = 7;
            this.label10.Text = "Tag_4 String";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btt_PLC_WriteToPLC);
            this.groupBox3.Controls.Add(this.panel11);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.panel12);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.panel13);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.panel14);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Location = new System.Drawing.Point(400, 37);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(308, 316);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Fill tag PLC";
            // 
            // panel11
            // 
            this.panel11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel11.Controls.Add(this.tbx_Write_TagString);
            this.panel11.Location = new System.Drawing.Point(156, 182);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(140, 37);
            this.panel11.TabIndex = 8;
            // 
            // tbx_Write_TagString
            // 
            this.tbx_Write_TagString.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbx_Write_TagString.Location = new System.Drawing.Point(8, 7);
            this.tbx_Write_TagString.Name = "tbx_Write_TagString";
            this.tbx_Write_TagString.Size = new System.Drawing.Size(120, 21);
            this.tbx_Write_TagString.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(18, 188);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(116, 24);
            this.label11.TabIndex = 7;
            this.label11.Text = "Tag_4 String";
            // 
            // panel12
            // 
            this.panel12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel12.Controls.Add(this.tbx_Write_TagReal);
            this.panel12.Location = new System.Drawing.Point(156, 139);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(140, 37);
            this.panel12.TabIndex = 8;
            // 
            // tbx_Write_TagReal
            // 
            this.tbx_Write_TagReal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbx_Write_TagReal.Location = new System.Drawing.Point(8, 7);
            this.tbx_Write_TagReal.Name = "tbx_Write_TagReal";
            this.tbx_Write_TagReal.Size = new System.Drawing.Size(120, 21);
            this.tbx_Write_TagReal.TabIndex = 1;
            this.tbx_Write_TagReal.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(18, 145);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(106, 24);
            this.label12.TabIndex = 7;
            this.label12.Text = "Tag_3 Real";
            // 
            // panel13
            // 
            this.panel13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel13.Controls.Add(this.tbx_Write_TagInt);
            this.panel13.Location = new System.Drawing.Point(156, 96);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(140, 37);
            this.panel13.TabIndex = 8;
            // 
            // tbx_Write_TagInt
            // 
            this.tbx_Write_TagInt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbx_Write_TagInt.Location = new System.Drawing.Point(8, 7);
            this.tbx_Write_TagInt.Name = "tbx_Write_TagInt";
            this.tbx_Write_TagInt.Size = new System.Drawing.Size(120, 21);
            this.tbx_Write_TagInt.TabIndex = 1;
            this.tbx_Write_TagInt.Text = "0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(18, 102);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(87, 24);
            this.label13.TabIndex = 7;
            this.label13.Text = "Tag_2 Int";
            // 
            // panel14
            // 
            this.panel14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel14.Controls.Add(this.tbx_Write_TagBool);
            this.panel14.Location = new System.Drawing.Point(156, 53);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(140, 37);
            this.panel14.TabIndex = 6;
            // 
            // tbx_Write_TagBool
            // 
            this.tbx_Write_TagBool.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbx_Write_TagBool.Location = new System.Drawing.Point(8, 7);
            this.tbx_Write_TagBool.Name = "tbx_Write_TagBool";
            this.tbx_Write_TagBool.Size = new System.Drawing.Size(120, 21);
            this.tbx_Write_TagBool.TabIndex = 1;
            this.tbx_Write_TagBool.Text = "FALSE";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(18, 59);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(106, 24);
            this.label14.TabIndex = 5;
            this.label14.Text = "Tag_1 Bool";
            // 
            // btt_PLC_WriteToPLC
            // 
            this.btt_PLC_WriteToPLC.BackColor = System.Drawing.Color.Silver;
            this.btt_PLC_WriteToPLC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btt_PLC_WriteToPLC.Location = new System.Drawing.Point(193, 248);
            this.btt_PLC_WriteToPLC.Name = "btt_PLC_WriteToPLC";
            this.btt_PLC_WriteToPLC.Size = new System.Drawing.Size(103, 49);
            this.btt_PLC_WriteToPLC.TabIndex = 13;
            this.btt_PLC_WriteToPLC.Text = "Write";
            this.btt_PLC_WriteToPLC.UseVisualStyleBackColor = false;
            this.btt_PLC_WriteToPLC.Click += new System.EventHandler(this.btt_PLC_WriteToPLC_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 673);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            this.panel14.ResumeLayout(false);
            this.panel14.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Sys_btt_Disconnect;
        private System.Windows.Forms.Button Sys_btt_Connect;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox Sys_tbx_WatchDog;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox Sys_tbx_PLC_Connect_Status;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox Sys_tbx_IOServer;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox Sys_tbx_PLC_Tag_Scan_Time;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox Sys_tbx_Channel;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Sys_btt_PLC_Data_Save;
        private System.Windows.Forms.Button Sys_btt_PLC_Data_Edit;
        private System.Windows.Forms.Timer timer_TagScan;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.TextBox tbx_TagString;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.TextBox tbx_TagReal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox tbx_TagInt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox tbx_TagBool;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.TextBox tbx_Write_TagString;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.TextBox tbx_Write_TagReal;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.TextBox tbx_Write_TagInt;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.TextBox tbx_Write_TagBool;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btt_PLC_WriteToPLC;
    }
}

