using System.Text.RegularExpressions;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibrarySystem.Domain
{
    public class Shelf
    {
        public virtual string ShelfCode { get; set; }
        public virtual string SiteName { get; set; }
        public virtual string Address { get; set; }
        public virtual string PostCode { get; set; }
    }
}
