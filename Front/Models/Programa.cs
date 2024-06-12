using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDASPNET.Models
{
    public class Programa
    {
        public string IdPrograma { get; set; }
        public string IdEstudiante { get; set; }
        public string ProDescripcion { get; set; }
        public string ProNombre { get; set; }
        public string ProCreditos { get; set; }
        public string ProDiplomados { get; set; }
    }
}
