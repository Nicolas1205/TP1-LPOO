using System;

namespace ClaseBase
{
    public class Evento
    {
        // Propiedades
        public int Eve_ID { get; set; }
        public int Com_ID { get; set; }  // ID de la competencia
        public int Atl_ID { get; set; }  // ID del atleta
        public string Eve_Estado { get; set; }
        public DateTime Eve_HoraInicio { get; set; }
        public DateTime Eve_HoraFin { get; set; }

        // Constructor vacío
        public Evento()
        {
        }

        // Constructor con argumentos
        public Evento(int eveID, int comID, int atlID, string eveEstado,
                      DateTime eveHoraInicio, DateTime eveHoraFin)
        {
            Eve_ID = eveID;
            Com_ID = comID;
            Atl_ID = atlID;
            Eve_Estado = eveEstado;
            Eve_HoraInicio = eveHoraInicio;
            Eve_HoraFin = eveHoraFin;
        }
    }

}
