using System;
using System.Collections.Generic;
using System.Text;

namespace Ferrari
{
    public interface IDrivable
    {
        string Driver { get; }
        string Gas();
        string Brakes();
    }
}
