// Paso 1 crear un objeto

using System.ComponentModel.DataAnnotations;

Modelo.Customer cliente = new();

cliente.Name = "ANGEL RENE DE LOS SANTOS FILTORIA GUZMAN ROCHA";

//Paso 2 "Agregar" -System.ComponentModel.DataAnnotations;

var context = new ValidationContext(cliente, null , null);


//PASO 3 crear el bool que me muestre que  si cliente esta validado, crear una coleccion del array list que
// igualmente me muestre si esta validado o no

var result = new List<ValidationResult>();

// bool que muestra si esta validado o no
bool isValid = Validator.TryValidateObject(cliente, context, result, true);

Console.WriteLine(isValid);

foreach (var validationResult in result)
{
    Console.WriteLine(validationResult.ErrorMessage);
}
