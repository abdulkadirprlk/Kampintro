using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    //interfaceler, birbirinin alternatifi olan ama kod içerikleri farklı olan durumlar için kullanılır.
    interface ICreditManager
    {
        void Calculate();
        void DoSomething();
    }
}
