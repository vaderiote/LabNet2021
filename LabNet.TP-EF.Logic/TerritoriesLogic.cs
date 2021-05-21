using LabNet.TP_EF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNet.TP_EF.Logic
{
    public class TerritoriesLogic : BaseLogic
    {

        public List<Territories> GetAll()
        {
            return context.Territories.ToList();
        }
    }
}