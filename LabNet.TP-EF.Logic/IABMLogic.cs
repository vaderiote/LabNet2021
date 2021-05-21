using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNet.TP_EF.Logic
{
    interface IABMLogic<T>
    {
        List<T> GetAll();
        void Add(T newCategory);
        void Delete(int id);
        void Update(T category);

    }
}
