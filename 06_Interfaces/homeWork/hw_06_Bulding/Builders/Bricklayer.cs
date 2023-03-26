using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_06_Bulding.Builders
{
    public class Bricklayer : Worker, IWorker
    {
        public Bricklayer(string name) : base(name) { }

        public void Build(House house)
        {
            if (house.PartTypeExists(typeof(Basement)) && !house.PartTypeExists(typeof(Walls)))
            {
                try
                {
                    house.AddPart(new Walls());
                }
                catch (Exception exc)
                {
                    Console.WriteLine(exc.Message);
                }
            }
        }
    }
}
