using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ResumeTemplate.Models
{
    public class Project
    {
        public string Title { get; set; }
        public string Description { get;  set; }
        public int Year { get; set; }
        public List<string> Technologies { get;  set; }
    }
}
