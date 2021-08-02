using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_1_1_EFCORE_CODEFIRST.Models
{
    [Table("Roles")]//Đặt tên bảng
    public class Role
    {
        [Key]
        public Guid Id { get; set; }
        [StringLength(29)]
        public string Code { get; set; }
        [StringLength(29)]
        public string Name { get; set; }
        public bool? Status { get; set; }
    }
}
