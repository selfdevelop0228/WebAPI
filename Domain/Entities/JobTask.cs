
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class JobTask
    {
        public int TaskID { get; set; }

        public string? TaskName { get; set; }

        public string? Description { get; set; }

        public string? Status { get; set; }
        public DateTime? Created { get; set; }

        public DateTime? End { get; set; }

        public string? Person { get; set; }


    }
}
