using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StudentAttendanceWebApp.Models
{
    public class Lesson
    {
        [Key]
        public int lessonNum { get; set; }
        public string lessonDate { get; set; }
        public string studentsAttendance { get; set; }  
    }
}