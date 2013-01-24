namespace LibrarySystem.Domain
{
    public class Book : Title
    {
        public virtual string Author { get; set; }
        public virtual string ISBN { get; set; }
    }
}
