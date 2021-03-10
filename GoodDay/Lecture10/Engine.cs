using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture10
{
    internal class Engine
    {
        int volume = 125;
        int power = 50;

        public int Volume { get { return volume; } set { if (value >= 125 && value <= 3200) volume = value; } }
        public int Power { get { return power; } set { if (value >= 50 && value <= 300) power = value; } }
    }
}
