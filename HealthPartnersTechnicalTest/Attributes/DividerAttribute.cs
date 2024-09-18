using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthPartnersTechnicalTest.Attributes
{
    [AttributeUsage(AttributeTargets.Method)]
    public class DividerAttribute : Attribute
    {
        public int Divider;

        public DividerAttribute(int divider)
        {
            this.Divider = divider;
        }
    }
}
