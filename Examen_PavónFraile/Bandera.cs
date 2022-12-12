using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_PavónFraile
{
    public class Bandera
    {
        private string nombre;
        private bool posicion;
        private string [] colores;

        public string Nombre
        {
            get { return nombre; }
        }

        public bool Posicion
        {
            get { return posicion; }
        }

        public string [] Colores
        {
            get { return colores; }
        }

        public Bandera(string n, bool pos, string[]c)
        {
            this.nombre = n;
            this.posicion = pos;
            this.colores = c;
        }
        public void mostrarBandera(int x, int y)
        {
            
            if (posicion)
            {
                for (int i = 0; i < 12; i++)
                {
                    Console.SetCursorPosition(x + i, y);
                    for (int c = 0; c < colores.Length; c++)
                    {
                        Console.BackgroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), colores[c], true);
                        for (int franja = 0; franja < 36/colores.Length; franja++)
                        {
                            Console.Write(" ");
                        }
                    }
                }
                Console.BackgroundColor = ConsoleColor.Black;
            }
            if (!posicion)
            {
                for (int c = 0; c < colores.Length; c++)
                {
                    Console.BackgroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), colores[c], true);
                    for (int linea = 0; linea < 12 / colores.Length; linea++)
                    {
                        Console.SetCursorPosition(x, y + linea);
                        for (int i = 0; i < 36; i++)
                        {
                            //Console.SetCursorPosition(x + i, y);
                            Console.Write(" ");
                        }
                    }
                }
                Console.BackgroundColor = ConsoleColor.Black;
            }
        }
    }
}
