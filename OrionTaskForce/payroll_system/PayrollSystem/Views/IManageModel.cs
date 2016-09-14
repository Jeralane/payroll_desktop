using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PayrollSystem.Views
{
    interface IManageModel
    {
        void Refresh();
        void Add();
        void Edit();
        void Delete();
    }
}
