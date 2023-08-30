using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Customer
    {
        //Agregar "Required"- System.ComponentModel.DataAnnotations;

        [Required(ErrorMessage = "Nombre obligatorio")]
        // que muestre de cuanto son los caracteres
        [StringLength(20)]
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,20}$",
        ErrorMessage = "Characters are not allowed.")]
        public string Name { get; set; }

       

    }
}
