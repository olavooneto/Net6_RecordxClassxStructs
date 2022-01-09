using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net6Console.RecordTypes
{
    public class MusicClass
    {
        public MusicClass(string name) => this.Name = name;

        public string Name { get; set; }
    }

    public record MusicRecord
    {
        public MusicRecord(string name) => this.Name = name;

        public string Name { get; set; } = default!;
    }
}
