using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERModeling_SQL.Models
{
    public class ClassList
    {
        public int Id { get; set; }
        public string ClassName { get; set; }
        public List<Student> Students { get; set; }
    }
}
