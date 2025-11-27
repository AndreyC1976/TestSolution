namespace BooksEF.MyClasses.Books
{
    public class BookEntity
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int AuthorID {  get; set; }
        public string Description { get; set; }
        public string Publisher { get; set; }
        public DateTime PublishingDate { get; set; }
        public string Location { get; set; }
        public int PageSize { get; set; }
        public string Volume { get; set; }


        // Navigation property: объект автора
        public AuthorEntity Author { get; set; }






    }
}
