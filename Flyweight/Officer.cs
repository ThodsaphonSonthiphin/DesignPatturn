using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    public class Officer
    {
        private ProvinceFlyweights _province = null;
        public ProvinceFlyweights Province
        {
            get
            {
                return this._province;
            }

        }
        public string Name { get; set; }
        public Officer(ProvinceFactory factory, string name, string provinceName,string provinceCode)
        {
            Factory = factory;
            Name = name;
            _province = factory.GetProvinceFlyweight(provinceName,provinceCode);
        }

        

       

        public void SetProvince(string provinceName, string provinceCode)
        {
            _province = this.Factory.GetProvinceFlyweight(provinceName, provinceCode);
        }

        public readonly ProvinceFactory Factory;

        public string Operation()
        {
            return $"operating {ToString()}";
        }

        public override string ToString()
        {
            return $"{Name} in {this._province}";
        }
    }
}
