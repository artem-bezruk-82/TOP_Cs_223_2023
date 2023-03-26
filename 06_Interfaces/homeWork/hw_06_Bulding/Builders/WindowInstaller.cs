using hw_06_Bulding.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_06_Bulding
{
    public class WindowInstaller : Worker, IWorker
    {
        public WindowInstaller(string name) : base(name) { }

        public void Build(House house)
        {
            if (house.PartTypeExists(typeof(Door)) && !house.PartTypeExists(typeof(Windows)))
            {
                try
                {
                    house.AddPart(new Windows());
                }
                catch (Exception exc)
                {
                    Console.WriteLine(exc.Message);
                }
            }
        }
    }
}
