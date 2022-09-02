using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBanking.Core.Domain.Exceptions
{
    public class CustomerNotValidException : NotValidException
    {
        internal CustomerNotValidException() { }
        internal CustomerNotValidException(string message) : base(message) { }
        internal CustomerNotValidException(string message, Exception inner) : base(message, inner) { }
    }
}