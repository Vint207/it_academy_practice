using System;
using System.Collections.Generic;
using System.Text;

namespace lecture_11
{
    class Figures<T> where T : Figure
    {
        public List<T> figures;

        public Figures() { figures = new List<T>(); }
    }
}
