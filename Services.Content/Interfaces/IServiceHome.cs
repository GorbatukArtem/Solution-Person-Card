using Services.Content.Domain;

namespace Services.Content.Interfaces
{
    public interface IServiceHome
    {
        Task<HomeModel> GetAsync();
    }
}