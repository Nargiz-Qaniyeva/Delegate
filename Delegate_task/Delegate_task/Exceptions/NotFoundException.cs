using System;
using System.Collections.Generic;
using System.Text;

namespace Delegate_task.Exceptions
{
    internal class NotFoundException:Exception
    {
        private string v;

        public NotFoundException(string v)
        {
            this.v = v;
        }
    }
}
