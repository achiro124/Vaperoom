using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Vaperoom.Storage.Entity
{
    public class Basket
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BasketId { get; set; }
        [NotMapped]
        public List<int> NumProduct { get; set; } = new List<int>();
        public List<User> Users { get; set; } = new List<User>();
        public List<Product> Products { get; set; } = new List<Product>();

    }
}
