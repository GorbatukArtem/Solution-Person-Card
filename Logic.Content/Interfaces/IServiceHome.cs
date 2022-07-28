using Logic.Content.Models;

namespace Logic.Content.Interfaces
{
    public interface IServiceHome
    {
        Task<HomeModel> GetAsync();
    }
}