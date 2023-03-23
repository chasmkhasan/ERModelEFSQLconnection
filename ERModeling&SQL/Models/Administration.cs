using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERModeling_SQL.Models
{
    public class Administration
    {
        
        public int Id { get; set; }
        public string AdministratorName { get; set; }
        public string Name { get; set; }

        public List<Result> Results { get; set; }
    }
}
