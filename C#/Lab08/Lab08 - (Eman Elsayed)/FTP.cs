using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab09
{
     class SingleTon
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        private SingleTon()
        {
            Id = 1;
            Name = "SingleTonClass";
            Description = "SingleTon Class Implementation";
        }

        public static SingleTon Obj { get; } = new SingleTon();
    }
}
