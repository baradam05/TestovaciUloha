using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestovaciUloha.Model
{
    public class ProductDto
    {
        [Browsable(false)]
        public int? id { get; set; }
        public string name { get; set; }
        public string? description { get; set; }
        public double price { get; set; }
        public string? note { get; set; }
        public int Parts {  get; set; }
        [Browsable(false)]
        public DateTime? createdAt { get; set; }
        [Browsable(false)]
        public DateTime? editedAt { get; set; }

        public ProductDto(Product product)
        {
            this.id = product.id;
            this.name = product.name;
            this.description = product.description;
            this.price = product.price;
            this.note = product.note;
            this.createdAt = product.createdAt;
            this.editedAt = product.editedAt;
        }

        public ProductDto()
        {
            
        }
    }
}
