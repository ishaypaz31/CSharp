using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL30HW
{
    class DAO : IDAO
    {
        static SQLiteConnection Connection;
        public static string dbName = @"C:\sqllite\sql30hw.db";

        static DAO()
        {
            Connection = new SQLiteConnection($"Data Source = {dbName}; Version=3;");
            Connection.Open();
        }
        public static void Close()
        {
            Connection.Close();
        }


        public object GetCountyAndItsCapitalCityDDetails(int countryid)
        {
            using (SQLiteCommand cmd = new SQLiteCommand($"SELECT *, COUNTRY.NAME as COUNTRY_NAME, CAPITALCITY.NAME as CITY_NAME FROM COUNTRY" +
                $" JOIN CapitalCity ON COUNTRY.CAPITALCITY_ID = CapitalCity.ID WHERE COUNTRY.ID = {countryid}", Connection))
            {
                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Country CurrentCountry = new Country
                        {
                            Id = (int)reader["ID"],
                            Name = (string)reader["NAME"],
                            SizeKm = (int)reader["SIZE_KM"],
                            BirthYear = (int)reader["BIRTH_YEAR"],
                            CapitalCityId = (int)reader["CAPITALCITY_ID"]
                        };

                        CapitalCity CurrentCity = new CapitalCity
                        {
                            Id = (int)reader["ID"],
                            Name = (string)reader["NAME"],
                            NumCitizens = (int)reader["NUMCITIZENS"],
                            CountryId = (int)reader["COUNTRY_ID"]
                        };

                        var result = new
                        {
                            Country_Id = CurrentCountry.Id,
                            Country_Name = CurrentCountry.Name,
                            Capital_Name = CurrentCity.Name,
                            Capital_Citizens = CurrentCity.NumCitizens,
                            Capital_Id = CurrentCountry.Id,
                        };
                        return result;
                    }
                }
            }
            return null;
        }

        public object GetCountyAndItsCapitalCityDDetails(string countryName)
        {
            using (SQLiteCommand cmd = new SQLiteCommand($"SELECT *, COUNTRY.NAME as COUNTRY_NAME, CAPITALCITY.NAME as CITY_NAME FROM COUNTRY" +
                $" JOIN CapitalCity ON COUNTRY.CAPITALCITY_ID = CapitalCity.ID WHERE COUNTRY.NAME = '{countryName}'", Connection))
            {
                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Country CurrentCountry = new Country
                        {
                            Id = (int)reader["ID"],
                            Name = (string)reader["NAME"],
                            SizeKm = (int)reader["SIZE_KM"],
                            BirthYear = (int)reader["BIRTH_YEAR"],
                            CapitalCityId = (int)reader["CAPITALCITY_ID"]
                        };

                        CapitalCity CurrentCity = new CapitalCity
                        {
                            Id = (int)reader["ID"],
                            Name = (string)reader["NAME"],
                            NumCitizens = (int)reader["NUMCITIZENS"],
                            CountryId = (int)reader["COUNTRY_ID"]
                        };

                        var result = new
                        {
                            Country_Id = CurrentCountry.Id,
                            Country_Name = CurrentCountry.Name,
                            Capital_Name = CurrentCity.Name,
                            Capital_NumCitizens = CurrentCity.NumCitizens,
                            Capital_Id = CurrentCity.CountryId
                        };
                        return result;
                    }
                }
            }
            return null;
        }

        public object GetCountyAndItsCapitalCityName(int countryid)
        {
            using (SQLiteCommand cmd = new SQLiteCommand($"SELECT *, COUNTRY.NAME as COUNTRY_NAME, CAPITALCITY.NAME as CITY_NAME FROM COUNTRY" +
                $" JOIN CapitalCity ON COUNTRY.CAPITALCITY_ID == CapitalCity.ID WHERE COUNTRY.ID == {countryid}", Connection))
            {
                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Country CurrentCountry = new Country
                        {
                            Id = (int)reader["ID"],
                            Name = (string)reader["NAME"],
                            SizeKm = (int)reader["SIZE_KM"],
                            BirthYear = (int)reader["BIRTH_YEAR"],
                            CapitalCityId = (int)reader["CAPITALCITY_ID"]
                        };

                        CapitalCity CurrentCity = new CapitalCity
                        {
                            Id = (int)reader["ID"],
                            Name = (string)reader["NAME"],
                            NumCitizens = (int)reader["NUMCITIZENS"],
                            CountryId = (int)reader["COUNTRY_ID"]
                        };

                        var result = new
                        {
                            Country_Id = CurrentCountry.Id,
                            Country_Name = CurrentCountry.Name,
                            Capital_name = CurrentCity.Name
                        };
                        return result;
                    }
                }
            }
            return null;
        }

        public object GetCountyAndItsCapitalCityName(string countryName)
        {
            using (SQLiteCommand cmd = new SQLiteCommand($"SELECT *, COUNTRY.NAME as COUNTRY_NAME, CAPITALCITY.NAME as CITY_NAME FROM COUNTRY" +
                $" JOIN CapitalCity ON COUNTRY.CAPITALCITY_ID == CapitalCity.ID WHERE COUNTRY.NAME == '{countryName}'", Connection))
            {
                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Country CurrentCountry = new Country
                        {
                            Id = (int)reader["ID"],
                            Name = (string)reader["NAME"],
                            SizeKm = (int)reader["SIZE_KM"],
                            BirthYear = (int)reader["BIRTH_YEAR"],
                            CapitalCityId = (int)reader["CAPITALCITY_ID"]
                        };

                        CapitalCity CurrentCity = new CapitalCity
                        {
                            Id = (int)reader["ID"],
                            Name = (string)reader["NAME"],
                            NumCitizens = (int)reader["NUMCITIZENS"],
                            CountryId = (int)reader["COUNTRY_ID"]
                        };

                        var result = new
                        {
                            Country_Id = CurrentCountry.Id,
                            Country_Name = CurrentCountry.Name,
                            Capital_Name = CurrentCity.Name
                        };
                        return result;
                    }
                }
            }
            return null;
        }
    }
}
