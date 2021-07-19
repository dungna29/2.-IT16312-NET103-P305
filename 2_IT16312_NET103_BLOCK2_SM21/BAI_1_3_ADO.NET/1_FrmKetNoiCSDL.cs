using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BAI_1_3_ADO.NET
{
    public partial class frmKetNoiCSDL : Form
    {
        private string _sqlConnectionStr = @"Data Source=DUNGNA_PC2021\SQLEXPRESS;Initial Catalog=CSharp3_Dungna29;Persist Security Info=True;User ID=dungna29;Password=123;
            ";//Chuỗi kết nối
        private SqlConnection _conn;
        private SqlCommand _cmd;
        public frmKetNoiCSDL()
        {
            InitializeComponent();
        }

        private void btn_KetNoiDB_Click(object sender, EventArgs e)
        {
            
            //1. Khởi tạo lớp kết nối vào cơ sở dững liệu truyền đường dẫn kết nối vào CSDL.
            _conn = new SqlConnection(_sqlConnectionStr);
            //2. Mở kết nối
            _conn.Open();
            //3. Sau khi mở kết nối CSDL thì cần thực hiện 1 hành động nào đó
            MessageBox.Show("Kết nối CSDL thành công");
            //4. Khởi tạo SqlCommand với Query và SqlConnection
            _cmd = new SqlCommand("Select * from Accounts_ADO", _conn);
            //var data = _cmd.ExecuteReader();//Thực thi đọc dữ liệu lên
            SqlDataAdapter data = new SqlDataAdapter(_cmd);
            DataTable table = new DataTable();
            data.Fill(table);
            dataGridView1.DataSource = table;
            //5. Sau khi thực hiện xong hành động nào đó nếu ko làm việc với CSDL nữa thì phải đóng lại
            _conn.Close();
            
        }
    }
}
