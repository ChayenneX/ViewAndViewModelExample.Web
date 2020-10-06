using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wba.Oefening.Students.Domain;

namespace ViewAndViewModelExample.Web.Models
{
    public class StudentVM
    {
        public Course course { get; set; }
        public Student student { get; set; }
        public IEnumerable<Course> courses { get; set; }
        public IEnumerable<Student> students { get; set; }
    }
}
