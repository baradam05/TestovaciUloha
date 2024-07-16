using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestovaciUloha.Model
{
    public class Part
    {
        [Browsable(false)]
        public int id { get; set; }
        [Browsable(false)]
        public int productId { get; set; }
        public string name { get; set; }
        public string? description { get; set; }
        public double price { get; set; }
        [Browsable(false)]
        public DateTime? createdAt { get; set; }
        [Browsable(false)]
        public DateTime? editedAt { get; set; }
    }
}
