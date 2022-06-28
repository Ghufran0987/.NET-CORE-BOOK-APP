using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Model;

namespace WebApplication1.Server
{
    public static class DbSeedingClass
    {
        public static void SeedDataContext(this BookContext context)
        {
            var bookAuthors = new List<BookAuthor>()
            {
                new BookAuthor()
                {
                    book=new Book()
                    {
                        isbn="1234",
                        title="The Call Of Wild",
                        DatePublished=new DateTime(1903,1,1),
                        BookCategories=new List<BookCategory>()
                        {
                            new BookCategory{Categories=new Categories(){Name="Action"}}
                        },
                        reviews=new List<Review>()
                        {
                            new Review{Headline="Awsome Book",ReviewText="Reviewing Call Of the Wild",Rating=5,
                            Reviewers=new Reviewers(){firstName="xyz",lastName="abc"} },

                            new Review{Headline="Terible Book",ReviewText="Reviewing Call Of the Wild",Rating=5,
                            Reviewers=new Reviewers(){firstName="john",lastName="smith"} },

                            new Review{Headline="Decent Book",ReviewText="Reviewing Call Of the Wild",Rating=5,
                            Reviewers=new Reviewers(){firstName="peter",lastName="graffin"} },




                        }


                    },
                    author=new Author()
                    {
                        firstName="Jack",
                        lastName="London",
                        country=new Country()
                        {
                            Name="USA"
                        }

                    }

                   
                },
                new BookAuthor()
                {
                    book=new Book()
                    {
                        isbn="1234567",
                        title="Big Romantic Book",
                        DatePublished=new DateTime(1879,3,2),
                        BookCategories=new List<BookCategory>()
                        {
                            new BookCategory{Categories=new Categories(){Name="Romance"}}
                        },
                        reviews=new List<Review>()
                        {
                            new Review{Headline="Good Book",ReviewText="Made me cry",Rating=5,
                            Reviewers=new Reviewers(){firstName="xyz",lastName="abc"} },

                            new Review{Headline="Horrible Book",ReviewText="wide made me to read it",Rating=5,
                            Reviewers=new Reviewers(){firstName="abc",lastName="bxc"} },

                            new Review{Headline="Decent Book",ReviewText="Reviewing Call Of the Wild",Rating=5,
                            Reviewers=new Reviewers(){firstName="aas",lastName="dasd"} },




                        }


                    },
                    author=new Author()
                    {
                        firstName="Anita",
                        lastName="Powers",
                        country=new Country()
                        {
                            Name="RUSSIA"
                        }

                    }


                },



            };
            context.BookAuthors.AddRange(bookAuthors);
            context.SaveChanges();
        }
    }
}
