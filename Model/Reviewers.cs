using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Model
{
    public class Reviewers
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int Id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public virtual ICollection<Review> reviews { get; set; }
    }
}
