using Dapper;
using Domain.Models;
using Infrastructure.DataContext;

namespace Infrastructure.Services;

public class HouseService : IHouseService
{
    private readonly DapperContext _context;
    public HouseService()
    {
        _context= new DapperContext();
    }
    public List<House> GetHouses()
    {
        var sql = "select * from houses";
        var result = _context.Connection().Query<House>(sql);
        return result.ToList();
    }

    public House GetHouseById(int id)
    {
        var sql = "select * from houses where id=@id";
        var result = _context.Connection().QueryFirstOrDefault<House>(sql);
        return result;
    }

    public string AddHouse(House house)
    {
        var sql =  $"insert into houses (address,number,owner)" +
                   $"values ('{house.address}','{house.number}', '{house.owner}')";
        var inserted =  _context.Connection().Execute(sql);
        if (inserted > 0) return "Successfully created new student";
        return "Error in creating new student";
    }

    public string UpdateHouse(House house)
    {
        var sql=$"update houses set address = '{house.address}', "+
                $"number = '{house.number}',owner = '{house.owner}' "+
                $"where id = {house.id}";
        var inserted =  _context.Connection().Execute(sql);
        if (inserted > 0) return "Successfully created new student";
        return "Error in creating new student";
    }

    public string DeleteHouse(int id)
    {
        var sql = $"delete from houses where id = {@id}";
        var deleted =_context.Connection().Execute(sql);
        if (deleted > 0) return "House successfully deleted";
        return "Failed to delete house";
    }
}