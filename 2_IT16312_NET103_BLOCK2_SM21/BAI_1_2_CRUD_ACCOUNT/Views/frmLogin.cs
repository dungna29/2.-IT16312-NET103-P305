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
    public partial class frmLogin : Form
    {
        private IAccountService _iAccountService;
        private IFileService _iFileService;
        private string _fileNamePath;//Link đường dẫn
        private List<Account> _lstAccounts;
        public frmLogin()
        {
            InitializeComponent();
            //khởi tạo
            _iFileService = new FileService();
            _iAccountService = new AccountService();
        }

        private void btn_OpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                _fileNamePath = dlg.FileName;//Gán lại đường dẫn của file cho biến
                lbl_fileNamePath.Text = _fileNamePath;
                _lstAccounts = _iFileService.openFile<Account>(_fileNamePath);//Đọc file lên và lấy giá trị ở trong file gán lại cho List
                _iAccountService.fillDataFromFileToService(_lstAccounts);//Đổ giá trị vào cho List ở bên AccountService
                lbl_checkdata.Text = (_iAccountService.getlstAccounts() == null?0: _iAccountService.getlstAccounts().Count).ToString();
            }
        }

        private void lbl_DangKy_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmRegister frmRegister = new frmRegister();
            frmRegister.SenderFileNamePathFromLogin(_fileNamePath);//Gọi phương thức bên class đăng ký và truyền đường dẫn sang để gán lại
            this.Hide();//Ẩn form hiện tại đi
            frmRegister.Show();//Hiển thị form gọi đến
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            if (_iAccountService.getlstAccounts() != null)
            {
                lbl_checkdata.Text = _iAccountService.getlstAccounts().Count.ToString();
                //Trước khi login có thể chekc lỗi để trống .....
                //Câu điền kiên kiểm tra tài khoản bằng linq
                if (_iAccountService.getlstAccounts().Any(c => c.Acc == txt_Acc.Text && c.Pass == txt_Pass.Text))
                {
                    MessageBox.Show("Chúc mừng đăng nhập thành công", "Thông báo");
                    this.Hide();
                    frmMain frmMain = new frmMain();
                    frmMain.SenderDataFromLogin(txt_Acc,_fileNamePath);//Truyền dữ liệu từ login lên main khi đăng nhập thành công
                    frmMain.Show();
                }
                return;
            }
            MessageBox.Show("File Data rỗng ko thể login");
        }

        private void txt_Acc_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt_Acc.Text))
            {
                MessageBox.Show("Bạn ko đc để Empty", "Thông báo");
                txt_Acc.Text = "";
            }
        }
    }
}
