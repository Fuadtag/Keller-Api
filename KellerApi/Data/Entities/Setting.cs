using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KellerApi.Data.Entities
{
    public class Setting
    {
        public int Id { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string FaxNumber { get; set; }
        public string FacebookAdress { get; set; }
        public string TwitterAdress { get; set; }
        public string LinkedInAdress { get; set; }
        public string InstagramAdress { get; set; }
    }
}
