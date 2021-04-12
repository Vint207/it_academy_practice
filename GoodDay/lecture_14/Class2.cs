using System;
using System.Collections.Generic;
using System.Text;

namespace lecture_14
{
    class Product
    {
        public const string ProductType = "Phone";
        public Guid _id;
        public Guid Id { get { return _id; } }
        public string Name { get; set; }
        public Product()
        {
            _id = Guid.NewGuid();
        }
    }
}
