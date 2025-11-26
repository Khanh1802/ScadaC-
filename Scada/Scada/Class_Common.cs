using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scada
{
    class Class_Common
    {
        //// 1. Operation confirm popup                                            
        public static bool fn_Confirm()
        {
            string message = "Bạn có muốn thao tác?";
            string title = "Xác nhận thao tác";
            MessageBoxButtons button = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, button, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                return true;
            }
            return false;
        }
    }
}
