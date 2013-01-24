using System.Collections.Generic;

namespace LibrarySystem.Domain
{
    public class Title
    {
        public virtual int TitleId { get; set; }
        public virtual string TitleName { get; set; }
        public virtual Shelf Shelf { get; set; }
        public virtual List<Copy> Copies { get; set; }
    }
}
