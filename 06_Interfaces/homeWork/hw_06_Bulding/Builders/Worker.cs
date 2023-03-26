using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_06_Bulding
{
    public abstract class Worker
    {
        public string Name { get; set; }

        public Worker(string name)
        {
            Name = name;
        }
    }
}
