using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net6Console.RecordTypes
{
    public record Motorcycle(string Brand, string Model) : Vehicle(Brand, Model);
}
