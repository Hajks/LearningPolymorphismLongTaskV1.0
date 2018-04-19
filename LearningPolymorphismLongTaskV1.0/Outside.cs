using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningPolymorphismLongTaskV1._0
{
    class Outside :Location
    {
        public Outside(string name, bool hot) : base(name)
        {
            this.hot = hot;
        }
        private bool hot;

        public override string Description
        {
            get
            {
                if (hot)
                    return base.Description += "\r\n" + "Tutaj jest bardzo gorąco.";
                else
                    return base.Description += "\r\n" + "Tutaj jest sporo cienia.";
            }
        }
    }
}
