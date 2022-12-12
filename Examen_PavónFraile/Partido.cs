using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_PavónFraile
{
    public class Partido
    {
        private Equipo local;
        private Equipo visitante;
        private Arbitro arbitro;
        private int golesLocal;
        private int golesVisitante;
        private int totalTarjetas;

        public int GolesLocal
        {
            get
            {
                return this.golesLocal;
            }
        }
        public int GolesVisitante
        {
            get
            {
                return this.golesVisitante;
            }
        }
        public int TotalTarjetas
        {
            get
            {
                return this.totalTarjetas;
            }
        }
        public void SimulaResultado(Equipo local, Equipo visitante, Arbitro arbitro)
        {
            Random rand = new Random();

            int probGoles = rand.Next(0, 101);
            switch (probGoles)
            {
                case int when probGoles >= 0 && probGoles <= 35:
                    this.golesVisitante = 0;
                    break;
                case int when probGoles > 35 && probGoles <= 60:
                    this.golesVisitante = 1;
                    break;
                case int when probGoles > 60 && probGoles <= 80:
                    this.golesVisitante = 2;
                    break;
                case int when probGoles > 80 && probGoles <= 90:
                    this.golesVisitante = 3;
                    break;
                case int when probGoles > 90 && probGoles <= 100:
                    this.golesVisitante = rand.Next(4,11);
                    break;
            }

            switch (probGoles)
            {
                case int when probGoles >= 0 && probGoles <= 30:
                    this.golesLocal = 0;
                    break;
                case int when probGoles > 30 && probGoles <= 55:
                    this.golesLocal = 1;
                    break;
                case int when probGoles > 55 && probGoles <= 70:
                    this.golesLocal = 2;
                    break;
                case int when probGoles > 70 && probGoles <= 85:
                    this.golesLocal = 3;
                    break;
                case int when probGoles > 85 && probGoles <= 100:
                    this.golesLocal = rand.Next(4, 11);
                    break;
            }

            for(int i = 0; i < golesLocal; i++)
            {
                local.Jugadores[rand.Next(0, local.NumeroJugadores)].Goles = 1;
            }
            for (int i = 0; i < golesVisitante; i++)
            {
                visitante.Jugadores[rand.Next(0, visitante.NumeroJugadores)].Goles = 1;
            }

            this.totalTarjetas = rand.Next(0, 11);
            arbitro.TotalTarjetas = TotalTarjetas;
        }
    }
}
