using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CQRS.DefinitionExampleProject.Models
{
    public class Product
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }


        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }
        public DateTime? CreateDate { get; set; }
    }
}
