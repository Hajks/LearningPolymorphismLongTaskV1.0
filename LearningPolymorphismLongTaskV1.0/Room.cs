using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningPolymorphismLongTaskV1._0
{
    class Room:Location
    {
        public Room(string name, string decoration):base(name)

        {
            this.decoration = decoration;
        }
        private string decoration { get; }

        public override string Description
        {
            get
            {
                return base.Description += "\r\nWidzisz tutaj " + decoration + ".";
            }
        }

    }
}
