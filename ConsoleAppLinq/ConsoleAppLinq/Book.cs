namespace ConsoleAppLinq
{
    public class Book
    {
        public string Title { get; set; }
        public int Year { get; set; }
        public string[] Tags { get; set; }
        public string Author { get; set; }

        public Book(string title, int year, string[] tags, string author)
        {
            Title = title;
            Year = year;
            Tags = tags;
            Author = author;
        }

        public Book(string title, int year, string[] tags)
        {
            Title = title;
            Year = year;
            Tags = tags;
        }
    }
}
