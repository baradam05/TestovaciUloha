using Org.BouncyCastle.Cms;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestovaciUloha.Model
{
    public class Product
    {
        public int? id {  get; set; }
        public string name { get; set; }
        public string? description { get; set; }        
        public double price { get; set; }
        public string? note { get; set; }
        public DateTime? createdAt { get; set; }
        public DateTime? editedAt { get; set; }

        public Product()
        {
            
        }

        public Product(ProductDto product)
        {
            this.id = product.id;
            this.name = product.name;
            this.description = product.description;
            this.price = product.price;
            this.note = product.note;
        }
    }
}
