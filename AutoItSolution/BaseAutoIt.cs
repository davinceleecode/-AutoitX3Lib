using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoItX3Lib;

namespace AutoItSolution
{
    public class BaseAutoIt
    {
        protected readonly internal IAutoItX3 AI;
        
        public BaseAutoIt(IAutoItX3 autoItX3)
        {
            AI = autoItX3;
        }
    }
}
