using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2Exceptions
{
    public class LogicEj3 : Exception
    {
         public LogicEj3() : base("Mensaje de error de custom exception")
        {

        }
    }
}
