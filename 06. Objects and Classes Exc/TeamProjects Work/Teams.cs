using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamProjects_Work
{
    public class Teams
    {
        public string Name { get; set; }

        public string Creator { get; set; }

        public List<string> Members { get; set; } 

        public Teams (string creator,string name)
        {
            Creator= creator;
            Name= name;
            Members= new List<string> ();
        }
    }
}
