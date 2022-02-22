using CoureTechnologies.Models;
using System.Collections;

namespace CoureTechnologies.Interface
{
    public interface ICountry
    {
            
        Task<IEnumerable> Country(Country country);
            
        Task<IEnumerable> User(CountryDetails countryDetails);
    

    }
}
