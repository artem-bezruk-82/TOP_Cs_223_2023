using hw_06_Bulding.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_06_Bulding
{
    public class СementPourer : Worker, IWorker
    {
        public СementPourer(string Name) : base(Name) { }

        public void Build(House house)
        {
            if (!house.PartTypeExists(typeof(Basement)))
            {
                try
                {
                    house.AddPart(new Basement());
                }
                catch (Exception exc)
                {
                    Console.WriteLine(exc.Message);
                }
            }
        }
    }
}
