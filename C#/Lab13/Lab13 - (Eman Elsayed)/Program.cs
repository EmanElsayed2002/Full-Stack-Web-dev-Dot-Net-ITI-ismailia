namespace Delegates
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Book> bookList = new List<Book>
            {
                new Book("111-22-333", "Book1", new[] { "EmanElsayed", "William" }, new DateTime(2023, 1, 1), 19m),
                new Book("222-33-444", "Book2", new[] { "Shakespeare" }, new DateTime(2021, 7, 15), 14m),
                new Book("333-44-555", "Book3", new[] { "J.K. Rowling" }, new DateTime(2022, 9, 10), 25m),
                new Book("444-55-666", "Book4", new[] { "George Orwell" }, new DateTime(2020, 5, 23), 12.5m),
                new Book("555-66-777", "Book5", new[] { "Agatha Christie" }, new DateTime(2019, 11, 1), 18m),
                new Book("666-77-888", "Book6", new[] { "J.R.R. Tolkien" }, new DateTime(2021, 3, 17), 22m),
                new Book("777-88-999", "Book7", new[] { "Stephen King" }, new DateTime(2022, 6, 30), 16m),
                new Book("888-99-000", "Book8", new[] { "Mark Twain" }, new DateTime(2018, 8, 12), 20m),
                new Book("999-00-111", "Book9", new[] { "Jane Austen" }, new DateTime(2020, 1, 5), 15m),
                new Book("000-11-222", "Book10", new[] { "Charles Dickens" }, new DateTime(2017, 4, 23), 30m)
            };
            #region #1
            //BookFunction fptr2 = new BookFunction(BookFunctions.GetTitle);
            //LibraryEngine.ProcessBooksV1(bookList, fptr2);
            #endregion

            #region #2
            //Func<Book, string> fptr1 = (ww) =>
            //{
            //    return ww.Title;
            //};
            //LibraryEngine.ProcessBooksV2(bookList, fptr1);
            #endregion

            #region #3
            //Func<Book, string> fptr1 = delegate (Book B)
            //{
            //    return B.ISBN;
            //};
            //LibraryEngine.ProcessBooksV2(bookList, fptr1);
            #endregion

            #region #4
            Func<Book, string> fptr3 = b => b.PublicationDate.ToString();
            LibraryEngine.ProcessBooksV2(bookList, fptr3);
            #endregion
        }
    }
}
