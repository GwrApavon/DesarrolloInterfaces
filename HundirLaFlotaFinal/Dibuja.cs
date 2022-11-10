using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HundirLaFlotaFinal
{
    public class Dibuja
    //Se crean los métodos para dibujar en consola: Tablero usuario, tablero máquina y tablero final
    //Se puede utilizar cualquier método creado en las clases Barco, Tablero
    {

        //Dibuja el entorno del tablero. Recibe dos enteros que representan la posición en la que queremos que quede el tablero
        public static void DibujaCuadro(int x, int y)
        {
            //Opcional. Para dibujar los bordes del tablero. x e y representan la posición en la que quiero que 
            //aparezca el tablero
            Console.ForegroundColor = ConsoleColor.DarkGray;
            for (int n = 0; n < 23; n++)
            {
                for (int i = 0; i < 20; i++)
                {
                    if (n == 2 || n == 21)
                    {
                        n++;
                    }
                    Console.SetCursorPosition(x + n, y + i + 1);
                    Console.WriteLine("|");
                    Console.SetCursorPosition(x, y + i);
                    Console.WriteLine("+ - - - - - - - - - - +");
                    i++;
                }
                Console.SetCursorPosition(x, y + 20);
                Console.WriteLine("+ - - - - - - - - - - +");
                n++;
            }
            Console.ForegroundColor = ConsoleColor.White;
        }

        //Representa el tablero de juego de un jugador
        public static void TableroJuegoUsuario(Tablero T, int x, int y)
        {
            //Este método se llamaba tableroJuego
            //Debe dibujar: Gris si una coordenada no ha sido elegida por el usuario
            //              Rojo si el usuario ha elegido una coordenada y esa coordenada es barco
            //              Azul si el usuario ha elegido una coordenada y esa coordenada es agua
            //x e y representan la posición en la que quiero que aparezca el tablero


            //Tablero.Mar --> Array bidireccional en donde cada compoente vale true or false en función de 
            //si el usuario ha elegido una coordenada determinada
            //Tablero.Barcos --> Array de barcos

            //Para dibujar agua o barco puede convenir utilizar el método  CoordenadaEnBarcos de la clase Tablero
            for (int X = 0; X < 10; X++)
            {
                for (int Y = 0; Y < 10; Y++)
                {
                    Console.SetCursorPosition((X + 1) * 2 + x, Y * 2 + 1 + y);
                    if (T.Mar[X, Y])
                    {
                        if (T.CoordenadaEnBarcos(X, Y) == true)
                        {
                            Console.BackgroundColor = ConsoleColor.Red;             
                            Console.WriteLine(" ");
                        }
                        else if (T.CoordenadaEnBarcos(X,Y) == false)
                        {
                            Console.BackgroundColor = ConsoleColor.Blue;
                            Console.WriteLine(" ");
                        }
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.Gray;
                        Console.WriteLine(" ");
                    }
                }
            }
            Console.BackgroundColor = ConsoleColor.Black;
        }

        //Representa el tablero final de un jugador/máquina
        public static void DibujaFinal(Barco [] B, int x, int y)
        {
            //Debe dibujar:
            //              Rojo si una coordenada es barco
            //              Azul si si una coordenada es agua
            //x e y representan la posición en la que quiero que aparezca el tablero

            //B --> Array de barcos

            //Para dibujar agua o barco puede convenir utilizar el método CoordenadaEnBarcos (static) de la clase tablero
            for (int X = 0; X < 10; X++)
            {
                for (int Y = 0; Y < 10; Y++)
                {
                    Console.SetCursorPosition((X + 1) * 2 + x, Y * 2 + 1 + y);
                    if (Tablero.CoordenadaEnBarcos(B, X, Y) == true)
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        System.Console.WriteLine(" ");
                    }
                    else//Si no hay barco
                    {
                        Console.BackgroundColor = ConsoleColor.Blue;
                        System.Console.WriteLine(" ");
                    }
                }
            }
            Console.BackgroundColor = ConsoleColor.Black;
        }

        //Representa el tablero de juego de la maquina
        public static void TableroJuegoMaquina(Tablero T, int x, int y)
        //Debe dibujar:
        //              Rojo si una coordenada es barco
        //              Azul si si una coordenada es agua
        //              X si una coordenada ha sido elegida por la máquina
        //x e y representan la posición en la que quiero que aparezca el tablero

        //B --> Array de barcos

        //Para dibujar agua o barco puede convenir utilizar el método creaBarco de la clase Barco
        {
            for (int X = 0; X < 10; X++)
            {
                for (int Y = 0; Y < 10; Y++)
                {
                    Console.SetCursorPosition((X + 1) * 2 + x, Y * 2 + 1 + y);
                    if (T.Mar[X, Y])
                    {
                        if (T.CoordenadaEnBarcos(X, Y))
                        {
                            Console.BackgroundColor = ConsoleColor.Red;
                            Console.WriteLine("X");
                        }
                        else if (T.CoordenadaEnBarcos(X, Y) == false)
                        {
                            Console.BackgroundColor = ConsoleColor.Blue;
                            Console.WriteLine("X");
                        }
                    }
                    else { 
                        if (T.CoordenadaEnBarcos(X, Y))
                        {
                            Console.BackgroundColor = ConsoleColor.Red;
                            Console.WriteLine(" ");
                        }
                        else if (T.CoordenadaEnBarcos(X, Y) == false)
                        {
                            Console.BackgroundColor = ConsoleColor.Blue;
                            Console.WriteLine(" ");
                        }
                    }
                }
            }
            Console.BackgroundColor = ConsoleColor.Black;

        }
    }
}
