using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankParser.Controller
{
    class AnalysisController
    {
        internal static void OpenAnalysisAssignForm()
        {
            View.AnalysisForm af = new View.AnalysisForm();
            af.Show();
        }
    }
}
