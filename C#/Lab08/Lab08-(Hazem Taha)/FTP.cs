using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day09
{
    public  class FTP
    {
        public  string Manufacture { get; set; }
        public string MACAddress { get; set; }
        public Type TypeOf { get; set; }
        private FTP()
        {
            Manufacture = "Manufacture";
            MACAddress= "00:1A:2B:3C:4D:5E";
            TypeOf = (Type)1;
        }



        public static FTP MyObj { get; } = new FTP();

    }
}
