using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Generics.Exceptions
{
    class InvalidAttendenceValue:Exception
    {
        public InvalidAttendenceValue(string message):base(message)
        {
 
        }
    }
}
