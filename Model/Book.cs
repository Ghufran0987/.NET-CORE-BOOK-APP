using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Model
{
    public class Book
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        [Required]

        [StringLength(10, MinimumLength = 3, ErrorMessage = "ISBN must be between 3 and 10 characters")]
        public string isbn { get; set; }
        [Required]
        [MaxLength(200, ErrorMessage = "Title cannot be more than 200 characters")]
        public string title { get; set; }
        public DateTime? DatePublished { get; set; }
        public virtual ICollection<Review> reviews { get; set; }
        public virtual ICollection<BookAuthor> BookAuthors { get; set; }
        public virtual ICollection<BookCategory> BookCategories { get; set; }


    }
}
