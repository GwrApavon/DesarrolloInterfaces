using System.Runtime.CompilerServices;
namespace HundirFinal
{
    public class HundirLaFlota
    {
        static void Main(string[] args)
        {
            /*
            Tablero tableroUser = Tablero.tableroUser();
            Tablero tableroUsuario = Tablero.tableroMaquina();
            Tablero tableroMaquina = Tablero.tableroMaquina();
            */
            Tablero tPrueba = Tablero.tableroMaquina();
            /*
            while(true){
               tableroUsuario.juegaUsuario(2,2);
            }
            */
            Console.Clear();
            Dibuja.DibujaCuadro(40,2);
            Dibuja.DibujaFinal(tPrueba.Barcos ,40,2);

        }
    }

}