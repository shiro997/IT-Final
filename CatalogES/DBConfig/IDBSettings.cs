using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CatalogES.DBConfig
{
    public interface IDBSettings
    {
        string ConnectionString { get; set; }
        string DataBaseName { get; set; }
    }
}
