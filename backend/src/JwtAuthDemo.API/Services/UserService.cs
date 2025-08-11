using JwtAuthDemo.API.Entities;
using JwtAuthDemo.API.Interfaces.Repositories;
using JwtAuthDemo.API.Interfaces.Services;

namespace JwtAuthDemo.API.Services;

public class UserService : IUserService
{
    private readonly IUserRepository _repository;

    public UserService(IUserRepository repository)
    {
        _repository = repository;
    }

    public async Task<User?> GetByIdAsync(int id)
    {
        return await _repository.GetByIdAsync(id);
    }

    public async Task<List<User>> GetAllAsync()
    {
        return await _repository.GetAllAsync();
    }
}
