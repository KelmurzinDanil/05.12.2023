using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Tum_14
{
    
    internal sealed class ConditionalAttributeClass : Attribute
    {
        [ConditionalAttribute("DEBUG_ACCOUNT")]
        public static void CallAttribute(BankAccount_2 bankAccount_2) // Вызов DumpToScreen
        {
            bankAccount_2.DumpToScreen();
        }
    }
}
