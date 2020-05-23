using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KellerApi.Data.Entities
{
    public enum JobType
    {
        Fulltime,
        PartTime,
        Freelance,
        Remote
    }
    public class Job
    {
        public int Id { get; set; }
        public int CompanyId { get; set; }
        public Company Company { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime PublishDate { get; set; }
        public string Salary { get; set; }
        public string Experience { get; set; }
        public DateTime Deadline { get; set; }
        public string Responsibilitie { get; set; }
        public string Benefit { get; set; }
        public JobType Type { get; set; }
    }
}
