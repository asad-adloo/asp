﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CRM.Application.Common.Exceptions
{
    class NotFoundException : Exception
    {
        public NotFoundException(string name, object key)
            : base($"Entity \"{name}\" ({key}) was not found.")
        {
        }

    }
}
