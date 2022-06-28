using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Model;

namespace WebApplication1.Business
{
    public interface ICountries
    {
        //GET ALL COUNTRIES

        public ICollection<Country> GetCountries();

        //GET SPECIFIC COUNTRIES BY ID
        public Country GetCountry(int countryId);

        //GET COUNTRY OF AN AUTHOR
        public Country GetCountryOfAnAuthor(int authorId);

        //Get Author From a Country
        public ICollection<Author> GetAuthorFromACountry(int countryId);

        //Passed Country is exist or not

        public bool countryExist(int countryId);
    }
}
