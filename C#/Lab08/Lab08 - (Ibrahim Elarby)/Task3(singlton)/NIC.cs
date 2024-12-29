using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3_singlton_
{
    public class NIC
    {
        public static NIC Object { get; } = new NIC();
        
        public string Manufacture {  get; set; }
        public string MacAdress { get; set; }

        Type NICType { get; set; }
        
        public enum Type
        {
            Ethernet,
            Token_Ring
        }

       

        private NIC()
        {
            Manufacture = "Intel";
            MacAdress = "00331-10000-00001-AA630";
            Type NICType = Type.Ethernet;
        }

    }
}
