using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkTest.Data
{
    class Group
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public ICollection<Student> Students { get; set; }
    }
}
