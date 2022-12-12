using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_PavónFraile
{
    public class Menu
    {
        public static string MaximoGoleador(Equipo [] equipos)
        {
            int aux = 0;
            int maxGoles = 0;
            int contador = 0;
            foreach (Equipo equipo in equipos)
            {
                if (maxGoles < equipo.MaximoGoleador().Goles)
                {
                    maxGoles = equipo.MaximoGoleador().Goles;
                    aux = contador;
                }
                contador++;
            }

            return "Maximo Goleador: " + equipos[aux].MaximoGoleador().StringDatos();
        }
        public static string MasVictorias(Equipo[] equipos)
        {
            int aux = 0;
            int maxVictorias = 0;
            int contador = 0;
            foreach (Equipo equipo in equipos)
            {
                if (maxVictorias < equipo.Victorias)
                {
                    maxVictorias = equipo.Victorias;
                    aux = contador;
                }
                contador++;
            }

            return "Equipo con más victorias: " + equipos[aux].NombreEquipo;
        }
        public static string MasDerrotas(Equipo[] equipos)
        {
            int aux = 0;
            int maxVictorias = 0;
            int contador = 0;
            foreach (Equipo equipo in equipos)
            {
                if (maxVictorias > equipo.Victorias)
                {
                    maxVictorias = equipo.Victorias;
                    aux = contador;
                }
                contador++;
            }

            return "Equipo con más derrotas: " + equipos[aux].NombreEquipo;
        }
        public static void mostrarMenu(Equipo[] equipos  )
        {
            bool ejecutar = false;
            int top = 0;
            int left = 0;
            for (int k = 0; ;)
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

                if (k < 0) k = 3;
                else if (k > 3) k = 0;

                if (ejecutar)
                {
                    ejecutar = false;
                    switch (k)
                    {
                        case 0:
                            do
                            {
                                Console.Clear();
                                Console.WriteLine(Menu.MaximoGoleador(equipos));
                                top = Console.GetCursorPosition().Top;
                                left = Console.GetCursorPosition().Left;

                            } while (Retorno(left, top));
                            Console.Clear();

                            if (k == 4)
                            {
                                goto case 1;
                            }
                            break;

                        case 1:
                            do
                            {
                                Console.Clear();
                                Console.WriteLine(Menu.MasVictorias(equipos));
                                top = Console.GetCursorPosition().Top;
                                left = Console.GetCursorPosition().Left;
                            } while (Retorno(left, top));
                            Console.Clear();
                            if (k == 4)
                            {
                                goto case 2;
                            }
                            break;

                        case 2:
                            do
                            {
                                Console.Clear();
                                Console.WriteLine(Menu.MasDerrotas(equipos));
                                top = Console.GetCursorPosition().Top;
                                left = Console.GetCursorPosition().Left;
                            } while (Retorno(left, top));
                            Console.Clear();
                            break;

                        //SALIR
                        case 3:
                            return;
                    }
                }
            }
        }

        //Dibuja el cuadro del menú
        public static void DibujarCuadro()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(2, 2);
            Console.WriteLine("+------------------------------------------------+"); //51 - 2
            for (int i = 1; i <= 10; i++)
            {
                Console.SetCursorPosition(2, 2 + i);
                Console.WriteLine("|");
                Console.SetCursorPosition(51, 2 + i);
                Console.WriteLine("|");
            }
            Console.SetCursorPosition(2, 12);
            Console.WriteLine("+------------------------------------------------+");
        }

        //Dibuja las opcioness

        public static void DibujarOpciones(int k)
        {
            ConsoleColor cc = ConsoleColor.White;
            ConsoleColor sel = ConsoleColor.Green;

            Console.SetCursorPosition(20, 5);
            Console.ForegroundColor = k == 0 ? sel : cc;
            Console.WriteLine("Máximo Goleador");
            Console.SetCursorPosition(20, 6);
            Console.ForegroundColor = k == 1 ? sel : cc;
            Console.WriteLine("Equipo Con Más Victorias");
            Console.SetCursorPosition(20, 7);
            Console.ForegroundColor = k == 2 ? sel : cc;
            Console.WriteLine("Equipo Con Más Derrotas");
            Console.SetCursorPosition(20, 8);
            Console.ForegroundColor = k == 3 ? sel : cc;
            Console.WriteLine("Salir");
        }

        //Boton volver
        public static bool Retorno(int left, int top)
        {

            bool ejecutar = false;

            for (int n = 0; ;)
            {
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

                if (ejecutar)
                {
                    ejecutar = false;
                    switch (n)
                    {
                        case 0: return true;
                        case 1: return false;
                    }
                }
            }
        }

        //Dibuja las opciones despues de un juego 

        public static void DibujarRetorno(int n, int left, int top)
        {
            ConsoleColor cc = ConsoleColor.White;
            ConsoleColor sel = ConsoleColor.Green;

            Console.SetCursorPosition(left, top + 1);
            Console.ForegroundColor = n == 0 ? sel : cc;
            Console.WriteLine("Volver a Jugar");
            Console.SetCursorPosition(left + 50, top + 1);
            Console.ForegroundColor = n == 1 ? sel : cc;
            Console.WriteLine("Salir");
        }
    }
}
