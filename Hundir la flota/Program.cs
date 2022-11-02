using Hundir_la_flota;
using System.Collections;
public class Program
{
    public static ArrayList coords = new ArrayList();
    public static void Main(string[] args)
    {
        
        if (ImprimirMenuInicio())
        {
            Random rnd = new Random();
            int x = 51, y = 7;
            int xb = 10, yb = 10;

            ImprimirTablero();

            colocarBarco();

            xb = Console.GetCursorPosition().Left;
            yb = Console.GetCursorPosition().Top;
         
            do
            {
                x = rnd.Next(51, 60);
            } while (x == xb);

            do
            {
                y = rnd.Next(7, 15);
            } while (y == yb);

            MoverFlechas(x, y, xb, yb);
            
        }
    }

    // IMPRIME EL MENU DE INICIO
    public static bool ImprimirMenuInicio()
    {
        Console.ForegroundColor = ConsoleColor.White;
        Console.SetCursorPosition(4, 0);
        Console.WriteLine("Bienvenido a hundir la flota");
        Console.SetCursorPosition(4, 2);
        Console.WriteLine("Para jugar use los controles: →↑←↓");

        Console.ForegroundColor = ConsoleColor.Green;
        Console.SetCursorPosition(4, 4);
        Console.WriteLine("Iniciar ");

        Console.ForegroundColor = ConsoleColor.White;
        Console.SetCursorPosition(4, 5);
        Console.WriteLine("Pulse intro para continuar");


        for (int k = 0; ;)
        {
            ConsoleKeyInfo cki = Console.ReadKey(true);
            if (cki.Key == ConsoleKey.Enter)
            {
                return true;
            }
            else
            {
                k++;
                Console.SetCursorPosition(4, 10);
                Console.WriteLine("Número de veces que no sabes presionar una tecla:" + k);
            }
        }
    }

    // IMPRIME EL TABLERO DE JUEGO
    public static void ImprimirTablero()
    {
        Console.Clear();
        Console.SetCursorPosition(50, 6);
        Console.WriteLine("+----------+");
        
        for (int i = 1; i <= 10; i++)
        {
             Console.SetCursorPosition(50, 6 + i);
             Console.WriteLine("|");
             Console.SetCursorPosition(61, 6 + i);
             Console.WriteLine("|");
        }
           
        
        Console.SetCursorPosition(50, 16);
        Console.WriteLine("+----------+");

    }
    //COLOCAR BARCO
    public static void colocarBarco()
    {
        bool ejecutar = false;
        int y = 7;
        for (int x = 51; ;)
        {
            Console.SetCursorPosition(x, y);

            ConsoleKeyInfo cki = Console.ReadKey(true);

            switch (cki.Key)
            {
                case ConsoleKey.UpArrow: y--; break;
                case ConsoleKey.DownArrow: y++; break;
                case ConsoleKey.RightArrow: x+=2; break;
                case ConsoleKey.LeftArrow: x-=2; break;
                case ConsoleKey.Enter: ejecutar = true; break;
            }

            if (x < 51) x = 60;
            else if (x > 60) x = 51;

            if (y < 7) y = 15;
            else if (y > 15) y = 7;

            if (ejecutar)
            {
                ejecutar = false;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("X");
                Console.SetCursorPosition(x, y);
                return;
            }
        }
    }

    // CONTROLES JUEGO
    public static void MoverFlechas(int bx, int by, int xb, int yb)
    {
        bool ejecutar = false;
        int y = 7;
        for (int x = 51; ;)
        {
            Console.SetCursorPosition(x, y);

            ConsoleKeyInfo cki = Console.ReadKey(true);

            switch (cki.Key)
            {
                case ConsoleKey.UpArrow: y--; break;
                case ConsoleKey.DownArrow: y++; break;
                case ConsoleKey.RightArrow: x++; break;
                case ConsoleKey.LeftArrow: x--; break;
                case ConsoleKey.Enter: ejecutar = true; break;
            }

            if (x < 51) x = 60;
            else if (x > 60) x = 51;

            if (y < 7) y = 15;
            else if (y > 15) y = 7;

            if (ejecutar)
            {
                ejecutar = false;
                if (x == bx && y == by)
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("o");

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.SetCursorPosition(51, 18);
                    Console.WriteLine("HAS GANADO!");
                    Console.ReadLine();
                    return;

                }
                else
                {
                   // if (x != xb && y != yb)
                    //{
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("X");
                    //}
                }

                if(movimientoConsola(xb, yb))
                {
                    Console.ReadLine();
                    return;
                }

                Console.SetCursorPosition(x, y);
            }

        }
    }

    public static bool movimientoConsola(int xb, int yb)
    {
        Coordenadas coordenadas; 
        Random random = new Random();
        int xc = 0, yc = 0;
        
        xc = random.Next(51, 60);
        yc = random.Next(7, 15);
        foreach (Coordenadas c in coords)
        {                 
            int coordX = c.coord_x;
            int coordY = c.coord_y;

            if (coordX == xc && coordY == yc)
            {
                do
                {
                    xc = random.Next(51, 60);
                } while (xc == coordX);
                do
                {
                    yc = random.Next(7, 15);
                }while(yc == coordY);
            }
        }
 
        coordenadas = new Coordenadas(xc, yc);
        coords.Add(coordenadas);
        if (xc == xb && yc == yb)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(xc, yc);
            Console.WriteLine("o");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(51, 18);
            Console.WriteLine("HAS PERDIDO!");
            return true;
        }
        else
        {
            // if (x != xb && y != yb)
            //{
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.SetCursorPosition(xc, yc);
            Console.WriteLine("X");
            //}
            return false;
        }
        
    }

}