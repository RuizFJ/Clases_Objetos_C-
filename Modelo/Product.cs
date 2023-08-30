using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    internal class Product
    {
        //Validando campos


        [Required]
        [StringLength(20)]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }

        [RegularExpression(@"^\$?\d+(\.(\d{2}))?$")]
        public string price { get; set; }
    }
}
