using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day10.Entities
{
    public class Output : IDestination
    {
        public int Id { get; }

        public int Value { get; private set; }

        public Output(int id)
        {
            Id = id;
        }

        public void Give(int value)
        {
            Value = value;
        }
    }
}
