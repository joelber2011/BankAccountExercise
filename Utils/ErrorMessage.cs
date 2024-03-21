using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountExercise.Utils
{
    public class ErrorMessage
    {
        public string InvalidOption { get; protected set; }
        public string LimitAttemps { get; protected set; }
        public string InvalidFormat { get; protected set; }

        public ErrorMessage(string invalidOption, string limitAttemps, string invalidFormat)
        {
            InvalidOption = invalidOption;
            LimitAttemps = limitAttemps;
            InvalidFormat = invalidFormat;
        }
    }
}
