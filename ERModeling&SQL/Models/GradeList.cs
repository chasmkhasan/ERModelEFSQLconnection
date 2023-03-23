using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERModeling_SQL.Models
{
    public class GradeList
    {
        public int Id { get; set; }
        public string GradeName { get; set; }
        public string GradeDescription { get; set;}
        public List<Result> Results { get; set; }
    }
}
