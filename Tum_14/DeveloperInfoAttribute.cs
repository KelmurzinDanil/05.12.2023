using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tum_14
{
    internal class DeveloperInfoAttribute : Attribute // Атрибут для вывода инфы
    {
        public string Name { get; }
        public string Datetime { get; }
        public DeveloperInfoAttribute(string name, string datetime)
        {
            Name = name;
            Datetime = datetime;
        }
    }
}
