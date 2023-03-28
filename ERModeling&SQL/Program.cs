using ERModeling_SQL.Data;

namespace ERModeling_SQL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var context = new PersonDbContext())
            {
                var students = context.Students;
                foreach (var items in students)
                {
                    Console.WriteLine(items.ID + ", " + items.FirstName + ", " + items.LastName + ", " + items.Email + ", " + items.PersonalNumber + ", " + items.Phone);
                }
            }

            //using (var context = new PersonDbContext())
            //{
            //    var courseList = context.CourseLists;
            //    foreach (var items in courseList)
            //    {
            //        Console.WriteLine(items.CourseName + ", " + items.Duration + ", " + items.Points);
            //    }
            //}

            //using (var context = new PersonDbContext())
            //{
            //    var result = context.Results;
            //    foreach (var items in result)
            //    {
            //        Console.WriteLine(items.FkCourseListId + ", " + items.FkAdministrationId + ", " + items.FkClassListId);
            //    }
            //}

            //using (var context = new PersonDbContext())
            //{
            //    var lastPerson = context.Students.OrderByDescending(x => x.PersonalNumber)
            //                                       .Last(x => x.PersonalNumber == 29);

            //    Console.WriteLine(lastPerson.FirstName);

            //    lastPerson = context.Students.OrderByDescending(x => x.PersonalNumber)
            //                                .LastOrDefault(x => x.PersonalNumber == 29);

            //    if (lastPerson != null)
            //    {
            //        Console.WriteLine(lastPerson.FirstName);
            //    }
            //    else
            //    {
            //        Console.WriteLine("No Data");
            //    }
            //}

        }
    }
}