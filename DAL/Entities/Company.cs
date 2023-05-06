using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Company
    {
        public int Id { get; set; }
        [Required]
        [RegularExpression(@".\d[§®™©ʬ@].")]
        public string Name { get; set; }

        public virtual ICollection<Contact> Contact { get; set; } = new List<Contact>();

    }
}
