using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JuegoFinal.Entidades
{
    public class Dificultades
    {
        public int DificultadId { get; set; }
        public string Descripcion { get; set; }
        public List<string> animalList { get; set; } = new List<string>();
        public int Coincidencias { get; set; }
    }
}
