using AutoMapper;
using Skeleton.BLL.Exceptions;
using Skeleton.BLL.Interfaces;
using Skeleton.BLL.Models;
using Skeleton.BLL.Models.AddModels;
using Skeleton.BLL.Models.UpdateModels;
using Skeleton.DAL.Entities;
using Skeleton.DAL.Interfaces;

namespace Skeleton.BLL.Services;

public class UserService : IUserService
{
    private readonly IUserRepository _userRepository;
    private readonly IMapper _mapper;

    public UserService(IUserRepository userRepository, IMapper mapper)
    {
        _userRepository = userRepository;
        _mapper = mapper;
    }

    public async Task AddUserAsync(AddUserModel userModel)
    {
        if (string.IsNullOrEmpty(userModel.Name)
            || string.IsNullOrEmpty(userModel.Surname)
            || string.IsNullOrEmpty(userModel.Password))
            throw new ModelIsEmptyException();

        var entity = _mapper.Map<User>(userModel);

        await _userRepository.AddAsync(entity);
    }

    public async Task UpdateUserAsync(UpdateUserModel userModel)
    {
        if (string.IsNullOrEmpty(userModel.Name)
            || string.IsNullOrEmpty(userModel.Surname)
            || string.IsNullOrEmpty(userModel.Password))
            throw new ModelIsEmptyException();

        var entity = await _userRepository.GetByIdAsync(Guid.Parse(userModel.Id));
        _mapper.Map(userModel, entity);

        await _userRepository.UpdateAsync(entity);
    }

    public async Task DeleteUserAsync(Guid id)
    {
        await _userRepository.DeleteAsync(id);
    }

    public async Task<UserModel> GetUserAsync(Guid id)
    {
        var entity = await _userRepository.GetByIdAsync(id);

        var model = _mapper.Map<UserModel>(entity);

        return model;
    }
}