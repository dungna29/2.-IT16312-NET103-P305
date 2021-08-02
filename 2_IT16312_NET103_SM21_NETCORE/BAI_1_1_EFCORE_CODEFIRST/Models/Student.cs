using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_1_1_EFCORE_CODEFIRST.Models
{
    [Table("Students")]//Đặt tên bảng
    public class Student
    {
        [Key]
        public Guid Id { get; set; }
        [StringLength(30)]
        public string Acc { get; set; }
        public string Name { get; set; }
       
    }
}
