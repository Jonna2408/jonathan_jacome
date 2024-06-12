using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase
{
    public class Tareas
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public string? titulo    { get; set; }
        public string? descripcion { get; set; }
        public string? fecha_creacion { get; set; }
        public string? fecha_vencimiento     { get; set; }
        public string? completada    { get; set; }
    }
}
