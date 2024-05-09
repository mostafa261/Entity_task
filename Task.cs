using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    internal class Task
    {
        public int Id { get; set; }

        [Required]
        public string title { get; set; } = null!;
        public string? description { get; set; }
        public DateTime data { get; set; }
    }
}
