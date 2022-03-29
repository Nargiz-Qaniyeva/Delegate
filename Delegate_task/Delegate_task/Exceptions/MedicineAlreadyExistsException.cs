using System;
using System.Collections.Generic;
using System.Text;

namespace Delegate_task.Exceptions
{
    internal class MedicineAlreadyExistsException:Exception
    {
        public MedicineAlreadyExistsException(string message) : base(message)
        { Console.WriteLine("Bu obyekt artiq var"); }
    }
}
