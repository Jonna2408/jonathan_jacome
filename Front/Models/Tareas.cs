namespace CRUDASPNET.Models
{
    public class Tareas
    {
        public int id { get; set; }
        public string? titulo { get; set; }
        public string? descripcion { get; set; }
        public string? fecha_creacion { get; set; }
        public string? fecha_vencimiento { get; set; }
        public string? completada { get; set; }
    }
}
