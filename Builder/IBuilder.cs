using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public interface IBuilder
    {
        public void AddSecurity();
        public void AddServeStaticFile();
        public void AddLocalDatabase();
    }
}
