using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _2080600047.Models.ViewModels
{
    public class CoursesViewModel
    {
        public IEnumerable<Course> UpcommingCourses { get; set; }
        public bool ShowAction { get; set; }
    }

}