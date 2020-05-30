using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp6
{//Auto-property initializers let you declare the initial value for an auto-property as part of the property declaration.
    class AutoPropertyInitializers
    {
        public ICollection<double> Grades { get; } = new List<double>();
    }
}
