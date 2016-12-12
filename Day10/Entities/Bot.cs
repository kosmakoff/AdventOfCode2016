using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day10.Entities
{
    public class Bot : IDestination
    {
        private readonly List<int> _values = new List<int>();

        private int _lowerValue;

        private int _higherValue;

        public int LowerValue => _values.Count == 2 ? _lowerValue : 0;

        public int HigherValue => _values.Count == 2 ? _higherValue : 0;

        public int Id { get; }

        public Bot(int id)
        {
            Id = id;
        }

        public void Give(int value)
        {
            if (_values.Count >= 2)
                throw new InvalidOperationException("Cannot give more than 2 values");

            _values.Add(value);

            if (_values.Count == 2)
            {
                if (_values[0] > _values[1])
                {
                    _higherValue = _values[0];
                    _lowerValue = _values[1];
                }
                else
                {
                    _higherValue = _values[1];
                    _lowerValue = _values[0];
                }
            }
        }

        public bool Retrieve(out int lowerValue, out int higherValue)
        {
            lowerValue = higherValue = 0;

            if (_values.Count < 2)
                return false;

            lowerValue = _lowerValue;
            higherValue = _higherValue;

            _lowerValue = _higherValue = 0;
            _values.Clear();

            return true;
        }
    }
}
