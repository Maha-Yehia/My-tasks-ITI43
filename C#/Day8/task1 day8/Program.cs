namespace task1_day8
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] authors1 = { "Maha, ", "Yehia, ", "Ahmed" };
            string[] authors2 = { "Hoda, ", "Ali, ", "Amal" };
            string[] authors3 = { "Menna, ", "Mohamed, ", "Sara" };
            DateTime date = new();

            Book book1 = new Book("h1", "Yes", authors1, date, 150);
            Book book2 = new Book("h2", "No", authors2, date, 200);
            Book book3 = new Book("h3", "Maybe", authors3, date, 250);

            List<Book> books = new List<Book> { book1 , book2 , book3 };

            //-------------------------------Delegate Datatype-------------------------------------

            Book_Delegate fPtr1 = new Book_Delegate(BookFunctions.GetTitle);
            Book_Delegate fPtr2 = BookFunctions.GetPrice;
            Book_Delegate fPtr3 = BookFunctions.GetAuthors;
            Console.WriteLine("------------------1-------------------");
            Console.WriteLine("Titles of the books"); 
            LibraryEngine.ProcessBooks(books, fPtr1);
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Prices of the books");
            LibraryEngine.ProcessBooks(books, fPtr2);
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Authors of the books");
            LibraryEngine.ProcessBooks(books, fPtr3);

            //LibraryEngine.ProcessBooks(books, BookFunctions.GetAuthors);
            Console.WriteLine("");

            //-------------------------------BCL Delegates-------------------------------------

            Func<Book, string> fPtr4 = BookFunctions.GetTitle;
            Func<Book, string> fPtr5 = BookFunctions.GetPrice;
            Func<Book, string> fPtr6 = BookFunctions.GetAuthors;

            Console.WriteLine("------------------2-------------------");
            Console.WriteLine("Titles of the books");
            LibraryEngine.ProcessBooks(books, fPtr4);
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Prices of the books");
            LibraryEngine.ProcessBooks(books, fPtr5);
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Authors of the books");
            LibraryEngine.ProcessBooks(books, fPtr6);
            Console.WriteLine("");


            //-------------------------------Anonymous Method-------------------------------------
            Func<Book, string> fPtr7 = delegate (Book book) { return book.ISBN; };
            Console.WriteLine("------------------3-------------------");
            Console.WriteLine("ISBN of the books");
            LibraryEngine.ProcessBooks(books, fPtr7);

            //-------------------------------Lambda Expression-------------------------------------

            Console.WriteLine("------------------4-------------------");
            Func<Book, string> fPtr8 = (Book book) => book.PublicationDate.ToString();
            LibraryEngine.ProcessBooks(books, fPtr8);
         
        }
    }
}