using System.Security.Cryptography.X509Certificates;

public class Program
{
    public static void Main(string[] args)
    {
        if (ImprimirMenuInicio())
        {   
            int x=51,y=7;
            Random rnd = new Random();
            x = rnd.Next(51,70);
            y = rnd.Next(7,15);
            Console.ReadLine();
            ImprimirTablero();
            MoverFlechas(x,y);
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
        Console.WriteLine("Iniciar");

        Console.ForegroundColor = ConsoleColor.White;
        Console.SetCursorPosition(4,5);
        Console.WriteLine("Pulse intro para continuar");

     
        for(int k = 0; ;)
        {
            ConsoleKeyInfo cki = Console.ReadKey(true);
            if (cki.Key == ConsoleKey.Enter)
            {
                return true;
            }
            else
            {
                k++;
                Console.SetCursorPosition(4,10);
                Console.WriteLine("Número de veces que no sabes presionar una tecla:" + k);
            }
        }
    }

    // IMPRIME EL TABLERO DE JUEGO
    public static void ImprimirTablero()
    {
        Console.Clear();
        Console.SetCursorPosition(50,6);
        Console.WriteLine("+--------------------+");
         for(int i = 1; i <= 10; i++)
         {
                Console.SetCursorPosition(50,6+i);
                Console.WriteLine("|");
                Console.SetCursorPosition(71,6+i);
                Console.WriteLine("|");
         }
         Console.SetCursorPosition(50,16);
         Console.WriteLine("+--------------------+");

    }

    // CONTROLES JUEGO
    public static void MoverFlechas(int bx, int by)
    {
        bool ejecutar = false;
        int y = 7;
        for(int x= 51; ; )
        {
           Console.SetCursorPosition(x,y);
           
           ConsoleKeyInfo cki = Console.ReadKey(true);
                
           switch (cki.Key)
           {
                case ConsoleKey.UpArrow: y--; break;
                case ConsoleKey.DownArrow: y++; break;
                case ConsoleKey.RightArrow: x++; break;
                case ConsoleKey.LeftArrow: x--; break;
                case ConsoleKey.Enter: ejecutar = true; break;
           }

            if (x < 51) x = 70; 
            else if (x > 70) x = 51;

            if (y < 7) y = 15; 
            else if (y > 15) y = 7;

            if(ejecutar)
            {
                ejecutar = false;
                if (x == bx && y == by)
                {
                    Console.BackgroundColor= ConsoleColor.Black;    
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("o");

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.SetCursorPosition(55,18);
                    Console.WriteLine("HAS GANADO!");
                    Console.ReadLine();
                    return;
                    
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Black;    
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("X");
                }

                Console.SetCursorPosition(x,y);
            }
           
        }
    }

}