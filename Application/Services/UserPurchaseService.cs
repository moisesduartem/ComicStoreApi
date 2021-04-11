using System;
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

        public UserPurchase Register([FromBody] UserPurchase model)
        {
            try
            {
                return _purchaseRepository.Register(model);
            }
            catch (Exception e)
            { 
                throw e;
                // throw new Exception("Erro ao tentar registrar compra.");
            }
        }

    }
}