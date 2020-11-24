using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VCE_Server
{
   public class Answer
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public bool IsRight { get; set; }
        public int IdQuestion { get; set; }
    }
}
