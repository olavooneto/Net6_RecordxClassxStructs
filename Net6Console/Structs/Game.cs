using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net6Console.Structs
{
    public struct Game
    {
        public Game()
        {
            this.Name = "UNDEFINED";
            this.Developer = "UNDEFINED";
            this.ReleaseDate = DateTime.Now;
            this.Value = double.NaN;
        }

        public Game(string name, string developer, DateTime releaseDate, double value) => (Name, Developer, ReleaseDate, Value) = (name, developer, releaseDate, value); 

        public string Name { get; init; }
        
        public string Developer { get; init; }
        
        public DateTime ReleaseDate { get; init; }

        public double Value { get; init; }

        public override string ToString() => $"{nameof(Name)} = {Name}, {nameof(Developer)} = {Developer}, {nameof(ReleaseDate)} = {ReleaseDate}, {nameof(Value)} = {Value}";
    }
}
