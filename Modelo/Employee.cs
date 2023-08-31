using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Employee
    {
        private int _idNumber;
        private string _firstname;
        private string _lastname;

        //public properties






        [Display(Name = "ID Number", Description = "INGRESE UN NUMERO ")]
        [Required(ErrorMessage = "Tiene que ingresar un numero valido")]
        public string Firstname
        {
            get { return _firstname; }
            set
            {

                Validator.ValidateProperty(value, new ValidationContext(this, null, null) { MemberName = "First Name" });

                _firstname = value;
            }


        }
        [Display(Name = "ID Number", Description = "INGRESE UN NUMERO ")]
        [Required(ErrorMessage = "Tiene que ingresar un numero valido")]
        public string LastName
        {
            get { return LastName; }

            set
            {
                Validator.ValidateProperty(value, new ValidationContext(this, null, null) { MemberName = "Last name" +
                    "" });


                LastName = value;
            }

        }



            [Display(Name = "ID Number", Description = "INGRESE UN NUMERO ")]
        [Required(ErrorMessage = "Tiene que ingresar un numero valido")]
        public string IDNumber
        {
            get { return IDNumber; }

            set
            {
                Validator.ValidateProperty(value, new ValidationContext(this, null, null) { MemberName = "ID Number" });


                IDNumber = value;
            }

        }
    }
}
