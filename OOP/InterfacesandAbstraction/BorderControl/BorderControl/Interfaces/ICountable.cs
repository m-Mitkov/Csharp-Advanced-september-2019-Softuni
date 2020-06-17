using System;
using System.Collections.Generic;
using System.Text;

namespace BorderControl
{
    public interface ICountable
    {
        string Name { get; set; }

        string Id { get; set; }

        bool CheckBorderControllPassed(string specificDigits);
        
    }
}
