using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorSolution
{
  
        public class MyException : Exception
        {
            public MyException() : base() { }
            public MyException(string message) : base(message) { }
            public MyException(string message, Exception innerException) : base(message, innerException) { }
                    
            public override string ToString()
            {
                return Message;
              
            }
        }
  

}
