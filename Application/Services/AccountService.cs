using BC = BCrypt.Net.BCrypt;
using System;
using ComicStoreApi.Repositories;
using Microsoft.AspNetCore.Mvc;
using ComicStoreApi.Models;

namespace ComicStoreApi.Application.Services
{
    public class AccountService : IAccountService
    {
        private readonly IUserRepository _userRepository;

        public AccountService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public User Register([FromBody] User model)
        {
            try
            {
                var user = new User { Name = model.Name, Email = model.Email, Username = model.Username };
                user.Password = BC.HashPassword(model.Password);
                _userRepository.Register(user);
                return user;
            }
            catch
            {
                throw new Exception("Erro ao tentar registrar usuário.");
            }
        }

        public User Authenticate([FromBody] User model)
        {
            var user = _userRepository.GetByEmail(model.Email);

            if (user == null || !BC.Verify(model.Password, user.Password))
            {
                throw new Exception("Usuário ou senha inválidos.");
            }

            return user;
        }
    }
}