using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_06_Bulding
{
    public class TeamLeader : Worker
    {
        public TeamLeader(string name) : base(name) { }

        public Type? GetHousePartReady(House house) 
        {
            if (!house.PartTypeExists(typeof(Windows)))
            {
                if (!house.PartTypeExists(typeof(Door)))
                {
                    if (!house.PartTypeExists(typeof(Roof)))
                    {
                        if (!house.PartTypeExists(typeof(Walls)))
                        {
                            if (!house.PartTypeExists(typeof(Basement)))
                            {
                                return null;
                            }
                            return typeof(Basement);
                        }
                        return typeof(Walls);
                    }
                    return typeof(Roof);
                }
                return typeof(Door);
            }
            return typeof(Windows);
        }

        public void PrintBulildingStatusConsole(House house) 
        {
            Console.WriteLine($"{GetHousePartReady(house)?.Name} is ready");
        }

    }
}
