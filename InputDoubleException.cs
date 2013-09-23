using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace СurrencyConverter
{
    class InputDoubleException : Exception
    {
        public InputDoubleException()
            : base()
        {
        }

        public InputDoubleException(string message)
            : base(message)
        {

        }

        public InputDoubleException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
