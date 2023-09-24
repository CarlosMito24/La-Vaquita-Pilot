using SQLite;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Models
{
    public class Variables
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Teléfono { get; set; }
        public string Fecha { get; set; }
        public string Total { get; set; }
    }
}