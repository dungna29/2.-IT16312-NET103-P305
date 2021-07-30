using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BAI_1_1_EFCORE_CODEFIRST.Models;
using Microsoft.EntityFrameworkCore;

namespace BAI_1_1_EFCORE_CODEFIRST.DBContext
{
    class DBContextDungna:DbContext
    {

        //1. Kế thừa 1 cái phương thức OnConfiguring của lớp cha
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //Khi cấu hình đổi tên DATABASE mà các bạn muốn nó tạo ra
                optionsBuilder.UseSqlServer("Data Source=DUNGNA_PC2021\\SQLEXPRESS;Initial Catalog=IT16312_EFCODEFIRST;Persist Security Info=True;User ID=dungna29;Password=123");
            }
        }
        //2. Tiến hành tạo bảng
        public DbSet<Account> Accounts { get; set; }
    }
}
