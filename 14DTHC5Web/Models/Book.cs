using System.ComponentModel.DataAnnotations;

namespace _14DTHC5Web.Models
{
    public class Book
    {
        public int BookId { get; set; }
        [Required(ErrorMessage = "Tieu de khong duoc trong")]
        [StringLength(200, ErrorMessage = "khong qua 200 ky tu")]

        public string Title { get; set; }
        [Required(ErrorMessage = "tac gia khong duoc trong")]
        public string Author { get; set; }
        public int Year { get; set; }
        public string Cover { get; set; }
    }
}