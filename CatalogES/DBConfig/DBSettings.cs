using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CatalogES.DBConfig
{
    public class DBSettings:IDBSettings
    {
        public string ConnectionString { get; set; }
        public string DataBaseName { get; set; }
    }
}
