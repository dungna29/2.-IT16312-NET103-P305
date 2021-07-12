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
    public partial class frmRegister : Form
    {
        private IAccountService _iAccountService;
        private IFileService _iFileService;
        private string _fileNamePath;//Link đường dẫn
        private List<Account> _lstAccounts;
        public frmRegister()
        {
            InitializeComponent();
            //Khởi tạo
            _iAccountService = new AccountService();
            _iFileService = new FileService();
            rbtnNam.Checked = true;
            loadCbxNamSinh();
            cmbNamSinh.SelectedIndex = cmbNamSinh.Items.Count - 20;//Load giá trị mặc định của combox năm sinh
           
        }

        void loadCbxNamSinh()//Đổ năm sinh vào combobox năm sinh
        {
            foreach (var x in _iAccountService.getYearOfBirths())
            {
                cmbNamSinh.Items.Add(x);
            }
        }
        //Đọc dữ liệu trong file lên để khi thêm thì sẽ thêm tài khoản vào cuối danh sách giúp ko bị ghi đè dữ liệu
        void loadData()
        {
            if (_iFileService.openFile<Account>(_fileNamePath) != null)
            {
                _lstAccounts = _iFileService.openFile<Account>(_fileNamePath);
                return;
            }
            _lstAccounts = new List<Account>();
           
        }

        public void SenderFileNamePathFromLogin(string path)
        {
            _fileNamePath = path; //Gán lại giá trị đường dẫn từ form login sang bên form đăng ký
        }

        private void btn_TaoTaiKhoan_Click(object sender, EventArgs e)
        {
            loadData();//Đọc data từ file trước
            Account acc = new Account();
            //Gán giá trị cho đối tượng
            acc.Id = _lstAccounts == null ? 1 : _lstAccounts.Count;//Giúp cho id tự sinh
            acc.Acc = txtAcc.Text;
            acc.Pass = txtPass.Text;
            acc.Sex = rbtnNam.Checked ? 1 : 0;
            acc.YearofBirth =Convert.ToInt32(cmbNamSinh.SelectedItem);
            _lstAccounts.Add(acc);//Thêm đối tượng vào danh sách
            //Sau khi thêm mới vào List thì tiến hành lưu vào file đã chỉ định
            string temp = _iFileService.saveFile(_fileNamePath, _lstAccounts);
            MessageBox.Show(temp, "Thông báo");
            this.Hide();
            frmLogin frmLogin = new frmLogin();
            frmLogin.Show();
        }
    }
}
