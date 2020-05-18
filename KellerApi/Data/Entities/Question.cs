using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KellerApi.Data.Entities
{
    public class Question
    {
        public int Id { get; set; }
        [MaxLength(200)]
        public string Quest { get; set; }
        [MaxLength(1000)]
        public string Answer { get; set; }
    }
}
