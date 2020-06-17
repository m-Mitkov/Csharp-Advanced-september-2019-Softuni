using System;
using System.Collections.Generic;
using System.Text;

namespace BorderControl
{
    class Robot : ICountable
    {
        public Robot(string name, string id)
        {
            this.Name = name;
            this.Id = id;
        }

        public string Name { get; set; }
        public string Id { get; set; }

        public bool CheckBorderControllPassed(string specificCode)
        {
            if (Id.Substring(Id.Length - specificCode.Length, specificCode.Length) == specificCode)
            {
                return true;
            }

            return false;
        }
    }
}

