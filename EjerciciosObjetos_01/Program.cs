
using EjerciciosObjetos_01;
using System.Net;

public class main
{
    static void Main(string[] args)
    {
        Directivo dir = new Directivo("Informatica", 15, "Juan", "Ocabo Castañeda", 24, "12312312", 1500.00, "987521349");
        Empleado emp = new Empleado("Jose", "Perez Serrano", 41, "142783341", 1000.00, "987161349");
        EmpleadoEspecial empe = new EmpleadoEspecial("Tomás", "Palomares Carnicero", 19, "96241398", 1400.00,"");

        bool salir = false;
        do
        {
            Console.Write("Indique que quiere visualizar:" +
                            "\n(1) - Datos del directivo" +
                            "\n(2) - Datos del empleado" +
                            "\n(3) - Datos del empleado especial\n");
            int opt = int.Parse(Console.ReadLine());
            Console.Clear();
            switch (opt)
            {
                case 1:
                    Console.Write(dir.ToString(dineroEmpresa()));
                    Console.Write("\nHacienda: " + dir.hacienda());
                    break;
                case 2:
                    Console.Write(emp.ToString());
                    Console.Write("\nHacienda: " + emp.hacienda());
                    break;
                case 3:
                    Console.Write(empe.ToString(dineroEmpresa()));
                    Console.Write("\nHacienda: " + empe.hacienda());
                    break;
                default:
                    Console.WriteLine("Opción no valida");
                    break;
            }

            Console.Write("\nQuieres salir? s/n");
            string salida = Console.ReadLine();
            if(salida == "s" || salida == "S")
            {
                salir = true;
            }
        } while (!salir);
    }

    public static double dineroEmpresa()
    {
        double dinero = 0;
        Console.WriteLine("Cuanto dinero gana la empresa:");
        dinero = double.Parse(Console.ReadLine());
        return dinero;
    }
}



