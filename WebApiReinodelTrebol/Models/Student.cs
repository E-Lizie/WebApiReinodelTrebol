using System.Reflection.Metadata.Ecma335;

namespace WebApiReinodelTrebol.Models
{
    public class Request
    {
        public int Id { get; set; }
        public string name { get; set; }
        public string apellido { get; set; }
        public  int edad { get; set; }
        public string afinidadMagica { get; set; }
        public int statusSolicitud { get; set; }
        public int Grimorio { get; set; }
    }
}
