using Database.Contexts;
using Logic.Content.Interfaces;
using Logic.Content.Models;
using Microsoft.EntityFrameworkCore;

namespace Logic.Content.Services
{
    public class ServiceHome : IServiceHome
    {
        public Task<HomeModel> GetAsync()
        {
            using var context1 = new DbContextPersonalCard();
            using var context2 = new DbContextPersonalCard();
            using var context3 = new DbContextPersonalCard();
            using var context4 = new DbContextPersonalCard();
            using var context5 = new DbContextPersonalCard();

            var personsTotal = context1.Persons.CountAsync();

            var aliveTotal = context2.Persons
                .CountAsync(p => p.Death == null && p.Birth != null && p.Birth.Value.Year > DateTime.Now.Year - 120);

            var deadTotal = context3.Persons
                .CountAsync(p => p.Birth != null && p.Death != null);

            var gendersTotal = context4.Genders.CountAsync();

            var personsTotalByGenders = context5.Genders
                .GroupBy(p => new { GenderName = p.Name, PersonsTotal = p.Persons.Count })
                .Select(p => new KeyValuePair<string, int>(p.Key.GenderName, p.Key.PersonsTotal))
                .ToListAsync();

            Task.WaitAll(personsTotal, aliveTotal, deadTotal, gendersTotal, personsTotalByGenders);

            return Task.FromResult(new HomeModel()
            {
                PersonsTotal = personsTotal.Result,
                AliveTotal = aliveTotal.Result,
                DeadTotal = deadTotal.Result,
                GendersTotal = gendersTotal.Result,
                PersonsTotalByGenders = personsTotalByGenders.Result,
            });
        }
    }
}