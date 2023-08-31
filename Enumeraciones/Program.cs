int estatusOprecion = 5;
// Practicando enumeraciones para mejorar el entendimeinto de un codigo

if (estatusOprecion ==(int) EstatusOperacion.Exitoso)
{
    //7
} else if (estatusOprecion == (int) EstatusOperacion.ClienteNoEncontrado)
{

} else if (estatusOprecion == (int ) EstatusOperacion.ErrordeSistema)
{

}

//Enumeraciones
public enum EstatusOperacion
{
    Exitoso = 1,
    ClienteNoEncontrado = 2,
    ErrordeSistema = 5,
}
