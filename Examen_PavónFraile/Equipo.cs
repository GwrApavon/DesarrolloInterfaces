using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_PavónFraile
{
    public class Equipo
    {  
        private string nombreEquipo;
        private int victorias;
        private int numeroJugadores;
        private Jugador[] jugadores;
        private Bandera bandera;

        public int Victorias
        {
            set
            {
                victorias = value;
            }
            get
            {
                return this.victorias;
            }
        }
        public Jugador[] Jugadores
        {
            get
            {
                return jugadores;
            }
        }
        public string NombreEquipo
        {
            get
            {
                return this.nombreEquipo;
            }
        }
        public int NumeroJugadores
        {
            get
            {
                return numeroJugadores;
            }
        }
        public Bandera Bandera
        {
            get
            {
                return this.bandera;
            }
        }
        public Equipo(string nEquipo,int victorias, int numeroJugadores, Jugador[] jugadores, Bandera bandera)
        {
            this.nombreEquipo = nEquipo;
            this.victorias = victorias;
            this.numeroJugadores = numeroJugadores;
            this.bandera = bandera;
            this.jugadores = jugadores;
        }
        public Jugador MaximoGoleador()
        {
            int aux = 0;
            int maxGoles = 0;
            int contador = 0;
            foreach(Jugador jugador in jugadores)
            {
                if (jugador.Goles > maxGoles)
                {
                    maxGoles = jugador.Goles;
                    aux = contador;                    
                }
                contador++;
            }
            return jugadores[aux];
        }

        public void MuestraEquipo(int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine("Equipo: " + nombreEquipo + "\nMáximo Goleador:" + MaximoGoleador());
            bandera.mostrarBandera(x, y + 1);
        }
    
    }
}
