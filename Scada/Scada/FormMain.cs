using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NgocAuto_OPC;
namespace Scada
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        //Hàm form load
        private void Form1_Load(object sender, EventArgs e)
        {
            fn_show_para_textbox();
            fn_OPC(); // Kết nối PLC (OPC)

            // Cài đặt thời gian quét tag
            timer_TagScan.Interval = Properties.Settings.Default.PLC_Tag_Scan_Time;
            timer_TagScan.Enabled = true;
        }

        #region Kết nối OPC
        // 1.1 Khai báo OPC
        KEPServerEX PLCMitsubishi = new KEPServerEX();

        // 1.2 Tạo phương thức kết nối OPC
        public void fn_OPC()
        {
            string IOServer = Properties.Settings.Default.IOServer;
            string Channel = Properties.Settings.Default.Channel;
            int PLCscantime = Properties.Settings.Default.PLC_Tag_Scan_Time;
            PLCMitsubishi.OPCSetting(IOServer, Channel, PLCscantime, Class_Tags_List.Tags_List);
            PLCMitsubishi.Connect();
        }


        #region Nút nhấn kết nối & ngắt kết nối
        // Nút nhấn kết nối
        private void Sys_btt_Connect_Click(object sender, EventArgs e)
        {
            var confirm = Class_Common.fn_Confirm();
            if (confirm)
            {
                PLCMitsubishi.Connect();
            }
        }

        // Nút nhấn ngắt kết nối
        private void Sys_btt_Disconnect_Click(object sender, EventArgs e)
        {
            var confirm = Class_Common.fn_Confirm();
            if (confirm)
            {
                PLCMitsubishi.Disconnect();
                // Hiển thị trạng thái disconnect
                Sys_tbx_PLC_Connect_Status.Text = "Disconnected";
                Sys_tbx_PLC_Connect_Status.BackColor = Color.Red;
            }
        }

        #endregion

        // Timer scan
        public void fn_Tags_Read()
        {
            string tag_watchdog = PLCMitsubishi.Read("Watchdog");
            Sys_tbx_WatchDog.Text = tag_watchdog;

            // Hiển thị giá trị lên textbox
            tbx_TagBool.Text = PLCMitsubishi.Read("Tag1");
            tbx_TagInt.Text = PLCMitsubishi.Read("Tag2");
            tbx_TagReal.Text = PLCMitsubishi.Read("Tag3");
            tbx_TagString.Text = PLCMitsubishi.Read("Tag4");
            // Gọi phương thức watchdog            
            fn_Watchdog(tag_watchdog);
        }

        // Timer quét giá trị tag
        private void timer_TagScan_Tick(object sender, EventArgs e)
        {
            fn_Tags_Read(); // Đọc giá trị tag
        }

        #endregion

        #region Cấu hình nút nhấn sửa & lưu
        //1 Chương trình cho nút nhấn sửa
        private void Sys_btt_PLC_Data_Edit_Click(object sender, EventArgs e)
        {
            bool editConfirm = Class_Common.fn_Confirm();
            //Enable các textbox
            if (editConfirm)
            {
                Sys_tbx_IOServer.Enabled = true;
                Sys_tbx_Channel.Enabled = true;
                Sys_tbx_PLC_Tag_Scan_Time.Enabled = true;

                // Hiện nút lưu & ẩn nút sửa
                Sys_btt_PLC_Data_Save.Visible = true;
                Sys_btt_PLC_Data_Edit.Visible = false;

                //Move vị trí nút lưu vào vị trí nút sửa
                Sys_btt_PLC_Data_Save.Location = Sys_btt_PLC_Data_Edit.Location;
            }
        }

        //2 Chương trình cho nút nhấn lưu
        private void Sys_btt_PLC_Data_Save_Click(object sender, EventArgs e)
        {
            bool saveConfirm = Class_Common.fn_Confirm();
            // Xác nhận thao tác
            if (saveConfirm == true)
            {
                // B1: Lấy thuộc tính textbox đưa vào trường cài đặt (setting)
                Properties.Settings.Default.IOServer = Sys_tbx_IOServer.Text;
                Properties.Settings.Default.Channel = Sys_tbx_Channel.Text;
                Properties.Settings.Default.PLC_Tag_Scan_Time = int.Parse(Sys_tbx_PLC_Tag_Scan_Time.Text);
                Properties.Settings.Default.Save();

                // B2: Thông báo lưu thành công
                MessageBox.Show("Lưu dữ liệu thành công", "Màn hình thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            // B3: Disable các textbox
            Sys_tbx_IOServer.Enabled = false;
            Sys_tbx_Channel.Enabled = false;
            Sys_tbx_PLC_Tag_Scan_Time.Enabled = false;

            // B4: Hiện nút sửa & ẩn nút lưu
            Sys_btt_PLC_Data_Save.Visible = false;
            Sys_btt_PLC_Data_Edit.Visible = true;
            //Thông báo lưu thành công
        }

        //3 Tạo phương thức hiển thị từ trường lên textbox
        private void fn_show_para_textbox()
        {
            Sys_tbx_IOServer.Text = Properties.Settings.Default.IOServer.ToString();
            Sys_tbx_Channel.Text = Properties.Settings.Default.Channel.ToString();
            Sys_tbx_PLC_Tag_Scan_Time.Text = Properties.Settings.Default.PLC_Tag_Scan_Time.ToString();
        }
        #endregion

        #region Hiển thị trạng thái kết nối
        //-----------------------------------------------
        //               Xử lý Watchdog              
        //-----------------------------------------------
        static int watchdog_last = 0;
        static int watchdog_timeout = 0;
        static int reconnect_count = 0;

        // Phương thức watchdog - kiểm tra trạng thái kết nối
        public void fn_Watchdog(string tag_watchdog_in)
        {
            try
            {
                int tag_watchdogPresent = int.Parse(tag_watchdog_in);
                if (tag_watchdogPresent != watchdog_last)
                {
                    watchdog_timeout = 0;
                    reconnect_count = 0;
                    Sys_tbx_PLC_Connect_Status.Text = "Connected";
                    Sys_tbx_PLC_Connect_Status.BackColor = Color.Green;
                    Sys_tbx_PLC_Connect_Status.ForeColor = Color.White;
                }
                else
                {
                    watchdog_timeout += 1;
                }
                watchdog_last = tag_watchdogPresent;

                // Nếu time out thì ngắt kết nối PLC
                if (watchdog_timeout >= 5) // 5s
                {
                    // Hiển thị trạng thái disconnect
                    Sys_tbx_PLC_Connect_Status.Text = "Disconnected";
                    Sys_tbx_PLC_Connect_Status.BackColor = Color.Red;

                    // Thực hiện kết nối lại khi bộ đếm >= 15s.
                    reconnect_count++;
                    if (reconnect_count >= 15)
                    {
                        PLCMitsubishi.Connect(); // Kết nối PLC1
                        reconnect_count = 0;
                        watchdog_timeout = 0;
                    }
                }
            }
            catch { }
        }
        #endregion

        private void btt_PLC_WriteToPLC_Click(object sender, EventArgs e)
        {
            PLCMitsubishi.Write("Tag1", tbx_Write_TagBool.Text);
            PLCMitsubishi.Write("Tag2", tbx_Write_TagInt.Text);
            PLCMitsubishi.Write("Tag3", tbx_Write_TagReal.Text);
        }
    }
}
