using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Quiz.Models
{
    public class KSCQuiz
    {
        public int ID { get; set; }
        public string Category { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; }
    }
}
