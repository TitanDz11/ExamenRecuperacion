using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace PM2Examen201510020106.Model
{
    class Ubicacion
    {
        [PrimaryKey, AutoIncrement]
        public int id { get; set; }

        [MaxLength(100)]
        public String Latitud { get; set; }

        [MaxLength(100)]
        public String Longitud { get; set; }


        [MaxLength(100)]
        public String Descripcion { get; set; }

        [MaxLength(100)]
        public String DescripcionCorta { get; set; }
    }
}
