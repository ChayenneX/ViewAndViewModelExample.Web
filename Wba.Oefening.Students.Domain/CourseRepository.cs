using System;
using System.Collections.Generic;
using System.Text;

namespace Wba.Oefening.Students.Domain
{
   public class CourseRepository
    {
        public IEnumerable<Course> GetCourses()
        {
            return new List<Course>
            {
                new Course{ Id = 0, Name = "GameDeveloper"},
                new Course{ Id = 1, Name = "AppDeveloper"}
            };
        }
    }
}
