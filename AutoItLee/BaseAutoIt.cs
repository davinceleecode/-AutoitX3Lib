using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoItX3Lib;

namespace AutoItLee
{
    /// <summary>
    /// base class of AuoItLee
    /// </summary>
    public class BaseAutoIt
    {
        /// <summary>
        /// instance of AutoItLeeHelper
        /// </summary>
        protected readonly internal IAutoItX3 AI;

        /// <summary>
        /// instance of AutoItLeeHelper
        /// </summary>
        /// <param name="autoItX3"></param>
        public BaseAutoIt(IAutoItX3 autoItX3)
        {
            AI = autoItX3;
        }
    }
}
