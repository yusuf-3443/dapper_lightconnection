using Domain.Models;

namespace Infrastructure.Services;

public interface IHouseService
{
    List<House> GetHouses();
    House GetHouseById(int id);
    string AddHouse(House house);
    string UpdateHouse(House house);
    string DeleteHouse(int id);
}