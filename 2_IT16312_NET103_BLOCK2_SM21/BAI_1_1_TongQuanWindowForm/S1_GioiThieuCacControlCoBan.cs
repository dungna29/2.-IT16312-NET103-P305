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
            loadNamSinh();
            loadDataToGridView();//Load data vào gridview
         

           
        }

        void loadDataToGridView()
        {
            gv_data.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;//Cấu hình cho các cột fill all trong grid view không để khoảng trống

            TheLoai lsTheLoai = new TheLoai();
            //Cách 1:
            //gv_data.DataSource = lsTheLoai.GetListTheLoais();

            //Cách 2: DataTable
            DataTable table = new DataTable();
            //Tạo tên cột và kiểu dữ liệu cột
            table.Columns.Add("Mã Thể Loại", typeof(string));
            table.Columns.Add("Tên Thể Loại", typeof(string));
            table.Columns.Add("Trạng Thái", typeof(string));
            table.Columns.Add("Trạng Thái Sửa", typeof(string));

            //Fill Data
            foreach (var x in lsTheLoai.GetListTheLoais())
            {
                table.Rows.Add(x.MaTheLoai, x.TenTheLoai, x.TrangThai, x.statuEdit);
            }
            //gv_data.DataSource = table;

            //Cách 3: Làm việc trực tiếp trên Gridview
            //Tạo cột
            gv_data.ColumnCount = 4;//Số lượng cột
            gv_data.Columns[0].Name = "Mã Thể Loại";
            gv_data.Columns[1].Name = "Tên";
            gv_data.Columns[2].Name = "Trạng Thái";
            gv_data.Columns[3].Name = "Trạng Thái Sửa";
            //Fill Data
            foreach (var x in lsTheLoai.GetListTheLoais())
            {
                gv_data.Rows.Add(x.MaTheLoai, x.TenTheLoai, x.TrangThai, x.statuEdit);
            }

         

        }

        void loadNamSinh()
        {
            //Từ năm 1600 đến 2021
            int temp = 1600;
            for (int i = 0; i <= 2021-1600; i++)
            {
                cbb_NamSinh.Items.Add(temp);
                temp++;
            }
            
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txt_Id.Text))
            {
                MessageBox.Show("Không được để khoảng trắng","Cảnh báo");
                return;
            }
            MessageBox.Show("Chào bạn: " + txt_Id.Text, "Thông báo");//Show ra thông báo
        }
    }
}
