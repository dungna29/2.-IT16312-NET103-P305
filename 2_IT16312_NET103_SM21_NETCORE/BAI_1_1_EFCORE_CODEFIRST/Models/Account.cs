using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_1_1_EFCORE_CODEFIRST.Models
{
    [Table("Accounts")]//Đặt tên bảng
    public class Account
    {
        [Key]
        public int Id { get; set; }
        [StringLength(30)]
        public string Acc { get; set; }
        [StringLength(30)]
        public string Pass { get; set; }
    }
}
