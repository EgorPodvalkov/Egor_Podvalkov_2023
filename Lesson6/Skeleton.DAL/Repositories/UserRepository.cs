using Microsoft.EntityFrameworkCore;
using Skeleton.DAL.Context;
using Skeleton.DAL.Entities;
using Skeleton.DAL.Interfaces;

namespace Skeleton.DAL.Repositories;

public class UserRepository : BaseRepository<User>, IUserRepository
{
    public UserRepository(QuizHubDatabaseContext dbContext) : base(dbContext)
    {
    }

    public async Task<User> GetUserByCredentialsAsync(string name, string password)
    {
        return await _dbContext.Set<User>()
            .FirstAsync(x => x.Name == name && x.Password == password);
    }
}