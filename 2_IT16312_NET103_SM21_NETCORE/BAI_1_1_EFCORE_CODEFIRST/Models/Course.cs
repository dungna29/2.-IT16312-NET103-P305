using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_1_1_EFCORE_CODEFIRST.Models
{
    [Table("Courses")]//Đặt tên bảng
    public class Course
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string CourseName { get; set; }
        
    }
}
