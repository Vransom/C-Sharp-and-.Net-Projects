using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalChallengeSubmission
{
    class DbContext
    {
        public class Student
        {
            public int StudentID { get; set; }
            public string StudentName { get; set; }
            public string EmailAddress { get; set; }
            public Grade Grade { get; set; }
        }

        public class Grade
        {
            public int GradeId { get; set; }
            public string GradeName { get; set; }
            public string Section { get; set; }

            public ICollection<Student> Students { get; set; }
        }
    }
}
