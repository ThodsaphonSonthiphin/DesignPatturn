using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public interface IFactory
    {
        public INoteBook CreateNotebook();
        public IHeadSet CreateHeadSet();
    }
}
