using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERModeling_SQL.Models
{
    public class CourseList
    {
        public int Id { get; set; }
        public string CourseName { get; set; }
        public int Points { get; set; }
        public string Duration { get; set; }
        public List<Result> Results { get; set; }
    }
}
