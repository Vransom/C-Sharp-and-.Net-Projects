﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using static FinalChallengeSubmission.DbContext;

namespace FinalChallengeSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var ctx = new SchoolContext())
            {
                var stud = new Student() { StudentName = "Victoria" };

                ctx.Students.Add(stud);

                ctx.SaveChanges();
            }
        }
    }

}
