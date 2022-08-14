using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class GamingHeadSet : IHeadSet
    {
       

        public void Play()
        {
            Console.WriteLine($"sound of {nameof(GamingHeadSet)}");
        }
    }
}
