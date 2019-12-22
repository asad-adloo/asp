using System;
using System.Collections.Generic;
using System.Text;

namespace CRM.Application.Common.Exceptions
{
    public class DeleteFailureException : Exception
    {
        public DeleteFailureException(string name, object key, string message)
            : base ($"deletion of entity \"{name}\" ({key}) faild. {message}")
        {
        }
    }
}
