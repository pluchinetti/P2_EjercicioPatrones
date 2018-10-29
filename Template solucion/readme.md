# Ejercicios de DIP, ISP, SRP
## Ejercicio 1 

**DIP:** No, no se cumple ya que existe una dependecia entre la clase AnlizadorDatos y BaseDeDatos. Para evitar esto se sugiere la creación de una interfaz que indique el método ListarDatos, y que BaseDeDatos la implemente (ver solución).

**ISP:** Sí, se cumple ya que no exiten dependencias entre objetos con más responsabilidades de las que se necesitan.

**SRP:** Sí, se cumple en las 3 clases ya que estas poseen responsabilidades únicas y no existen más de 1 razon para cambiar cada una de ellas.


## Ejercicio 2

```cs
//Insertar el código corregido

```
## Ejercicio 3 

```cs
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

```