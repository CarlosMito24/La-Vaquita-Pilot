using SQLite;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Models
{
    /// <summary>
    /// Clase que declara todad las varibales que usaremos y que deseamos guardar en nuestra tabla de la base de datos
    /// </summary>
    public class Variables
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Teléfono { get; set; }
        public string Fecha { get; set; }
        public string Total { get; set; }
        public string DetallesProducto1 { get; set; }
        public string SubTotalProducto1 { get; set; }
        public string DetallesProducto2 { get; set; }
        public string SubTotalProducto2 { get; set; }
        public string DetallesProducto3 { get; set; }
        public string SubTotalProducto3 { get; set; }
        public string DetallesProducto4 { get; set; }
        public string SubTotalProducto4 { get; set; }
        public string DetallesProducto5 { get; set; }
        public string SubTotalProducto5 { get; set; }
        public string DetallesProducto6 { get; set; }
        public string SubTotalProducto6 { get; set; }
        public string DetallesProducto7 { get; set; }
        public string SubTotalProducto7 { get; set; }
        public string DetallesProducto8 { get; set; }
        public string SubTotalProducto8 { get; set; }
        public string DetallesProducto9 { get; set; }
        public string SubTotalProducto9 { get; set; }
        public string DetallesProducto10 { get; set; }
        public string SubTotalProducto10 { get; set; }
        public string DetallesProducto11 { get; set; }
        public string SubTotalProducto11 { get; set; }
        public string DetallesProducto12 { get; set; }
        public string SubTotalProducto12 { get; set; }
        public string DetallesProducto13 { get; set; }
        public string SubTotalProducto13 { get; set; }
        public string DetallesProducto14 { get; set; }
        public string SubTotalProducto14 { get; set; }
        public string DetallesProducto15 { get; set; }
        public string SubTotalProducto15 { get; set; }
        public string DetallesProducto16 { get; set; }
        public string SubTotalProducto16 { get; set; }
        public string DetallesProducto17 { get; set; }
        public string SubTotalProducto17 { get; set; }
        public string DetallesProducto18 { get; set; }
        public string SubTotalProducto18 { get; set; }
        public string DetallesProducto19 { get; set; }
        public string SubTotalProducto19 { get; set; }
        public string DetallesProducto20 { get; set; }
        public string SubTotalProducto20 { get; set; }
        public string DetallesProducto21 { get; set; }
        public string SubTotalProducto21 { get; set; }
        public double Orden1 { get; set; } = 0;
        public double Orden2 { get; set; } = 0;
        public double Orden3 { get; set; } = 0;
        public double Orden4 { get; set; } = 0;
        public double Orden5 { get; set; } = 0;
        public double Orden6 { get; set; } = 0;
        public double Orden7 { get; set; } = 0;
        public double Orden8 { get; set; } = 0;
        public double Orden9 { get; set; } = 0;
        public double Orden10 { get; set; } = 0;
        public double Orden11 { get; set; } = 0;
        public double Orden12 { get; set; } = 0;
        public double Orden13 { get; set; } = 0;
        public double Orden14 { get; set; } = 0;
        public double Orden15 { get; set; } = 0;
        public double Orden16 { get; set; } = 0;
        public double Orden17 { get; set; } = 0;
        public double Orden18 { get; set; } = 0;
        public double Orden19 { get; set; } = 0;
        public double Orden20 { get; set; } = 0;
        public double Orden21 { get; set;} = 0;
        public double Total1 { get; set; }
    }
}