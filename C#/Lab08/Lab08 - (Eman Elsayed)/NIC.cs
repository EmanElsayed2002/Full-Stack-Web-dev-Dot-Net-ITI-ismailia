using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lab09
{
    [Flags]
    enum Type
    {
        Ethernet = 0b01,
        tokenRing = 0b10
    }


    class NIC
    {

        public string Manufacture { get; set; }
        public string MacAddress { get; set; }
        public Type Types { get; set; }

        private NIC()
        {
            Manufacture = "Manu";
            MacAddress = "SingleTonClass";
            Types = (Type)Enum.Parse(typeof(Type) , "Ethernet");
        }

        public static NIC Obj { get; } = new NIC();

    }
}
