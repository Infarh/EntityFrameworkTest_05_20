using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
//using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkTest.Data
{
    class Student
    {
        //[Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string SurName { get; set; }

        public string Patronymic { get; set; }

        public DateTime Birthday { get; set; }

        //[ForeignKey(nameof(GroupId))]
        public Group Group { get; set; }

        //public int GroupId { get; set; }

        public ICollection<Course> Courses { get; set; }
    }
}
