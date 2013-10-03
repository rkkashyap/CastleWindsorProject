using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFServiceComponent
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Calculator" in both code and config file together.
    public class Calculator : ICalculator
    {
       
        public int Sum(int x, int y)
        {
            return x + y;
        }
    }
}
