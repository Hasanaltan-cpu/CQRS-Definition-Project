using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRS.DefinitionExampleProject.VMs
{
    public class ProductReadVM
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime? CreateDate { get; set; }
    }
}
