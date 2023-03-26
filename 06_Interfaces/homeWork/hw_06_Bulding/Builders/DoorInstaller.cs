using hw_06_Bulding.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_06_Bulding
{
    public class DoorInstaller : Worker, IWorker
    {
        public DoorInstaller(string name) : base(name) { }

        public void Build(House house)
        {
            if (house.PartTypeExists(typeof(Roof)) && !house.PartTypeExists(typeof(Door)))
            {
                try
                {
                    house.AddPart(new Door());
                }
                catch (Exception exc)
                {
                    Console.WriteLine(exc.Message);
                }

            }
        }
    }
}
