using System.Reflection.Metadata.Ecma335;

namespace LibraryA
{
    public class Book
    {
        public String Title = string.Empty;
        public String Author = string.Empty;
        public String Genre = String.Empty;
        public DateTime DateOfPublish;
        public int BookPrice;
        public int TotalPages = 300;
        public Book()
        {
            Console.WriteLine("");
        }
        public void OpenBook()
        {
            Console.WriteLine("Book is Open");
        }
        public void BookmarkPage(int pageNo)
        {
            Console.WriteLine($"Page No:{pageNo}Bookmarked");
        }
        public int GetCurrentPage()
        {
            Random r = new Random();
            return r.Next(TotalPages);
        }
    }

}


