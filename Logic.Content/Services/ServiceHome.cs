using Database.Contexts;
using Logic.Content.Interfaces;
using Logic.Content.Models;
using Microsoft.EntityFrameworkCore;

namespace Logic.Content.Services
{
    public class ServiceHome : IServiceHome
    {
        public async Task<HomeModel> GetAsync()
        {
            await using var context = new DbContextPersonalCard();

            var personsTotal = context.Persons.CountAsync();

            Task.WaitAll(personsTotal);

            return new HomeModel() { PersonsTotal = personsTotal.Result };
        }

    }
}