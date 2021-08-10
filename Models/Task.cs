using System;
using ASP.NET_Project.Controllers;
using System.Collections.Generic;
using System.Linq;

namespace ASP.NET_Project.Models
{
    public class Task
    {
        public enum PriorityLevel { Immediate, Routine, Convenient };
        public enum Category { Work, Personal };

        private PriorityLevel priority;
        private Category category;

        public string TaskName { get; set; }
        public DateTime DueDate { get; set; }
        public PriorityLevel Priority
        {
            get { return priority; }
            set { priority = value; }
        }
        public Category _Category
        {
            get { return category; }
            set { category = value; }
        }

    }
}
