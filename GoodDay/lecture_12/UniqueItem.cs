using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lecture_12
{
    class UniqueItem
    {
        static int staticId;
        public int id;

        static UniqueItem() { staticId = 0; }

        public UniqueItem() 
        {
            staticId++;
            id = staticId; 
        }

        public UniqueItem(int id) 
        { 
            staticId = id;
            this.id = staticId; 
        }
    }
}
