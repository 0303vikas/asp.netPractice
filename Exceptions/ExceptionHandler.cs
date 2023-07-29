using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracticeAsp.Net.Exceptions
{
    public class HandleException : Exception
    {
        private string _errorMessage;
        private int _code;

        public HandleException(string message, int code)
        {
            _errorMessage = message;
            _code = code;
        }

        public static HandleException UserNotFound(string? message, int? code)
        {
            return new HandleException(message ?? "User not created", code ?? 500);
        }
    }
}