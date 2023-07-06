using BookDemo.Models;

namespace BookDemo.Data
{
    public static class ApplicationContext
    {
        public static List<Book> Books { get; set; }
        static ApplicationContext()
        {
            Books = new List<Book>()
            {
                new Book(){ID = 1, Title="Karagöz ve Hacivat",Price = 75},
                new Book(){ID = 2, Title="Mesnevi",Price = 150},
                new Book(){ID = 3, Title="Dede Korkut",Price = 75}
            };
        }
    }
}
