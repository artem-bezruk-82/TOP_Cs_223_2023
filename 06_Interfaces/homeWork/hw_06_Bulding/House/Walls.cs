using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_06_Bulding
{
    internal class Walls : IPart
    {
        public string Image
        {
            get
            {
                return 
                    "  |                                                                            |" +
                    "\n  |                                                                            |" +
                    "\n  |                                                                            |" +
                    "\n  |                                                                            |" +
                    "\n  |                                                                            |" +
                    "\n  |                                                                            |" +
                    "\n  |                                                                            |" +
                    "\n  |                                                                            |" +
                    "\n  |                                                                            |" +
                    "\n _|____________________________________________________________________________|_" +
                    "\n ================================================================================";
            }
        }
    }
}
