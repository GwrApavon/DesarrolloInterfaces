internal class Program
{
    private static void Main(string[] args)
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
                        Console.WriteLine("Juego 1");
                    }while(salir1);
                   
                    if(op == 4)
                    {
                        goto case 2;
                    }
                    break;
              
                case 2:
                    Boolean salir2 = true;
                    do
                    {
                        Console.WriteLine("Juego 2");
                    } while (salir2);
                   
                    if (op == 4)
                    {
                        goto case 2;
                    }
                    break;
               
                case 3:
                    Boolean salir3 = true;
                    do
                    {
                        Console.WriteLine("Juego 3");
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
}