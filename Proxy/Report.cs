using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    public class Report : IReport
    {
        public string ShowReport()
        {
            return "Showing Report";
        }
    }
}
