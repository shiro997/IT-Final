using CatalogES.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CatalogES.Repository
{
    public interface ICatalogRepository
    {
        Task<IEnumerable<SubjectModel>> getSubjects();
        Task<IEnumerable<UserTypeModel>> getUserTypes();
    }
}
