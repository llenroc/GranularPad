using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace System
{
    public static class ExceptionExtensions
    {
        public static string GetStackTrace(this Exception exception)
        {
            return exception.Stack;
        }
    }
}
