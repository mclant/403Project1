﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using _403Project1.Models;

namespace _403Project1.DAL
{
    public class LearningDynamicsContext : DbContext
    {
<<<<<<< HEAD
        public LearningDynamicsContext() : base("LearningDynamicsContext")
        {

        }
        
        public DbSet<Parent> Parents { get; set; }
        public DbSet<School> Schools { get; set; }
        public DbSet<SchoolQuestion> SchoolQuestions { get; set; }
        public DbSet<Student> Students { get; set; }
=======
        public LearningDynamicsContext() :
            base("LearningDynamicsContext")
        {

        }

        public DbSet<Parent> Parent { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<SchoolQuestion> SchoolQuestions { get; set; }
        public DbSet<School> School { get; set; }
>>>>>>> 4344ae47aaf0ba394516781dfbeb26f18133e942
    }
}