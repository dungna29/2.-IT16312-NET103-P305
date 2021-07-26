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
using BAI_1_3_ADO.Services;

namespace BAI_1_3_ADO.NET
{
    public partial class MainAccount_ADO : Form
    {
        private AccountService _accountService;
        private List<Account> _lstAccounts;
        private string _sqlConnectionStr = @"Data Source=DUNGNA_PC2021\SQLEXPRESS;Initial Catalog=CSharp3_Dungna29;Persist Security Info=True;User ID=dungna29;Password=123;
            ";//Chuỗi kết nối
        private SqlConnection _conn;
        private SqlCommand _cmd;
        public MainAccount_ADO()
        {
            InitializeComponent();
            _accountService = new AccountService(_sqlConnectionStr);
            Cach1LoadData();
            Cach2LoadData();
            Cach4LoadData();
        }
        void Cach1LoadData()
        {
            _lstAccounts = new List<Account>();//Khởi tạo lại List
            _lstAccounts = _accountService.GetLstAccountsDB();//Đổ dữ liệu vào List hiện tại
            //Đếm số lượng thuốc tính có trong dối tượng
            Type type = typeof(Account);
            int slThuocTinh = type.GetProperties().Length;//Số lượng thuộc tính có trong đối tượng
            dgrid_Account.ColumnCount = slThuocTinh + 1;//Ví có thêm cột tuổi
            dgrid_Account.Columns[0].Name = "Id";
            dgrid_Account.Columns[1].Name = "Tài khoản";
            dgrid_Account.Columns[2].Name = "Mật khẩu";
            dgrid_Account.Columns[3].Name = "Giới tính";
            dgrid_Account.Columns[4].Name = "Năm sinh";
            dgrid_Account.Columns[5].Name = "Tuổi";
            dgrid_Account.Columns[6].Name = "Trang thái";
            dgrid_Account.Rows.Clear();
            //Đổ dữ liệu
            foreach (var x in _lstAccounts)
            {
                dgrid_Account.Rows.Add(x.Id, x.Acc, x.Pass, x.Sex == 1 ? "Nam" : "Nữ", x.YearofBirth, DateTime.Now.Year - x.YearofBirth, x.Status ? "Hoạt động" : "Không hoạt động");
            }
        }

        void Cach2LoadData()
        {
            _conn = _accountService.GetSqlConnection(_sqlConnectionStr);
            _conn.Open();
            _cmd = _accountService.GetSqlCommand("Select * from Accounts_ADO", _conn);
            //Sử dụng SqlDataAdapter hứng dữ liệu khi truy vấn
            SqlDataAdapter dataAdapter = new SqlDataAdapter(_cmd);

            //DataTable là con của DataSet và nó tương ứng 1 bảng trong CSDL bao gồm row và col
            //DataSet là tập hợp các bảng bên trong

            //Dùng DataTable
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);//Đổ dữ liệu vào DataTable
            dgrid_Account2.DataSource = dataTable;
            //Không nên can thiệp vào các Col nếu như muốn thay đổi tên cột phải sử dụng câu truy vấn thêm từ khóa AS để đổi tên cột.
            _conn.Close();
        }
        void Cach3LoadData()//Không sử dụng SqlCommand
        {
            _conn = _accountService.GetSqlConnection(_sqlConnectionStr);
            _conn.Open();
            //Sử dụng SqlDataAdapter hứng dữ liệu khi truy vấn
            SqlDataAdapter dataAdapter = new SqlDataAdapter("Select * from Accounts_ADO", _conn);

            //DataTable là con của DataSet và nó tương ứng 1 bảng trong CSDL bao gồm row và col
            //DataSet là tập hợp các bảng bên trong

            //Dùng DataTable
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);//Đổ dữ liệu vào DataTable
            dgrid_Account2.DataSource = dataTable;
            //Không nên can thiệp vào các Col nếu như muốn thay đổi tên cột phải sử dụng câu truy vấn thêm từ khóa AS để đổi tên cột.
            _conn.Close();
        }
        void Cach4LoadData()//Sử dụng Dataset
        {
            _conn = _accountService.GetSqlConnection(_sqlConnectionStr);
            _conn.Open();
            //Sử dụng SqlDataAdapter hứng dữ liệu khi truy vấn
            SqlDataAdapter dataAdapter = new SqlDataAdapter("Select * from Accounts_ADO", _conn);

            //DataTable là con của DataSet và nó tương ứng 1 bảng trong CSDL bao gồm row và col
            //DataSet là tập hợp các bảng bên trong

            //Dùng DataSet
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);//Đổ dữ liệu vào DataTable
            dgrid_Account3.DataSource = dataSet.Tables[0];//Vì nó gồm nhiều bảng bên trong vì vậy không thể gán trực tiếp
            _conn.Close();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            _conn = _accountService.GetSqlConnection(_sqlConnectionStr);
            _conn.Open();
            string query =
                @"INSERT INTO Accounts_ADO(Acc,Pass,Sex,YearofBirth,Status) VALUES (@Acc,@Pass,@Sex,@YearofBirth,@Status)";
            _cmd = _accountService.GetSqlCommand(query, _conn);
            _cmd.CommandText = query;
            //_cmd.Parameters.AddWithValue("@Id", Guid.NewGuid());//Tạo ra Guild tự động trên code
            _cmd.Parameters.AddWithValue("@Acc", txtAcc.Text);
            _cmd.Parameters.AddWithValue("@Pass", txtPass.Text);
            _cmd.Parameters.AddWithValue("@Sex", rbtnNam.Checked?1:0);
            _cmd.Parameters.AddWithValue("@YearofBirth", cmbNamSinh.Text);
            _cmd.Parameters.AddWithValue("@Status",cbxHoatDong.Checked);

            _cmd.ExecuteNonQuery();//Thực thi câu truy vấn không trả về dữ liệu
            Cach1LoadData();
            Cach2LoadData();
            Cach4LoadData();
            _conn.Close();
        }
    }
}
