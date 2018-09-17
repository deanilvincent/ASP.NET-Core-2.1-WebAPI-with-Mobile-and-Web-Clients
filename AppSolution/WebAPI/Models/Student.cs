using System;
using System.ComponentModel.DataAnnotations;

namespace WebAPI.Models
{
    public class Student
    {
        [Key] public int StudentId { get; set; }

        public string Firstname { get; set; }

        public string Lastname { get; set; }

        public string Department { get; set; }

        public int Age { get; set; }

        public DateTime DateCreated { get; set; } = DateTime.Now;
    }
}
