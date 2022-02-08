using System.Security.Principal;
using SupportLibrary.DataAccess;
using SupportLibrary.Models;

namespace SupportLibrary.Data
{
    public class PersonSqlDataService : IPersonDataService
    {
        private readonly ISqlDataAccess _dataAccess;

        public PersonSqlDataService(ISqlDataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }
        public async Task CreatePerson(IPersonModel person)
        {
            //P is a anonymous type with only the parameters that the stored procedure needs
            var p = new
            {
                person.FirstName,
                person.LastName,
                person.DateOfBirth
            };
            await _dataAccess.SaveData("dbo.spPeople_Create", p, "SQLDB");
        }

        public async Task<List<IPersonModel>> ReadPeople()
        {
            var people =  await _dataAccess.LoadData<PersonModel, dynamic>
                ("dbo.spPeople_Read", new { }, "SQLDB");

            return people.ToList<IPersonModel>();
        }

        public async Task<IPersonModel> ReadPeople(int id)
        {
            var people = await _dataAccess.LoadData<PersonModel, dynamic>
                ("dbo.spPeople_ReadOne", new { Id = id }, "SQLDB");

            return people.FirstOrDefault();
        }
        public async Task<List<IPersonModel>> ReadPeople(string searchTerm)
        {
            var people = await _dataAccess.LoadData<PersonModel, dynamic>
                ("dbo.spPeople_ReadBasedOnSearchTerm", new { SearchTerm = searchTerm }, "SQLDB");

            return people.ToList<IPersonModel>();
        }


        public async Task<List<IPersonModel>> ReadPeopleQuery()
        {
            var query = "select Id, FirstName, LastName, DateOfBirth from dbo.People";

            var people = await _dataAccess.LoadDataTest<PersonModel, dynamic>
                (query, "SQLDB");

            return people.ToList<IPersonModel>();
        }

        public async Task UpdatePerson(IPersonModel person)
        {
            await _dataAccess.SaveData("dbo.spPeople_Update", person, "SQLDB");
        }

        public async Task DeletePerson(int id)
        {
            await _dataAccess.SaveData("dbo.spPeople_Delete", new {Id = id}, "SQLDB");
        }
    }
}
