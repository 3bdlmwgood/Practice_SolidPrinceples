using System;
using System.Collections.Generic;
using System.Text;

namespace ISP.Printer
{
    public interface IPrinter
    {
        void Print(string Content);

        void Scan();
        void Fax();
    }
}
