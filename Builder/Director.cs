using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class Director
    {
        private readonly IBuilder _builder;

        public Director(IBuilder builder)
        {
            _builder = builder;
        }

        public void BuildFullFeature()
        {
            
            _builder.AddSecurity();
            _builder.AddServeStaticFile();
            _builder.AddLocalDatabase();
        }

        public void BuildNoneLocalDatabase()
        {
            _builder.AddSecurity();
            _builder.AddServeStaticFile();
        }

    }
}
