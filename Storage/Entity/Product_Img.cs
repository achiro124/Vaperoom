using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Vaperoom.Storage.Entity
{
    public class Product_Img
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ImgId { get; set; }
        public int ProductId { get; set; }
        [Required]
        public string ImagesUrl { get; set; }
        public Product Product { get; set; }

    }
}
