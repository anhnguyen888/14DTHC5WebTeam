using System.Collections.Generic;

namespace _14DTHC5Web.Models
{
    public class Category
    {
        public byte Id { get; set; }
        public string Name { get; set; }

        public ICollection<Course> Courses { get; set; }

    }
}