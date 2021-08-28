using System;
using System.Collections.Generic;
using System.Text;
using SQLite.Net.Interop;

namespace PM2Examen201510020106
{
    public interface IConfiguration
    {
        string directorio { get; }

        ISQLitePlatform plataforma { get; }
    }
}
