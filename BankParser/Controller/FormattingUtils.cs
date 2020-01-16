using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankParser.Controller
{
    static class FormattingUtils
    {

        public static string GetDateStamp()
        {
            return DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString() + DateTime.Now.Millisecond;
        }

    }
}
