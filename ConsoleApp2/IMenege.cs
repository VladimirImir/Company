using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
    interface IMenege
    {
        void Control();
        void Organize();

        ListOfWorkers Workers { get; } // Дать возможность получить  доступ к сотрудникам.

    }
}
