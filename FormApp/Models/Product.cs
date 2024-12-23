using System.ComponentModel.DataAnnotations;

namespace FormApp.Models{


    public class Product{

        [Display(Name = "Ürün Id")]
        public int ProductId { get; set; }

        [Display(Name = "Ürün Adı")]
        public string Name { get; set; } = string.Empty;
        [Display(Name = "Ürün Fiyat")]
        public decimal Price { get; set; }
        [Display(Name = "Ürün Görseli")]
        public string Image { get; set; } = string.Empty;
        public bool IsActive { get; set; }
        [Display(Name = "Ürün Kategorisi")]
        public int CategoryId { get; set; }
    }
}