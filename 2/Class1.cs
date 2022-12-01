using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    public class BlackBoxInteger
    {
        private static int DefaultValue = 0;
        private int Value;
        private BlackBoxInteger(int innerValue)
        {
            Value = innerValue;
        }
        private BlackBoxInteger()
        {
            Value = DefaultValue;
        }
        private void Add(int added)
        {
            Value += added;
        }
        private void Subtract(int subtracted)
        {
            Value -= subtracted;
        }
        private void Multiply(int multiplier)
        {
            Value *= multiplier;
        }
        private void Divide(int divider)
        {
            Value /= divider;
        }
        private void LeftShift(int shifter)
        {
            Value <<= shifter;
        }
        private void RightShift(int shifter)
        {
            Value >>= shifter;
        }
    }
}