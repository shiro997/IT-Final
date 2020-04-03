using CatalogES.Model;
using Microsoft.Extensions.Logging;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CatalogES.Repository
{
    public class CatalogRepository
    {
        private CatalogContext context;
        private ILogger logger;

        public CatalogRepository(CatalogContext context)
        {
            this.context = context;
            logger = new LoggerFactory().CreateLogger<CatalogRepository>();
        }

        public async Task<IEnumerable<SubjectModel>> getSubjects() 
        {
            try 
            {
                IEnumerable<SubjectModel> data = await context.Subjects.Find(sub => sub.Id != null).ToListAsync();
                return data;
            } 
            catch (Exception ex) 
            {
                logger.LogError(ex.Message);
                throw;
            }
        }

        public async Task<IEnumerable<UserTypeModel>> getUserTypes() 
        {
            try 
            {
                IEnumerable<UserTypeModel> data = await context.UserTypes.Find(ust => ust.Id != null).ToListAsync();
                return data;
            } 
            catch (Exception ex) 
            {
                logger.LogError(ex.Message);
                throw;
            }
        }
    }
}
