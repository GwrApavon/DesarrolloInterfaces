using EjercicioFecha;

public class Program
{
    public static void Main(string[] args)
    {
        Fecha f1 = Fecha.CrearFecha();

        Console.Write("la fecha siguiente a " + f1.ToString() +
        " es: " + f1.DiaSiguiente().ToString() +'\n');
        Fecha f2 = Fecha.CrearFecha();

        if (f1.EsAnterior(f2))
        {
            Console.Write("la fecha " + f1.ToString()
            + " es menor que " + f2.ToString());
        }

        else
        {
            Console.Write("la fecha " + f1.ToString()
            + " es mayor o igual que " + f2.ToString());
        }
    }
}

