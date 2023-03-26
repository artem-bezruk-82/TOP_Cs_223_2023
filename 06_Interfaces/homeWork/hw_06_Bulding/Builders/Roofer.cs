using hw_06_Bulding.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_06_Bulding
{
    public class Roofer : Worker, IWorker
    {
        public Roofer(string name) : base(name) { }

        public void Build(House house)
        {
            if (house.PartTypeExists(typeof(Walls)) && !house.PartTypeExists(typeof(Roof)))
            {
                try
                {
                    house.AddPart(new Roof());
                }
                catch (Exception exc)
                {
                    Console.WriteLine(exc.Message);
                }
            }
        }

    }
}
