using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NIC
{
	public class NIC
	{
		public string Manufacture { get; set; }
		public string MacAddress { get; set; }

		enum Type
		{
			ethernet,
			tokenRing

		}

		private NIC()
		{
			Manufacture = string.Empty;
			MacAddress = string.Empty;
		}


		public static NIC Obj { get; } = new NIC();
	}
}
