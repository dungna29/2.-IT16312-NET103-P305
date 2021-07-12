using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_1_2_CRUD_ACCOUNT.Models
{
    [Serializable]
    public class Account
    {
        public int Id { get; set; }
        public string Acc { get; set; }
        public string Pass { get; set; }
        public int Sex { get; set; }
        public int YearofBirth { get; set; }
        public bool Status { get; set; }
    }
}
