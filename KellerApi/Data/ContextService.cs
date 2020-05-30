using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KellerApi.Data
{
    public class ContextService
    {
        private readonly KellerDbContext _context;
        public ContextService(KellerDbContext context)
        {
            _context = context; 
        }
        
    }
}
