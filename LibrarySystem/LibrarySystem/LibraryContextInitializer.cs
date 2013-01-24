using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using LibrarySystem.Domain;


namespace LibrarySystem
{
    public class LibraryContextInitializer : DropCreateDatabaseAlways<LibraryContext>
    {
        protected override void Seed(LibraryContext context)
        {
            base.Seed(context);

            Shelf sh1 = new Shelf{
                ShelfCode = "005.7",
                SiteName = "Glasgow Caledonian University",
                Address = "Cowcaddens Road",
                PostCode = "G4 0BA" 
            };

            Shelf sh2 = new Shelf
            {
                ShelfCode = "781.655",
                SiteName = "Glasgow Caledonian University",
                Address = "Cowcaddens Road",
                PostCode = "G4 0BA"
            };

            Book bk1 = new Book{
                TitleName = "Programming Entity Framework",
                Author = "Julie Lerman",
                ISBN = "0596807260",
                Shelf = sh1,
                Copies = new List<Copy>{
                    new Copy{
                        IsAvailable = true
                    },
                    new Copy{
                        IsAvailable = true
                    },
                    new Copy{
                        IsAvailable = true
                    }
                }
            };

            MusicDvd md1 = new MusicDvd
            {
                TitleName = "Live at Belgrade",
                Artist = "John McLaughlin and the 4th Dimension",
                Rating = "Exempt",
                Region = 2,
                Shelf = sh1,
                Copies = new List<Copy>{
                    new Copy{
                        IsAvailable = true
                    },
                    new Copy{
                        IsAvailable = true
                    }
                }
            };

            context.Titles.Add(bk1);
            context.Titles.Add(md1);
            context.SaveChanges();
        }
    }
}
