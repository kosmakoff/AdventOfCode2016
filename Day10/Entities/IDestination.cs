using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day10.Entities
{
    public interface IDestination
    {
        int Id { get; }

        void Give(int value);
    }
}
