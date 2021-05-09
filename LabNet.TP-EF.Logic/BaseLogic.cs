using LabNet.TP_EF.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNet.TP_EF.Logic
{
    public class BaseLogic
    {
        protected readonly NorthWindContext context;

        public BaseLogic()
        {
            context = new NorthWindContext();
        }
    }
}
