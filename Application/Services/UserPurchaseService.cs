using System;
using System.Collections.Generic;
using ComicStoreApi.Application.Interfaces;
using ComicStoreApi.Domain.Interfaces;
using ComicStoreApi.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace ComicStoreApi.Application.Services
{
    public class UserPurchaseService : IUserPurchaseService
    {
        private readonly IUserPurchaseRepository _purchaseRepository;

        public UserPurchaseService(IUserPurchaseRepository purchaseRepository)
        {
            _purchaseRepository = purchaseRepository;
        }

        public List<UserPurchase> GetPurchasesByUserId(int userId)
        {
            try
            {
                return _purchaseRepository.GetAllByUserId(userId);
            }
            catch
            {
                throw new Exception("Erro ao tentar listar compras.");
            }
        }

        public UserPurchase Register([FromBody] UserPurchase model)
        {
            try
            {
                return _purchaseRepository.Register(model);
            }
            catch
            {
                throw new Exception("Erro ao tentar registrar compra.");
            }
        }

    }
}