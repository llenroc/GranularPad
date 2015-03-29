using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GranularPad.ViewModelBuilders
{
    interface IBuilder<out T>
    {
        T Build();
    }
}
