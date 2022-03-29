using System;
using System.Collections.Generic;
using System.Text;

namespace Delegate_task.Exceptions
{
    internal class CapacityLimitException:Exception
    {
        public CapacityLimitException(string message) : base(message)
        {
            Console.WriteLine();
        }
    }
}
