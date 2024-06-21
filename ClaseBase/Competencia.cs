using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseBase
{
    public class Competencia
    {
        // Propiedades
        public int Com_ID { get; set; }
        public string Com_Nombre { get; set; }
        public string Com_Descripcion { get; set; }
        public DateTime Com_FechaInicio { get; set; }
        public DateTime Com_FechaFin { get; set; }
        public string Com_Estado { get; set; }
        public int Cat_ID { get; set; }
        public int Dis_ID { get; set; }



        // Constructor vacío
        public Competencia()
        {
        }

        // Constructor con argumentos
        public Competencia(int comID, string comNombre, string comDescripcion, DateTime comFechaInicio,
                           DateTime comFechaFin, string comEstado)
        {
            Com_ID = comID;
            Com_Nombre = comNombre;
            Com_Descripcion = comDescripcion;
            Com_FechaInicio = comFechaInicio;
            Com_FechaFin = comFechaFin;
            Com_Estado = comEstado;
        }
        public override string ToString()
        {
            return this.Com_Nombre; 
        }
    }

}
