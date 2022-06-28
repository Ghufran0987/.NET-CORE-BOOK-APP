using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Model;
using WebApplication1.Server;

namespace WebApplication1.Business
{
    public class Countries : ICountries
    {
        private BookContext context;

        public Countries(BookContext context)
        {
            this.context = context;
        }

        public ICollection<Author> GetAuthorFromACountry(int countryId)
        {
            return context.Authors.Where(a => a.country.Id == countryId).ToList();

        }

        public ICollection<Country> GetCountries()
        {

            //getting all countries
            return context.Countries.OrderBy(c => c.Name).ToList();




        }
        //GET SPECIFIC COUNTRIES BY ID
        public Country GetCountry(int countryId)
        {

            return context.Countries.Where(c => c.Id == countryId).FirstOrDefault();
        }

        public Country GetCountryOfAnAuthor(int authorId)
        {
            //It will first get the specific id we will pass then it will show the coutry
            return context.Authors.Where(a => a.id == authorId).Select(c => c.country).FirstOrDefault();
        }
        public bool countryExist(int countryId)
        {
            //any is bool enumurate it used to get true or false values
            return context.Countries.Any(c => c.Id == countryId);
        }
    }
}
