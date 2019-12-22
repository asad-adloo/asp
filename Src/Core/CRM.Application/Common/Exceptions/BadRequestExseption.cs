using System;
using System.Collections.Generic;
using System.Text;

namespace CRM.Application.Common.Exceptions
{
    class BadRequestExseption : Exception
    {
        public BadRequestExseption(string message): base(message){}
    }
}
