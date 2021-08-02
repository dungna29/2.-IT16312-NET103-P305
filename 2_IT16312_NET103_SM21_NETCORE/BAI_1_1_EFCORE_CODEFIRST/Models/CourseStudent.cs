using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_1_1_EFCORE_CODEFIRST.Models
{
    [Table("CourseStudent")]//Đặt tên bảng
    public class CourseStudent
    {
        [Key, Column(Order = 0)]
        public Guid Id { get; set; }
        public Guid IdCourse { get; set; }
        [ForeignKey("IdStudent"), Column(Order = 0)]
        public Student Students { get; set; }
        [ForeignKey("IdCourse"), Column(Order = 1)]
        public Course Courses { get; set; }
        public string Note { get; set; }

    }
}
