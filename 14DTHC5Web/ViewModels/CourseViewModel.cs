using _14DTHC5Web.Models;
using System.Collections.Generic;

namespace _14DTHC5Web.ViewModels
{
    public class CourseViewModel
    {
        public string Place { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public byte CategoryId { get; set; }
        public ICollection<Category> Categories { get; set; }

    }
}