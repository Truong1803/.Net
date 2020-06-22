using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caro3
{
    public class Players
    {
        private string name;
        public string Name { get => name; set => name = value; }
        public Players(string name)
        {
            this.Name = name;
           
        }
    }
}
