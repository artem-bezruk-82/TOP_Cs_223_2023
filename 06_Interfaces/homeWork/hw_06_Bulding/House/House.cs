using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_06_Bulding
{
    public class House
    {
        //private List<IPart> _parts = new List<IPart>();
        public List<IPart> Parts { get; }
        public string? Image { get; private set; }

        public House()
        {
            Parts = new List<IPart>();
        }

        public void AddPart(IPart part)
        {

            if (!PartTypeExists(part.GetType()))
            {
                switch (part)
                {
                    case Basement:
                        break;
                    case Walls:
                        if (!PartTypeExists(typeof(Basement)))
                        {
                            throw new Exception(message: $"{typeof(Basement).Name} has not been completed yet");
                        }
                        break;
                    case Roof:
                        if (!PartTypeExists(typeof(Walls)))
                        {
                            throw new Exception(message: $"{typeof(Walls).Name} have not been completed yet");
                        }
                        break;
                    case Door:
                        if (!PartTypeExists(typeof(Roof)))
                        {
                            throw new Exception(message: $"{typeof(Roof).Name} has not been completed yet");
                        }
                        break;
                    case Windows:
                        if (!PartTypeExists(typeof(Door)))
                        {
                            throw new Exception(message: $"{typeof(Door).Name} has not been completed yet");
                        }
                        break;
                    default:
                        throw new ArgumentException(message: $"{part.GetType().Name} is not supported");
                }

                Parts.Add(part);
                Image = part.Image;
            }
            else 
            {
                throw new Exception(message: $"{part.GetType().Name} already exists");
            } 

            

            //if (part is Basement basement)
            //{
            //    if (Parts.Exists(p => p is Basement))
            //    {
            //        throw new Exception(message: $"{typeof(Basement).Name} already exists");
            //    }

            //}

            //if (part is Walls walls)
            //{
            //    if (Parts.Exists(p => p is Basement))
            //    {
            //        if (Parts.Exists(w => w is Walls))
            //        {
            //            throw new Exception(message: $"{typeof(Walls).Name} already exists");
            //        }
            //    }
            //}
            //Parts.Add(part);
            //Image = part.Image;
        }

        //public bool Exists(IPart part)
        //{
        //    return Parts.Exists(p => p.GetType() == part.GetType()) ? true : false;
        //}

        public bool PartTypeExists(Type partType)
        {
            return Parts.Exists(p => p.GetType() == partType) ? true : false;
        }

    }
}
