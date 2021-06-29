using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BAI_1_1_TongQuanWindowForm
{
    public partial class S1_GioiThieuCacControlCoBan : Form
    {
        public S1_GioiThieuCacControlCoBan()
        {
            InitializeComponent();
            lbl_Ten.Text = "Dũng";
        }

        private void btn_ClickVaoDay_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_ClickVaoDay_MouseDown(object sender, MouseEventArgs e)
        {
            lbl_Ten.Text = "Tôi đang giữ chuột";
        }

        private void btn_ClickVaoDay_MouseUp(object sender, MouseEventArgs e)
        {
            lbl_Ten.Text = "Tôi đã bỏ giữ chuột";
        }
    }
}
