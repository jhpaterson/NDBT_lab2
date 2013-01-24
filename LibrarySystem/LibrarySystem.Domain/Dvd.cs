namespace LibrarySystem.Domain
{
    public class Dvd : Title
    {
        public virtual string Rating { get; set; }
        public virtual int Region { get; set; }
    }
}
