using System.Runtime.CompilerServices;
namespace HundirLaFlotaFinal
{
    public class HundirLaFlota
    {
        static void Main(string[] args)
        {
            //Funcionamiento completo del juego, puede convenir comentar parte del código para comprobar que funcionan los métodos que vamos creando   
            Tablero tableroUsuario = Tablero.tableroUser();
            Tablero tableroMaquina = Tablero.tableroMaquina();

            Console.Clear();

    
            while(tableroUsuario.TotalTocados < 2 && tableroMaquina.TotalTocados < 2 ){
                  tableroMaquina.juegaUsuario(2,2);
                  tableroUsuario.juegaMaquina(55,2);
            }

            Console.Clear();
            Dibuja.DibujaCuadro(2,2);
            Dibuja.TableroJuegoMaquina(tableroMaquina, 2, 2);
            Dibuja.DibujaCuadro(55,2);
            Dibuja.TableroJuegoMaquina(tableroUsuario, 55, 2);
            Console.SetCursorPosition(28, 26);
            if (tableroMaquina.TotalTocados ==2 ){
               Console.WriteLine("Enhorabuena, has ganado! ");
            }
            else{
                Console.WriteLine("Lo siento, has perdido! ");
            }
            Console.ReadKey();
        }
    }

}