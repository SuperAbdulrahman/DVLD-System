using DVLD_DataAccess;
using System;
using System.Data;

namespace DVLD_Business
{
    public class Country
    {
        public int CountryID { get; private set; }
        public string CountryName { get; set; }

        public Country()
        {
            CountryID = 0;
            CountryName = "";
        }
        private Country(int countryID, string countryName)
        {
            CountryID = countryID;
            CountryName = countryName;
        }

        public static Country Find(int CountryID)
        {
            Country country = null;
            string countryName = "";
            if(CountryDataAccess.Find(CountryID,ref countryName))
            {
                country = new Country(CountryID,countryName);
            }
            return country;
        }
        public static DataTable GetAllCountries()
        { 
            return CountryDataAccess.GetAllCountries();        
        }
        public static DataTable GetAllCountriesNames()
        {
            return CountryDataAccess.GetAllCountriesNames();
        }
    }
}
