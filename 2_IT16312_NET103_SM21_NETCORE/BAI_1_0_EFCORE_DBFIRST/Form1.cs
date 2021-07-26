using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BAI_1_0_EFCORE_DBFIRST.Context;
using BAI_1_0_EFCORE_DBFIRST.Models;

namespace BAI_1_0_EFCORE_DBFIRST
{
    public partial class Form1 : Form
    {
        private DatabaseContext _databaseContext;
        public Form1()
        {
            InitializeComponent();
            _databaseContext = new DatabaseContext();
            Cach1LoadData();
        }
        void Cach1LoadData()
        {
            var _lstAccounts = new List<AccountsAdo>();//Khởi tạo lại List
            _lstAccounts = _databaseContext.AccountsAdos.ToList();//Đổ dữ liệu vào List hiện tại
            //Đếm số lượng thuốc tính có trong dối tượng
            Type type = typeof(AccountsAdo);
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
                dgrid_Account.Rows.Add(x.Id, x.Acc, x.Pass, x.Sex == 1 ? "Nam" : "Nữ", x.YearofBirth, DateTime.Now.Year - x.YearofBirth, x.Status== true ? "Hoạt động" : "Không hoạt động");
            }
        }
    }
}
