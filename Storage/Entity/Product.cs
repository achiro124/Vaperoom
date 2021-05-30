using NewKinoHub.Storage.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Vaperoom.Storage.Entity
{
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Img { get; set; }
        [Required]
        public int Value { get; set; }
        public double Score { get; set; }
        public int NumberScore { get; set; }
        [Required]
        public string Description { get; set; }
        public string Characteristics { get; set; }
        public string Equipment { get; set; }
        public List<Review> Reviews { get; set; } = new List<Review>();
        public Category Category { get; set; }
        public TypeProduct ProductType { get; set; }

        public List<Product_Img> Imgs { get; set; }

    }
    public enum TypeProduct
    {
        GeekVape,
        SMOK,
        Logic_Compact,
        Солевые_жидкости,
        Щелочные_жидкости,
        Мехмоды,
        Аккамуляторы,
        Готовые_койлы
    }
}
