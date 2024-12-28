using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTP
{
    class NetworkCard
    {
        public FTP_Type Type { get; set; }
        public string Manufacture { get; set; }
        public string MAC_Address { get; set; }


        private NetworkCard()
        {
            Manufacture = "manufacture";
            MAC_Address = "0xfffff";
            Type = (FTP_Type)Enum.Parse(typeof(FTP_Type), "eathernet");
        }
        public static NetworkCard obj { get; } = new NetworkCard();
}


 }
