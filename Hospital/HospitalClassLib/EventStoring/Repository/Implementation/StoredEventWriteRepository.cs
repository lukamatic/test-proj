using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hospital.Database.EfStructures;
using Hospital.EventStoring.Model;
using Hospital.SharedModel.Repository.Base;

namespace Hospital.EventStoring.Repository.Implementation
{
    public class StoredEventWriteRepository : WriteBaseRepository<StoredEvent>, IStoredEventWriteRepository
    {
        public StoredEventWriteRepository(AppDbContext context) : base(context)
        {
        }
    }
}
