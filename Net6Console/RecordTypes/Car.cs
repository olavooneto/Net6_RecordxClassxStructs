using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net6Console.RecordTypes
{
    public record Car : Vehicle
    {
        public Car(string brand, string model) : base(brand, model) => (Brand, Model) = (brand, model);
    }
}
