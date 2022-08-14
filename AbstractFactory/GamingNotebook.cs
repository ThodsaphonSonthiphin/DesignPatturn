using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactory
{
    public class GamingNotebook : INoteBook
    {
        public void TurnOn()
        {
            Console.WriteLine($"{nameof(GamingNotebook)} turn on");
        }

        public void TurnOff()
        {
            Console.WriteLine($"{nameof(GamingNotebook)} turn off");
        }
    }
}