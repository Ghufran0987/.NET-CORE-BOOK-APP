using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Model
{
    public class Author
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        [Required]
        [MaxLength(100, ErrorMessage = "Max Character 100")]
        public string firstName { get; set; }
        [Required]
        [MaxLength(200, ErrorMessage = "Max Character 200")]
        public string lastName { get; set; }
        public virtual Country country { get; set; }
        public virtual ICollection<BookAuthor> BookAuthors { get; set; }

    }
}
