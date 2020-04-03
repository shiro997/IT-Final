using CatalogES.DBConfig;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CatalogES.Model
{
    public class CatalogContext
    {
        public IMongoCollection<UserTypeModel> UserTypes { get; }
        public IMongoCollection<SubjectModel> Subjects { get; }

        public CatalogContext(IDBSettings settings)
        {
            IMongoClient client = new MongoClient(settings.ConnectionString);
            IMongoDatabase database = client.GetDatabase(settings.DataBaseName);
            UserTypes = database.GetCollection<UserTypeModel>("UserType");
            Subjects = database.GetCollection<SubjectModel>("Subject");
        }
    }
}
