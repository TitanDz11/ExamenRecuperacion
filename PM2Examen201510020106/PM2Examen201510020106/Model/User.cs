using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace PM2Examen201510020106.Model
{
    class User
    {
        [PrimaryKey, AutoIncrement]
        public int id { get; set; }

        [MaxLength(100)]
        public String Usu { get; set; }

        [MaxLength(100)]
        public String Pass { get; set; }
    }
}
