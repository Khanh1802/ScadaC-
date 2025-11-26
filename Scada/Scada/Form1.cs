using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scada
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Hàm form load
        private void Form1_Load(object sender, EventArgs e)
        {
            fn_show_para_textbox();
        }

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

    }
}
