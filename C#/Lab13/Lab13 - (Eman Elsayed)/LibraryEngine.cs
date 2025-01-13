namespace Delegates
{
    public class LibraryEngine
    {
        public static void ProcessBooksV1(List<Book> bList, BookFunction fPtr)
        {
            foreach (Book B in bList)
            {
                Console.WriteLine(fPtr(B));
            }
        }

        #region BuiltIn Delegates
        public static void ProcessBooksV2(List<Book> bList, Func<Book , string> fPtr)
        {
            foreach (Book B in bList)
            {
                Console.WriteLine(fPtr(B));
            }
        }
        #endregion


    }
}
