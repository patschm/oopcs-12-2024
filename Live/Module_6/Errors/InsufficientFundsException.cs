using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Errors;

internal class InsufficientFundsException : Exception
{
    public double MaxAmount { get; set; }
}
