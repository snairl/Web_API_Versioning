using Web_API_Versioning.Models.Domain;

namespace Web_API_Versioning
{
    public static class CountriesData
    {
        public static List<Country> Get() {
            var countries = new[]
            {
                new {Id = 1, Name = "Country 1"},
                new {Id = 2, Name = "Country 2"},
                new {Id = 3, Name = "Country 3"},
                new {Id = 4, Name = "Country 4"},
                new {Id = 5, Name = "Country 5"},
                new {Id = 6, Name = "Country 6"},
                new {Id = 7, Name = "Country 7"},
                new {Id = 8, Name = "Country 8"},
            };

            return countries.Select(c => new Country { Id = c.Id, Name = c.Name }).ToList();
        }
    }
}
