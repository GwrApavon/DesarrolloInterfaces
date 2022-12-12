using System.Net;
using Examen_PavónFraile;

public class main
{
    static void Main(string[] args)
    {
    //    Equipo[] equipos = new Equipo[2];
    //    Jugador[] jugadores = new Jugador[11];
    //    //Banderas

        Bandera espania = new Bandera("españa", true, new string[] { "Yellow",
        "Red", "Yellow" });
        Bandera rumania = new Bandera("rumania", false, new string[] { "Blue",
        "Yellow", "Red" });

        //Jugadores
        
        //Jugador jugador1 = new Jugador("Juan", 27, 4);
        //jugadores[0] = jugador1;
        //Jugador jugador2 = new Jugador("Pedro", 24, 6);
        //jugadores[1] = jugador1;
        //Jugador jugador3 = new Jugador("Joaquin", 18, 14);
        //jugadores[2] = jugador1;
        //Jugador jugador4 = new Jugador("Tomás", 37, 54);
        //jugadores[3] = jugador1;
        //Jugador jugador5 = new Jugador("Iker", 23, 43);
        //jugadores[4] = jugador1;
        //Jugador jugador6 = new Jugador("Alvaro", 19, 16);
        //jugadores[5] = jugador1;
        //Jugador jugador7 = new Jugador("Gaél", 24, 41);
        //jugadores[6] = jugador1;
        //Jugador jugador8 = new Jugador("Ángel", 19, 4);
        //jugadores[7] = jugador1;
        //Jugador jugador9 = new Jugador("Sergio", 21, 64);
        //jugadores[8] = jugador1;
        //Jugador jugador10 = new Jugador("Adrian", 34, 45);
        //jugadores[9] = jugador1;
        //Jugador jugador11 = new Jugador("Jorge", 20, 49);
        //jugadores[10] = jugador1;

        ////Equipos
        //Equipo equipo1 = new Equipo("España", 7, 11, jugadores, espania);
        //equipos[0] = equipo1;
        //Equipo equipo2 = new Equipo("Rumania", 3, 11, jugadores, rumania);
        //equipos[1] = equipo2;

        //Menu.mostrarMenu(equipos);

        espania.mostrarBandera(50,50);
        rumania.mostrarBandera(5, 5);
    }

        
    
}
    