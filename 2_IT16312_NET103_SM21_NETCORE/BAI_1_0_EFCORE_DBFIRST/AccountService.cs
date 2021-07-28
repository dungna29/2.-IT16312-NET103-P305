using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BAI_1_0_EFCORE_DBFIRST.Context;
using BAI_1_0_EFCORE_DBFIRST.Models;

namespace BAI_1_0_EFCORE_DBFIRST
{
    class AccountService
    {
        private DatabaseContext _dbContext;
        private List<AccountsAdo> _lstAccountsAdos;
        public AccountService()
        {
            _dbContext = new DatabaseContext();//Khởi tạo lớp đối tượng kết nối vào CSDL và có các phương thức làm việc với các bảng
            _lstAccountsAdos = new List<AccountsAdo>();
        }

        //Phương thức insert vào trong table
        public bool AddNewAccountDB(AccountsAdo accounts)
        {
            _dbContext.AccountsAdos.Add(accounts);
            _dbContext.SaveChanges();
            return true;
        }
        //Phước thức update trong table
        public bool UpdateAccountDB(AccountsAdo account)
        {
            _dbContext.AccountsAdos.Update(account);
            _dbContext.SaveChanges();
            return true;
        }
        //Phước thức delete trong table
        public bool DeleteAccountDB(Guid id)
        {
            //Tìm đối tượng trong bảng CSDL sau đó tiến hành xóa
            AccountsAdo acc = _dbContext.AccountsAdos.ToList().FirstOrDefault(c => c.Id == id);
            //Tiến hành xóa
            _dbContext.AccountsAdos.Remove(acc);
            _dbContext.SaveChanges();
            return true;
        }
        //Phương thức tìm kiếm gần đúng
        public List<AccountsAdo> GetListAccByStartwith(string acc)
        {
            List<AccountsAdo> temp = _dbContext.AccountsAdos.Where(c => c.Acc.StartsWith(acc)).ToList();
            return temp;
        }
        //Phương thức lấy data từ Table trong DB
        public void getListAccountFromDB()
        {
            _lstAccountsAdos = _dbContext.AccountsAdos.ToList();
        }
    }
}
