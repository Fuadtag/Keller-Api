using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KellerApi.Data.Entities
{
    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string About { get; set; }
        public IFormFile PhotoFile{ get; set; }
        public string Photo { get; set; }
        public DateTime FoundDate { get; set; }
        public string TeamSize { get; set; }
        public string Location { get; set; }
        public string Website { get; set; }

        public string Category { get; set; }
    }
}
