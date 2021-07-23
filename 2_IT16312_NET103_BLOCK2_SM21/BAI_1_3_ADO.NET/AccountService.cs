using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BAI_1_3_ADO.NET;


namespace BAI_1_3_ADO.Services
{
    class AccountService
    {
        private List<Account> _lstAccounts;
        private SqlConnection _conn;
        private SqlCommand _cmd;
        private string _connStr;
        public AccountService(string connStr)
        {
            _connStr = connStr;
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
            int index = _lstAccounts.FindIndex(c => c.Id == account.Id);
            if (index == -1) return "không tìm thấy đối tượng";
            _lstAccounts[index] = account;
            return "Sửa thành công";
        }

        public string removeAccount(Guid id)
        {
           // if (id < 0) return "Xóa không thành công";
            _lstAccounts.RemoveAt(_lstAccounts.FindIndex(c=>c.Id == id));
            return "Xóa thành công";
        }

        public Account findAccount(Guid id)
        {
           // if (id < 0) return null;
            return _lstAccounts.Where(c => c.Id == id).FirstOrDefault();
        }

        public List<Account> getlstAccounts()
        {
            return _lstAccounts;
        }

        public List<Account> getlstAccountsByAcc(string acc)
        {
            return _lstAccounts.Where(c => c.Acc.StartsWith(acc)).ToList();
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
        //Phần triển khai kết nối DB
        public SqlConnection GetSqlConnection(string connStr)
        {
            return new SqlConnection(connStr);
        }

        public SqlCommand GetSqlCommand(string query,SqlConnection conn)
        {
            return new SqlCommand(query, conn);
        }
        //Lấy dữ liệu từ DB
        public List<Account> GetLstAccountsDB()
        {
            _lstAccounts = new List<Account>();
            _conn = GetSqlConnection(_connStr);
            _conn.Open();
            _cmd = GetSqlCommand("Select * from Accounts_ADO", _conn);
            var data = _cmd.ExecuteReader();//Thực thi câu truy vấn
            while (data.Read())
            {
                Account acc = new Account();
                acc.Id = new Guid(data["Id"].ToString());
                acc.Acc = data["Acc"].ToString();
                acc.Pass = data["Pass"].ToString();
                acc.Sex = Convert.ToInt32(data["Sex"].ToString());
                acc.YearofBirth = Convert.ToInt32(data["YearofBirth"].ToString());
                acc.Status = Convert.ToBoolean(data["Status"].ToString());
                _lstAccounts.Add(acc);
            }
            _conn.Close();
            return _lstAccounts;
        }
    }
}
