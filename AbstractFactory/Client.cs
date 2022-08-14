using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class Client
    {
        private readonly IFactory _factory;


        public Client(IFactory factory)
        {
            _factory = factory;
        }

        public void Work()
        {
            var notebook = _factory.CreateNotebook();
            var headset = _factory.CreateHeadSet();

            notebook.TurnOn();
            headset.Play();
            notebook.TurnOff();
        }
    }
}
