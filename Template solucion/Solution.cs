//Objeto que representa un dato de la base de datos.
class DataBaseObject
{
    public string Descripcion { get; }
}

public interface IDB
{
    DataBaseObject[] ListarDatos()
    {
        //Devuelve un DataBaseObject[] con todos los datos almacenados en la base
    }
}

//Base de datos.
class BaseDeDatos : IDB
{
    public DataBaseObject ObtenerDato(string clave)
    {
        //Devuelve el dato correspondiente a la clave
    }
    public void GrabarDato(string clave, DataBaseObject dato)
    {
        //Graba el dato en la base de datos, bajo la clave dada
    }
    public String[] ListarClaves()
    {
        //Devuelve un String[] con todas las claves
    }
    public String[] ListarDescripcionDatos()
    {
        //Devuelve un String[] con la descripción de todas los 
        //datos almacenados en la base
    }

}
class AnlizadorDatos
{
    private IDB baseDatos{get; set;};
    public void Analizar()
    {
        foreach (DataBaseObject DBObj in baseDatos.ListarDatos())
        {
            DBCondition dbCondition = new DBCondition;

            if (dbCondition.CumpleCondicion1(DBObj))
            {
                MensajeUno();
            }
            else if (dbCondition.CumpleCondicion2(DBObj))
            {
                MensajeDos();
            }
            // .
            // .
            // .
            else if (dbCondition.CumpleCondicionN(DBObj))
            {
                MensajeN();
            }
        }
    }
}

// Clase cuya responsabilidad es comprobar si se cumplen ciertas condiciones.
class DBCondition
{
    public void CumpleCondicion1(DataBaseObject DBobj)
    {
        //Devuelve true si se cumple una cierta condición
    }
    public void CumpleCondicion2(DataBaseObject DBobj)
    {
        //Devuelve true si se cumple una cierta condición
    }
    // .
    // .
    // .
    public void CumpleCondicion2(DataBaseObject DBobj)
    {
        //Devuelve true si se cumple una cierta condición
    }

}

// Clase cuya responsabilidad es la emisión de mensajes.
class Messenger
{
    public void MensajeUno()
    { /*Mensaje predeterminado*/ }
    public void MensajeDos()
    { /*Mensaje predeterminado*/ }
    // .
    // .
    // .
    public void MensajeN()
    { /*Mensaje predeterminado*/ }

}