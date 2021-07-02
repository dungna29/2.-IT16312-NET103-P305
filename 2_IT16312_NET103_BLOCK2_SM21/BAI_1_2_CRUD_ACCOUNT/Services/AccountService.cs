using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BAI_1_2_CRUD_ACCOUNT.IServices;
using BAI_1_2_CRUD_ACCOUNT.Models;

namespace BAI_1_2_CRUD_ACCOUNT.Services
{
    class AccountService:IAccountService
    {
        private List<Account> _lstAccounts;
        public AccountService()
        {
            _lstAccounts = new List<Account>();
        }
        public string addAccount(Account account)
        {
            if (account == null) return "Không được null";
            _lstAccounts.Add(account);
            return "Thêm thành công";
        }

        public string editAccount(Account account)
        {
            throw new NotImplementedException();
        }

        public string removeAccount(int id)
        {
            if (id < 0) return "Xóa không thành công";
            _lstAccounts.RemoveAt(_lstAccounts.FindIndex(c=>c.Id == id));
            return "Xóa thành công";
        }

        public Account findAccount(int id)
        {
            if (id < 0) return null;
            return _lstAccounts.Where(c => c.Id == id).FirstOrDefault();
        }

        public List<Account> getlstAccounts()
        {
            return _lstAccounts;
        }

        public List<Account> getlstAccountsByAcc(string acc)
        {
            throw new NotImplementedException();
        }

        public void fillDataFromFileToService(List<Account> lstAccounts)
        {
            _lstAccounts = lstAccounts;
        }

        public string[] getYearOfBirths()
        {
            string[] tempNs = new string[2021 - 1900];
            int temp = 1900;
            for (int i = 0; i < tempNs.Length; i++)
            {
                tempNs[i] = temp.ToString();
                temp++;
            }

            return tempNs;
        }
    }
}
