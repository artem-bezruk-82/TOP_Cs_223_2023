using hw_06_Bulding.Builders;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_06_Bulding
{
    public class Team
    {
        public TeamLeader? TeamLeader { get; set; }
        public List<IWorker> Workers { get; set; }

        private List<Type>? _missingWorkerTypes;

        public List<Type>? MissingWorkerTypes 
        {
            get 
            {
                if (!WorkerTypeExists(typeof(СementPourer))) { _missingWorkerTypes?.Add(typeof(СementPourer)); };
                if (!WorkerTypeExists(typeof(Bricklayer))) { _missingWorkerTypes?.Add(typeof(Bricklayer)); };
                if (!WorkerTypeExists(typeof(Roofer))) { _missingWorkerTypes?.Add(typeof(Roofer)); };
                if (!WorkerTypeExists(typeof(DoorInstaller))) { _missingWorkerTypes?.Add(typeof(DoorInstaller)); };
                if (!WorkerTypeExists(typeof(WindowInstaller))) { _missingWorkerTypes?.Add(typeof(WindowInstaller)); };
                return _missingWorkerTypes;
            } 
        }

        public Team(TeamLeader teamLeader)
        {
            TeamLeader = teamLeader;
            Workers = new List<IWorker>();
            _missingWorkerTypes = new List<Type>();
        }

        public void Add(IWorker worker) 
        {
            Workers.Add(worker);
        }

        public void BuildHouse(House house) 
        {
            if (MissingWorkerTypes?.Count == 0)
            {
                while (TeamLeader?.GetHousePartReady(house) != typeof(Windows))
                {
                    foreach (var worker in Workers)
                    {
                        try
                        {
                            worker.Build(house);
                        }
                        catch (Exception exc)
                        {
                            Console.WriteLine(exc.Message);
                        }
                        TeamLeader?.PrintBulildingStatusConsole(house);
                        Console.WriteLine();
                        Console.WriteLine(house.Image);
                    }
                }
            }
            else 
            {
                throw new Exception(message: $"{string.Join(',',MissingWorkerTypes!)}");
            }

        }

        public bool WorkerTypeExists(Type partType)
        {
            return Workers.Exists(w => w.GetType() == partType) ? true : false;
        }
    }
}
