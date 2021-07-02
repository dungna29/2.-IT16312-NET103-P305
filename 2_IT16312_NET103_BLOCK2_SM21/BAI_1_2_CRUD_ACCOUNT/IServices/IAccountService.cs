using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BAI_1_2_CRUD_ACCOUNT.Models;

namespace BAI_1_2_CRUD_ACCOUNT.IServices
{
    public interface IAccountService
    {
        string addAccount(Account account);//Phương thức thêm
        string editAccount(Account account);//Phương thức sửa
        string removeAccount(int id);//Phương thức xóa

        //Phương thức tìm 1 đối tượng
        Account findAccount(int id);

        //Phương thức Lấy danh sách 
        List<Account> getlstAccounts();
        //Phương thức lấy danh sách gần đúng theo tài khoản
        List<Account> getlstAccountsByAcc(string acc);

        //Phương thức đổ dữ liệu từ file về Service
        void fillDataFromFileToService(List<Account> lstAccounts);

        //Phương thức lấy danh sách năm sinh
        string[] getYearOfBirths();

    }
}
