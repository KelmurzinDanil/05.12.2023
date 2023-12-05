using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tum_14
{
    internal class DeveloperInfo2Attribute : Attribute // Атрибут для вывода инфы
    {
        public string Name { get; }
        public string NameOrg { get; }
        public DeveloperInfo2Attribute(string name, string datetime)
        {
            Name = name;
            NameOrg = datetime;
        }
    }
}

