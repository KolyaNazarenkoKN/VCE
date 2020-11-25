using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VCE_Server
{
   public  class UserGroup
    {
        public int IdUser { get; set; }
        public int IdGroup { get; set; }
        public virtual ICollection<User> Users { get; set; }
        UserGroup()
        {
            Users = new List<User>();
        }
    }
}
