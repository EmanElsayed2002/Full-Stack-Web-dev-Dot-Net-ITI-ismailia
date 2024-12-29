namespace Task3_singlton_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NIC c1 = NIC.Object;
            NIC c2 = NIC.Object;
            NIC c3 = NIC.Object;

            Console.WriteLine($"c1 hashcode {c1.GetHashCode()} c1 Manufacture {c1.Manufacture} c1 Mac {c1.MacAdress}");
            Console.WriteLine($"c1 hashcode {c2.GetHashCode()} c2 Manufacture {c2.Manufacture} c2 Mac {c2.MacAdress}");
            Console.WriteLine($"c1 hashcode {c3.GetHashCode()} c3 Manufacture {c3.Manufacture} c1 Mac {c3.MacAdress}");
            

        }
    }
}
