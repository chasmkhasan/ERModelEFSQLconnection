using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERModeling_SQL.Models
{
    public class Result
    {
        [Key]
        public int Id { get; set; }
        public int FkStudentId { get; set; }
        public int FkCourseListId { get; set; }
        public int FkAdministrationId { get; set; }
        public int FkGradeListId { get; set; }
        public DateTime ResultDate { get; set; }
        public virtual Administration Administrations { get; set; }
        public virtual Role Roles { get; set; }
        public virtual ClassList ClassLists { get; set; }
        public virtual CourseList CourseLists { get; set; }
        public virtual GradeList GradeLists { get; set; }
        public virtual Student Students { get; set; }
    }
}
