namespace FTP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region FTP
            Console.WriteLine(NetworkCard.obj.MAC_Address);
            Console.WriteLine(NetworkCard.obj.Manufacture);
            Console.WriteLine(NetworkCard.obj.Type);
            #endregion
        }
    }
}
