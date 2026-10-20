using System;
using System.Collections.Generic;
using System.Text;

namespace ISP.Printer
{
    
    //Not Used Yet
    public interface IPrinter
    {
        void Print(string Content);

        void Scan();
        void Fax();
    }
}
