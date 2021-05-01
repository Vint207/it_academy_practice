using System;
using System.Collections.Generic;
using System.Text;

namespace lecture_18
{
    class Motorcycle
    {
        public Guid Id { get; private set; }
        public string Model { get; set; }
        public int Odometer { get; set; }
        public string MadeIn { get; set; }
    }
}
