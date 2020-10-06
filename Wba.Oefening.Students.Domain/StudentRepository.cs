using System;
using System.Collections.Generic;
using System.Text;

namespace Wba.Oefening.Students.Domain
{
   public class StudentRepository
    {
        public IEnumerable<Student> GetStudents()
        {
            return new List<Student>
            {
                new Student{ Id = 0, Lastname = "Debouwer", Firstname = "Bob", Course = "Bouwvakker"},
                new Student{ Id = 1, Lastname = "Frey", Firstname = "Irma", Course = "Kuisvrouw"},
                new Student{ Id = 2, Lastname = "Deman", Firstname = "Evert", Course = "Accountant"}
            };
        }
    }
}
