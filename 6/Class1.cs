using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6
{
    public enum Color
    {
        Red,
        Green,
        Yellow
    }
    public class TrafficLight
    {
        public TrafficLight(Color color)
        {
            Color = color;
        }
        public Color Color { get; set; }
        public void ChangeColor()
        {
            Color = (Color)(((int)Color + 1) % 3);
        }
        public override string ToString()
        {
            return Color.ToString();
        }
    }
}