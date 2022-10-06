using System.Security.Cryptography.X509Certificates;

public class Program
{
    public static void Main(string[] args)
    {
        Boolean salir = false;
        do
        {
            Console.WriteLine("1. Juego 1 ");
            Console.WriteLine("2. Juego 2");
            Console.WriteLine("3. Juego 3");
            Console.WriteLine("4. Todos");
            Console.WriteLine("0. Salir ");
            int op = int.Parse(Console.ReadLine());
            switch (op)
            {
                case 1:
                    Boolean salir1 = true;
                    do
                    {
                        Juego1();

                        Console.WriteLine("Quiere volver a jugar? Si/No");
                        if ( Console.ReadLine().ToUpper().Equals("no".ToUpper()))
                        {
                            salir1 = false;
                        }

                    } while(salir1);
                   
                    if(op == 4)
                    {
                        goto case 2;
                    }
                    break;
              
                case 2:
                    Boolean salir2 = true;
                    do
                    {
                        Juego2();

                        Console.WriteLine("Quiere volver a jugar? Si/No");
                        if (Console.ReadLine().ToUpper().Equals("no".ToUpper()))
                        {
                            salir2 = false;
                        }

                    } while (salir2);
                   
                    if (op == 4)
                    {
                        goto case 3;
                    }
                    break;
               
                case 3:
                    Boolean salir3 = true;
                    do
                    {
                        Juego3();

                        Console.WriteLine("Quiere volver a jugar? Si/No");
                        if (Console.ReadLine().ToUpper().Equals("no".ToUpper()))
                        {
                            salir3 = false;
                        }

                    } while (salir3);
                    break;
                
                case 4:
                    goto case 1;
                
                case 0:
                    salir = true;
                    break;
            }
        } while (!salir);
        
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
            Console.WriteLine("+------------------------------------------------+");
            Console.WriteLine("+------------------------------------------------+");
            
        }
}