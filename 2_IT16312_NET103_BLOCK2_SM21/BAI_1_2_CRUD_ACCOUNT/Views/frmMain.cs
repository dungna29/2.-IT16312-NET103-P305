using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BAI_1_2_CRUD_ACCOUNT.IServices;
using BAI_1_2_CRUD_ACCOUNT.Models;
using BAI_1_2_CRUD_ACCOUNT.Services;

namespace BAI_1_2_CRUD_ACCOUNT.Views
{
    public partial class frmMain : Form
    {
        private IAccountService _iAccountService;
        private IFileService _iFileService;
        private string _fileNamePath;//Link đường dẫn
        private List<Account> _lstAccounts;
        private Account _account;
        private int idAccWhenClick = -1;
        public frmMain()
        {
            InitializeComponent();
            //khởi tạo
            _iFileService = new FileService();
            _iAccountService = new AccountService();
            _lstAccounts = new List<Account>();
            rbtnNam.Checked = true;
            cbxKhongHoatDong.Checked = true;
            loadCbxNamSinh();
        }
        void loadCbxNamSinh()//Đổ năm sinh vào combobox năm sinh
        {
            foreach (var x in _iAccountService.getYearOfBirths())
            {
                cmbNamSinh.Items.Add(x);
            }

            cmbNamSinh.SelectedIndex = _iAccountService.getYearOfBirths().Length - 10;
        }

        void loadData()
        {
            _lstAccounts = new List<Account>();//Khởi tạo lại List
            _lstAccounts = _iAccountService.getlstAccounts();//Đổ dữ liệu vào List hiện tại
            //Đếm số lượng thuốc tính có trong dối tượng
            Type type = typeof(Account);
            int slThuocTinh = type.GetProperties().Length;//Số lượng thuộc tính có trong đối tượng
            dgrid_Account.ColumnCount = slThuocTinh+1;//Ví có thêm cột tuổi
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
                dgrid_Account.Rows.Add(x.Id,x.Acc,x.Pass,x.Sex == 1?"Nam":"Nữ",x.YearofBirth,DateTime.Now.Year - x.YearofBirth,x.Status?"Hoạt động":"Không hoạt động");
            }
        }
        public void SenderDataFromLogin(TextBox txtacc, string duongDanFile)
        {
            _fileNamePath = duongDanFile; //Gán lại giá trị đường dẫn từ form login sang bên form đăng ký
            lbl_AccLogin.Text = "Bạn đang nhập bằng: " + txtacc.Text;
            //Khi lấy được đường dẫn từ form Login lên main thì chúng ta tiến hành đọc file và đổ dữ liệu vào AccountService
            _iAccountService.fillDataFromFileToService(_iFileService.openFile<Account>(duongDanFile));
            loadData();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {

            _account = new Account();
            //Gán giá trị cho đối tượng
            _account.Id = _lstAccounts == null ? 1 : _lstAccounts.Count;//Giúp cho id tự sinh
            _account.Acc = txtAcc.Text;
            _account.Pass = txtPass.Text;
            _account.Sex = rbtnNam.Checked ? 1 : 0;
            _account.YearofBirth = Convert.ToInt32(cmbNamSinh.SelectedItem);
            _account.Status = cbxKhongHoatDong.Checked?false:true;
            //Sau khi gán dữ liệu vào đối tượng thì tiến hành sử dụng chức năng thêm đối tượng
            _iAccountService.addAccount(_account);
            //Sau khi thêm đối tượng xong thì tiến hành LoadData
            loadData();
        }

        private void cbxHoatDong_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxHoatDong.Checked)
            {
                cbxKhongHoatDong.Checked = false;
            }
        }

        private void cbxKhongHoatDong_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxKhongHoatDong.Checked)
            {
                cbxHoatDong.Checked = false;
            }
        }

        private void mn_luuFile_Click(object sender, EventArgs e)
        {
            string temp = _iFileService.saveFile(_fileNamePath, _lstAccounts);
            MessageBox.Show(temp, "Thông báo");
        }

        private void dgrid_Account_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //1. Lấy index row khi mình bấm vào Grid
            int rowIndex = e.RowIndex;
            if (rowIndex == _lstAccounts.Count) return;//Khi bấm vào dòng cuối của grid nằm ngoài index thì sẽ ko làm gì
            //2. Lấy giá trị tại cột ID trên dòng được chọn
            idAccWhenClick = Convert.ToInt32(dgrid_Account.Rows[rowIndex].Cells[0].Value);

            //3. Có 2 cách để tìm được đối tượng 1- dùng Service để tìm 2 là sử dụng cách lấy giá trị tại cột ở trên.
            txtAcc.Text = dgrid_Account.Rows[rowIndex].Cells[1].Value.ToString();
            txtPass.Text = dgrid_Account.Rows[rowIndex].Cells[2].Value.ToString();
            rbtnNam.Checked = dgrid_Account.Rows[rowIndex].Cells[3].Value.ToString() == "Nam"
                ? true
                : false;
            rbtnNu.Checked = dgrid_Account.Rows[rowIndex].Cells[3].Value.ToString() == "Nữ"
                ? true
                : false;
            cmbNamSinh.SelectedIndex = cmbNamSinh.FindString(dgrid_Account.Rows[rowIndex].Cells[4].Value.ToString());
            cbxHoatDong.Checked = dgrid_Account.Rows[rowIndex].Cells[6].Value.ToString() == "Hoạt động"
                ? true
                :false;
            cbxKhongHoatDong.Checked = dgrid_Account.Rows[rowIndex].Cells[6].Value.ToString() == "Không hoạt động"
                ? true
                : false;
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_iAccountService.removeAccount(_lstAccounts.Where(c => c.Acc == txtAcc.Text)
                .Select(c => c.Id).FirstOrDefault()),"Thông báo");
            //Sau khi xóa thành công thì cần phải load lại data ở Grid view
            loadData();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            _account = new Account();
            _account.Id = idAccWhenClick;//idAccWhenClick là 1 biến toàn cục được lưu từ khi bấm vào Cell click có kiểu số nguyên
            _account.Acc = txtAcc.Text;
            _account.Pass = txtPass.Text;
            _account.Sex = rbtnNam.Checked ? 1 : 0;
            _account.YearofBirth = Convert.ToInt32(cmbNamSinh.SelectedItem);
            _account.Status = cbxHoatDong.Checked;
            MessageBox.Show(_iAccountService.editAccount(_account), "Thông báo");
            loadData();
            idAccWhenClick = -1;
        }

        private void txtTimKiem_KeyUp(object sender, KeyEventArgs e)
        {
            loadDataBySearch(txtTimKiem.Text);
        }
        void loadDataBySearch(string acc)
        {
            _lstAccounts = new List<Account>();//Khởi tạo lại List
            _lstAccounts = _iAccountService.getlstAccountsByAcc(acc);//Đổ dữ liệu vào List hiện tại
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
    }
}
