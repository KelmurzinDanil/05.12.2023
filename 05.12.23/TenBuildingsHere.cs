using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05._12._23
{
    internal class TenBuildingsHere
    {
        private Building[] tenBuilds = new Building[10];
        public Building[] TenBuilds { get { return tenBuilds; } }
        public Building this[int index] //Индексатор
        {
            get
            {
                if (index >= 0 && index <= tenBuilds.Length)
                {
                    return tenBuilds[index];
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }

            }
        }
        public void AddBuild(Building building)
        {
            tenBuilds[tenBuilds.Count(s => s != null)] = building;
        }
        
    }
}
