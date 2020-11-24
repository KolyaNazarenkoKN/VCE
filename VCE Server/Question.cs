using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VCE_Server
{
   public  class Question
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Difficalt { get; set; }
        public int IdTest { get; set; }
    }
}
