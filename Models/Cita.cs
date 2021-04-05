using System;
using Newtonsoft.Json;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Tarea_9.Models
{
    public class Cita
    {
        [Key]
        public long cedula {get; set;}
        public string nombre {get; set;}
        public string apellido {get; set;}
        public long telefono {get; set;}
        public string correoElectronico {get; set;}
        public DateTime fechaNacimiento {get; set;}
        public string tipoSangre {get; set;}
        public string provincia {get; set;}
        public string direccion {get; set;}
        public double latitud {get; set;}
        public double longitud {get; set;}
        public bool covid {get; set;}
        public string justificacion {get; set;}
    }
}