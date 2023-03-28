using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERModeling_SQL.Models
{
    public class Role
    {
        public int Id { get; set; }
        public string Principal { get; set; }
        public string PublicAffairs { get; set; }
        public string FinanceAccounts { get; set; }
        public string Teacher { get; set; }
        public List<Administration> Administrations { get; set; }


    }
}
