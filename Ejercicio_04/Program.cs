using System.Security.Cryptography.X509Certificates;

public class Program
{
    public static void Main(string[] args)
    {
             bool ejecutar = false;
             int top = 0;
             int left = 0;  
             for (int k = 0; ; )
             {
                DibujarCuadro();
                DibujarOpciones(k);
                ConsoleKeyInfo cki = Console.ReadKey(true);
                
                switch (cki.Key)
                {
                    case ConsoleKey.UpArrow: k--; break;
                    case ConsoleKey.DownArrow: k++; break;
                    case ConsoleKey.Enter: ejecutar = true; break;
                }

                if (k < 0) k = 4; 
                else if (k > 4) k = 0;

                if (ejecutar)
                {
                    ejecutar = false;
                    switch (k)
                    {
                        //JUEGO 1
                        case 0:
                            do
                            {
                                Juego1();
                                top = Console.GetCursorPosition().Top;
                                left = Console.GetCursorPosition().Left;      
                                
                            } while(Retorno(left, top));
                            Console.Clear();
                   
                            if(k == 4)
                            {
                                goto case 1;
                            }
                            break;

                        //JUEGO 2
                        case 1:
                            do
                            {
                                Juego2();
                                top = Console.GetCursorPosition().Top;
                                left = Console.GetCursorPosition().Left;
                            } while (Retorno(left, top));
                            Console.Clear();
                            if (k == 4)
                            {
                                goto case 2;
                            }
                            break;
                        
                        //JUEGO 3
                        case 2:
                            do
                            {
                                Juego3();
                                top = Console.GetCursorPosition().Top;
                                left = Console.GetCursorPosition().Left;
                            } while (Retorno(left, top));
                            Console.Clear();
                            break;
                        
                        //TODOS
                        case 3:
                            goto case 0;

                        //SALIR
                        case 4:
                            return;
                    }
                }
             }
    }

    //Juego 1
        public static void Juego1()
        {
            Console.Clear();
            Random rnd = new Random();
            int max = 6;
                        Console.WriteLine("Quieres modificar el número máximo?");
                        if ( Console.ReadLine().ToUpper().Equals("si".ToUpper()))
                        {
                            Console.WriteLine("Hasta que número quieres tirar");
                            max = int.Parse(Console.ReadLine());
                        }
                        Console.WriteLine("Elige un número del 1 al " + max);
                        int eleccion = int.Parse(Console.ReadLine());
                        int aciertos = 0;
                        for(int i = 0; i < 10; i++)
                        {
                            int random = rnd.Next(1, max + 1);
                            Console.WriteLine(random);
                            if(random == eleccion)
                            {
                                aciertos++;
                            }
                        }
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("El número de aciertos es: " + aciertos);
        }

        //Juego 2
        public static void Juego2()
        {
            Console.Clear();
            Random rnd = new Random();
            int aleatorio = rnd.Next(1,101);

                        for(int i = 5; i > 0 ; i--)
                        {
                            Console.WriteLine("Adivina el número:");
                            int respuesta = int.Parse(Console.ReadLine());
                            if(respuesta == aleatorio)
                            {
                                Console.WriteLine("Enhorabuena, has acetado");
                                i = 0;
                            }
                            else if(respuesta > aleatorio)
                            {
                                Console.WriteLine("El número es menor que el introducido");
                            }
                            else
                            {
                                Console.WriteLine("El número es mayor que el introducido");
                            }
                        }
        }

        //Juego 3 
        public static void Juego3()
        {
            Console.Clear();
            Console.WriteLine("+----------Estos son los valores de la quiniela: ----------+");
            Console.ForegroundColor = ConsoleColor.Gray;
            for(int i = 0; i < 14; i++)
            {

                if (Resultado() == 1)
                {
                    Console.Write("\t\t partido {0}: resultado ", i +1 );
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("  1  ");
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
                if (Resultado() == 2)
                {
                    Console.Write("\t\t partido {0}: resultado ", i +1 );
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("  2  ");
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
                if (Resultado() == 0)
                {
                    Console.Write("\t\t partido {0}: resultado ", i +1 );
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("  X  ");
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
        }
        }

        //Método para resultado juego 3
        public static int Resultado()
        {
            Random rnd = new Random();
            int num = rnd.Next(1, 101);
            switch (num)
            {
                case int when (num>0 && num <= 60): 
                    return 1 ; // Devuelve 1 
                case int when (num > 60 && num <=85): 
                    return 0; // Devuelve 0 (X)                              
                case int when (num > 85 && num <= 100):
                    return 2; // Devuelve 2 
            }
        return -1;
        }

        //Dibuja el cuadro

        public static void DibujarCuadro()
        {   
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(2,2);
            Console.WriteLine("+------------------------------------------------+"); //51 - 2
            for(int i = 1; i <= 10; i++)
            {
                Console.SetCursorPosition(2,2+i);
                Console.WriteLine("|");
                Console.SetCursorPosition(51,2+i);
                Console.WriteLine("|");
            }
            Console.SetCursorPosition(2,12);
            Console.WriteLine("+------------------------------------------------+");
        }

        //Dibuja las opcioness

        public static void DibujarOpciones(int k)
        { 
            ConsoleColor cc = ConsoleColor.White;
            ConsoleColor sel = ConsoleColor.Green;

            Console.SetCursorPosition(20,5);
            Console.ForegroundColor = k == 0 ? sel : cc;
            Console.WriteLine("Juego 1 ");
            Console.SetCursorPosition(20,6);
            Console.ForegroundColor = k == 1 ? sel : cc;
            Console.WriteLine("Juego 2");
            Console.SetCursorPosition(20,7);
            Console.ForegroundColor = k == 2 ? sel : cc;
            Console.WriteLine("Juego 3");
            Console.SetCursorPosition(20,8);
            Console.ForegroundColor = k == 3 ? sel : cc;
            Console.WriteLine("Todos");
            Console.SetCursorPosition(20,9);
            Console.ForegroundColor = k == 4 ? sel : cc;
            Console.WriteLine("Salir ");
        }

        //Dibuja las opciones despues de un juego 

        public static void DibujarRetorno(int n, int left, int top)
        {
            ConsoleColor cc = ConsoleColor.White;
            ConsoleColor sel = ConsoleColor.Green;

            Console.SetCursorPosition(left,top + 1);
            Console.ForegroundColor = n == 0 ? sel : cc;
            Console.WriteLine("Volver a Jugar");
            Console.SetCursorPosition(left + 50, top + 1);
            Console.ForegroundColor = n == 1 ? sel : cc;
            Console.WriteLine("Salir");
        }

        // Codigo para volver a jugar/salir

        public static bool Retorno( int left, int top)
        {
            
            bool ejecutar = false;
           
            for(int n = 0; ;) { 
                DibujarRetorno(n, left, top);
                ConsoleKeyInfo cki = Console.ReadKey(true);  
                switch (cki.Key)
                {
                       case ConsoleKey.LeftArrow: n--; break;
                       case ConsoleKey.RightArrow: n++; break;
                       case ConsoleKey.Enter: ejecutar = true; break;
                }
                if (n < 0) n = 1; 
                else if (n > 1) n = 0;

                if (ejecutar) { 
                    ejecutar = false;
                    switch (n)
                    {
                          case 0: return true;
                          case 1: return false;
                    }
                }
            }           
        }
}
